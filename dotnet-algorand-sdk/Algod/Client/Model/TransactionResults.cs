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
    /// TransactionResults contains information about the side effects of a transaction
    /// </summary>
    [DataContract]
        public partial class TransactionResults :  IEquatable<TransactionResults>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionResults" /> class.
        /// </summary>
        /// <param name="createdasset">CreatedAssetIndex indicates the asset index of an asset created by this txn.</param>
        public TransactionResults(ulong? createdasset = default(ulong?))
        {
            this.Createdasset = createdasset;
        }
        
        /// <summary>
        /// CreatedAssetIndex indicates the asset index of an asset created by this txn
        /// </summary>
        /// <value>CreatedAssetIndex indicates the asset index of an asset created by this txn</value>
        [DataMember(Name="createdasset", EmitDefaultValue=false)]
        public ulong? Createdasset { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransactionResults {\n");
            sb.Append("  Createdasset: ").Append(Createdasset).Append("\n");
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
            return this.Equals(input as TransactionResults);
        }

        /// <summary>
        /// Returns true if TransactionResults instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionResults to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionResults input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Createdasset == input.Createdasset ||
                    (this.Createdasset != null &&
                    this.Createdasset.Equals(input.Createdasset))
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
                if (this.Createdasset != null)
                    hashCode = hashCode * 59 + this.Createdasset.GetHashCode();
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
