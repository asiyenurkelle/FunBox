using BitirmeProjesi.Entities.Concrete;
using BitirmeProjesi.Entities.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web;

namespace BitirmeProjesi.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserController : Controller
    {
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;

        public UserController(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View("UserLogin");
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            return View("UserSignUp");
        }

        [HttpPost]
        public async Task<IActionResult> SignUp(UserSignUpDto userSignUpDto)
        {
            if (ModelState.IsValid)
            {
                User user = new User
                {
                    UserName = userSignUpDto.UserName,
                    Email = userSignUpDto.Email,
                    PhoneNumber = userSignUpDto.PhoneNumber

                };
                var result = await _userManager.CreateAsync(user, userSignUpDto.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Lütfen tüm alanları doldurun.");
                    return View("UserSignUp");
                }
            }
            else
            {
                return View("UserSignUp");
            }
        }




        [HttpPost]
        public async Task<IActionResult> Login(UserLoginDto userLoginDto)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(userLoginDto.Email);
                if (user != null)
                {
                    var result = await _signInManager.PasswordSignInAsync(user, userLoginDto.Password, userLoginDto.RememberMe, false);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        ModelState.AddModelError("", "E-posta adresiniz veya şifreniz yanlıştır.");
                        return View("UserLogin");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "E-posta adresiniz veya şifreniz yanlıştır.");
                    return View("UserLogin");
                }
            }
            else
            {
                return View("UserLogin");
            }


        }
        [Authorize]
        [HttpGet]
        public ViewResult PasswordChange()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> PasswordChange(UserPasswordChangeDto userPasswordChangeDto)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.GetUserAsync(HttpContext.User);
                var isVerified = await _userManager.CheckPasswordAsync(user, userPasswordChangeDto.CurrentPassword);
                if (isVerified)
                {
                    var result = await _userManager.ChangePasswordAsync(user, userPasswordChangeDto.CurrentPassword, userPasswordChangeDto.NewPassword);
                    if (result.Succeeded)
                    {
                        await _userManager.UpdateSecurityStampAsync(user);
                        await _signInManager.SignOutAsync();
                        await _signInManager.PasswordSignInAsync(user, userPasswordChangeDto.NewPassword, true, false);
                        TempData.Add("SuccessMessage", $"Şifreniz başarıyla değiştirilmiştir.");
                        return View();

                    }
                }
                else
                {
                    ModelState.AddModelError("", "Lütfen girmiş olduğunuz şuanki şifrenizi kontrol ediniz.");
                    return View(userPasswordChangeDto);
                }
            }
            else
            {

                return View(userPasswordChangeDto);
            }
            return View();

        }


        [HttpGet]
        [AllowAnonymous]
        public ViewResult ResetPassword()
        {
            return View();
        }


        [HttpPost]
        
        public async Task<IActionResult> ResetPassword(UserPasswordResetDto userPasswordResetDto)
        {
            if (ModelState.IsValid)
            {

                User user = await _userManager.FindByEmailAsync(userPasswordResetDto.Email);
                if (user != null)
                {
                    string resetToken = await _userManager.GeneratePasswordResetTokenAsync(user);
                    MailMessage mail = new MailMessage();
                    mail.IsBodyHtml = true;
                    mail.To.Add(userPasswordResetDto.Email);
                    mail.From = new MailAddress("asiyekelle7@gmail.com", "Şifre Güncelleme", System.Text.Encoding.UTF8);
                    mail.Subject = "Şifre Güncelleme Talebi";
                    mail.Body = $"<a target=\"_blank\" href=\"https://localhost:44359{Url.Action("UpdatePassword", "User", new { userId = user.Id, token = HttpUtility.UrlEncode(resetToken) })}\">Yeni şifre talebi için tıklayınız</a>";
                    mail.IsBodyHtml = true;
                  
                    SmtpClient smp = new SmtpClient();
                    smp.Credentials = new NetworkCredential("asiyekelle7@gmail.com", "asiyekelle7asiyekelle7");
                    smp.UseDefaultCredentials = false;
                    smp.Port = 587;
                    smp.Host = "smtp.gmail.com";
                    smp.EnableSsl = true;
                    smp.Send(mail);
                    
                    ViewBag.State = true;
                }
                else
                {
                    ViewBag.State = false;

                    return View();
                }
            }
            else
            {

                return View(userPasswordResetDto);
            }
            return View();

        }

        [HttpGet("[action]/{userId}/{token}")]
        public IActionResult UpdatePassword(string userId, string token)
        {
            return View();
        }
        public async Task<IActionResult> UpdatePassword(UserUpdatePasswordDto userUpdatePasswordDto, string userId, string token)
        {
            User user = await _userManager.FindByIdAsync(userId);
            IdentityResult result = await _userManager.ResetPasswordAsync(user, HttpUtility.UrlDecode(token), userUpdatePasswordDto.Password);
            if (result.Succeeded)
            {
                ViewBag.State = true;
                await _userManager.UpdateSecurityStampAsync(user);
            }
            else
                ViewBag.State = false;
            return View();
        }



        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home", new { Area = "Admin" });
        }


      
    }
}
