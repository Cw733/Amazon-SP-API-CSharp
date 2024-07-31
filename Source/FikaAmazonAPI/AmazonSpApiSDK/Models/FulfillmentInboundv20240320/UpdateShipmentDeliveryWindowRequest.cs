/* 
 * The Selling Partner API for FBA inbound operations.
 *
 * The Selling Partner API for Fulfillment By Amazon (FBA) Inbound. The FBA Inbound API enables building inbound workflows to create, manage, and send shipments into Amazon's fulfillment network. The API has interoperability with the Send-to-Amazon user interface.
 *
 * OpenAPI spec version: 2024-03-20
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

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.FulfillmentInboundv20240320
{
    /// <summary>
    /// The &#x60;updateShipmentDeliveryWindow&#x60; request.
    /// </summary>
    [DataContract]
    public partial class UpdateShipmentDeliveryWindowRequest :  IEquatable<UpdateShipmentDeliveryWindowRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateShipmentDeliveryWindowRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateShipmentDeliveryWindowRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateShipmentDeliveryWindowRequest" /> class.
        /// </summary>
        /// <param name="deliveryWindow">The range of dates within which the seller expects that their shipment will be delivered to Amazon.  (required).</param>
        public UpdateShipmentDeliveryWindowRequest(WindowInput deliveryWindow = default(WindowInput))
        {
            // to ensure "deliveryWindow" is required (not null)
            if (deliveryWindow == null)
            {
                throw new InvalidDataException("deliveryWindow is a required property for UpdateShipmentDeliveryWindowRequest and cannot be null");
            }
            else
            {
                this.DeliveryWindow = deliveryWindow;
            }
        }
        
        /// <summary>
        /// The range of dates within which the seller expects that their shipment will be delivered to Amazon. 
        /// </summary>
        /// <value>The range of dates within which the seller expects that their shipment will be delivered to Amazon. </value>
        [DataMember(Name="deliveryWindow", EmitDefaultValue=false)]
        public WindowInput DeliveryWindow { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateShipmentDeliveryWindowRequest {\n");
            sb.Append("  DeliveryWindow: ").Append(DeliveryWindow).Append("\n");
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
            return this.Equals(input as UpdateShipmentDeliveryWindowRequest);
        }

        /// <summary>
        /// Returns true if UpdateShipmentDeliveryWindowRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateShipmentDeliveryWindowRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateShipmentDeliveryWindowRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DeliveryWindow == input.DeliveryWindow ||
                    (this.DeliveryWindow != null &&
                    this.DeliveryWindow.Equals(input.DeliveryWindow))
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
                if (this.DeliveryWindow != null)
                    hashCode = hashCode * 59 + this.DeliveryWindow.GetHashCode();
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