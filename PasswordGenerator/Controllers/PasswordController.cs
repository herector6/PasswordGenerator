using Microsoft.AspNetCore.Mvc;
using PasswordGenerator.Models;

namespace PasswordGenerator.Controllers
{
    public class PasswordController : Controller
    {
        public IActionResult Index()
        {
            PasswordViewModel model = new PasswordViewModel();

            return View(model);
        }
        public IActionResult Generate(PasswordViewModel model)
        {
            Random random = new Random();
            string UpperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string Numbers = "1234567890";
            string SpecialCharacters = "!@#$%^&*()_+";
            string Default = "abcdefghijklmnopqrstuvwxyz";

            string Result = "";
            string CurrentPassword = "";

            if (model.UpperCase && model.Numbers && model.SpecialCharacters)
            {
                CurrentPassword = Default + SpecialCharacters + Numbers + UpperCase;
            }
            else if (model.UpperCase)
            {
                CurrentPassword = Default + UpperCase;
            }
            else if (model.Numbers)
            {
                CurrentPassword = Default + Numbers;
            }
            else if (model.SpecialCharacters)
            {
                CurrentPassword = Default + SpecialCharacters;
            }
            else
            {
                CurrentPassword= Default;
            }

            for (int i = 0; i < model.PasswordLength; i++)
            {
                int value = random.Next(0, CurrentPassword.Length);
                char valueCharacter = CurrentPassword[value];
                Result += valueCharacter;
            }
            model.PasswordResult = Result;

            return View("Index", model);
        }


    }
}
