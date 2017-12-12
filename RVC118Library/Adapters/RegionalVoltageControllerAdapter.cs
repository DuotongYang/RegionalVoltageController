using Accord;
using Accord.IO;
using Accord.MachineLearning.DecisionTrees;
using Accord.MachineLearning.DecisionTrees.Learning;
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using RVC118.Adapters;
using RVC118.ControlActions;
using RVC118.Model.RVC118Data;

namespace RVC118.Adapters
{
    [Serializable()]
    public class RegionalVoltageControllerAdapter
    {

        #region [ Private Members ]

        private double m_baseVoltage;
        private int[] m_capBankCombinationArray;
        private int m_capBankCombinationIndex;
        private string m_currentSecurityStatus;
        private List<CtrlAction> m_ctrlDecisionList;
        private Inputs m_inputFrame;
        private int m_numOfBuses;
        private int m_numOfCapBanks;
        private CtrlAction m_selectedDecision;
        private string m_trainedTreeName;
        private string m_trainedTreeFolder;
        private VoltageSecurityAssessor m_preventiveVSA;
        private List<VoltageSecurityAssessor> m_remedialVSA;
        private double[] m_voltMeasMagFrame;

        #endregion

        #region [ Properties ]     

        [XmlIgnore()]
        public double BaseVoltage
        {
            get
            {
                return m_baseVoltage;
            }
            set
            {
                m_baseVoltage = value;
            }
        }

        [XmlArray("CapBankCombinationArray")]
        public int[] CapBankCombinationArray
        {
            get
            {
                return m_capBankCombinationArray;
            }
            set
            {
                m_capBankCombinationArray = value;
            }
        }

        [XmlAttribute("CapBankCombinationIndex")]
        public int CapBankCombinationIndex
        {
            get
            {
                return m_capBankCombinationIndex;
            }
            set
            {
                m_capBankCombinationIndex = value;
            }
        }

        [XmlAttribute("CurrentSecurityStatus")]
        public string CurrentSecurityStatus
        {
            get
            {
                return m_currentSecurityStatus;
            }
            set
            {
                m_currentSecurityStatus = value;
            }
        }

        [XmlAttribute("NumOfCapBanks")]
        public int NumOfCapBanks
        {
            get
            {
                return m_numOfCapBanks;
            }
            set
            {
                m_numOfCapBanks = value;
            }
        }

        [XmlAttribute("NumOfBuses")]
        public int NumOfBuses
        {
            get
            {
                return m_numOfBuses;
            }
            set
            {
                m_numOfBuses = value;
            }
        }

        [XmlIgnore()]
        public Inputs InputFrame
        {
            get
            {
                return m_inputFrame;
            }
            set
            {
                m_inputFrame = value;
            }
        }        

        [XmlArray("CtrlDecisionList")]
        public List<CtrlAction> CtrlDecisionList
        {
            get
            {
                return m_ctrlDecisionList;
            }
            set
            {
                m_ctrlDecisionList = value;
            }
        }

        [XmlIgnore()]
        public CtrlAction SelectedDecision
        {
            get
            {
                return m_selectedDecision;
            }
            set
            {
                m_selectedDecision = value;
            }
        }

        [XmlAttribute("TrainedTreeName")]
        public string TrainedTreeName
        {
            get
            {
                return m_trainedTreeName;
            }
            set
            {
                m_trainedTreeName = value;
            }
        }

        [XmlAttribute("TrainedTreeFolder")]
        public string TrainedTreeFolder
        {
            get
            {
                return m_trainedTreeFolder;
            }
            set
            {
                m_trainedTreeFolder = value;
            }
        }

        [XmlIgnore()]
        public VoltageSecurityAssessor PreventiveVoltageSecurityAssessor
        {
            get
            {
                return m_preventiveVSA;
            }
            set
            {
                m_preventiveVSA = value;
            }
        }

        [XmlIgnore()]
        public List<VoltageSecurityAssessor> RemedialVoltageSecurityAssessorList
        {
            get
            {
                return m_remedialVSA;
            }
            set
            {
                m_remedialVSA = value;
            }
        }

        [XmlArray("VoltMeasMagFrame")]
        public double[] VoltMeasMagFrame
        {
            get
            {
                return m_voltMeasMagFrame;
            }
            set
            {
                m_voltMeasMagFrame = value;
            }
        }
        
        #endregion

        #region [ Constructor ]

