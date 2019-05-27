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
    /// A complex element that allows  the sender to override some envelope email setting information. This can be used to override the Reply To email address and name associated with the envelope and to override the BCC email addresses to which an envelope is sent.   When the emailSettings information is used for an envelope, it only applies to that envelope.   **IMPORTANT**: The emailSettings information is not returned in the GET for envelope status. Use GET /email_settings to return information about the emailSettings.   EmailSettings consists of:   * replyEmailAddressOverride - The Reply To email used for the envelope. DocuSign will verify that a correct email format is used, but does not verify that the email is active. Maximum Length: 100 characters. * replyEmailNameOverride - The name associated with the Reply To email address. Maximum Length: 100 characters. * bccEmailAddresses - An array of up to five email addresses to which the envelope is sent to as a BCC email. Only users with canManageAccount setting set to true can use this option.  DocuSign verifies that the email format is correct, but does not verify that the email is active. Using this overrides the BCC for Email Archive information setting for this envelope. Maximum Length: 100 characters. *Example*: if your account has BCC for Email Archive set up for the email address ‘archive@mycompany.com’ and you send an envelope using the BCC Email Override to send a BCC email to ‘salesarchive@mycompany.com’, then a copy of the envelope is only sent to the ‘salesarchive@mycompany.com’ email address.
    /// </summary>
    [DataContract]
    public partial class EmailSettings :  IEquatable<EmailSettings>, IValidatableObject
    {
        public EmailSettings()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailSettings" /> class.
        /// </summary>
        /// <param name="BccEmailAddresses">A list of email addresses that receive a copy of all email communications for an envelope. You can use this for archiving purposes..</param>
        /// <param name="ReplyEmailAddressOverride">.</param>
        /// <param name="ReplyEmailNameOverride">.</param>
        public EmailSettings(List<BccEmailAddress> BccEmailAddresses = default(List<BccEmailAddress>), string ReplyEmailAddressOverride = default(string), string ReplyEmailNameOverride = default(string))
        {
            this.BccEmailAddresses = BccEmailAddresses;
            this.ReplyEmailAddressOverride = ReplyEmailAddressOverride;
            this.ReplyEmailNameOverride = ReplyEmailNameOverride;
        }
        
        /// <summary>
        /// A list of email addresses that receive a copy of all email communications for an envelope. You can use this for archiving purposes.
        /// </summary>
        /// <value>A list of email addresses that receive a copy of all email communications for an envelope. You can use this for archiving purposes.</value>
        [DataMember(Name="bccEmailAddresses", EmitDefaultValue=false)]
        public List<BccEmailAddress> BccEmailAddresses { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="replyEmailAddressOverride", EmitDefaultValue=false)]
        public string ReplyEmailAddressOverride { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="replyEmailNameOverride", EmitDefaultValue=false)]
        public string ReplyEmailNameOverride { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmailSettings {\n");
            sb.Append("  BccEmailAddresses: ").Append(BccEmailAddresses).Append("\n");
            sb.Append("  ReplyEmailAddressOverride: ").Append(ReplyEmailAddressOverride).Append("\n");
            sb.Append("  ReplyEmailNameOverride: ").Append(ReplyEmailNameOverride).Append("\n");
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
            return this.Equals(obj as EmailSettings);
        }

        /// <summary>
        /// Returns true if EmailSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of EmailSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmailSettings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.BccEmailAddresses == other.BccEmailAddresses ||
                    this.BccEmailAddresses != null &&
                    this.BccEmailAddresses.SequenceEqual(other.BccEmailAddresses)
                ) && 
                (
                    this.ReplyEmailAddressOverride == other.ReplyEmailAddressOverride ||
                    this.ReplyEmailAddressOverride != null &&
                    this.ReplyEmailAddressOverride.Equals(other.ReplyEmailAddressOverride)
                ) && 
                (
                    this.ReplyEmailNameOverride == other.ReplyEmailNameOverride ||
                    this.ReplyEmailNameOverride != null &&
                    this.ReplyEmailNameOverride.Equals(other.ReplyEmailNameOverride)
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
                if (this.BccEmailAddresses != null)
                    hash = hash * 59 + this.BccEmailAddresses.GetHashCode();
                if (this.ReplyEmailAddressOverride != null)
                    hash = hash * 59 + this.ReplyEmailAddressOverride.GetHashCode();
                if (this.ReplyEmailNameOverride != null)
                    hash = hash * 59 + this.ReplyEmailNameOverride.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
