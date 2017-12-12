using System;
using System.IO;
using System.Text;
using ECAClientFramework;
using ECAClientUtilities.API;
using RVC118.Adapters;
using RVC118.Model.RVC118Data;


namespace RVC118
{
    public static class Algorithm
    {
        public static Hub API { get; set; }

        internal class Output
        {
            public Outputs OutputData = new Outputs();
            public _OutputsMeta OutputMeta = new _OutputsMeta();
            public static Func<Output> CreateNew { get; set; } = () => new Output();
        }

        public static void UpdateSystemSettings()
        {
            SystemSettings.InputMapping = "RVC118Data_InputMapping";
            SystemSettings.OutputMapping = "RVC118Data_OutputMapping";
            SystemSettings.ConnectionString = @"server=localhost:6190; interface=0.0.0.0";
            SystemSettings.FramesPerSecond = 1;
            SystemSettings.LagTime = 2;
            SystemSettings.LeadTime = 1;
        }

        internal static Output Execute(Inputs inputData, _InputsMeta inputMeta)
        {
            Output output = Output.CreateNew();
            DateTime runTime = DateTime.UtcNow;

            #region [ Message Output ]

            const bool enableXmlFileLog = false;
            const bool enableMainWindowMessageDisplay = true;
            const bool enableVoltageControlsMessageOutput = true;

            #endregion

            #region [ Environment Settings ]

            string mainFolderPath = (@"C:\Users\jxhan\Desktop\openECA20171024\RVC118-master\");
            string libraryFolderPath = Path.Combine(mainFolderPath, @"RVC118Library");
            string treeModelsFolderPath = Path.Combine(libraryFolderPath, @"DecisionTreeModels");

            const double systemBaseVoltage = 138000;

            #endregion

            #region [ Voltage Security Assessment ]

            RegionalVoltageControllerAdapter RVCAdapter = new RegionalVoltageControllerAdapter()
            {
                BaseVoltage = systemBaseVoltage,
                InputFrame = inputData,
                TrainedTreeFolder = treeModelsFolderPath
            };

            RVCAdapter.Initialize();
            RVCAdapter.AssessVoltageSecurity();

            #endregion

            #region [ Search for Control Decisions ]

            if (RVCAdapter.CurrentSecurityStatus == "INSECURE")
            //if (true)
            {
                RVCAdapter.AcquireCtrlDecisionsList();
                RVCAdapter.SelectPriorCtrlDecision();

                if (RVCAdapter.SelectedDecision.Index != -1)
                {

                    #region [ Output Control Signals to openECA ]

                    ActionsAdapter actChannel = new ActionsAdapter()
                    {
                        ActSnB34Close = (RVCAdapter.SelectedDecision.CtrlCapBankCominationArray[0] > RVCAdapter.CapBankCombinationArray[0]) ? (short)1 : (short)0,
                        ActSnB44Close = (RVCAdapter.SelectedDecision.CtrlCapBankCominationArray[1] > RVCAdapter.CapBankCombinationArray[1]) ? (short)1 : (short)0,
                        ActSnB45Close = (RVCAdapter.SelectedDecision.CtrlCapBankCominationArray[2] > RVCAdapter.CapBankCombinationArray[2]) ? (short)1 : (short)0,
                        ActSnB48Close = (RVCAdapter.SelectedDecision.CtrlCapBankCominationArray[3] > RVCAdapter.CapBankCombinationArray[3]) ? (short)1 : (short)0,
                        ActSnB74Close = (RVCAdapter.SelectedDecision.CtrlCapBankCominationArray[4] > RVCAdapter.CapBankCombinationArray[4]) ? (short)1 : (short)0,
                        ActSnB105Close = (RVCAdapter.SelectedDecision.CtrlCapBankCominationArray[5] > RVCAdapter.CapBankCombinationArray[5]) ? (short)1 : (short)0,
                        ActSnB34Trip = (RVCAdapter.SelectedDecision.CtrlCapBankCominationArray[0] < RVCAdapter.CapBankCombinationArray[0]) ? (short)1 : (short)0,
                        ActSnB44Trip = (RVCAdapter.SelectedDecision.CtrlCapBankCominationArray[1] < RVCAdapter.CapBankCombinationArray[1]) ? (short)1 : (short)0,
                        ActSnB45Trip = (RVCAdapter.SelectedDecision.CtrlCapBankCominationArray[2] < RVCAdapter.CapBankCombinationArray[2]) ? (short)1 : (short)0,
                        ActSnB48Trip = (RVCAdapter.SelectedDecision.CtrlCapBankCominationArray[3] < RVCAdapter.CapBankCombinationArray[3]) ? (short)1 : (short)0,
                        ActSnB74Trip = (RVCAdapter.SelectedDecision.CtrlCapBankCominationArray[4] < RVCAdapter.CapBankCombinationArray[4]) ? (short)1 : (short)0,
                        ActSnB105Trip = (RVCAdapter.SelectedDecision.CtrlCapBankCominationArray[5] < RVCAdapter.CapBankCombinationArray[5]) ? (short)1 : (short)0
                    };

                    output.OutputData.ActSnB34Close = actChannel.ActSnB34Close;
                    output.OutputData.ActSnB44Close = actChannel.ActSnB44Close;
                    output.OutputData.ActSnB45Close = actChannel.ActSnB45Close;
                    output.OutputData.ActSnB48Close = actChannel.ActSnB48Close;
                    output.OutputData.ActSnB74Close = actChannel.ActSnB74Close;
                    output.OutputData.ActSnB105Close = actChannel.ActSnB105Close;
                    output.OutputData.ActSnB34Trip = actChannel.ActSnB34Trip;
                    output.OutputData.ActSnB44Trip = actChannel.ActSnB44Trip;
                    output.OutputData.ActSnB45Trip = actChannel.ActSnB45Trip;
                    output.OutputData.ActSnB48Trip = actChannel.ActSnB48Trip;
                    output.OutputData.ActSnB74Trip = actChannel.ActSnB74Trip;
                    output.OutputData.ActSnB105Trip = actChannel.ActSnB105Trip; 




                    //output.OutputData.ActSnB34Close = 0;
                    //output.OutputData.ActSnB44Close = 0;
                    //output.OutputData.ActSnB45Close = 0;
                    //output.OutputData.ActSnB48Close = 0;
                    //output.OutputData.ActSnB74Close = 0;
                    //output.OutputData.ActSnB105Close = 0;
                    //output.OutputData.ActSnB34Trip = 0;
                    //output.OutputData.ActSnB44Trip = 0;
                    //output.OutputData.ActSnB45Trip = 0;
                    //output.OutputData.ActSnB48Trip = 0;
                    //output.OutputData.ActSnB74Trip = 0;
                    //output.OutputData.ActSnB105Trip = 0;
                    #endregion

                    #region [ Update Timestamps for Control Signals ]

                    output.OutputMeta.ActSnB34Close = UpdateTime(output.OutputMeta.ActSnB34Close);
                    output.OutputMeta.ActSnB44Close = UpdateTime(output.OutputMeta.ActSnB44Close);
                    output.OutputMeta.ActSnB45Close = UpdateTime(output.OutputMeta.ActSnB45Close);
                    output.OutputMeta.ActSnB48Close = UpdateTime(output.OutputMeta.ActSnB48Close);
                    output.OutputMeta.ActSnB74Close = UpdateTime(output.OutputMeta.ActSnB74Close);
                    output.OutputMeta.ActSnB105Close = UpdateTime(output.OutputMeta.ActSnB105Close);
                    output.OutputMeta.ActSnB34Trip = UpdateTime(output.OutputMeta.ActSnB34Trip);
                    output.OutputMeta.ActSnB44Trip = UpdateTime(output.OutputMeta.ActSnB44Trip);
                    output.OutputMeta.ActSnB45Trip = UpdateTime(output.OutputMeta.ActSnB45Trip);
                    output.OutputMeta.ActSnB48Trip = UpdateTime(output.OutputMeta.ActSnB48Trip);
                    output.OutputMeta.ActSnB74Trip = UpdateTime(output.OutputMeta.ActSnB74Trip);
                    output.OutputMeta.ActSnB105Trip = UpdateTime(output.OutputMeta.ActSnB105Trip);

                    #endregion

                }
                else
                {
                    MainWindow.WriteWarning($"*** Error 666: No capbank ctrldecision is found... ***");
                }


            }

            #endregion
            

            try
            {
                // TODO: Implement your algorithm here...
                // You can also write messages to the main window:


                #region [ Write openECA Client Windows Message]
                if (enableVoltageControlsMessageOutput)
                {
                    StringBuilder _message = new StringBuilder();
                    _message.AppendLine($" ================= RVC118 Analytics ================== ");
                    _message.AppendLine($"                 Run Time:  {runTime:yyyy-MM-dd HH:mm:ss.fff}");
                    _message.AppendLine($"          Completion Time:  {DateTime.UtcNow:yyyy-MM-dd HH:mm:ss.fff}");
                    _message.AppendLine($"      InputData Timestamp:  {inputMeta.MeasB1VoltV.Timestamp:yyyy-MM-dd HH:mm:ss.fff}");
                    _message.AppendLine($"     OutputData Timestamp:  {output.OutputMeta.ActSnB34Close.Timestamp:yyyy-MM-dd HH:mm:ss.fff}");
                    //_message.AppendLine($" ------------------ CsvInputAdapter ------------------ ");
                    //_message.AppendLine($" ------------------- ActionChannel ------------------- ");
                    //_message.AppendLine($"            ActSnB34Close:  {output.OutputData.ActSnB34Close}");
                    //_message.AppendLine($"             ActSnB34Trip:  {output.OutputData.ActSnB34Trip}");
                    //_message.AppendLine($" ---------------- MeasurementChannel ----------------- ");
                    //_message.AppendLine($"              MeasB1VoltV:  {inputData.MeasB1VoltV}  Volts");
                    _message.AppendLine($" ------------------- StateChannel -------------------- ");
                    _message.AppendLine($"        StateSnB34CapBkrV:  {inputData.StateSnB34CapBkrV}");
                    _message.AppendLine($" ------------- Regional Voltage Controller ----------- ");
                    //_message.AppendLine($"               NumOfBuses:  {RVCAdapter.NumOfBuses}");
                    //_message.AppendLine($"            NumOfCapBanks:  {RVCAdapter.NumOfCapBanks}");
                    _message.AppendLine($"         StateSnB*CapBkrV:  | {inputData.StateSnB34CapBkrV} | {inputData.StateSnB44CapBkrV} | {inputData.StateSnB45CapBkrV} | {inputData.StateSnB48CapBkrV} | {inputData.StateSnB74CapBkrV} | {inputData.StateSnB105CapBkrV} |");
                    _message.AppendLine($"  CapBankCombinationArray:  | {RVCAdapter.CapBankCombinationArray[0]} | {RVCAdapter.CapBankCombinationArray[1]} | {RVCAdapter.CapBankCombinationArray[2]} | {RVCAdapter.CapBankCombinationArray[3]} | {RVCAdapter.CapBankCombinationArray[4]} | {RVCAdapter.CapBankCombinationArray[5]} |");
                    _message.AppendLine($"  CapBankCombinationIndex:  {RVCAdapter.CapBankCombinationIndex}");
                    _message.AppendLine($"         AssessmentResult:  {RVCAdapter.CurrentSecurityStatus}");
                    _message.AppendLine($"            VSA.TreeIndex:  {RVCAdapter.PreventiveVoltageSecurityAssessor.TreeIndex}");
                    _message.AppendLine($"         VSA.TreeFilePath:  {RVCAdapter.PreventiveVoltageSecurityAssessor.TreeFilePath}");
                    _message.AppendLine($" -------------- Control Decision Message ------------- ");
                    _message.AppendLine($"  Available CtrlDecisions:  {RVCAdapter.CtrlDecisionList.Count}");
                    _message.AppendLine($"    Selected CtrlDecision:  {RVCAdapter.SelectedDecision.Index}");
                    _message.AppendLine($"CtrlDecision ActionsCount:  {RVCAdapter.SelectedDecision.ActionsCount}");
                    _message.AppendLine($"     CtrlDecision Message:  {RVCAdapter.SelectedDecision.CtrlActionMessage}");
                    _message.AppendLine($" ===================================================== ");

                    MainWindow.WriteMessage(_message.ToString());
                }

                #endregion
            }
            catch (Exception ex)
            {
                // Display exceptions to the main window
                MainWindow.WriteError(new InvalidOperationException($"Algorithm exception: {ex.Message}", ex));
            }

            return output;
        }


        private static MetaValues UpdateTime(MetaValues source)
        {
            return new MetaValues
            {
                ID = source.ID,
                Flags = source.Flags,
                Timestamp = source.Timestamp.AddSeconds(3.0D)
            };
        }
    }
}
