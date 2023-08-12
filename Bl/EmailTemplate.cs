using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl
{
    public interface IEmailTempalte
    {
        string CustomEmail();
    }
    public class EmailTemplate : IEmailTempalte
    {
        
        public string CustomEmail()
        {
            var header = File.ReadAllText("wwwroot/EmailTemplates/Header.html");
            var footer = File.ReadAllText("wwwroot/EmailTemplates/Footer.html");
            //var template= File.ReadAllText(pageName);
            //template.Replace("[Get the App]", r1);

            return header+ bodyAfterRegisteration() + footer;
        }
        public string bodyAfterRegisteration()
        {
            var body = File.ReadAllText("wwwroot/EmailTemplates/BodyAfterRegister.html");
            return body;
        }
    }
}
