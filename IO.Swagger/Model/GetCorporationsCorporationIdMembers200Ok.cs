/* 
 * EVE Swagger Interface
 *
 * An OpenAPI for EVE Online
 *
 * OpenAPI spec version: 0.5.5
 * 
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
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// 200 ok object
    /// </summary>
    [DataContract]
    public partial class GetCorporationsCorporationIdMembers200Ok :  IEquatable<GetCorporationsCorporationIdMembers200Ok>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCorporationsCorporationIdMembers200Ok" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetCorporationsCorporationIdMembers200Ok() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCorporationsCorporationIdMembers200Ok" /> class.
        /// </summary>
        /// <param name="CharacterId">character_id integer (required).</param>
        public GetCorporationsCorporationIdMembers200Ok(int? CharacterId = default(int?))
        {
            // to ensure "CharacterId" is required (not null)
            if (CharacterId == null)
            {
                throw new InvalidDataException("CharacterId is a required property for GetCorporationsCorporationIdMembers200Ok and cannot be null");
            }
            else
            {
                this.CharacterId = CharacterId;
            }
        }
        
        /// <summary>
        /// character_id integer
        /// </summary>
        /// <value>character_id integer</value>
        [DataMember(Name="character_id", EmitDefaultValue=false)]
        public int? CharacterId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetCorporationsCorporationIdMembers200Ok {\n");
            sb.Append("  CharacterId: ").Append(CharacterId).Append("\n");
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
            return this.Equals(input as GetCorporationsCorporationIdMembers200Ok);
        }

        /// <summary>
        /// Returns true if GetCorporationsCorporationIdMembers200Ok instances are equal
        /// </summary>
        /// <param name="input">Instance of GetCorporationsCorporationIdMembers200Ok to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetCorporationsCorporationIdMembers200Ok input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CharacterId == input.CharacterId ||
                    (this.CharacterId != null &&
                    this.CharacterId.Equals(input.CharacterId))
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
                if (this.CharacterId != null)
                    hashCode = hashCode * 59 + this.CharacterId.GetHashCode();
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
