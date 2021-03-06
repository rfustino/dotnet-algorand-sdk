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
    /// Fields for an asset freeze transaction.  Definition: data/transactions/asset.go : AssetFreezeTxnFields
    /// </summary>
    [DataContract]
        public partial class TransactionAssetFreeze :  IEquatable<TransactionAssetFreeze>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionAssetFreeze" /> class.
        /// </summary>
        /// <param name="address">\\[fadd\\] Address of the account whose asset is being frozen or thawed. (required).</param>
        /// <param name="assetId">\\[faid\\] ID of the asset being frozen or thawed. (required).</param>
        /// <param name="newFreezeStatus">\\[afrz\\] The new freeze status. (required).</param>
        public TransactionAssetFreeze(string address = default(string), long? assetId = default, bool? newFreezeStatus = default(bool?))
        {
            // to ensure "address" is required (not null)
            if (address == null)
            {
                throw new InvalidDataException("address is a required property for TransactionAssetFreeze and cannot be null");
            }
            else
            {
                this.Address = address;
            }
            // to ensure "assetId" is required (not null)
            if (assetId == null)
            {
                throw new InvalidDataException("assetId is a required property for TransactionAssetFreeze and cannot be null");
            }
            else
            {
                this.AssetId = assetId;
            }
            // to ensure "newFreezeStatus" is required (not null)
            if (newFreezeStatus == null)
            {
                throw new InvalidDataException("newFreezeStatus is a required property for TransactionAssetFreeze and cannot be null");
            }
            else
            {
                this.NewFreezeStatus = newFreezeStatus;
            }
        }
        
        /// <summary>
        /// \\[fadd\\] Address of the account whose asset is being frozen or thawed.
        /// </summary>
        /// <value>\\[fadd\\] Address of the account whose asset is being frozen or thawed.</value>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; set; }

        /// <summary>
        /// \\[faid\\] ID of the asset being frozen or thawed.
        /// </summary>
        /// <value>\\[faid\\] ID of the asset being frozen or thawed.</value>
        [DataMember(Name="asset-id", EmitDefaultValue=false)]
        public long? AssetId { get; set; }

        /// <summary>
        /// \\[afrz\\] The new freeze status.
        /// </summary>
        /// <value>\\[afrz\\] The new freeze status.</value>
        [DataMember(Name="new-freeze-status", EmitDefaultValue=false)]
        public bool? NewFreezeStatus { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransactionAssetFreeze {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  AssetId: ").Append(AssetId).Append("\n");
            sb.Append("  NewFreezeStatus: ").Append(NewFreezeStatus).Append("\n");
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
            return this.Equals(input as TransactionAssetFreeze);
        }

        /// <summary>
        /// Returns true if TransactionAssetFreeze instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionAssetFreeze to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionAssetFreeze input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.AssetId == input.AssetId ||
                    (this.AssetId != null &&
                    this.AssetId.Equals(input.AssetId))
                ) && 
                (
                    this.NewFreezeStatus == input.NewFreezeStatus ||
                    (this.NewFreezeStatus != null &&
                    this.NewFreezeStatus.Equals(input.NewFreezeStatus))
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
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.AssetId != null)
                    hashCode = hashCode * 59 + this.AssetId.GetHashCode();
                if (this.NewFreezeStatus != null)
                    hashCode = hashCode * 59 + this.NewFreezeStatus.GetHashCode();
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