        public RegionalVoltageControllerAdapter()
        {
            m_baseVoltage = 1;
            m_capBankCombinationArray = null;
            m_capBankCombinationIndex = -1;
            m_currentSecurityStatus = "UNKNOWN";
            m_ctrlDecisionList = new List<CtrlAction>();
            m_numOfBuses = 0;
            m_numOfCapBanks = 0;
            m_trainedTreeName = null;
            m_trainedTreeFolder = null;
            m_preventiveVSA = new VoltageSecurityAssessor();
            m_remedialVSA = new List<VoltageSecurityAssessor>();
        }

        #endregion

        #region [ Private Methods ]

        private int[] GetCapBankCombinationArray(Inputs frame)
        {
            int[] combinationArray = new int[]
            {
                frame.StateSnB34CapBkrV,
                frame.StateSnB44CapBkrV,
                frame.StateSnB45CapBkrV,
                frame.StateSnB48CapBkrV,
                frame.StateSnB74CapBkrV,
                frame.StateSnB105CapBkrV                
            };
            return combinationArray;
        }
        
        private int GetCapBankCombinationIndex()
        {
            double combinationIndex = 0;
            for (int i = 0; i < m_capBankCombinationArray.Count(); i++)
            {
                if (m_capBankCombinationArray[i] == 1)
                {
                    combinationIndex += Math.Pow(2, i);
                }
            }
            return Convert.ToInt32(combinationIndex);
        }

        private int[] ConvertCapBankCombinationIndexToArray(int index, int arrayLength)
        {
            int[] combinationArray = new int[arrayLength];
            string s = Convert.ToString(index, 2).PadLeft(arrayLength, '0');
            combinationArray = s.Select(c => int.Parse(c.ToString())).ToArray();
            Array.Reverse(combinationArray);

            return combinationArray;
        }

        private double[] ConvertInputDataToArray(Inputs frame)
        {
            double[] voltMeasMagFrame = new double[] {
                frame.MeasB1VoltV,
                frame.MeasB2VoltV,
                frame.MeasB3VoltV,
                frame.MeasB4VoltV,
                frame.MeasB5VoltV,
                frame.MeasB6VoltV,
                frame.MeasB7VoltV,
                frame.MeasB8VoltV,
                frame.MeasB9VoltV,
                frame.MeasB10VoltV,
                frame.MeasB11VoltV,
                frame.MeasB12VoltV,
                frame.MeasB13VoltV,
                frame.MeasB14VoltV,
                frame.MeasB15VoltV,
                frame.MeasB16VoltV,
                frame.MeasB17VoltV,
                frame.MeasB18VoltV,
                frame.MeasB19VoltV,
                frame.MeasB20VoltV,
                frame.MeasB21VoltV,
                frame.MeasB22VoltV,
                frame.MeasB23VoltV,
                frame.MeasB24VoltV,
                frame.MeasB25VoltV,
                frame.MeasB26VoltV,
                frame.MeasB27VoltV,
                frame.MeasB28VoltV,
                frame.MeasB29VoltV,
                frame.MeasB30VoltV,
                frame.MeasB31VoltV,
                frame.MeasB32VoltV,
                frame.MeasB33VoltV,
                frame.MeasB34VoltV,
                frame.MeasB35VoltV,
                frame.MeasB36VoltV,
                frame.MeasB37VoltV,
                frame.MeasB38VoltV,
                frame.MeasB39VoltV,
                frame.MeasB40VoltV,
                frame.MeasB41VoltV,
                frame.MeasB42VoltV,
                frame.MeasB43VoltV,
                frame.MeasB44VoltV,
                frame.MeasB45VoltV,
                frame.MeasB46VoltV,
                frame.MeasB47VoltV,
                frame.MeasB48VoltV,
                frame.MeasB49VoltV,
                frame.MeasB50VoltV,
                frame.MeasB51VoltV,
                frame.MeasB52VoltV,
                frame.MeasB53VoltV,
                frame.MeasB54VoltV,
                frame.MeasB55VoltV,
                frame.MeasB56VoltV,
                frame.MeasB57VoltV,
                frame.MeasB58VoltV,
                frame.MeasB59VoltV,
                frame.MeasB60VoltV,
                frame.MeasB61VoltV,
                frame.MeasB62VoltV,
                frame.MeasB63VoltV,
                frame.MeasB64VoltV,
                frame.MeasB65VoltV,
                frame.MeasB66VoltV,
                frame.MeasB67VoltV,
                frame.MeasB68VoltV,
                frame.MeasB69VoltV,
                frame.MeasB70VoltV,
                frame.MeasB71VoltV,
                frame.MeasB72VoltV,
                frame.MeasB73VoltV,
                frame.MeasB74VoltV,
                frame.MeasB75VoltV,
                frame.MeasB76VoltV,
                frame.MeasB77VoltV,
                frame.MeasB78VoltV,
                frame.MeasB79VoltV,
                frame.MeasB80VoltV,
                frame.MeasB81VoltV,
                frame.MeasB82VoltV,
                frame.MeasB83VoltV,
                frame.MeasB84VoltV,
                frame.MeasB85VoltV,
                frame.MeasB86VoltV,
                frame.MeasB87VoltV,
                frame.MeasB88VoltV,
                frame.MeasB89VoltV,
                frame.MeasB90VoltV,
                frame.MeasB91VoltV,
                frame.MeasB92VoltV,
                frame.MeasB93VoltV,
                frame.MeasB94VoltV,
                frame.MeasB95VoltV,
                frame.MeasB96VoltV,
                frame.MeasB97VoltV,
                frame.MeasB98VoltV,
                frame.MeasB99VoltV,
                frame.MeasB100VoltV,
                frame.MeasB101VoltV,
                frame.MeasB102VoltV,
                frame.MeasB103VoltV,
                frame.MeasB104VoltV,
                frame.MeasB105VoltV,
                frame.MeasB106VoltV,
                frame.MeasB107VoltV,
                frame.MeasB108VoltV,
                frame.MeasB109VoltV,
                frame.MeasB110VoltV,
                frame.MeasB111VoltV,
                frame.MeasB112VoltV,
                frame.MeasB113VoltV,
                frame.MeasB114VoltV,
                frame.MeasB115VoltV,
                frame.MeasB116VoltV,
                frame.MeasB117VoltV,
                frame.MeasB118VoltV
            };
            return voltMeasMagFrame;
        }

