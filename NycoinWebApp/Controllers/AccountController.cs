using NycoinWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace NycoinWebApp.Controllers
{
    public class AccountController : Controller
    {
        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }

        [AllowAnonymous]
        public ActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Login(string login, string password)
        {
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                return View();
            }
            else if(login == "a@a.com")
            {
                Session["Usuario"] = "a@a.com";
                return RedirectToAction("PlataformaBasica", "Dashboard");
            }
            else if (!string.IsNullOrEmpty(login.ToLower()) && !string.IsNullOrEmpty(password.ToLower()))
            {
                return RedirectToAction("ClienteValores", "Account");
            }
            return RedirectToAction("VerifyEmail", "Account");
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult SignUp(string email, string confirmEmail, string password, string confirmPassword)
        {
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(confirmEmail) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                return View();
            }
            return RedirectToAction("VerifyEmail", "Account");
        }

        public ActionResult VerifyEmail()
        {
            return View();
        }

        public ActionResult RegistrationForm()
        {
            return View();
        }

        public ActionResult ClienteValores()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ClienteValores(Cliente cliente)
        {
            //if (!string.IsNullOrEmpty(cliente.PesCPFCNPJ))
            //{
                return RedirectToAction("ClienteEndereco", "Account");
            //}
            //return View();
        }

        public ActionResult ClienteEndereco()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ClienteEndereco(Cliente cliente)
        {
            //if (!string.IsNullOrEmpty(cliente.CliEndereco))
            //{
                return RedirectToAction("ClienteTermoCompra", "Account");
            //}
            //return View();
        }

        public ActionResult ClienteTermoCompra()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ClienteTermoCompra(Cliente cliente)
        {
            //if (cliente.CliConfirmaTermoCompra)
            //{
                return RedirectToAction("PlataformaBasica", "Dashboard");
            //}
            //return View();
        }

        public ActionResult Logout()
        {
            Session.Abandon();
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}