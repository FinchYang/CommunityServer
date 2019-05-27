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
    /// Provides properties that describe user authorization to a workspace.
    /// </summary>
    [DataContract]
    public partial class WorkspaceUserAuthorization :  IEquatable<WorkspaceUserAuthorization>, IValidatableObject
    {
        public WorkspaceUserAuthorization()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceUserAuthorization" /> class.
        /// </summary>
        /// <param name="CanDelete">.</param>
        /// <param name="CanMove">.</param>
        /// <param name="CanTransact">.</param>
        /// <param name="CanView">.</param>
        /// <param name="Created">The UTC DateTime when the workspace user authorization was created..</param>
        /// <param name="CreatedById">.</param>
        /// <param name="ErrorDetails">ErrorDetails.</param>
        /// <param name="Modified">.</param>
        /// <param name="ModifiedById">.</param>
        /// <param name="WorkspaceUserId">.</param>
        /// <param name="WorkspaceUserInformation">WorkspaceUserInformation.</param>
        public WorkspaceUserAuthorization(string CanDelete = default(string), string CanMove = default(string), string CanTransact = default(string), string CanView = default(string), string Created = default(string), string CreatedById = default(string), ErrorDetails ErrorDetails = default(ErrorDetails), string Modified = default(string), string ModifiedById = default(string), string WorkspaceUserId = default(string), WorkspaceUser WorkspaceUserInformation = default(WorkspaceUser))
        {
            this.CanDelete = CanDelete;
            this.CanMove = CanMove;
            this.CanTransact = CanTransact;
            this.CanView = CanView;
            this.Created = Created;
            this.CreatedById = CreatedById;
            this.ErrorDetails = ErrorDetails;
            this.Modified = Modified;
            this.ModifiedById = ModifiedById;
            this.WorkspaceUserId = WorkspaceUserId;
            this.WorkspaceUserInformation = WorkspaceUserInformation;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="canDelete", EmitDefaultValue=false)]
        public string CanDelete { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="canMove", EmitDefaultValue=false)]
        public string CanMove { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="canTransact", EmitDefaultValue=false)]
        public string CanTransact { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="canView", EmitDefaultValue=false)]
        public string CanView { get; set; }
        /// <summary>
        /// The UTC DateTime when the workspace user authorization was created.
        /// </summary>
        /// <value>The UTC DateTime when the workspace user authorization was created.</value>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public string Created { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="createdById", EmitDefaultValue=false)]
        public string CreatedById { get; set; }
        /// <summary>
        /// Gets or Sets ErrorDetails
        /// </summary>
        [DataMember(Name="errorDetails", EmitDefaultValue=false)]
        public ErrorDetails ErrorDetails { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="modified", EmitDefaultValue=false)]
        public string Modified { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="modifiedById", EmitDefaultValue=false)]
        public string ModifiedById { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="workspaceUserId", EmitDefaultValue=false)]
        public string WorkspaceUserId { get; set; }
        /// <summary>
        /// Gets or Sets WorkspaceUserInformation
        /// </summary>
        [DataMember(Name="workspaceUserInformation", EmitDefaultValue=false)]
        public WorkspaceUser WorkspaceUserInformation { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkspaceUserAuthorization {\n");
            sb.Append("  CanDelete: ").Append(CanDelete).Append("\n");
            sb.Append("  CanMove: ").Append(CanMove).Append("\n");
            sb.Append("  CanTransact: ").Append(CanTransact).Append("\n");
            sb.Append("  CanView: ").Append(CanView).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  CreatedById: ").Append(CreatedById).Append("\n");
            sb.Append("  ErrorDetails: ").Append(ErrorDetails).Append("\n");
            sb.Append("  Modified: ").Append(Modified).Append("\n");
            sb.Append("  ModifiedById: ").Append(ModifiedById).Append("\n");
            sb.Append("  WorkspaceUserId: ").Append(WorkspaceUserId).Append("\n");
            sb.Append("  WorkspaceUserInformation: ").Append(WorkspaceUserInformation).Append("\n");
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
            return this.Equals(obj as WorkspaceUserAuthorization);
        }

        /// <summary>
        /// Returns true if WorkspaceUserAuthorization instances are equal
        /// </summary>
        /// <param name="other">Instance of WorkspaceUserAuthorization to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkspaceUserAuthorization other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CanDelete == other.CanDelete ||
                    this.CanDelete != null &&
                    this.CanDelete.Equals(other.CanDelete)
                ) && 
                (
                    this.CanMove == other.CanMove ||
                    this.CanMove != null &&
                    this.CanMove.Equals(other.CanMove)
                ) && 
                (
                    this.CanTransact == other.CanTransact ||
                    this.CanTransact != null &&
                    this.CanTransact.Equals(other.CanTransact)
                ) && 
                (
                    this.CanView == other.CanView ||
                    this.CanView != null &&
                    this.CanView.Equals(other.CanView)
                ) && 
                (
                    this.Created == other.Created ||
                    this.Created != null &&
                    this.Created.Equals(other.Created)
                ) && 
                (
                    this.CreatedById == other.CreatedById ||
                    this.CreatedById != null &&
                    this.CreatedById.Equals(other.CreatedById)
                ) && 
                (
                    this.ErrorDetails == other.ErrorDetails ||
                    this.ErrorDetails != null &&
                    this.ErrorDetails.Equals(other.ErrorDetails)
                ) && 
                (
                    this.Modified == other.Modified ||
                    this.Modified != null &&
                    this.Modified.Equals(other.Modified)
                ) && 
                (
                    this.ModifiedById == other.ModifiedById ||
                    this.ModifiedById != null &&
                    this.ModifiedById.Equals(other.ModifiedById)
                ) && 
                (
                    this.WorkspaceUserId == other.WorkspaceUserId ||
                    this.WorkspaceUserId != null &&
                    this.WorkspaceUserId.Equals(other.WorkspaceUserId)
                ) && 
                (
                    this.WorkspaceUserInformation == other.WorkspaceUserInformation ||
                    this.WorkspaceUserInformation != null &&
                    this.WorkspaceUserInformation.Equals(other.WorkspaceUserInformation)
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
                if (this.CanDelete != null)
                    hash = hash * 59 + this.CanDelete.GetHashCode();
                if (this.CanMove != null)
                    hash = hash * 59 + this.CanMove.GetHashCode();
                if (this.CanTransact != null)
                    hash = hash * 59 + this.CanTransact.GetHashCode();
                if (this.CanView != null)
                    hash = hash * 59 + this.CanView.GetHashCode();
                if (this.Created != null)
                    hash = hash * 59 + this.Created.GetHashCode();
                if (this.CreatedById != null)
                    hash = hash * 59 + this.CreatedById.GetHashCode();
                if (this.ErrorDetails != null)
                    hash = hash * 59 + this.ErrorDetails.GetHashCode();
                if (this.Modified != null)
                    hash = hash * 59 + this.Modified.GetHashCode();
                if (this.ModifiedById != null)
                    hash = hash * 59 + this.ModifiedById.GetHashCode();
                if (this.WorkspaceUserId != null)
                    hash = hash * 59 + this.WorkspaceUserId.GetHashCode();
                if (this.WorkspaceUserInformation != null)
                    hash = hash * 59 + this.WorkspaceUserInformation.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
