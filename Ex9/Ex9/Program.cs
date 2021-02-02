using System;
using System.Threading.Tasks;

namespace Ex9
{
    class Program
	{
		static async Task Main(string[] args)
		{
            const int episodeId = 1;

			var task = Service.GetStarWarsEpisodeIntroductionAsync(episodeId);

			Console.WriteLine("Waiting for film data ...");

			var film = await task;

			if (film == null)
			{
				Console.WriteLine($"Film with id {episodeId} not found!");
				return;
			}

			Console.WriteLine($"Found film with title: {film.Title}");
			Console.WriteLine($"Introduction: {film.Introduction}");
		}
	}
}
