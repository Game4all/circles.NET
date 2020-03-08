//
// This SampleApplication demonstrates how to use circles.NET to fetch the top 50 scores of the specified user using the APIv2 client.
//

using System;
using System.Linq;
using System.Threading.Tasks;

namespace circles.NET.V2.SampleApplication
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var apiClient = new CirclesAPIV2Client("kdsoksodos");
            var idx = await apiClient.GetChangelogIndex();

            var ch = idx.Streams.Where(t => t.Name == "lazer").First();

            var chData = await apiClient.GetChangelogBuildForVersion(ch, "2019.508.0");
            Console.WriteLine(chData.CreatedAt);
        }
    }
}
