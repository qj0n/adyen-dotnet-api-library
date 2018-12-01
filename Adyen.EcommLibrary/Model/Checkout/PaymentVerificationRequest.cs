
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Adyen.EcommLibrary.Model.Checkout
{
    /// <summary>
    /// PaymentVerificationRequest
    /// </summary>
    [DataContract]
    public partial class PaymentVerificationRequest :  IEquatable<PaymentVerificationRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentVerificationRequest" /> class.
        /// </summary>
        [JsonConstructor]
        protected PaymentVerificationRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentVerificationRequest" /> class.
        /// </summary>
        /// <param name="Payload">Encrypted and signed payment result data. You should receive this value from the Checkout SDK after the shopper completes the payment. (required).</param>
        public PaymentVerificationRequest(string Payload = default(string))
        {
            // to ensure "Payload" is required (not null)
            if (Payload == null)
            {
                throw new InvalidDataException("Payload is a required property for PaymentVerificationRequest and cannot be null");
            }
            else
            {
                this.Payload = Payload;
            }
        }
        
        /// <summary>
        /// Encrypted and signed payment result data. You should receive this value from the Checkout SDK after the shopper completes the payment.
        /// </summary>
        /// <value>Encrypted and signed payment result data. You should receive this value from the Checkout SDK after the shopper completes the payment.</value>
        [DataMember(Name="payload", EmitDefaultValue=false)]
        public string Payload { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentVerificationRequest {\n");
            sb.Append("  Payload: ").Append(Payload).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
            return this.Equals(input as PaymentVerificationRequest);
        }

        /// <summary>
        /// Returns true if PaymentVerificationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentVerificationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentVerificationRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Payload == input.Payload ||
                    (this.Payload != null &&
                    this.Payload.Equals(input.Payload))
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
                if (this.Payload != null)
                    hashCode = hashCode * 59 + this.Payload.GetHashCode();
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