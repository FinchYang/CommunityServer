/* 
 * DocuSign REST API
 *
 * The DocuSign REST API provides you with a powerful, convenient, and simple Web services API for interacting with DocuSign.
 *
 * OpenAPI spec version: v2
 * Contact: devcenter@docusign.com
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

namespace DocuSign.eSign.Model
{
    /// <summary>
    /// PowerFormsFormDataResponse
    /// </summary>
    [DataContract]
    public partial class PowerFormsFormDataResponse :  IEquatable<PowerFormsFormDataResponse>, IValidatableObject
    {
        public PowerFormsFormDataResponse()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PowerFormsFormDataResponse" /> class.
        /// </summary>
        /// <param name="Envelopes">.</param>
        public PowerFormsFormDataResponse(List<PowerFormFormDataEnvelope> Envelopes = default(List<PowerFormFormDataEnvelope>))
        {
            this.Envelopes = Envelopes;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="envelopes", EmitDefaultValue=false)]
        public List<PowerFormFormDataEnvelope> Envelopes { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PowerFormsFormDataResponse {\n");
            sb.Append("  Envelopes: ").Append(Envelopes).Append("\n");
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
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as PowerFormsFormDataResponse);
        }

        /// <summary>
        /// Returns true if PowerFormsFormDataResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of PowerFormsFormDataResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PowerFormsFormDataResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Envelopes == other.Envelopes ||
                    this.Envelopes != null &&
                    this.Envelopes.SequenceEqual(other.Envelopes)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Envelopes != null)
                    hash = hash * 59 + this.Envelopes.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
