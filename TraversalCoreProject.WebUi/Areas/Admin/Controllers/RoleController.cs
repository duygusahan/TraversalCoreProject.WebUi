using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TraversalCoreProject.EntityLayer.Concrete;
using TraversalCoreProject.WebUi.Areas.Admin.Models;

namespace TraversalCoreProject.WebUi.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]/{id?}")]
    public class RoleController : Controller
    {
        private readonly RoleManager<AppRole> _roleManager;
        private readonly UserManager<AppUser> _userManager;

        public RoleController(RoleManager<AppRole> roleManager, UserManager<AppUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var values=_roleManager.Roles.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateRole()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateRole(CreateRoleViewModel createRoleViewModel)
        {
            AppRole role=new AppRole()
            {
                Name=createRoleViewModel.RoleName
            };
            var result = await _roleManager.CreateAsync(role);
            if (result.Succeeded) 
            {
                return RedirectToAction("Index", "Role", new { area = "Admin" });
            }
            else
            {
                return View();
            }
            
        }
        public async Task<IActionResult> DeleteRole(int id)
        {
            var values=_roleManager.Roles.FirstOrDefault(x=>x.Id == id);
            await _roleManager.DeleteAsync(values);
            return RedirectToAction("Index", "Role", new {area="Admin"} );
        }

        [HttpGet]
        public IActionResult UpdateRole(int id)
        {
            var values=_roleManager.Roles.FirstOrDefault(x=>x.Id == id);
            UpdateRoleViewModel updateRoleViewModel = new UpdateRoleViewModel
            {
                RoleId = values.Id,
                RoleName = values.Name
            };
            return View(updateRoleViewModel);
        }
        [HttpPost]
        public async Task< IActionResult> UpdateRole(UpdateRoleViewModel updateRoleViewModel)
        {
            var value=_roleManager.Roles.FirstOrDefault(x=>x.Id ==updateRoleViewModel.RoleId);  
            value.Name=updateRoleViewModel.RoleName;
            await _roleManager.UpdateAsync(value);
            return RedirectToAction("Index", "Role", new { area = "Admin" });
        }
        public IActionResult UserList()
        {
            var values = _userManager.Users.ToList();
            return View(values);
        }
        [HttpGet]
        public async Task<IActionResult> AssignRole(int id)
        {
            var users = _userManager.Users.FirstOrDefault(x => x.Id == id);
            TempData["UserId"]=users.Id;
            var roles = _roleManager.Roles.ToList();
            var userRoles = await _userManager.GetRolesAsync(users);
            List<RoleAssingViewModel> roleAssingViewModels = new List<RoleAssingViewModel>();
            foreach (var item in roles)
            {
                RoleAssingViewModel model=new RoleAssingViewModel();
                model.RoleId=item.Id;
                model.RoleName=item.Name;
                model.RoleExist = userRoles.Contains(item.Name);
                roleAssingViewModels.Add(model);
            }
            return View(roleAssingViewModels);
        }
        [HttpPost]
        public async Task<IActionResult> AssignRole(List<RoleAssingViewModel> model)
        {
            var userId = (int)TempData["userId"];
            var user = _userManager.Users.FirstOrDefault(x => x.Id == userId);
            foreach (var item in model) 
            {
                if (item.RoleExist)
                {
                    await _userManager.AddToRoleAsync(user, item.RoleName);
                }
                else
                {
                    await _userManager.RemoveFromRoleAsync(user, item.RoleName);
                }
            }
            return RedirectToAction("UserList" , "Role" , new {area="Admin"});
        }
    }


}
