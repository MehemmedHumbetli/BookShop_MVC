using Microsoft.AspNetCore.Mvc;
using MiniBookShop.Application.Abstract;
using MiniBookShop.Domain.Entities;

namespace MiniBookShop.Controllers
{
    public class UserController(IUserService userService) : Controller
    {
        private readonly IUserService _userService = userService;

        public IActionResult Index()
        {
            var users = _userService.GetAll();
            return View(users);
        }

        [HttpGet]
        public IActionResult Add()
        {
            var model = new UserViewModel();
            model.User = new User();
            return View(model);
        }

        [HttpPost]
        public IActionResult Add(UserViewModel model)
        {
            _userService.Add(model.User);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete()
        {
            var model = new UserViewModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            _userService.Delete(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var user = _userService.GetById(id);
            if (user == null)
            {
                return NotFound();
            }

            var model = new UserViewModel
            {
                User = user
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult Update(UserViewModel model)
        {
            var userInDb = _userService.GetById(model.User.Id);
            if (userInDb == null)
            {
                return NotFound(); 
            }

            userInDb.Name = model.User.Name;
            userInDb.Surname = model.User.Surname;
            userInDb.Age = model.User.Age;
            userInDb.Gmail = model.User.Gmail;
            userInDb.ProfilePicturePath = model.User.ProfilePicturePath;

            _userService.Update(userInDb);
            return RedirectToAction("Index");
        }

    }
}
