using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using InfoCard.Models;
using System.Threading.Tasks;
using InfoCard.Models.Services;

namespace QuestionnaireApp.Pages
{
	public class IndexModel : PageModel
	{
		private readonly ILogger<IndexModel> _logger;
		private readonly InfoService _service;
		public Info Info
		{
			get; private set;
		}

		public IndexModel (ILogger<IndexModel> logger, InfoService service)
		{
			_logger = logger;
			_service = service;
		}

		public async Task OnGetAsync ()
		{
			Info = await _service.GetInfoAsync();
		}
	}
}