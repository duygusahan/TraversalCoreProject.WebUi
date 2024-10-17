using Microsoft.AspNetCore.Mvc;
using MimeKit;
using System.Net.Mail;
using TraversalCoreProject.WebUi.Models;
using MailKit.Net.Smtp;


namespace TraversalCoreProject.WebUi.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MailController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(MailRequest mailRequest)
        {
            MimeMessage mimeMessage = new MimeMessage();
            MailboxAddress mailboxAddressFrom = new MailboxAddress("Admin" , "sahanduygu3@gmail.com");
            mimeMessage.From.Add(mailboxAddressFrom);
            MailboxAddress mailboxAddressTo = new MailboxAddress("User", mailRequest.RecieverMail);
            mimeMessage.To.Add(mailboxAddressTo);

            mimeMessage.Subject=mailRequest.Subject;
            
            var bodyBuilder=new BodyBuilder();
            bodyBuilder.TextBody = mailRequest.Body;
            mimeMessage.Body=bodyBuilder.ToMessageBody();

            MailKit.Net.Smtp.SmtpClient client = new MailKit.Net.Smtp.SmtpClient();
            client.Connect("smtp.gmail.com", 587, false);
            client.Authenticate("sahanduygu3@gmail.com", "uxtf ogrs mold emgv");
            client.Send(mimeMessage);
            client.Disconnect(true);
            return View();
        }
    }
}
