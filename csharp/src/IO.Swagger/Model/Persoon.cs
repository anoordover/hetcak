/* 
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 1.0.0
 * Contact: anoordover@hetcak.nl
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
    /// Persoon
    /// </summary>
    [DataContract]
    public partial class Persoon :  IEquatable<Persoon>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Persoon" /> class.
        /// </summary>
        /// <param name="PersoonId">PersoonId.</param>
        /// <param name="DatumOpdracht">DatumOpdracht.</param>
        /// <param name="Relaties">Relaties.</param>
        public Persoon(int? PersoonId = default(int?), DateTime? DatumOpdracht = default(DateTime?), Relaties Relaties = default(Relaties))
        {
            this.PersoonId = PersoonId;
            this.DatumOpdracht = DatumOpdracht;
            this.Relaties = Relaties;
        }
        
        /// <summary>
        /// Gets or Sets PersoonId
        /// </summary>
        [DataMember(Name="PersoonId", EmitDefaultValue=false)]
        public int? PersoonId { get; set; }

        /// <summary>
        /// Gets or Sets DatumOpdracht
        /// </summary>
        [DataMember(Name="DatumOpdracht", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? DatumOpdracht { get; set; }

        /// <summary>
        /// Gets or Sets Relaties
        /// </summary>
        [DataMember(Name="Relaties", EmitDefaultValue=false)]
        public Relaties Relaties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Persoon {\n");
            sb.Append("  PersoonId: ").Append(PersoonId).Append("\n");
            sb.Append("  DatumOpdracht: ").Append(DatumOpdracht).Append("\n");
            sb.Append("  Relaties: ").Append(Relaties).Append("\n");
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
            return this.Equals(input as Persoon);
        }

        /// <summary>
        /// Returns true if Persoon instances are equal
        /// </summary>
        /// <param name="input">Instance of Persoon to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Persoon input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PersoonId == input.PersoonId ||
                    (this.PersoonId != null &&
                    this.PersoonId.Equals(input.PersoonId))
                ) && 
                (
                    this.DatumOpdracht == input.DatumOpdracht ||
                    (this.DatumOpdracht != null &&
                    this.DatumOpdracht.Equals(input.DatumOpdracht))
                ) && 
                (
                    this.Relaties == input.Relaties ||
                    (this.Relaties != null &&
                    this.Relaties.Equals(input.Relaties))
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
                if (this.PersoonId != null)
                    hashCode = hashCode * 59 + this.PersoonId.GetHashCode();
                if (this.DatumOpdracht != null)
                    hashCode = hashCode * 59 + this.DatumOpdracht.GetHashCode();
                if (this.Relaties != null)
                    hashCode = hashCode * 59 + this.Relaties.GetHashCode();
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
