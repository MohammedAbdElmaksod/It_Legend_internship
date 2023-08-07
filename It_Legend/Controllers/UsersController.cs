using AutoMapper;
using Bl.Data;
using Domains;
using It_Legend.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.Language;
using Microsoft.IdentityModel.Tokens;

namespace It_Legend.Controllers
{
    public class UsersController : Controller
    {
        private readonly IMapper _mapper;
        private readonly UserManager<ApplicationUser> _userManger;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ApplicationDbContext _context;

        public UsersController(UserManager<ApplicationUser> userManger, IMapper mapper, ApplicationDbContext context, SignInManager<ApplicationUser> signInManager)
        {
            _userManger = userManger;
            _mapper = mapper;
            _context = context;
            _signInManager = signInManager;
        }

        public IActionResult Login(string returnUrl)
        {
            return View(new userModel { returnUrl=returnUrl});
        }
        [HttpPost]
        public async Task<IActionResult> Login(userModel loginUser)
        {
            var existEmail = _context.Users.FirstOrDefault(e => e.Email == loginUser.Email);
            if(existEmail is null)
            {
                ModelState.AddModelError("Email", "This E-mail is not Exist");
                return View(loginUser);
            }
            var result = await _signInManager.PasswordSignInAsync(loginUser.Email, loginUser.Password,true,false);
            if (loginUser.returnUrl.IsNullOrEmpty())
                loginUser.returnUrl = "~/";
            if (result.Succeeded)
            {
                return Redirect(loginUser.returnUrl);
            }
            ModelState.AddModelError("Password", "password is wrong please try again");
            return View(nameof(Login), loginUser);
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(userModel RegisterdUser)
        {
            var user = _mapper.Map<ApplicationUser>(RegisterdUser);
            user.UserName = RegisterdUser?.Email;
            user.FullName = RegisterdUser?.CompanyName is not null ? RegisterdUser.CompanyName : RegisterdUser?.FullName;
            if (!ModelState.IsValid)
            {
                return View(RegisterdUser);
            }
            else
            {
                var existEmail = _context.Users.FirstOrDefault(e=>e.Email== user.Email);
                if (existEmail is not null)
                {
                    ModelState.AddModelError("Email", "this E-mail is already Exist");
                    return View(RegisterdUser);
                }
                if (RegisterdUser?.Password?.Length < 8)
                {
                    ModelState.AddModelError("Password", "Enter at least 8 length");
                    return View(RegisterdUser);
                }
                if(!(bool)RegisterdUser.AcceptedTerms)
                {
                    ModelState.AddModelError("AcceptedTerms", "you should accept our terms to signup");
                    return View(RegisterdUser);
                }
                var result = await _userManger.CreateAsync(user, RegisterdUser.Password);

                if (result.Succeeded)
                {
                    if (string.IsNullOrEmpty(RegisterdUser.CompanyName))
                    {

                        await _userManger.AddToRoleAsync(user, "Candidate");
                        var candidateUser = new Candidates()
                        {
                            fullName = RegisterdUser.FullName,
                            userId = user.Id,
                        };
                        _context.TbCandidates.Add(candidateUser);
                        _context.SaveChanges();
                        return Redirect("/Home/Index");
                    }
                    else
                    {

                        await _userManger.AddToRoleAsync(user, "Employeer");
                        var EmployeerUser = new Employees()
                        {
                            fullName = RegisterdUser.CompanyName,
                            email = RegisterdUser.Email,
                            phoneNumber = RegisterdUser.PhoneNumber,
                            userId = user.Id,
                        };
                        _context.TbEmplyees.Add(EmployeerUser);
                        _context.SaveChanges();
                        return Redirect("/Home/Index");
                    }
                }
                return View(RegisterdUser);

            }
        }
    }
}