// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Personalizer.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class PolicyResultSummary
    {
        /// <summary>
        /// Initializes a new instance of the PolicyResultSummary class.
        /// </summary>
        public PolicyResultSummary()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PolicyResultSummary class.
        /// </summary>
        public PolicyResultSummary(System.DateTime? timeStamp = default(System.DateTime?), double? ipsEstimatorNumerator = default(double?), double? ipsEstimatorDenominator = default(double?), double? snipsEstimatorDenominator = default(double?), string aggregateTimeWindow = default(string), double? nonZeroProbability = default(double?), double? confidenceInterval = default(double?), double? sumOfSquares = default(double?))
        {
            TimeStamp = timeStamp;
            IpsEstimatorNumerator = ipsEstimatorNumerator;
            IpsEstimatorDenominator = ipsEstimatorDenominator;
            SnipsEstimatorDenominator = snipsEstimatorDenominator;
            AggregateTimeWindow = aggregateTimeWindow;
            NonZeroProbability = nonZeroProbability;
            ConfidenceInterval = confidenceInterval;
            SumOfSquares = sumOfSquares;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timeStamp")]
        public System.DateTime? TimeStamp { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ipsEstimatorNumerator")]
        public double? IpsEstimatorNumerator { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ipsEstimatorDenominator")]
        public double? IpsEstimatorDenominator { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "snipsEstimatorDenominator")]
        public double? SnipsEstimatorDenominator { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "aggregateTimeWindow")]
        public string AggregateTimeWindow { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "nonZeroProbability")]
        public double? NonZeroProbability { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "confidenceInterval")]
        public double? ConfidenceInterval { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sumOfSquares")]
        public double? SumOfSquares { get; private set; }

    }
}