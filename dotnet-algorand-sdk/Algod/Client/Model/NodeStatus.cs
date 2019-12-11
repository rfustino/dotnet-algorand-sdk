/* 
 * Algod REST API.
 *
 * API Endpoint for AlgoD Operations.
 *
 * OpenAPI spec version: 0.0.1
 * Contact: contact@algorand.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = Algorand.Algod.Client.SwaggerDateConverter;

namespace Algorand.Algod.Client.Model
{
    /// <summary>
    /// NodeStatus contains the information about a node status
    /// </summary>
    [DataContract]
        public partial class NodeStatus :  IEquatable<NodeStatus>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NodeStatus" /> class.
        /// </summary>
        /// <param name="catchupTime">CatchupTime in nanoseconds (required).</param>
        /// <param name="hasSyncedSinceStartup">HasSyncedSinceStartup indicates whether a round has completed since startup (required).</param>
        /// <param name="lastConsensusVersion">LastVersion indicates the last consensus version supported (required).</param>
        /// <param name="lastRound">LastRound indicates the last round seen (required).</param>
        /// <param name="nextConsensusVersion">NextVersion of consensus protocol to use (required).</param>
        /// <param name="nextConsensusVersionRound">NextVersionRound is the round at which the next consensus version will apply (required).</param>
        /// <param name="nextConsensusVersionSupported">NextVersionSupported indicates whether the next consensus version is supported by this node (required).</param>
        /// <param name="timeSinceLastRound">TimeSinceLastRound in nanoseconds (required).</param>
        public NodeStatus(long? catchupTime = default(long?), bool? hasSyncedSinceStartup = default(bool?), string lastConsensusVersion = default(string), ulong? lastRound = default(ulong?), string nextConsensusVersion = default(string), ulong? nextConsensusVersionRound = default(ulong?), bool? nextConsensusVersionSupported = default(bool?), long? timeSinceLastRound = default(long?))
        {
            // to ensure "catchupTime" is required (not null)
            if (catchupTime == null)
            {
                throw new InvalidDataException("catchupTime is a required property for NodeStatus and cannot be null");
            }
            else
            {
                this.CatchupTime = catchupTime;
            }
            // to ensure "hasSyncedSinceStartup" is required (not null)
            if (hasSyncedSinceStartup == null)
            {
                throw new InvalidDataException("hasSyncedSinceStartup is a required property for NodeStatus and cannot be null");
            }
            else
            {
                this.HasSyncedSinceStartup = hasSyncedSinceStartup;
            }
            // to ensure "lastConsensusVersion" is required (not null)
            if (lastConsensusVersion == null)
            {
                throw new InvalidDataException("lastConsensusVersion is a required property for NodeStatus and cannot be null");
            }
            else
            {
                this.LastConsensusVersion = lastConsensusVersion;
            }
            // to ensure "lastRound" is required (not null)
            if (lastRound == null)
            {
                throw new InvalidDataException("lastRound is a required property for NodeStatus and cannot be null");
            }
            else
            {
                this.LastRound = lastRound;
            }
            // to ensure "nextConsensusVersion" is required (not null)
            if (nextConsensusVersion == null)
            {
                throw new InvalidDataException("nextConsensusVersion is a required property for NodeStatus and cannot be null");
            }
            else
            {
                this.NextConsensusVersion = nextConsensusVersion;
            }
            // to ensure "nextConsensusVersionRound" is required (not null)
            if (nextConsensusVersionRound == null)
            {
                throw new InvalidDataException("nextConsensusVersionRound is a required property for NodeStatus and cannot be null");
            }
            else
            {
                this.NextConsensusVersionRound = nextConsensusVersionRound;
            }
            // to ensure "nextConsensusVersionSupported" is required (not null)
            if (nextConsensusVersionSupported == null)
            {
                throw new InvalidDataException("nextConsensusVersionSupported is a required property for NodeStatus and cannot be null");
            }
            else
            {
                this.NextConsensusVersionSupported = nextConsensusVersionSupported;
            }
            // to ensure "timeSinceLastRound" is required (not null)
            if (timeSinceLastRound == null)
            {
                throw new InvalidDataException("timeSinceLastRound is a required property for NodeStatus and cannot be null");
            }
            else
            {
                this.TimeSinceLastRound = timeSinceLastRound;
            }
        }
        
        /// <summary>
        /// CatchupTime in nanoseconds
        /// </summary>
        /// <value>CatchupTime in nanoseconds</value>
        [DataMember(Name="catchupTime", EmitDefaultValue=false)]
        public long? CatchupTime { get; set; }

        /// <summary>
        /// HasSyncedSinceStartup indicates whether a round has completed since startup
        /// </summary>
        /// <value>HasSyncedSinceStartup indicates whether a round has completed since startup</value>
        [DataMember(Name="hasSyncedSinceStartup", EmitDefaultValue=false)]
        public bool? HasSyncedSinceStartup { get; set; }

        /// <summary>
        /// LastVersion indicates the last consensus version supported
        /// </summary>
        /// <value>LastVersion indicates the last consensus version supported</value>
        [DataMember(Name="lastConsensusVersion", EmitDefaultValue=false)]
        public string LastConsensusVersion { get; set; }

        /// <summary>
        /// LastRound indicates the last round seen
        /// </summary>
        /// <value>LastRound indicates the last round seen</value>
        [DataMember(Name="lastRound", EmitDefaultValue=false)]
        public ulong? LastRound { get; set; }

        /// <summary>
        /// NextVersion of consensus protocol to use
        /// </summary>
        /// <value>NextVersion of consensus protocol to use</value>
        [DataMember(Name="nextConsensusVersion", EmitDefaultValue=false)]
        public string NextConsensusVersion { get; set; }

        /// <summary>
        /// NextVersionRound is the round at which the next consensus version will apply
        /// </summary>
        /// <value>NextVersionRound is the round at which the next consensus version will apply</value>
        [DataMember(Name="nextConsensusVersionRound", EmitDefaultValue=false)]
        public ulong? NextConsensusVersionRound { get; set; }

        /// <summary>
        /// NextVersionSupported indicates whether the next consensus version is supported by this node
        /// </summary>
        /// <value>NextVersionSupported indicates whether the next consensus version is supported by this node</value>
        [DataMember(Name="nextConsensusVersionSupported", EmitDefaultValue=false)]
        public bool? NextConsensusVersionSupported { get; set; }

        /// <summary>
        /// TimeSinceLastRound in nanoseconds
        /// </summary>
        /// <value>TimeSinceLastRound in nanoseconds</value>
        [DataMember(Name="timeSinceLastRound", EmitDefaultValue=false)]
        public long? TimeSinceLastRound { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NodeStatus {\n");
            sb.Append("  CatchupTime: ").Append(CatchupTime).Append("\n");
            sb.Append("  HasSyncedSinceStartup: ").Append(HasSyncedSinceStartup).Append("\n");
            sb.Append("  LastConsensusVersion: ").Append(LastConsensusVersion).Append("\n");
            sb.Append("  LastRound: ").Append(LastRound).Append("\n");
            sb.Append("  NextConsensusVersion: ").Append(NextConsensusVersion).Append("\n");
            sb.Append("  NextConsensusVersionRound: ").Append(NextConsensusVersionRound).Append("\n");
            sb.Append("  NextConsensusVersionSupported: ").Append(NextConsensusVersionSupported).Append("\n");
            sb.Append("  TimeSinceLastRound: ").Append(TimeSinceLastRound).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as NodeStatus);
        }

        /// <summary>
        /// Returns true if NodeStatus instances are equal
        /// </summary>
        /// <param name="input">Instance of NodeStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NodeStatus input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CatchupTime == input.CatchupTime ||
                    (this.CatchupTime != null &&
                    this.CatchupTime.Equals(input.CatchupTime))
                ) && 
                (
                    this.HasSyncedSinceStartup == input.HasSyncedSinceStartup ||
                    (this.HasSyncedSinceStartup != null &&
                    this.HasSyncedSinceStartup.Equals(input.HasSyncedSinceStartup))
                ) && 
                (
                    this.LastConsensusVersion == input.LastConsensusVersion ||
                    (this.LastConsensusVersion != null &&
                    this.LastConsensusVersion.Equals(input.LastConsensusVersion))
                ) && 
                (
                    this.LastRound == input.LastRound ||
                    (this.LastRound != null &&
                    this.LastRound.Equals(input.LastRound))
                ) && 
                (
                    this.NextConsensusVersion == input.NextConsensusVersion ||
                    (this.NextConsensusVersion != null &&
                    this.NextConsensusVersion.Equals(input.NextConsensusVersion))
                ) && 
                (
                    this.NextConsensusVersionRound == input.NextConsensusVersionRound ||
                    (this.NextConsensusVersionRound != null &&
                    this.NextConsensusVersionRound.Equals(input.NextConsensusVersionRound))
                ) && 
                (
                    this.NextConsensusVersionSupported == input.NextConsensusVersionSupported ||
                    (this.NextConsensusVersionSupported != null &&
                    this.NextConsensusVersionSupported.Equals(input.NextConsensusVersionSupported))
                ) && 
                (
                    this.TimeSinceLastRound == input.TimeSinceLastRound ||
                    (this.TimeSinceLastRound != null &&
                    this.TimeSinceLastRound.Equals(input.TimeSinceLastRound))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.CatchupTime != null)
                    hashCode = hashCode * 59 + this.CatchupTime.GetHashCode();
                if (this.HasSyncedSinceStartup != null)
                    hashCode = hashCode * 59 + this.HasSyncedSinceStartup.GetHashCode();
                if (this.LastConsensusVersion != null)
                    hashCode = hashCode * 59 + this.LastConsensusVersion.GetHashCode();
                if (this.LastRound != null)
                    hashCode = hashCode * 59 + this.LastRound.GetHashCode();
                if (this.NextConsensusVersion != null)
                    hashCode = hashCode * 59 + this.NextConsensusVersion.GetHashCode();
                if (this.NextConsensusVersionRound != null)
                    hashCode = hashCode * 59 + this.NextConsensusVersionRound.GetHashCode();
                if (this.NextConsensusVersionSupported != null)
                    hashCode = hashCode * 59 + this.NextConsensusVersionSupported.GetHashCode();
                if (this.TimeSinceLastRound != null)
                    hashCode = hashCode * 59 + this.TimeSinceLastRound.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
