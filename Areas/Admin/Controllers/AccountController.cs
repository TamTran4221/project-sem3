using eproject_sem3.Areas.Admin.Models;
using eproject_sem3.Data;
using eproject_sem3.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NuGet.Protocol.Plugins;
using System.Security.Principal;

namespace eproject_sem3.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class AccountController : Controller
	{
		private readonly ApplicationDbContext _context;

		public AccountController(ApplicationDbContext context)
		{
			_context = context;
		}
		public IActionResult Login()
		{
			return View();
		}

		public IActionResult Logout()
		{
			HttpContext.Session.Remove("AdminLogin");
			return RedirectToAction("Login");
		}


		[HttpPost] // POST khi submit form
		public IActionResult Login(Login model)
		{
			if (ModelState.IsValid)
			{
				User acc = _context.Users.FirstOrDefault(a => a.Email.Equals(model.Email) && a.Password.Equals(model.Password));

				if (acc != null)
				{
					HttpContext.Session.SetString("AdminLogin", JsonConvert.SerializeObject(acc));
					return RedirectToAction("Index", "Dashboard");
				}
				else
				{
					ModelState.AddModelError("Email", "Tài khoản hoặc mật khẩu không chính xác");
				}
			}
			return View(model);
		}

	}
}

