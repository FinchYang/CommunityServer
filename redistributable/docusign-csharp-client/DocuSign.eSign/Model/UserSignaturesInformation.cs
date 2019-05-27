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
    /// UserSignaturesInformation
    /// </summary>
    [DataContract]
    public partial class UserSignaturesInformation :  IEquatable<UserSignaturesInformation>, IValidatableObject
    {
        public UserSignaturesInformation()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserSignaturesInformation" /> class.
        /// </summary>
        /// <param name="UserSignatures">.</param>
        public UserSignaturesInformation(List<UserSignature> UserSignatures = default(List<UserSignature>))
        {
            this.UserSignatures = UserSignatures;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="userSignatures", EmitDefaultValue=false)]
        public List<UserSignature> UserSignatures { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserSignaturesInformation {\n");
            sb.Append("  UserSignatures: ").Append(UserSignatures).Append("\n");
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
            return this.Equals(obj as UserSignaturesInformation);
        }

        /// <summary>
        /// Returns true if UserSignaturesInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of UserSignaturesInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserSignaturesInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.UserSignatures == other.UserSignatures ||
                    this.UserSignatures != null &&
                    this.UserSignatures.SequenceEqual(other.UserSignatures)
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
                if (this.UserSignatures != null)
                    hash = hash * 59 + this.UserSignatures.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
