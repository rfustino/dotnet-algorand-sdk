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
    /// AssetParams
    /// </summary>
    [DataContract]
        public partial class AssetParams :  IEquatable<AssetParams>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AssetParams" /> class.
        /// </summary>
        /// <param name="assetname">AssetName specifies the name of this asset, as supplied by the creator..</param>
        /// <param name="clawbackaddr">ClawbackAddr specifies the address used to clawback holdings of this asset.  If empty, clawback is not permitted..</param>
        /// <param name="creator">Creator specifies the address that created this asset. This is the address where the parameters for this asset can be found, and also the address where unwanted asset units can be sent in the worst case. (required).</param>
        /// <param name="defaultfrozen">DefaultFrozen specifies whether holdings in this asset are frozen by default..</param>
        /// <param name="freezeaddr">FreezeAddr specifies the address used to freeze holdings of this asset.  If empty, freezing is not permitted..</param>
        /// <param name="managerkey">ManagerAddr specifies the address used to manage the keys of this asset and to destroy it..</param>
        /// <param name="metadatahash">MetadataHash specifies a commitment to some unspecified asset metadata. The format of this metadata is up to the application..</param>
        /// <param name="reserveaddr">ReserveAddr specifies the address holding reserve (non-minted) units of this asset..</param>
        /// <param name="total">Total specifies the total number of units of this asset. (required).</param>
        /// <param name="unitname">UnitName specifies the name of a unit of this asset, as supplied by the creator..</param>
        /// <param name="url">URL specifies a URL where more information about the asset can be retrieved.</param>
        public AssetParams(string assetname = default(string), string clawbackaddr = default(string), string creator = default(string), bool? defaultfrozen = default(bool?), string freezeaddr = default(string), string managerkey = default(string), string metadatahash = default(string), string reserveaddr = default(string), ulong? total = default(ulong?), string unitname = default(string), string url = default(string))
        {
            // to ensure "creator" is required (not null)
            if (creator == null)
            {
                throw new InvalidDataException("creator is a required property for AssetParams and cannot be null");
            }
            else
            {
                this.Creator = creator;
            }
            // to ensure "total" is required (not null)
            if (total == null)
            {
                throw new InvalidDataException("total is a required property for AssetParams and cannot be null");
            }
            else
            {
                this.Total = total;
            }
            this.Assetname = assetname;
            this.Clawbackaddr = clawbackaddr;
            this.Defaultfrozen = defaultfrozen;
            this.Freezeaddr = freezeaddr;
            this.Managerkey = managerkey;
            this.Metadatahash = metadatahash;
            this.Reserveaddr = reserveaddr;
            this.Unitname = unitname;
            this.Url = url;
        }
        
        /// <summary>
        /// AssetName specifies the name of this asset, as supplied by the creator.
        /// </summary>
        /// <value>AssetName specifies the name of this asset, as supplied by the creator.</value>
        [DataMember(Name="assetname", EmitDefaultValue=false)]
        public string Assetname { get; set; }

        /// <summary>
        /// ClawbackAddr specifies the address used to clawback holdings of this asset.  If empty, clawback is not permitted.
        /// </summary>
        /// <value>ClawbackAddr specifies the address used to clawback holdings of this asset.  If empty, clawback is not permitted.</value>
        [DataMember(Name="clawbackaddr", EmitDefaultValue=false)]
        public string Clawbackaddr { get; set; }

        /// <summary>
        /// Creator specifies the address that created this asset. This is the address where the parameters for this asset can be found, and also the address where unwanted asset units can be sent in the worst case.
        /// </summary>
        /// <value>Creator specifies the address that created this asset. This is the address where the parameters for this asset can be found, and also the address where unwanted asset units can be sent in the worst case.</value>
        [DataMember(Name="creator", EmitDefaultValue=false)]
        public string Creator { get; set; }

        /// <summary>
        /// DefaultFrozen specifies whether holdings in this asset are frozen by default.
        /// </summary>
        /// <value>DefaultFrozen specifies whether holdings in this asset are frozen by default.</value>
        [DataMember(Name="defaultfrozen", EmitDefaultValue=false)]
        public bool? Defaultfrozen { get; set; }

        /// <summary>
        /// FreezeAddr specifies the address used to freeze holdings of this asset.  If empty, freezing is not permitted.
        /// </summary>
        /// <value>FreezeAddr specifies the address used to freeze holdings of this asset.  If empty, freezing is not permitted.</value>
        [DataMember(Name="freezeaddr", EmitDefaultValue=false)]
        public string Freezeaddr { get; set; }

        /// <summary>
        /// ManagerAddr specifies the address used to manage the keys of this asset and to destroy it.
        /// </summary>
        /// <value>ManagerAddr specifies the address used to manage the keys of this asset and to destroy it.</value>
        [DataMember(Name="managerkey", EmitDefaultValue=false)]
        public string Managerkey { get; set; }

        /// <summary>
        /// MetadataHash specifies a commitment to some unspecified asset metadata. The format of this metadata is up to the application.
        /// </summary>
        /// <value>MetadataHash specifies a commitment to some unspecified asset metadata. The format of this metadata is up to the application.</value>
        [DataMember(Name="metadatahash", EmitDefaultValue=false)]
        public string Metadatahash { get; set; }

        /// <summary>
        /// ReserveAddr specifies the address holding reserve (non-minted) units of this asset.
        /// </summary>
        /// <value>ReserveAddr specifies the address holding reserve (non-minted) units of this asset.</value>
        [DataMember(Name="reserveaddr", EmitDefaultValue=false)]
        public string Reserveaddr { get; set; }

        /// <summary>
        /// Total specifies the total number of units of this asset.
        /// </summary>
        /// <value>Total specifies the total number of units of this asset.</value>
        [DataMember(Name="total", EmitDefaultValue=false)]
        public ulong? Total { get; set; }

        /// <summary>
        /// UnitName specifies the name of a unit of this asset, as supplied by the creator.
        /// </summary>
        /// <value>UnitName specifies the name of a unit of this asset, as supplied by the creator.</value>
        [DataMember(Name="unitname", EmitDefaultValue=false)]
        public string Unitname { get; set; }

        /// <summary>
        /// URL specifies a URL where more information about the asset can be retrieved
        /// </summary>
        /// <value>URL specifies a URL where more information about the asset can be retrieved</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssetParams {\n");
            sb.Append("  Assetname: ").Append(Assetname).Append("\n");
            sb.Append("  Clawbackaddr: ").Append(Clawbackaddr).Append("\n");
            sb.Append("  Creator: ").Append(Creator).Append("\n");
            sb.Append("  Defaultfrozen: ").Append(Defaultfrozen).Append("\n");
            sb.Append("  Freezeaddr: ").Append(Freezeaddr).Append("\n");
            sb.Append("  Managerkey: ").Append(Managerkey).Append("\n");
            sb.Append("  Metadatahash: ").Append(Metadatahash).Append("\n");
            sb.Append("  Reserveaddr: ").Append(Reserveaddr).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  Unitname: ").Append(Unitname).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
            return this.Equals(input as AssetParams);
        }

        /// <summary>
        /// Returns true if AssetParams instances are equal
        /// </summary>
        /// <param name="input">Instance of AssetParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AssetParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Assetname == input.Assetname ||
                    (this.Assetname != null &&
                    this.Assetname.Equals(input.Assetname))
                ) && 
                (
                    this.Clawbackaddr == input.Clawbackaddr ||
                    (this.Clawbackaddr != null &&
                    this.Clawbackaddr.Equals(input.Clawbackaddr))
                ) && 
                (
                    this.Creator == input.Creator ||
                    (this.Creator != null &&
                    this.Creator.Equals(input.Creator))
                ) && 
                (
                    this.Defaultfrozen == input.Defaultfrozen ||
                    (this.Defaultfrozen != null &&
                    this.Defaultfrozen.Equals(input.Defaultfrozen))
                ) && 
                (
                    this.Freezeaddr == input.Freezeaddr ||
                    (this.Freezeaddr != null &&
                    this.Freezeaddr.Equals(input.Freezeaddr))
                ) && 
                (
                    this.Managerkey == input.Managerkey ||
                    (this.Managerkey != null &&
                    this.Managerkey.Equals(input.Managerkey))
                ) && 
                (
                    this.Metadatahash == input.Metadatahash ||
                    (this.Metadatahash != null &&
                    this.Metadatahash.Equals(input.Metadatahash))
                ) && 
                (
                    this.Reserveaddr == input.Reserveaddr ||
                    (this.Reserveaddr != null &&
                    this.Reserveaddr.Equals(input.Reserveaddr))
                ) && 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
                ) && 
                (
                    this.Unitname == input.Unitname ||
                    (this.Unitname != null &&
                    this.Unitname.Equals(input.Unitname))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
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
                if (this.Assetname != null)
                    hashCode = hashCode * 59 + this.Assetname.GetHashCode();
                if (this.Clawbackaddr != null)
                    hashCode = hashCode * 59 + this.Clawbackaddr.GetHashCode();
                if (this.Creator != null)
                    hashCode = hashCode * 59 + this.Creator.GetHashCode();
                if (this.Defaultfrozen != null)
                    hashCode = hashCode * 59 + this.Defaultfrozen.GetHashCode();
                if (this.Freezeaddr != null)
                    hashCode = hashCode * 59 + this.Freezeaddr.GetHashCode();
                if (this.Managerkey != null)
                    hashCode = hashCode * 59 + this.Managerkey.GetHashCode();
                if (this.Metadatahash != null)
                    hashCode = hashCode * 59 + this.Metadatahash.GetHashCode();
                if (this.Reserveaddr != null)
                    hashCode = hashCode * 59 + this.Reserveaddr.GetHashCode();
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.Unitname != null)
                    hashCode = hashCode * 59 + this.Unitname.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
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
