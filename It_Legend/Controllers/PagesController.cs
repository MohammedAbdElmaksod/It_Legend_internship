using Bl;
using Castle.Core.Smtp;
using It_Legend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;


namespace It_Legend.Controllers
{
    public class PagesController : Controller
    {

        private readonly IEmailSenderr _sendMail;

        public PagesController(IEmailSenderr sendMail)
        {
            _sendMail = sendMail;
        }

        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View(new userMessage());
        }
        [HttpPost]
        public  IActionResult Contact(userMessage sendMessage)
        {
             _sendMail.SendEmailAsync(sendMessage.senderEmail,sendMessage.purposeOfMessage,sendMessage.message);
            ViewBag.alert = "email send successfully";
            return RedirectToAction(nameof(Contact));
        }
        public IActionResult OurIndustries()
        {
            return View();
        }
    }
}
