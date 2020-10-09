/* 
 * Indexer
 *
 * Algorand ledger analytics API.
 *
 * OpenAPI spec version: 2.0
 * 
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
using SwaggerDateConverter = Algorand.Client.SwaggerDateConverter;

namespace Algorand.V2.Model
{
    /// <summary>
    /// Represents a \\[apls\\] local-state or \\[apgs\\] global-state schema. These schemas determine how much storage may be used in a local-state or global-state for an application. The more space used, the larger minimum balance must be maintained in the account holding the data.
    /// </summary>
    [DataContract]
        public partial class StateSchema :  IEquatable<StateSchema>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StateSchema" /> class.
        /// </summary>
        /// <param name="numByteSlice">Maximum number of TEAL byte slices that may be stored in the key/value store. (required).</param>
        /// <param name="numUint">Maximum number of TEAL uints that may be stored in the key/value store. (required).</param>
        public StateSchema(ulong? numByteSlice = 0, ulong? numUint = 0)
        {
            // to ensure "numByteSlice" is required (not null)
            if (numByteSlice == null)
            {
                throw new InvalidDataException("numByteSlice is a required property for StateSchema and cannot be null");
            }
            else
            {
                this.NumByteSlice = numByteSlice;
            }
            // to ensure "numUint" is required (not null)
            if (numUint == null)
            {
                throw new InvalidDataException("numUint is a required property for StateSchema and cannot be null");
            }
            else
            {
                this.NumUint = numUint;
            }
        }
        
        /// <summary>
        /// Maximum number of TEAL byte slices that may be stored in the key/value store.
        /// </summary>
        /// <value>Maximum number of TEAL byte slices that may be stored in the key/value store.</value>
        [DataMember(Name="num-byte-slice", EmitDefaultValue=false)]
        public ulong? NumByteSlice { get; set; }

        /// <summary>
        /// Maximum number of TEAL uints that may be stored in the key/value store.
        /// </summary>
        /// <value>Maximum number of TEAL uints that may be stored in the key/value store.</value>
        [DataMember(Name="num-uint", EmitDefaultValue=false)]
        public ulong? NumUint { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StateSchema {\n");
            sb.Append("  NumByteSlice: ").Append(NumByteSlice).Append("\n");
            sb.Append("  NumUint: ").Append(NumUint).Append("\n");
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
            return this.Equals(input as StateSchema);
        }

        /// <summary>
        /// Returns true if StateSchema instances are equal
        /// </summary>
        /// <param name="input">Instance of StateSchema to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StateSchema input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NumByteSlice == input.NumByteSlice ||
                    (this.NumByteSlice != null &&
                    this.NumByteSlice.Equals(input.NumByteSlice))
                ) && 
                (
                    this.NumUint == input.NumUint ||
                    (this.NumUint != null &&
                    this.NumUint.Equals(input.NumUint))
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
                if (this.NumByteSlice != null)
                    hashCode = hashCode * 59 + this.NumByteSlice.GetHashCode();
                if (this.NumUint != null)
                    hashCode = hashCode * 59 + this.NumUint.GetHashCode();
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
