// COMPILER GENERATED CODE
// THIS WILL BE OVERWRITTEN AT EACH GENERATION
// EDIT AT YOUR OWN RISK

using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using ECAClientFramework;
using ECAClientUtilities;
using ECACommonUtilities;
using ECACommonUtilities.Model;
using GSF.TimeSeries;

namespace RVC118.Model
{
    [CompilerGenerated]
    public class Mapper : MapperBase
    {
        #region [ Members ]

        // Fields
        private readonly Unmapper m_unmapper;

        #endregion

        #region [ Constructors ]

        public Mapper(Framework framework)
            : base(framework, SystemSettings.InputMapping)
        {
            m_unmapper = new Unmapper(framework, MappingCompiler);
            Unmapper = m_unmapper;
        }

        #endregion

        #region [ Methods ]

        public override void Map(IDictionary<MeasurementKey, IMeasurement> measurements)
        {
            SignalLookup.UpdateMeasurementLookup(measurements);
            TypeMapping inputMapping = MappingCompiler.GetTypeMapping(InputMapping);

            Reset();
            RVC118.Model.RVC118Data.Inputs inputData = CreateRVC118DataInputs(inputMapping);
            Reset();
            RVC118.Model.RVC118Data._InputsMeta inputMeta = CreateRVC118Data_InputsMeta(inputMapping);

            Algorithm.Output algorithmOutput = Algorithm.Execute(inputData, inputMeta);
            Subscriber.SendMeasurements(m_unmapper.Unmap(algorithmOutput.OutputData, algorithmOutput.OutputMeta));
        }

