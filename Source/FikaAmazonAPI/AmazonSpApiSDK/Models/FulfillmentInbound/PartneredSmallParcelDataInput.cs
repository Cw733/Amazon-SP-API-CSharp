/* 
 * Selling Partner API for Fulfillment Inbound
 *
 * The Selling Partner API for Fulfillment Inbound lets you create applications that create and update inbound shipments of inventory to Amazon's fulfillment network.
 *
 * OpenAPI spec version: v0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace AmazonSpApiSDK.Models.FulfillmentInbound
{
    /// <summary>
    /// Information that is required by an Amazon-partnered carrier to ship a Small Parcel inbound shipment.
    /// </summary>
    [DataContract]
    public partial class PartneredSmallParcelDataInput : IEquatable<PartneredSmallParcelDataInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PartneredSmallParcelDataInput" /> class.
        /// </summary>
        /// <param name="PackageList">PackageList.</param>
        /// <param name="CarrierName">The Amazon-partnered carrier to use for the inbound shipment..</param>
        public PartneredSmallParcelDataInput(PartneredSmallParcelPackageInputList PackageList = default(PartneredSmallParcelPackageInputList), string CarrierName = default(string))
        {
            this.PackageList = PackageList;
            this.CarrierName = CarrierName;
        }

        /// <summary>
        /// Gets or Sets PackageList
        /// </summary>
        [DataMember(Name = "PackageList", EmitDefaultValue = false)]
        public PartneredSmallParcelPackageInputList PackageList { get; set; }

        /// <summary>
        /// The Amazon-partnered carrier to use for the inbound shipment.
        /// </summary>
        /// <value>The Amazon-partnered carrier to use for the inbound shipment.</value>
        [DataMember(Name = "CarrierName", EmitDefaultValue = false)]
        public string CarrierName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PartneredSmallParcelDataInput {\n");
            sb.Append("  PackageList: ").Append(PackageList).Append("\n");
            sb.Append("  CarrierName: ").Append(CarrierName).Append("\n");
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
            return this.Equals(input as PartneredSmallParcelDataInput);
        }

        /// <summary>
        /// Returns true if PartneredSmallParcelDataInput instances are equal
        /// </summary>
        /// <param name="input">Instance of PartneredSmallParcelDataInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PartneredSmallParcelDataInput input)
        {
            if (input == null)
                return false;

            return
                (
                    this.PackageList == input.PackageList ||
                    (this.PackageList != null &&
                    this.PackageList.Equals(input.PackageList))
                ) &&
                (
                    this.CarrierName == input.CarrierName ||
                    (this.CarrierName != null &&
                    this.CarrierName.Equals(input.CarrierName))
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
                if (this.PackageList != null)
                    hashCode = hashCode * 59 + this.PackageList.GetHashCode();
                if (this.CarrierName != null)
                    hashCode = hashCode * 59 + this.CarrierName.GetHashCode();
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