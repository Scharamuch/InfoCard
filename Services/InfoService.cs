using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using InfoCard.Models;

namespace InfoCard.Models.Services
{
	public class InfoService
	{
		private readonly string _filePath = "Data/Info.json";

		public async Task<Info> GetInfoAsync ()
		{
			using (var stream = new FileStream(_filePath, FileMode.Open, FileAccess.Read))
			{
				return await JsonSerializer.DeserializeAsync<Info>(stream);
			}
		}
	}
}
