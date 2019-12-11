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
    /// Account Description
    /// </summary>
    [DataContract]
    public partial class Account :  IEquatable<Account>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Account" /> class.
        /// </summary>
        /// <param name="address">Address indicates the account public key (required).</param>
        /// <param name="amount">Amount indicates the total number of MicroAlgos in the account (required).</param>
        /// <param name="amountwithoutpendingrewards">AmountWithoutPendingRewards specifies the amount of MicroAlgos in the account, without the pending rewards. (required).</param>
        /// <param name="assets">Assets specifies the holdings of assets by this account, indexed by the asset ID..</param>
        /// <param name="participation">participation.</param>
        /// <param name="pendingrewards">PendingRewards specifies the amount of MicroAlgos of pending rewards in this account. (required).</param>
        /// <param name="rewards">Rewards indicates the total rewards of MicroAlgos the account has received, including pending rewards. (required).</param>
        /// <param name="round">Round indicates the round for which this information is relevant (required).</param>
        /// <param name="status">Status indicates the delegation status of the account&#x27;s MicroAlgos Offline - indicates that the associated account is delegated. Online  - indicates that the associated account used as part of the delegation pool. NotParticipating - indicates that the associated account is neither a delegator nor a delegate. (required).</param>
        /// <param name="thisassettotal">AssetParams specifies the parameters of assets created by this account..</param>
        public Account(string address = default(string), ulong? amount = default(ulong?), ulong? amountwithoutpendingrewards = default(ulong?), Object assets = default(Object), Participation participation = default(Participation), ulong? pendingrewards = default(ulong?), ulong? rewards = default(ulong?), ulong? round = default(ulong?), string status = default(string), Object thisassettotal = default(Object))
        {
            // to ensure "address" is required (not null)
            if (address == null)
            {
                throw new InvalidDataException("address is a required property for Account and cannot be null");
            }
            else
            {
                this.Address = address;
            }
            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new InvalidDataException("amount is a required property for Account and cannot be null");
            }
            else
            {
                this.Amount = amount;
            }
            // to ensure "amountwithoutpendingrewards" is required (not null)
            if (amountwithoutpendingrewards == null)
            {
                throw new InvalidDataException("amountwithoutpendingrewards is a required property for Account and cannot be null");
            }
            else
            {
                this.Amountwithoutpendingrewards = amountwithoutpendingrewards;
            }
            // to ensure "pendingrewards" is required (not null)
            if (pendingrewards == null)
            {
                throw new InvalidDataException("pendingrewards is a required property for Account and cannot be null");
            }
            else
            {
                this.Pendingrewards = pendingrewards;
            }
            // to ensure "rewards" is required (not null)
            if (rewards == null)
            {
                throw new InvalidDataException("rewards is a required property for Account and cannot be null");
            }
            else
            {
                this.Rewards = rewards;
            }
            // to ensure "round" is required (not null)
            if (round == null)
            {
                throw new InvalidDataException("round is a required property for Account and cannot be null");
            }
            else
            {
                this.Round = round;
            }
            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new InvalidDataException("status is a required property for Account and cannot be null");
            }
            else
            {
                this.Status = status;
            }
            this.Assets = assets;
            this.Participation = participation;
            this.Thisassettotal = thisassettotal;
        }
        
        /// <summary>
        /// Address indicates the account public key
        /// </summary>
        /// <value>Address indicates the account public key</value>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; set; }

        /// <summary>
        /// Amount indicates the total number of MicroAlgos in the account
        /// </summary>
        /// <value>Amount indicates the total number of MicroAlgos in the account</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public ulong? Amount { get; set; }

        /// <summary>
        /// AmountWithoutPendingRewards specifies the amount of MicroAlgos in the account, without the pending rewards.
        /// </summary>
        /// <value>AmountWithoutPendingRewards specifies the amount of MicroAlgos in the account, without the pending rewards.</value>
        [DataMember(Name="amountwithoutpendingrewards", EmitDefaultValue=false)]
        public ulong? Amountwithoutpendingrewards { get; set; }

        /// <summary>
        /// Assets specifies the holdings of assets by this account, indexed by the asset ID.
        /// </summary>
        /// <value>Assets specifies the holdings of assets by this account, indexed by the asset ID.</value>
        [DataMember(Name="assets", EmitDefaultValue=false)]
        public Object Assets { get; set; }

        /// <summary>
        /// Gets or Sets Participation
        /// </summary>
        [DataMember(Name="participation", EmitDefaultValue=false)]
        public Participation Participation { get; set; }

        /// <summary>
        /// PendingRewards specifies the amount of MicroAlgos of pending rewards in this account.
        /// </summary>
        /// <value>PendingRewards specifies the amount of MicroAlgos of pending rewards in this account.</value>
        [DataMember(Name="pendingrewards", EmitDefaultValue=false)]
        public ulong? Pendingrewards { get; set; }

        /// <summary>
        /// Rewards indicates the total rewards of MicroAlgos the account has received, including pending rewards.
        /// </summary>
        /// <value>Rewards indicates the total rewards of MicroAlgos the account has received, including pending rewards.</value>
        [DataMember(Name="rewards", EmitDefaultValue=false)]
        public ulong? Rewards { get; set; }

        /// <summary>
        /// Round indicates the round for which this information is relevant
        /// </summary>
        /// <value>Round indicates the round for which this information is relevant</value>
        [DataMember(Name="round", EmitDefaultValue=false)]
        public ulong? Round { get; set; }

        /// <summary>
        /// Status indicates the delegation status of the account&#x27;s MicroAlgos Offline - indicates that the associated account is delegated. Online  - indicates that the associated account used as part of the delegation pool. NotParticipating - indicates that the associated account is neither a delegator nor a delegate.
        /// </summary>
        /// <value>Status indicates the delegation status of the account&#x27;s MicroAlgos Offline - indicates that the associated account is delegated. Online  - indicates that the associated account used as part of the delegation pool. NotParticipating - indicates that the associated account is neither a delegator nor a delegate.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// AssetParams specifies the parameters of assets created by this account.
        /// </summary>
        /// <value>AssetParams specifies the parameters of assets created by this account.</value>
        [DataMember(Name="thisassettotal", EmitDefaultValue=false)]
        public Object Thisassettotal { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Account {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Amountwithoutpendingrewards: ").Append(Amountwithoutpendingrewards).Append("\n");
            sb.Append("  Assets: ").Append(Assets).Append("\n");
            sb.Append("  Participation: ").Append(Participation).Append("\n");
            sb.Append("  Pendingrewards: ").Append(Pendingrewards).Append("\n");
            sb.Append("  Rewards: ").Append(Rewards).Append("\n");
            sb.Append("  Round: ").Append(Round).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Thisassettotal: ").Append(Thisassettotal).Append("\n");
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
            return this.Equals(input as Account);
        }

        /// <summary>
        /// Returns true if Account instances are equal
        /// </summary>
        /// <param name="input">Instance of Account to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Account input)
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
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.Amountwithoutpendingrewards == input.Amountwithoutpendingrewards ||
                    (this.Amountwithoutpendingrewards != null &&
                    this.Amountwithoutpendingrewards.Equals(input.Amountwithoutpendingrewards))
                ) && 
                (
                    this.Assets == input.Assets ||
                    (this.Assets != null &&
                    this.Assets.Equals(input.Assets))
                ) && 
                (
                    this.Participation == input.Participation ||
                    (this.Participation != null &&
                    this.Participation.Equals(input.Participation))
                ) && 
                (
                    this.Pendingrewards == input.Pendingrewards ||
                    (this.Pendingrewards != null &&
                    this.Pendingrewards.Equals(input.Pendingrewards))
                ) && 
                (
                    this.Rewards == input.Rewards ||
                    (this.Rewards != null &&
                    this.Rewards.Equals(input.Rewards))
                ) && 
                (
                    this.Round == input.Round ||
                    (this.Round != null &&
                    this.Round.Equals(input.Round))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Thisassettotal == input.Thisassettotal ||
                    (this.Thisassettotal != null &&
                    this.Thisassettotal.Equals(input.Thisassettotal))
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
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.Amountwithoutpendingrewards != null)
                    hashCode = hashCode * 59 + this.Amountwithoutpendingrewards.GetHashCode();
                if (this.Assets != null)
                    hashCode = hashCode * 59 + this.Assets.GetHashCode();
                if (this.Participation != null)
                    hashCode = hashCode * 59 + this.Participation.GetHashCode();
                if (this.Pendingrewards != null)
                    hashCode = hashCode * 59 + this.Pendingrewards.GetHashCode();
                if (this.Rewards != null)
                    hashCode = hashCode * 59 + this.Rewards.GetHashCode();
                if (this.Round != null)
                    hashCode = hashCode * 59 + this.Round.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Thisassettotal != null)
                    hashCode = hashCode * 59 + this.Thisassettotal.GetHashCode();
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
