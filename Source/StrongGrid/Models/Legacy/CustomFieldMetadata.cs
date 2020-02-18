using Newtonsoft.Json;

namespace StrongGrid.Models.Legacy
{
	/// <summary>
	/// Metadata about a custom field.
	/// </summary>
	/// <seealso cref="StrongGrid.Models.Legacy.FieldMetadata" />
	public class CustomFieldMetadata : FieldMetadata
	{
		/// <summary>
		/// Gets or sets the identifier.
		/// </summary>
		/// <value>
		/// The identifier.
		/// </value>
		[JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
		public long Id { get; set; }
	}
}