        private RVC118.Model.RVC118Data.Inputs CreateRVC118DataInputs(TypeMapping typeMapping)
        {
            Dictionary<string, FieldMapping> fieldLookup = typeMapping.FieldMappings.ToDictionary(mapping => mapping.Field.Identifier);
            RVC118.Model.RVC118Data.Inputs obj = new RVC118.Model.RVC118Data.Inputs();

            {
                // Assign short value to "StateSnB34CapBkrV" field
                FieldMapping fieldMapping = fieldLookup["StateSnB34CapBkrV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.StateSnB34CapBkrV = (short)measurement.Value;
            }

            {
                // Assign short value to "StateSnB44CapBkrV" field
                FieldMapping fieldMapping = fieldLookup["StateSnB44CapBkrV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.StateSnB44CapBkrV = (short)measurement.Value;
            }

            {
                // Assign short value to "StateSnB45CapBkrV" field
                FieldMapping fieldMapping = fieldLookup["StateSnB45CapBkrV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.StateSnB45CapBkrV = (short)measurement.Value;
            }

            {
                // Assign short value to "StateSnB48CapBkrV" field
                FieldMapping fieldMapping = fieldLookup["StateSnB48CapBkrV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.StateSnB48CapBkrV = (short)measurement.Value;
            }

            {
                // Assign short value to "StateSnB74CapBkrV" field
                FieldMapping fieldMapping = fieldLookup["StateSnB74CapBkrV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.StateSnB74CapBkrV = (short)measurement.Value;
            }

            {
                // Assign short value to "StateSnB105CapBkrV" field
                FieldMapping fieldMapping = fieldLookup["StateSnB105CapBkrV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.StateSnB105CapBkrV = (short)measurement.Value;
            }

            {
                // Assign double value to "MeasB1VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB1VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB1VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB2VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB2VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB2VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB3VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB3VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB3VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB4VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB4VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB4VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB5VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB5VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB5VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB6VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB6VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB6VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB7VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB7VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB7VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB8VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB8VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB8VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB9VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB9VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB9VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB10VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB10VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB10VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB11VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB11VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB11VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB12VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB12VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB12VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB13VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB13VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB13VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB14VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB14VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB14VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB15VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB15VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB15VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB16VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB16VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB16VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB17VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB17VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB17VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB18VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB18VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB18VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB19VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB19VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB19VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB20VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB20VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB20VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB21VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB21VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB21VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB22VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB22VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB22VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB23VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB23VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB23VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB24VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB24VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB24VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB25VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB25VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB25VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB26VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB26VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB26VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB27VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB27VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB27VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB28VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB28VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB28VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB29VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB29VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB29VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB30VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB30VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB30VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB31VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB31VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB31VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB32VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB32VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB32VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB33VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB33VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB33VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB34VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB34VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB34VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB35VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB35VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB35VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB36VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB36VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB36VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB37VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB37VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB37VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB38VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB38VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB38VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB39VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB39VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB39VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB40VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB40VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB40VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB41VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB41VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB41VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB42VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB42VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB42VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB43VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB43VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB43VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB44VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB44VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB44VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB45VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB45VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB45VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB46VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB46VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB46VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB47VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB47VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB47VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB48VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB48VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB48VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB49VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB49VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB49VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB50VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB50VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB50VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB51VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB51VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB51VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB52VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB52VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB52VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB53VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB53VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB53VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB54VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB54VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB54VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB55VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB55VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB55VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB56VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB56VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB56VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB57VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB57VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB57VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB58VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB58VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB58VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB59VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB59VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB59VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB60VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB60VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB60VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB61VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB61VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB61VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB62VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB62VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB62VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB63VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB63VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB63VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB64VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB64VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB64VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB65VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB65VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB65VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB66VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB66VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB66VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB67VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB67VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB67VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB68VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB68VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB68VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB69VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB69VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB69VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB70VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB70VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB70VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB71VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB71VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB71VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB72VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB72VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB72VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB73VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB73VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB73VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB74VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB74VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB74VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB75VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB75VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB75VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB76VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB76VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB76VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB77VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB77VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB77VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB78VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB78VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB78VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB79VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB79VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB79VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB80VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB80VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB80VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB81VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB81VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB81VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB82VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB82VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB82VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB83VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB83VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB83VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB84VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB84VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB84VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB85VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB85VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB85VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB86VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB86VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB86VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB87VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB87VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB87VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB88VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB88VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB88VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB89VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB89VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB89VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB90VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB90VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB90VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB91VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB91VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB91VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB92VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB92VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB92VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB93VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB93VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB93VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB94VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB94VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB94VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB95VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB95VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB95VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB96VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB96VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB96VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB97VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB97VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB97VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB98VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB98VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB98VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB99VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB99VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB99VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB100VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB100VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB100VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB101VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB101VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB101VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB102VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB102VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB102VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB103VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB103VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB103VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB104VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB104VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB104VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB105VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB105VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB105VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB106VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB106VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB106VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB107VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB107VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB107VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB108VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB108VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB108VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB109VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB109VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB109VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB110VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB110VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB110VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB111VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB111VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB111VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB112VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB112VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB112VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB113VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB113VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB113VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB114VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB114VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB114VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB115VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB115VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB115VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB116VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB116VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB116VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB117VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB117VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB117VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasB118VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB118VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB118VoltV = (double)measurement.Value;
            }

            return obj;
        }

        private RVC118.Model.RVC118Data._InputsMeta CreateRVC118Data_InputsMeta(TypeMapping typeMapping)
        {
            Dictionary<string, FieldMapping> fieldLookup = typeMapping.FieldMappings.ToDictionary(mapping => mapping.Field.Identifier);
            RVC118.Model.RVC118Data._InputsMeta obj = new RVC118.Model.RVC118Data._InputsMeta();

            {
                // Assign MetaValues value to "StateSnB34CapBkrV" field
                FieldMapping fieldMapping = fieldLookup["StateSnB34CapBkrV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.StateSnB34CapBkrV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "StateSnB44CapBkrV" field
                FieldMapping fieldMapping = fieldLookup["StateSnB44CapBkrV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.StateSnB44CapBkrV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "StateSnB45CapBkrV" field
                FieldMapping fieldMapping = fieldLookup["StateSnB45CapBkrV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.StateSnB45CapBkrV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "StateSnB48CapBkrV" field
                FieldMapping fieldMapping = fieldLookup["StateSnB48CapBkrV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.StateSnB48CapBkrV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "StateSnB74CapBkrV" field
                FieldMapping fieldMapping = fieldLookup["StateSnB74CapBkrV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.StateSnB74CapBkrV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "StateSnB105CapBkrV" field
                FieldMapping fieldMapping = fieldLookup["StateSnB105CapBkrV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.StateSnB105CapBkrV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB1VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB1VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB1VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB2VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB2VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB2VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB3VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB3VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB3VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB4VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB4VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB4VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB5VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB5VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB5VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB6VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB6VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB6VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB7VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB7VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB7VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB8VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB8VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB8VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB9VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB9VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB9VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB10VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB10VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB10VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB11VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB11VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB11VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB12VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB12VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB12VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB13VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB13VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB13VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB14VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB14VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB14VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB15VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB15VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB15VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB16VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB16VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB16VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB17VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB17VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB17VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB18VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB18VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB18VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB19VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB19VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB19VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB20VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB20VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB20VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB21VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB21VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB21VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB22VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB22VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB22VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB23VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB23VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB23VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB24VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB24VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB24VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB25VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB25VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB25VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB26VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB26VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB26VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB27VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB27VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB27VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB28VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB28VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB28VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB29VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB29VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB29VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB30VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB30VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB30VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB31VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB31VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB31VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB32VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB32VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB32VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB33VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB33VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB33VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB34VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB34VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB34VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB35VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB35VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB35VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB36VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB36VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB36VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB37VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB37VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB37VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB38VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB38VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB38VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB39VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB39VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB39VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB40VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB40VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB40VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB41VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB41VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB41VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB42VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB42VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB42VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB43VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB43VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB43VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB44VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB44VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB44VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB45VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB45VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB45VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB46VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB46VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB46VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB47VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB47VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB47VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB48VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB48VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB48VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB49VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB49VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB49VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB50VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB50VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB50VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB51VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB51VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB51VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB52VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB52VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB52VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB53VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB53VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB53VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB54VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB54VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB54VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB55VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB55VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB55VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB56VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB56VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB56VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB57VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB57VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB57VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB58VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB58VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB58VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB59VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB59VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB59VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB60VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB60VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB60VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB61VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB61VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB61VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB62VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB62VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB62VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB63VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB63VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB63VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB64VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB64VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB64VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB65VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB65VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB65VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB66VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB66VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB66VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB67VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB67VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB67VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB68VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB68VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB68VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB69VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB69VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB69VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB70VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB70VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB70VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB71VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB71VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB71VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB72VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB72VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB72VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB73VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB73VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB73VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB74VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB74VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB74VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB75VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB75VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB75VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB76VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB76VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB76VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB77VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB77VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB77VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB78VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB78VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB78VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB79VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB79VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB79VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB80VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB80VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB80VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB81VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB81VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB81VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB82VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB82VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB82VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB83VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB83VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB83VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB84VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB84VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB84VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB85VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB85VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB85VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB86VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB86VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB86VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB87VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB87VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB87VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB88VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB88VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB88VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB89VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB89VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB89VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB90VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB90VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB90VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB91VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB91VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB91VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB92VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB92VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB92VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB93VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB93VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB93VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB94VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB94VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB94VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB95VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB95VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB95VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB96VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB96VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB96VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB97VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB97VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB97VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB98VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB98VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB98VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB99VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB99VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB99VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB100VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB100VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB100VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB101VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB101VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB101VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB102VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB102VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB102VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB103VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB103VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB103VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB104VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB104VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB104VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB105VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB105VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB105VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB106VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB106VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB106VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB107VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB107VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB107VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB108VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB108VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB108VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB109VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB109VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB109VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB110VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB110VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB110VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB111VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB111VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB111VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB112VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB112VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB112VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB113VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB113VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB113VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB114VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB114VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB114VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB115VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB115VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB115VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB116VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB116VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB116VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB117VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB117VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB117VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasB118VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB118VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasB118VoltV = GetMetaValues(measurement);
            }

            return obj;
        }

        #endregion
    }
}