        #endregion

        #region [ Public Methods ]

        public void Initialize()
        {
            m_ctrlDecisionList = new List<CtrlAction>();
            m_capBankCombinationArray = GetCapBankCombinationArray(m_inputFrame);
            m_capBankCombinationIndex = GetCapBankCombinationIndex();
            m_numOfCapBanks = m_capBankCombinationArray.Count();
            m_voltMeasMagFrame = ConvertInputDataToArray(m_inputFrame);
            m_numOfBuses = m_voltMeasMagFrame.Count();
            m_trainedTreeName = $"DecisionTreeModel_ControlForLowVoltage_{m_capBankCombinationIndex}_train";
            m_selectedDecision = new CtrlAction();
        }

        public void AssessVoltageSecurity()
        {
            m_preventiveVSA = new VoltageSecurityAssessor()
            {
                BaseVoltage = m_baseVoltage,
                //InputFrame = m_inputFrame,
                TreeIndex =  m_capBankCombinationIndex,
                TreeFilePath = Path.Combine(m_trainedTreeFolder, m_trainedTreeName),
                VoltMeasMagFrame = m_voltMeasMagFrame
            };

            m_preventiveVSA.Assess();
            m_currentSecurityStatus = m_preventiveVSA.AssessResult;
        }

        public void AcquireCtrlDecisionsList()
        {
            m_ctrlDecisionList = new List<CtrlAction>();
            m_remedialVSA = new List<VoltageSecurityAssessor>();

            for (int i = 0; i < Math.Pow(2, m_numOfCapBanks); i++)
            {
                VoltageSecurityAssessor vsa = new VoltageSecurityAssessor()
                {
                    BaseVoltage = m_baseVoltage,
                    //InputFrame = m_inputFrame,
                    TreeIndex = i,
                    TreeFilePath = Path.Combine(m_trainedTreeFolder, $"DecisionTreeModel_ControlForLowVoltage_{i}_train"),
                    VoltMeasMagFrame = m_voltMeasMagFrame
                };

                vsa.Assess();

                if ((vsa.AssessResult == "SECURE") && (vsa.TreeIndex != m_capBankCombinationIndex))
                {
                    CtrlAction ctrlact = new CtrlAction()
                    {
                        Index = vsa.TreeIndex,
                        CtrlTreeName = $"DecisionTreeModel_ControlForLowVoltage_{i}_train",
                        CurrentCapBankCombinationArray = m_capBankCombinationArray,
                        CtrlCapBankCominationArray = ConvertCapBankCombinationIndexToArray(vsa.TreeIndex, m_numOfCapBanks)
                    };

                    ctrlact.Initialize();                
                    m_ctrlDecisionList.Add(ctrlact);

                }

                m_remedialVSA.Add(vsa);

            }
        }

        //public void getActionCount(CtrlAction ctrlact)
        //{
           
