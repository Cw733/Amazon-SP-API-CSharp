/* 
 * Selling Partner API for Pricing
 *
 * The Selling Partner API for Pricing helps you programmatically retrieve product pricing and offer information for Amazon Marketplace products.
 *
 * OpenAPI spec version: v0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;

namespace AmazonSpApiSDK.Models.ProductPricing
{
    /// <summary>
    /// GetOffersResult
    /// </summary>
    [DataContract]
    public partial class GetOffersResult : IEquatable<GetOffersResult>, IValidatableObject
    {
        /// <summary>
        /// The condition of the item.
        /// </summary>
        /// <value>The condition of the item.</value>
        [DataMember(Name = "ItemCondition", EmitDefaultValue = false)]
        public ConditionType ItemCondition { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetOffersResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetOffersResult() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetOffersResult" /> class.
        /// </summary>
        /// <param name="MarketplaceID">A marketplace identifier. (required).</param>
        /// <param name="ASIN">The Amazon Standard Identification Number (ASIN) of the item..</param>
        /// <param name="SKU">The stock keeping unit (SKU) of the item..</param>
        /// <param name="ItemCondition">The condition of the item. (required).</param>
        /// <param name="Status">The status of the operation. (required).</param>
        /// <param name="Identifier">Metadata that identifies the item. (required).</param>
        /// <param name="Summary">Pricing information about the item. (required).</param>
        /// <param name="Offers">A list of offer details. The list is the same length as the TotalOfferCount in the Summary or 20, whichever is less. (required).</param>
        public GetOffersResult(string MarketplaceID = default(string), string ASIN = default(string), string SKU = default(string), ConditionType ItemCondition = default(ConditionType), string Status = default(string), ItemIdentifier Identifier = default(ItemIdentifier), Summary Summary = default(Summary), OfferDetailList Offers = default(OfferDetailList))
        {
            // to ensure "MarketplaceID" is required (not null)
            if (MarketplaceID == null)
            {
                throw new InvalidDataException("MarketplaceID is a required property for GetOffersResult and cannot be null");
            }
            else
            {
                this.MarketplaceID = MarketplaceID;
            }
            // to ensure "ItemCondition" is required (not null)
            if (ItemCondition == null)
            {
                throw new InvalidDataException("ItemCondition is a required property for GetOffersResult and cannot be null");
            }
            else
            {
                this.ItemCondition = ItemCondition;
            }
            // to ensure "Status" is required (not null)
            if (Status == null)
            {
                throw new InvalidDataException("Status is a required property for GetOffersResult and cannot be null");
            }
            else
            {
                this.Status = Status;
            }
            // to ensure "Identifier" is required (not null)
            if (Identifier == null)
            {
                throw new InvalidDataException("Identifier is a required property for GetOffersResult and cannot be null");
            }
            else
            {
                this.Identifier = Identifier;
            }
            // to ensure "Summary" is required (not null)
            if (Summary == null)
            {
                throw new InvalidDataException("Summary is a required property for GetOffersResult and cannot be null");
            }
            else
            {
                this.Summary = Summary;
            }
            // to ensure "Offers" is required (not null)
            if (Offers == null)
            {
                throw new InvalidDataException("Offers is a required property for GetOffersResult and cannot be null");
            }
            else
            {
                this.Offers = Offers;
            }
            this.ASIN = ASIN;
            this.SKU = SKU;
        }

        /// <summary>
        /// A marketplace identifier.
        /// </summary>
        /// <value>A marketplace identifier.</value>
        [DataMember(Name = "MarketplaceID", EmitDefaultValue = false)]
        public string MarketplaceID { get; set; }

        /// <summary>
        /// The Amazon Standard Identification Number (ASIN) of the item.
        /// </summary>
        /// <value>The Amazon Standard Identification Number (ASIN) of the item.</value>
        [DataMember(Name = "ASIN", EmitDefaultValue = false)]
        public string ASIN { get; set; }

        /// <summary>
        /// The stock keeping unit (SKU) of the item.
        /// </summary>
        /// <value>The stock keeping unit (SKU) of the item.</value>
        [DataMember(Name = "SKU", EmitDefaultValue = false)]
        public string SKU { get; set; }


        /// <summary>
        /// The status of the operation.
        /// </summary>
        /// <value>The status of the operation.</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Metadata that identifies the item.
        /// </summary>
        /// <value>Metadata that identifies the item.</value>
        [DataMember(Name = "Identifier", EmitDefaultValue = false)]
        public ItemIdentifier Identifier { get; set; }

        /// <summary>
        /// Pricing information about the item.
        /// </summary>
        /// <value>Pricing information about the item.</value>
        [DataMember(Name = "Summary", EmitDefaultValue = false)]
        public Summary Summary { get; set; }

        /// <summary>
        /// A list of offer details. The list is the same length as the TotalOfferCount in the Summary or 20, whichever is less.
        /// </summary>
        /// <value>A list of offer details. The list is the same length as the TotalOfferCount in the Summary or 20, whichever is less.</value>
        [DataMember(Name = "Offers", EmitDefaultValue = false)]
        public OfferDetailList Offers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetOffersResult {\n");
            sb.Append("  MarketplaceID: ").Append(MarketplaceID).Append("\n");
            sb.Append("  ASIN: ").Append(ASIN).Append("\n");
            sb.Append("  SKU: ").Append(SKU).Append("\n");
            sb.Append("  ItemCondition: ").Append(ItemCondition).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  Summary: ").Append(Summary).Append("\n");
            sb.Append("  Offers: ").Append(Offers).Append("\n");
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
            return this.Equals(input as GetOffersResult);
        }

        /// <summary>
        /// Returns true if GetOffersResult instances are equal
        /// </summary>
        /// <param name="input">Instance of GetOffersResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetOffersResult input)
        {
            if (input == null)
                return false;

            return
                (
                    this.MarketplaceID == input.MarketplaceID ||
                    (this.MarketplaceID != null &&
                    this.MarketplaceID.Equals(input.MarketplaceID))
                ) &&
                (
                    this.ASIN == input.ASIN ||
                    (this.ASIN != null &&
                    this.ASIN.Equals(input.ASIN))
                ) &&
                (
                    this.SKU == input.SKU ||
                    (this.SKU != null &&
                    this.SKU.Equals(input.SKU))
                ) &&
                (
                    this.ItemCondition == input.ItemCondition ||
                    (this.ItemCondition != null &&
                    this.ItemCondition.Equals(input.ItemCondition))
                ) &&
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) &&
                (
                    this.Identifier == input.Identifier ||
                    (this.Identifier != null &&
                    this.Identifier.Equals(input.Identifier))
                ) &&
                (
                    this.Summary == input.Summary ||
                    (this.Summary != null &&
                    this.Summary.Equals(input.Summary))
                ) &&
                (
                    this.Offers == input.Offers ||
                    (this.Offers != null &&
                    this.Offers.Equals(input.Offers))
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
                if (this.MarketplaceID != null)
                    hashCode = hashCode * 59 + this.MarketplaceID.GetHashCode();
                if (this.ASIN != null)
                    hashCode = hashCode * 59 + this.ASIN.GetHashCode();
                if (this.SKU != null)
                    hashCode = hashCode * 59 + this.SKU.GetHashCode();
                if (this.ItemCondition != null)
                    hashCode = hashCode * 59 + this.ItemCondition.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Identifier != null)
                    hashCode = hashCode * 59 + this.Identifier.GetHashCode();
                if (this.Summary != null)
                    hashCode = hashCode * 59 + this.Summary.GetHashCode();
                if (this.Offers != null)
                    hashCode = hashCode * 59 + this.Offers.GetHashCode();
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