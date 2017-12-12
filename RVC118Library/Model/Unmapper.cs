// COMPILER GENERATED CODE
// THIS WILL BE OVERWRITTEN AT EACH GENERATION
// EDIT AT YOUR OWN RISK

using System;
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
    public class Unmapper : UnmapperBase
    {
        #region [ Constructors ]

        public Unmapper(Framework framework, MappingCompiler mappingCompiler)
            : base(framework, mappingCompiler, SystemSettings.OutputMapping)
        {
            Algorithm.Output.CreateNew = () => new Algorithm.Output()
            {
                OutputData = FillOutputData(),
                OutputMeta = FillOutputMeta()
            };
        }

        #endregion

        #region [ Methods ]

        public RVC118.Model.RVC118Data.Outputs FillOutputData()
        {
            TypeMapping outputMapping = MappingCompiler.GetTypeMapping(OutputMapping);
            Reset();
            return FillRVC118DataOutputs(outputMapping);
        }

        public RVC118.Model.RVC118Data._OutputsMeta FillOutputMeta()
        {
            TypeMapping outputMeta = MappingCompiler.GetTypeMapping(OutputMapping);
            Reset();
            return FillRVC118Data_OutputsMeta(outputMeta);
        }

        public IEnumerable<IMeasurement> Unmap(RVC118.Model.RVC118Data.Outputs outputData, RVC118.Model.RVC118Data._OutputsMeta outputMeta)
        {
            List<IMeasurement> measurements = new List<IMeasurement>();
            TypeMapping outputMapping = MappingCompiler.GetTypeMapping(OutputMapping);

            CollectFromRVC118DataOutputs(measurements, outputMapping, outputData, outputMeta);

            return measurements;
        }

        private RVC118.Model.RVC118Data.Outputs FillRVC118DataOutputs(TypeMapping typeMapping)
        {
            Dictionary<string, FieldMapping> fieldLookup = typeMapping.FieldMappings.ToDictionary(mapping => mapping.Field.Identifier);
            RVC118.Model.RVC118Data.Outputs obj = new RVC118.Model.RVC118Data.Outputs();

            {
                // We don't need to do anything, but we burn a key index to keep our
                // array index in sync with where we are in the data structure
                BurnKeyIndex();
            }

            {
                // We don't need to do anything, but we burn a key index to keep our
                // array index in sync with where we are in the data structure
                BurnKeyIndex();
            }

            {
                // We don't need to do anything, but we burn a key index to keep our
                // array index in sync with where we are in the data structure
                BurnKeyIndex();
            }

            {
                // We don't need to do anything, but we burn a key index to keep our
                // array index in sync with where we are in the data structure
                BurnKeyIndex();
            }

            {
                // We don't need to do anything, but we burn a key index to keep our
                // array index in sync with where we are in the data structure
                BurnKeyIndex();
            }

            {
                // We don't need to do anything, but we burn a key index to keep our
                // array index in sync with where we are in the data structure
                BurnKeyIndex();
            }

            {
                // We don't need to do anything, but we burn a key index to keep our
                // array index in sync with where we are in the data structure
                BurnKeyIndex();
            }

            {
                // We don't need to do anything, but we burn a key index to keep our
                // array index in sync with where we are in the data structure
                BurnKeyIndex();
            }

            {
                // We don't need to do anything, but we burn a key index to keep our
                // array index in sync with where we are in the data structure
                BurnKeyIndex();
            }

            {
                // We don't need to do anything, but we burn a key index to keep our
                // array index in sync with where we are in the data structure
                BurnKeyIndex();
            }

            {
                // We don't need to do anything, but we burn a key index to keep our
                // array index in sync with where we are in the data structure
                BurnKeyIndex();
            }

            {
                // We don't need to do anything, but we burn a key index to keep our
                // array index in sync with where we are in the data structure
                BurnKeyIndex();
            }

            return obj;
        }

        private RVC118.Model.RVC118Data._OutputsMeta FillRVC118Data_OutputsMeta(TypeMapping typeMapping)
        {
            Dictionary<string, FieldMapping> fieldLookup = typeMapping.FieldMappings.ToDictionary(mapping => mapping.Field.Identifier);
            RVC118.Model.RVC118Data._OutputsMeta obj = new RVC118.Model.RVC118Data._OutputsMeta();

            {
                // Initialize meta value structure to "ActSnB34Close" field
                FieldMapping fieldMapping = fieldLookup["ActSnB34Close"];
                obj.ActSnB34Close = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "ActSnB44Close" field
                FieldMapping fieldMapping = fieldLookup["ActSnB44Close"];
                obj.ActSnB44Close = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "ActSnB45Close" field
                FieldMapping fieldMapping = fieldLookup["ActSnB45Close"];
                obj.ActSnB45Close = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "ActSnB48Close" field
                FieldMapping fieldMapping = fieldLookup["ActSnB48Close"];
                obj.ActSnB48Close = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "ActSnB74Close" field
                FieldMapping fieldMapping = fieldLookup["ActSnB74Close"];
                obj.ActSnB74Close = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "ActSnB105Close" field
                FieldMapping fieldMapping = fieldLookup["ActSnB105Close"];
                obj.ActSnB105Close = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "ActSnB34Trip" field
                FieldMapping fieldMapping = fieldLookup["ActSnB34Trip"];
                obj.ActSnB34Trip = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "ActSnB44Trip" field
                FieldMapping fieldMapping = fieldLookup["ActSnB44Trip"];
                obj.ActSnB44Trip = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "ActSnB45Trip" field
                FieldMapping fieldMapping = fieldLookup["ActSnB45Trip"];
                obj.ActSnB45Trip = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "ActSnB48Trip" field
                FieldMapping fieldMapping = fieldLookup["ActSnB48Trip"];
                obj.ActSnB48Trip = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "ActSnB74Trip" field
                FieldMapping fieldMapping = fieldLookup["ActSnB74Trip"];
                obj.ActSnB74Trip = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "ActSnB105Trip" field
                FieldMapping fieldMapping = fieldLookup["ActSnB105Trip"];
                obj.ActSnB105Trip = CreateMetaValues(fieldMapping);
            }

            return obj;
        }

        private void CollectFromRVC118DataOutputs(List<IMeasurement> measurements, TypeMapping typeMapping, RVC118.Model.RVC118Data.Outputs data, RVC118.Model.RVC118Data._OutputsMeta meta)
        {
            Dictionary<string, FieldMapping> fieldLookup = typeMapping.FieldMappings.ToDictionary(mapping => mapping.Field.Identifier);

            {
                // Convert value from "ActSnB34Close" field to measurement
                FieldMapping fieldMapping = fieldLookup["ActSnB34Close"];
                IMeasurement measurement = MakeMeasurement(meta.ActSnB34Close, (double)data.ActSnB34Close);
                measurements.Add(measurement);
            }

            {
                // Convert value from "ActSnB44Close" field to measurement
                FieldMapping fieldMapping = fieldLookup["ActSnB44Close"];
                IMeasurement measurement = MakeMeasurement(meta.ActSnB44Close, (double)data.ActSnB44Close);
                measurements.Add(measurement);
            }

            {
                // Convert value from "ActSnB45Close" field to measurement
                FieldMapping fieldMapping = fieldLookup["ActSnB45Close"];
                IMeasurement measurement = MakeMeasurement(meta.ActSnB45Close, (double)data.ActSnB45Close);
                measurements.Add(measurement);
            }

            {
                // Convert value from "ActSnB48Close" field to measurement
                FieldMapping fieldMapping = fieldLookup["ActSnB48Close"];
                IMeasurement measurement = MakeMeasurement(meta.ActSnB48Close, (double)data.ActSnB48Close);
                measurements.Add(measurement);
            }

            {
                // Convert value from "ActSnB74Close" field to measurement
                FieldMapping fieldMapping = fieldLookup["ActSnB74Close"];
                IMeasurement measurement = MakeMeasurement(meta.ActSnB74Close, (double)data.ActSnB74Close);
                measurements.Add(measurement);
            }

            {
                // Convert value from "ActSnB105Close" field to measurement
                FieldMapping fieldMapping = fieldLookup["ActSnB105Close"];
                IMeasurement measurement = MakeMeasurement(meta.ActSnB105Close, (double)data.ActSnB105Close);
                measurements.Add(measurement);
            }

            {
                // Convert value from "ActSnB34Trip" field to measurement
                FieldMapping fieldMapping = fieldLookup["ActSnB34Trip"];
                IMeasurement measurement = MakeMeasurement(meta.ActSnB34Trip, (double)data.ActSnB34Trip);
                measurements.Add(measurement);
            }

            {
                // Convert value from "ActSnB44Trip" field to measurement
                FieldMapping fieldMapping = fieldLookup["ActSnB44Trip"];
                IMeasurement measurement = MakeMeasurement(meta.ActSnB44Trip, (double)data.ActSnB44Trip);
                measurements.Add(measurement);
            }

            {
                // Convert value from "ActSnB45Trip" field to measurement
                FieldMapping fieldMapping = fieldLookup["ActSnB45Trip"];
                IMeasurement measurement = MakeMeasurement(meta.ActSnB45Trip, (double)data.ActSnB45Trip);
                measurements.Add(measurement);
            }

            {
                // Convert value from "ActSnB48Trip" field to measurement
                FieldMapping fieldMapping = fieldLookup["ActSnB48Trip"];
                IMeasurement measurement = MakeMeasurement(meta.ActSnB48Trip, (double)data.ActSnB48Trip);
                measurements.Add(measurement);
            }

            {
                // Convert value from "ActSnB74Trip" field to measurement
                FieldMapping fieldMapping = fieldLookup["ActSnB74Trip"];
                IMeasurement measurement = MakeMeasurement(meta.ActSnB74Trip, (double)data.ActSnB74Trip);
                measurements.Add(measurement);
            }

            {
                // Convert value from "ActSnB105Trip" field to measurement
                FieldMapping fieldMapping = fieldLookup["ActSnB105Trip"];
                IMeasurement measurement = MakeMeasurement(meta.ActSnB105Trip, (double)data.ActSnB105Trip);
                measurements.Add(measurement);
            }
        }

        #endregion
    }
}