        //    int[] TempCounter = new int[NumOfCapBanks];
        //    TempCounter[0] = Math.Abs(m_inputFrame.StateSnB34CapBkrV - ctrlact.CtrlCapBankCominationArray[0]);
        //    TempCounter[1] = Math.Abs(m_inputFrame.StateSnB44CapBkrV - ctrlact.CtrlCapBankCominationArray[1]);
        //    TempCounter[2] = Math.Abs(m_inputFrame.StateSnB45CapBkrV - ctrlact.CtrlCapBankCominationArray[2]);
        //    TempCounter[3] = Math.Abs(m_inputFrame.StateSnB45CapBkrV - ctrlact.CtrlCapBankCominationArray[3]);
        //    TempCounter[4] = Math.Abs(m_inputFrame.StateSnB48CapBkrV - ctrlact.CtrlCapBankCominationArray[4]);
        //    TempCounter[5] = Math.Abs(m_inputFrame.StateSnB105CapBkrV - ctrlact.CtrlCapBankCominationArray[5]);

        //    ctrlact.ActionsCount = TempCounter.Sum();
        //}


        public void SelectPriorCtrlDecision()
        {
            if (m_ctrlDecisionList.Count != 0)
            {
                //sort the control
                m_ctrlDecisionList.Sort((x, y) => x.ActionsCount.CompareTo(y.ActionsCount));
                m_selectedDecision = m_ctrlDecisionList[0];
            }
            else
            {
                m_selectedDecision.CtrlActionMessage = $"UNAVAILABLE";
            }
        }


        //// Search for all Feasible Control Combinations
        //private List<CtrlActions> getLeastActionsSecureCtrl(Inputs frame, string TreeModelsPath)
        //{
        //    List<CtrlActions> CtrlActionsList = new List<CtrlActions>();
        //    int numOfBuses = frame.Voltages.Count;
        //    int numOfCapBanks = frame.ShuntBreakers.Count;

        //    // Read the voltage measurement values of current frame
        //    double[] VoltMeasMagFrame = new double[numOfBuses];
        //    for (int i = 0; i < numOfBuses; i++)
        //    {
        //        VoltMeasMagFrame[i] = frame.Voltages[i].Measurement.Magnitude;
        //    }

        //    int[] CapBankCombinationFrame = GetCapBankCombinationArray(frame);
        //    string CapBankCombinationString = getCapBankCombinationString(frame);
        //    int CapBankCombinationIndex = getCapBankCombinationIndex(frame);

        //    // Load trained decision-tree models (Total = 63)
        //    for (int i = 0; i < Math.Pow(2, numOfCapBanks) - 1; i++)
        //    {
        //        CtrlActions ctrlact = new CtrlActions();
        //        ctrlact.Index = i + 1;                
        //        ctrlact.CtrlCombinationsString = convertCapBankCombinationIndexToString(ctrlact.Index, numOfCapBanks);
        //        ctrlact.CtrlCombinations = convertCapBankCombinationStringToArray(ctrlact.CtrlCombinationsString, numOfCapBanks);

        //        // Count the actions required for this combination
        //        int[] TempCounter = new int[numOfCapBanks];
        //        for (int j = 0; j < numOfCapBanks; j++)
        //        {
        //            TempCounter[j] = Math.Abs(CapBankCombinationFrame[j] - ctrlact.CtrlCombinations[j]);
        //        }
        //        ctrlact.ActionsCounter = TempCounter.Sum();

        //        // select the control decision list with minimum MVA summation              
        //        for (int indexCap = 0; indexCap < frame.ShuntBreakers.Count; indexCap++)
        //        {
        //            if (ctrlact.CtrlCombinationsString[indexCap].ToString() == "1")
        //            {
        //                ctrlact.MVARSum = ctrlact.MVARSum + frame.ShuntBreakers[indexCap].CapBankMVAR;
        //            }

        //        }

        //    }


        #endregion

        #region [ Xml Serialization/Deserialization methods ]

        public void SerializeToXml(string pathName)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(RegionalVoltageControllerAdapter));

                TextWriter writer = new StreamWriter(pathName);

                serializer.Serialize(writer, this);

                writer.Close();
            }
            catch (Exception exception)
            {
                throw new Exception("Failed to Serialize");
            }
        }

        public static RegionalVoltageControllerAdapter DeserializeFromXml(string pathName)
        {
            try
            {
                RegionalVoltageControllerAdapter regionalVoltageControllerAdapter = null;

                XmlSerializer deserializer = new XmlSerializer(typeof(RegionalVoltageControllerAdapter));

                StreamReader reader = new StreamReader(pathName);

                regionalVoltageControllerAdapter = (RegionalVoltageControllerAdapter)deserializer.Deserialize(reader);

                reader.Close();

                return regionalVoltageControllerAdapter;
            }
            catch (Exception exception)
            {
                throw new Exception("Failed to Deserialize");
            }
        }

        #endregion

    }
}
