using circles.NET.V1;
using circles.NET.V1.Enums;
using circles.NET.V1.Models;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace circles.NET.SampleApplication
{
    class Program
    {
        //This sample program will dump the provided user's top 50 scores
        static async Task Main(string[] args)
        {
            if (args.Length < 1)
            {
                Console.WriteLine("Usage: dotnet circles.NET.SampleApplication.dll <username> <gamemode id>");
                Environment.Exit(1);
            }

            try
            {
                var apiKey = File.Exists("API_KEY.txt") ? File.ReadAllText("API_KEY.txt") : throw new FileNotFoundException($"API_KEY.txt file containing the API Key wasn't found.");
                var apiClient = new CirclesAPIClient(apiKey);

                var gameMode = args.Length >= 2 ? (Gamemode)int.Parse(args[1]) : Gamemode.Standard;
                var bests = await apiClient.GetUserBestAsync(args[0], gameMode, 50);

                //basic average pp per play calc
                float averagePP = bests.Average(play => play.Pp);

                await Task.WhenAll(bests.Select(x => ShowUserBest(x, apiClient, args[0])));

                await Console.Out.WriteLineAsync($"Average pp per play: {averagePP}");
            }
            catch (Exception e)
            {
                if (e is FileNotFoundException)
                {
                    using (File.Create("API_KEY.txt"))
                    {
                        Console.WriteLine($"The API_KEY.txt file containing the API Key wasn't found and so have been created");
                        Console.WriteLine($"Please paste in the file your osu! api key.");
                        Environment.Exit(1);
                    }
                }

                throw;
            }
        }

        static async Task ShowUserBest(APIUserBest score, CirclesAPIClient apiClient, string player)
        {
            var mapinfo = await apiClient.GetBeatmapsByIdAsync(score.BeatmapId);
            var map = mapinfo[0];
            await Console.Out.WriteLineAsync($"{player} achieved rank {score.Rank} on {map.Artist} - {map.Title} [{map.Difficulty}] ({map.StarRating}*) --> {score.Pp} pp");
        }
    }
}
