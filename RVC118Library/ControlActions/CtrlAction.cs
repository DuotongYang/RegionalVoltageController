using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Collections;
using RVC118.Adapters;

namespace RVC118.ControlActions
{
    [Serializable()]
    public class CtrlAction
    {
        #region [ Private Members ]

        private string m_ctrlTreeName;
        private int m_index;
        private int m_actionsCount;
        private int[] m_currentCapBankCombinationArray;
        private int[] m_ctrlCapBankCominationArray;
        private string m_ctrlActionMessage;
        private double m_mVARSum;

        #endregion 

        #region [ Properties ]

        [XmlAttribute("CtrlTreeName")]
        public string CtrlTreeName
        {
            get
            {
                return m_ctrlTreeName;
            }
            set
            {
                m_ctrlTreeName = value;
            }
        }

        [XmlAttribute("CtrlIndex")]
        public int Index
        {
            get
            {
                return m_index;
            }
            set
            {
                m_index = value;
            }
        }

        [XmlAttribute("ActionsCount")]
        public int ActionsCount
        {
            get
            {
                return m_actionsCount;
            }
            set
            {
                m_actionsCount = value;
            }
        }

        [XmlIgnore()]
        public int[] CurrentCapBankCombinationArray
        {
            get
            {
                return m_currentCapBankCombinationArray;
            }
            set
            {
                m_currentCapBankCombinationArray = value;
            }
        }


        [XmlIgnore()]
        public int[] CtrlCapBankCominationArray
        {
            get
            {
                return m_ctrlCapBankCominationArray;
            }
            set
            {
                m_ctrlCapBankCominationArray = value;
            }
        }


        [XmlAttribute("CtrlActionMessage")]
        public string CtrlActionMessage
        {
            get
            {
                return m_ctrlActionMessage;
            }
            set
            {
                m_ctrlActionMessage = value;
            }
        }

        [XmlAttribute("MVARSum")]
        public double MVARSum
        {
            get
            {
                return m_mVARSum;
            }
            set
            {
                m_mVARSum = value;
            }
            
        }


        #endregion

        #region [ Constructor ]

        public CtrlAction()
        {
            m_ctrlTreeName = null;
            m_index = -1;
            m_mVARSum = 0;
            m_actionsCount = -1;
            m_currentCapBankCombinationArray = null;
            m_ctrlCapBankCominationArray = null;
            m_ctrlActionMessage = null;
        }

        #endregion

        #region [ Private Methods ]

        private int GetActionsCount()
        {
            int[] tempCounter = new int[m_currentCapBankCombinationArray.Count()];

            for (int i = 0; i < m_currentCapBankCombinationArray.Count(); i++)
            {
                tempCounter[i] = Math.Abs(m_currentCapBankCombinationArray[i] - m_ctrlCapBankCominationArray[i]);
            }

            return tempCounter.Sum();
        }

        private double GetMVARSum()
        {
            return new double();
        }

        private string GetCtrlActionMessages()
        {
            StringBuilder ctrlActionMessage = new StringBuilder();

            for (int i = 0; i < m_currentCapBankCombinationArray.Count(); i++)
            {
                if (m_currentCapBankCombinationArray[i] == m_ctrlCapBankCominationArray[i])
                {
                    ctrlActionMessage.Append($"#{i}:UNCHANGE ");

                }
                else
                {

                    if (m_ctrlCapBankCominationArray[i] == 1)
                    {
                        ctrlActionMessage.Append($"#{i}:CLOSE ");
                    }
                    else
                    {
                        ctrlActionMessage.Append($"#{i}:TRIP ");
                    }
                }
            }

            return ctrlActionMessage.ToString();
        }

        #endregion

        #region [ Public Methods ]

        public void Initialize()
        {
            m_actionsCount = GetActionsCount();
            m_mVARSum = GetMVARSum();
            m_ctrlActionMessage = GetCtrlActionMessages();
        }

        #endregion        

        #region [ Xml Serialization/Deserialization methods ]
        public void SerializeToXml(string pathName)
        {
            using (var stream = new FileStream(pathName, FileMode.Create))
            {
                var serializer = new XmlSerializer(typeof(CtrlAction));
                serializer.Serialize(stream, this);
            }
        }



        #endregion

    }
}
