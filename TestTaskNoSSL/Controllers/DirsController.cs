using Microsoft.AspNetCore.Mvc;
using TestTaskNoSSL.Data;

namespace TestTask_aspnet_mvc.Controllers
{
	public class DirsController : Controller
	{
		private readonly AppDbContext _context;

		public DirsController(AppDbContext context)
		{
			_context = context;
		}

		public async Task<IActionResult> Index(int id = 1)
		{
			var instances = _context.Dirs.Where(d => d.ParentDirId == id);
			var currentDir = _context.Dirs.FirstOrDefault(i => i.Id == id);
			var currentDirName = currentDir.DirName;
			ViewBag.currentDirName = currentDirName;
			var parentId = (currentDir?.ParentDirId ?? null);
			ViewBag.parentId = parentId;
			return View(instances);
		}
	}
}
