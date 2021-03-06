using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace StrongGrid.IntegrationTests.Tests
{
	public class Categories : IIntegrationTest
	{
		public async Task RunAsync(IClient client, TextWriter log, CancellationToken cancellationToken)
		{
			await log.WriteLineAsync("\n***** CATEGORIES *****\n").ConfigureAwait(false);

			var categories = await client.Categories.GetAsync(null, 50, 0, null, cancellationToken).ConfigureAwait(false);
			await log.WriteLineAsync($"Number of categories: {categories.Length}").ConfigureAwait(false);
			await log.WriteLineAsync($"Categories: {string.Join(", ", categories)}").ConfigureAwait(false);
		}
	}
}
