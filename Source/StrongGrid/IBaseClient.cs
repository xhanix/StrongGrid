using StrongGrid.Resources;

namespace StrongGrid
{
	/// <summary>
	/// Interface for the base SendGrid REST client.
	/// </summary>
	public interface IBaseClient
	{
		/// <summary>
		/// Gets the Access Management resource which allows you to control IP whitelisting.
		/// </summary>
		/// <value>
		/// The access management.
		/// </value>
		IAccessManagement AccessManagement { get; }

		/// <summary>
		/// Gets the Alerts resource which allows you to receive notifications regarding your email usage or statistics.
		/// </summary>
		/// <value>
		/// The alerts.
		/// </value>
		IAlerts Alerts { get; }

		/// <summary>
		/// Gets the API Keys resource which allows you to manage your API Keys.
		/// </summary>
		/// <value>
		/// The API keys.
		/// </value>
		IApiKeys ApiKeys { get; }

		/// <summary>
		/// Gets the Batches resource.
		/// </summary>
		/// <value>
		/// The batches.
		/// </value>
		IBatches Batches { get; }

		/// <summary>
		/// Gets the Blocks resource which allows you to manage blacked email addresses.
		/// </summary>
		/// <value>
		/// The blocks.
		/// </value>
		IBlocks Blocks { get; }

		/// <summary>
		/// Gets the Bounces resource which allows you to manage bounces.
		/// </summary>
		/// <value>
		/// The bounces.
		/// </value>
		IBounces Bounces { get; }

		/// <summary>
		/// Gets the Designs resource which allows you to manage designs.
		/// </summary>
		IDesigns Designs { get; }

		/// <summary>
		/// Gets the EmailActivities resource which allows you to search and download a CSV of your recent email event activity.
		/// </summary>
		/// <value>
		/// The email activities.
		/// </value>
		IEmailActivities EmailActivities { get; }

		/// <summary>
		/// Gets the validation resource.
		/// </summary>
		/// <value>The email validation.</value>
		IEmailValidation EmailValidation { get; }

		/// <summary>
		/// Gets the GlobalSuppressions resource.
		/// </summary>
		/// <value>
		/// The global suppressions.
		/// </value>
		IGlobalSuppressions GlobalSuppressions { get; }

		/// <summary>
		/// Gets the InvalidEmails resource.
		/// </summary>
		/// <value>
		/// The invalid emails.
		/// </value>
		IInvalidEmails InvalidEmails { get; }

		/// <summary>
		/// Gets the IpAddresses resource.
		/// </summary>
		/// <value>
		/// The IP addresses.
		/// </value>
		IIpAddresses IpAddresses { get; }

		/// <summary>
		/// Gets the IpPools resource.
		/// </summary>
		/// <value>
		/// The IP pools.
		/// </value>
		IIpPools IpPools { get; }

		/// <summary>
		/// Gets the Mail resource.
		/// </summary>
		/// <value>
		/// The mail.
		/// </value>
		IMail Mail { get; }

		/// <summary>
		/// Gets the SenderAuthentication resource.
		/// </summary>
		/// <value>
		/// The <see cref="ISenderAuthentication"/>.
		/// </value>
		ISenderAuthentication SenderAuthentication { get; }

		/// <summary>
		/// Gets the Settings resource.
		/// </summary>
		/// <value>
		/// The settings.
		/// </value>
		ISettings Settings { get; }

		/// <summary>
		/// Gets the SpamReports resource.
		/// </summary>
		/// <value>
		/// The spam reports.
		/// </value>
		ISpamReports SpamReports { get; }

		/// <summary>
		/// Gets the Statistics resource.
		/// </summary>
		/// <value>
		/// The statistics.
		/// </value>
		IStatistics Statistics { get; }

		/// <summary>
		/// Gets the Subusers resource which allows you to manage subusers.
		/// </summary>
		/// <value>
		/// The subusers.
		/// </value>
		ISubusers Subusers { get; }

		/// <summary>
		/// Gets the Suppressions resource.
		/// </summary>
		/// <value>
		/// The suppressions.
		/// </value>
		ISuppressions Suppressions { get; }

		/// <summary>
		/// Gets the Teammates resource.
		/// </summary>
		/// <value>
		/// The Teammates.
		/// </value>
		ITeammates Teammates { get; }

		/// <summary>
		/// Gets the Templates resource.
		/// </summary>
		/// <value>
		/// The templates.
		/// </value>
		ITemplates Templates { get; }

		/// <summary>
		/// Gets the UnsubscribeGroups resource.
		/// </summary>
		/// <value>
		/// The unsubscribe groups.
		/// </value>
		IUnsubscribeGroups UnsubscribeGroups { get; }

		/// <summary>
		/// Gets the User resource.
		/// </summary>
		/// <value>
		/// The user.
		/// </value>
		IUser User { get; }

		/// <summary>
		/// Gets the WebhookSettings resource.
		/// </summary>
		/// <value>
		/// The webhook settings.
		/// </value>
		IWebhookSettings WebhookSettings { get; }

		/// <summary>
		/// Gets the WebhookStats resource.
		/// </summary>
		/// <value>
		/// The webhook stats.
		/// </value>
		IWebhookStats WebhookStats { get; }
	}
}
