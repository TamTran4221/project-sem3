using eproject_sem3.Data;
using eproject_sem3.Models;
using Microsoft.AspNetCore.Mvc;

namespace eproject_sem3.Areas.Admin.Controllers;

[Area("Admin")]
public class UserController : Controller
{
    private readonly ApplicationDbContext _dbContext;

    public UserController(ApplicationDbContext context)
    {
        _dbContext = context;
    }
    public IActionResult Index()
    {
        List<User> users = _dbContext.Users.ToList();
        return View(users);
    }
    
}