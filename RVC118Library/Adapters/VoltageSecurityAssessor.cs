using Accord;
using Accord.IO;
using Accord.MachineLearning.DecisionTrees;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using RVC118.Model.RVC118Data;


namespace RVC118.Adapters
{
    [Serializable()]
    public class VoltageSecurityAssessor
    {

        #region [ Private Members ]

        private string m_assessResult;
        private double m_baseVoltage;
        //private Inputs m_inputFrame;
        private int m_treeIndex;
        private string m_treeFilePath;
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

        [XmlAttribute("TreeIndex")]
        public int TreeIndex
        {
            get
            {
                return m_treeIndex;
            }
            set
            {
                m_treeIndex = value;
            }
        }

        [XmlAttribute("TreeFilePath")]
        public string TreeFilePath
        {
            get
            {
                return m_treeFilePath;
            }
            set
            {
                m_treeFilePath = value;
            }
        }

        [XmlAttribute("AssessResult")]
        public string AssessResult
        {
            get
            {
                return m_assessResult;
            }
            set
            {
                m_assessResult = value;
            }
        }
        
        [XmlIgnore()]
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

        public VoltageSecurityAssessor()
        {
            m_treeIndex = -1;
            m_treeFilePath = null;
            m_assessResult = "UNKNOWN";
        }

        #endregion

        #region [ empty: Private Methods ]

        #endregion

        #region [ Public Methods ]

        public string Assess()
        {
            //If the treeFilePath has been occupied, then wait for 0.05 second and then try one more time.
            DecisionTree tree;
            try
            {
                tree = Serializer.Load<DecisionTree>(m_treeFilePath);
            }
            catch
            {
                System.Threading.Thread.Sleep(500);
                tree = Serializer.Load<DecisionTree>(m_treeFilePath);
            }

            double[] voltMeasPuFrame = Array.ConvertAll(m_voltMeasMagFrame, x => x/m_baseVoltage);            

            switch (tree.Decide(voltMeasPuFrame))
            {
                case 1:
                    m_assessResult = "SECURE";
                    break;
                case 0:
                    m_assessResult = "INSECURE";
                    break;
            }
            return m_assessResult;
        }

        #endregion

        #region [ Xml Serialization/Deserialization methods ]
        public void SerializeToXml(string pathName)
        {
            using (var stream = new FileStream(pathName, FileMode.Create))
            {
                var serializer = new XmlSerializer(typeof(VoltageSecurityAssessor));
                serializer.Serialize(stream, this);
            }
        }
        #endregion

    }
}
