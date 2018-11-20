﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Adyen.EcommLibrary.Model
{
    /// <summary>
    /// ApplicationInfo
    /// </summary>
    [DataContract]
    public partial class ApplicationInfo :  IEquatable<ApplicationInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationInfo" /> class.
        /// </summary>
        /// <param name="AdyenLibrary">AdyenLibrary.</param>
        /// <param name="AdyenPaymentSource">AdyenPaymentSource.</param>
        /// <param name="ExternalPlatform">ExternalPlatform.</param>
        /// <param name="MerchantApplication">MerchantApplication.</param>
        /// <param name="MerchantDevice">MerchantDevice.</param>
        /// <param name="ShopperInteractionDevice">ShopperInteractionDevice.</param>
        public ApplicationInfo(CommonField AdyenLibrary = default(CommonField), CommonField AdyenPaymentSource = default(CommonField), ExternalPlatform ExternalPlatform = default(ExternalPlatform), CommonField MerchantApplication = default(CommonField), MerchantDevice MerchantDevice = default(MerchantDevice), ShopperInteractionDevice ShopperInteractionDevice = default(ShopperInteractionDevice))
        {
            this.AdyenLibrary = AdyenLibrary;
            this.AdyenPaymentSource = AdyenPaymentSource;
            this.ExternalPlatform = ExternalPlatform;
            this.MerchantApplication = MerchantApplication;
            this.MerchantDevice = MerchantDevice;
            this.ShopperInteractionDevice = ShopperInteractionDevice;
        }
        
        /// <summary>
        /// Gets or Sets AdyenLibrary
        /// </summary>
        [DataMember(Name="adyenLibrary", EmitDefaultValue=false)]
        public CommonField AdyenLibrary { get; set; }

        /// <summary>
        /// Gets or Sets AdyenPaymentSource
        /// </summary>
        [DataMember(Name="adyenPaymentSource", EmitDefaultValue=false)]
        public CommonField AdyenPaymentSource { get; set; }

        /// <summary>
        /// Gets or Sets ExternalPlatform
        /// </summary>
        [DataMember(Name="externalPlatform", EmitDefaultValue=false)]
        public ExternalPlatform ExternalPlatform { get; set; }

        /// <summary>
        /// Gets or Sets MerchantApplication
        /// </summary>
        [DataMember(Name="merchantApplication", EmitDefaultValue=false)]
        public CommonField MerchantApplication { get; set; }

        /// <summary>
        /// Gets or Sets MerchantDevice
        /// </summary>
        [DataMember(Name="merchantDevice", EmitDefaultValue=false)]
        public MerchantDevice MerchantDevice { get; set; }

        /// <summary>
        /// Gets or Sets ShopperInteractionDevice
        /// </summary>
        [DataMember(Name="shopperInteractionDevice", EmitDefaultValue=false)]
        public ShopperInteractionDevice ShopperInteractionDevice { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApplicationInfo {\n");
            sb.Append("  AdyenLibrary: ").Append(AdyenLibrary).Append("\n");
            sb.Append("  AdyenPaymentSource: ").Append(AdyenPaymentSource).Append("\n");
            sb.Append("  ExternalPlatform: ").Append(ExternalPlatform).Append("\n");
            sb.Append("  MerchantApplication: ").Append(MerchantApplication).Append("\n");
            sb.Append("  MerchantDevice: ").Append(MerchantDevice).Append("\n");
            sb.Append("  ShopperInteractionDevice: ").Append(ShopperInteractionDevice).Append("\n");
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
            return this.Equals(input as ApplicationInfo);
        }

        /// <summary>
        /// Returns true if ApplicationInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ApplicationInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApplicationInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AdyenLibrary == input.AdyenLibrary ||
                    (this.AdyenLibrary != null &&
                    this.AdyenLibrary.Equals(input.AdyenLibrary))
                ) && 
                (
                    this.AdyenPaymentSource == input.AdyenPaymentSource ||
                    (this.AdyenPaymentSource != null &&
                    this.AdyenPaymentSource.Equals(input.AdyenPaymentSource))
                ) && 
                (
                    this.ExternalPlatform == input.ExternalPlatform ||
                    (this.ExternalPlatform != null &&
                    this.ExternalPlatform.Equals(input.ExternalPlatform))
                ) && 
                (
                    this.MerchantApplication == input.MerchantApplication ||
                    (this.MerchantApplication != null &&
                    this.MerchantApplication.Equals(input.MerchantApplication))
                ) && 
                (
                    this.MerchantDevice == input.MerchantDevice ||
                    (this.MerchantDevice != null &&
                    this.MerchantDevice.Equals(input.MerchantDevice))
                ) && 
                (
                    this.ShopperInteractionDevice == input.ShopperInteractionDevice ||
                    (this.ShopperInteractionDevice != null &&
                    this.ShopperInteractionDevice.Equals(input.ShopperInteractionDevice))
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
                if (this.AdyenLibrary != null)
                    hashCode = hashCode * 59 + this.AdyenLibrary.GetHashCode();
                if (this.AdyenPaymentSource != null)
                    hashCode = hashCode * 59 + this.AdyenPaymentSource.GetHashCode();
                if (this.ExternalPlatform != null)
                    hashCode = hashCode * 59 + this.ExternalPlatform.GetHashCode();
                if (this.MerchantApplication != null)
                    hashCode = hashCode * 59 + this.MerchantApplication.GetHashCode();
                if (this.MerchantDevice != null)
                    hashCode = hashCode * 59 + this.MerchantDevice.GetHashCode();
                if (this.ShopperInteractionDevice != null)
                    hashCode = hashCode * 59 + this.ShopperInteractionDevice.GetHashCode();
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
