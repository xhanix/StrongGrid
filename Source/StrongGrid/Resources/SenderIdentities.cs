using Newtonsoft.Json.Linq;
using Pathoschild.Http.Client;
using StrongGrid.Models;
using StrongGrid.Utilities;
using System.Threading;
using System.Threading.Tasks;

namespace StrongGrid.Resources
{
	/// <summary>
	/// Allows you to create and manage sender identities for Marketing Campaigns.
	/// </summary>
	/// <seealso cref="StrongGrid.Resources.Legacy.ISenderIdentities" />
	/// <remarks>
	/// See <a href="https://sendgrid.api-docs.io/v3.0/senders">SendGrid documentation</a> for more information.
	/// </remarks>
	public class SenderIdentities : ISenderIdentities
	{
		private const string _endpoint = "marketing/senders";
		private readonly Pathoschild.Http.Client.IClient _client;

		/// <summary>
		/// Initializes a new instance of the <see cref="SenderIdentities" /> class.
		/// </summary>
		/// <param name="client">The HTTP client.</param>
		internal SenderIdentities(Pathoschild.Http.Client.IClient client)
		{
			_client = client;
		}

		/// <summary>
		/// Create a sender identity.
		/// </summary>
		/// <param name="nickname">The nickname.</param>
		/// <param name="from">From.</param>
		/// <param name="replyTo">The reply to.</param>
		/// <param name="address1">The address1.</param>
		/// <param name="address2">The address2.</param>
		/// <param name="city">The city.</param>
		/// <param name="state">The state.</param>
		/// <param name="zip">The zip.</param>
		/// <param name="country">The country.</param>
		/// <param name="onBehalfOf">The user to impersonate.</param>
		/// <param name="cancellationToken">The cancellation token.</param>
		/// <returns>
		/// The <see cref="SenderIdentity" />.
		/// </returns>
		public Task<SenderIdentity> CreateAsync(string nickname, MailAddress from, MailAddress replyTo, string address1, string address2, string city, string state, string zip, string country, string onBehalfOf = null, CancellationToken cancellationToken = default)
		{
			var data = CreateJObject(nickname, from, replyTo, address1, address2, city, state, zip, country);

			return _client
				.PostAsync(_endpoint)
				.OnBehalfOf(onBehalfOf)
				.WithJsonBody(data)
				.WithCancellationToken(cancellationToken)
				.AsSendGridObject<SenderIdentity>();
		}

		private static JObject CreateJObject(
			Parameter<string> nickname,
			Parameter<MailAddress> from,
			Parameter<MailAddress> replyTo,
			Parameter<string> address1,
			Parameter<string> address2,
			Parameter<string> city,
			Parameter<string> state,
			Parameter<string> zip,
			Parameter<string> country)
		{
			var result = new JObject();
			result.AddPropertyIfValue("nickname", nickname);
			result.AddPropertyIfValue("from", from);
			result.AddPropertyIfValue("reply_to", from);
			result.AddPropertyIfValue("address", address1);
			result.AddPropertyIfValue("address2", address2);
			result.AddPropertyIfValue("city", city);
			result.AddPropertyIfValue("state", state);
			result.AddPropertyIfValue("zip", zip);
			result.AddPropertyIfValue("country", country);
			return result;
		}
	}
}
