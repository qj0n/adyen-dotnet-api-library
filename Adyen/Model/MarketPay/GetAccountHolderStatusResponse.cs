#region License
// /*
//  *                       ######
//  *                       ######
//  * ############    ####( ######  #####. ######  ############   ############
//  * #############  #####( ######  #####. ######  #############  #############
//  *        ######  #####( ######  #####. ######  #####  ######  #####  ######
//  * ###### ######  #####( ######  #####. ######  #####  #####   #####  ######
//  * ###### ######  #####( ######  #####. ######  #####          #####  ######
//  * #############  #############  #############  #############  #####  ######
//  *  ############   ############  #############   ############  #####  ######
//  *                                      ######
//  *                               #############
//  *                               ############
//  *
//  * Adyen Dotnet API Library
//  *
//  * Copyright (c) 2020 Adyen B.V.
//  * This file is open source and available under the MIT license.
//  * See the LICENSE file for more info.
//  */
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Adyen.Model.MarketPay
{
    /// <summary>
    /// GetAccountHolderStatusResponse
    /// </summary>
    [DataContract]
        public partial class GetAccountHolderStatusResponse :  IEquatable<GetAccountHolderStatusResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAccountHolderStatusResponse" /> class.
        /// </summary>
        /// <param name="accountHolderCode">The code of the Account Holder. (required).</param>
        /// <param name="accountHolderStatus">accountHolderStatus (required).</param>
        /// <param name="invalidFields">Contains field validation errors that would prevent requests from being processed..</param>
        /// <param name="pspReference">The reference of a request.  Can be used to uniquely identify the request. (required).</param>
        /// <param name="resultCode">The result code..</param>
        public GetAccountHolderStatusResponse(string accountHolderCode = default(string), AccountHolderStatus accountHolderStatus = default(AccountHolderStatus), List<ErrorFieldType> invalidFields = default(List<ErrorFieldType>), string pspReference = default(string), string resultCode = default(string))
        {
            // to ensure "accountHolderCode" is required (not null)
            if (accountHolderCode == null)
            {
                throw new InvalidDataException("accountHolderCode is a required property for GetAccountHolderStatusResponse and cannot be null");
            }
            else
            {
                this.AccountHolderCode = accountHolderCode;
            }
            // to ensure "pspReference" is required (not null)
            if (pspReference == null)
            {
                throw new InvalidDataException("pspReference is a required property for GetAccountHolderStatusResponse and cannot be null");
            }
            else
            {
                this.PspReference = pspReference;
            }
            this.AccountHolderStatus = accountHolderStatus;
            this.InvalidFields = invalidFields;
            this.ResultCode = resultCode;
        }
        
        /// <summary>
        /// The code of the Account Holder.
        /// </summary>
        /// <value>The code of the Account Holder.</value>
        [DataMember(Name="accountHolderCode", EmitDefaultValue=false)]
        public string AccountHolderCode { get; set; }

        /// <summary>
        /// Gets or Sets AccountHolderStatus
        /// </summary>
        [DataMember(Name="accountHolderStatus", EmitDefaultValue=false)]
        public AccountHolderStatus AccountHolderStatus { get; set; }

        /// <summary>
        /// Contains field validation errors that would prevent requests from being processed.
        /// </summary>
        /// <value>Contains field validation errors that would prevent requests from being processed.</value>
        [DataMember(Name="invalidFields", EmitDefaultValue=false)]
        public List<ErrorFieldType> InvalidFields { get; set; }

        /// <summary>
        /// The reference of a request.  Can be used to uniquely identify the request.
        /// </summary>
        /// <value>The reference of a request.  Can be used to uniquely identify the request.</value>
        [DataMember(Name="pspReference", EmitDefaultValue=false)]
        public string PspReference { get; set; }

        /// <summary>
        /// The result code.
        /// </summary>
        /// <value>The result code.</value>
        [DataMember(Name="resultCode", EmitDefaultValue=false)]
        public string ResultCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetAccountHolderStatusResponse {\n");
            sb.Append("  AccountHolderCode: ").Append(AccountHolderCode).Append("\n");
            sb.Append("  AccountHolderStatus: ").Append(AccountHolderStatus).Append("\n");
            sb.Append("  InvalidFields: ").Append(InvalidFields).Append("\n");
            sb.Append("  PspReference: ").Append(PspReference).Append("\n");
            sb.Append("  ResultCode: ").Append(ResultCode).Append("\n");
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
            return this.Equals(input as GetAccountHolderStatusResponse);
        }

        /// <summary>
        /// Returns true if GetAccountHolderStatusResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetAccountHolderStatusResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetAccountHolderStatusResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccountHolderCode == input.AccountHolderCode ||
                    (this.AccountHolderCode != null &&
                    this.AccountHolderCode.Equals(input.AccountHolderCode))
                ) && 
                (
                    this.AccountHolderStatus == input.AccountHolderStatus ||
                    (this.AccountHolderStatus != null &&
                    this.AccountHolderStatus.Equals(input.AccountHolderStatus))
                ) && 
                (
                    this.InvalidFields == input.InvalidFields ||
                    this.InvalidFields != null &&
                    input.InvalidFields != null &&
                    this.InvalidFields.SequenceEqual(input.InvalidFields)
                ) && 
                (
                    this.PspReference == input.PspReference ||
                    (this.PspReference != null &&
                    this.PspReference.Equals(input.PspReference))
                ) && 
                (
                    this.ResultCode == input.ResultCode ||
                    (this.ResultCode != null &&
                    this.ResultCode.Equals(input.ResultCode))
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
                if (this.AccountHolderCode != null)
                    hashCode = hashCode * 59 + this.AccountHolderCode.GetHashCode();
                if (this.AccountHolderStatus != null)
                    hashCode = hashCode * 59 + this.AccountHolderStatus.GetHashCode();
                if (this.InvalidFields != null)
                    hashCode = hashCode * 59 + this.InvalidFields.GetHashCode();
                if (this.PspReference != null)
                    hashCode = hashCode * 59 + this.PspReference.GetHashCode();
                if (this.ResultCode != null)
                    hashCode = hashCode * 59 + this.ResultCode.GetHashCode();
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
