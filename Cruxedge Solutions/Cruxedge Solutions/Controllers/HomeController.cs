using Cruxedge_Solutions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace Cruxedge_Solutions.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = new ContactModel();
            

            return View(model);
            
          
        }


        [HttpPost]
        public ActionResult Index(ContactModel model)
        {
            ToAdminEmail(model);
           
            return View();
        }
        public void ToAdminEmail(ContactModel model)
        {


            string MessageFrom = string.Format("You have a new message from {0} with Phone number {1} and Email {2}, See the message below:<br/>", model.Name, model.Phone, model.Email);

            var myMessage = new MailMessage();
            myMessage.To.Add(new MailAddress("ayodeleenitilo@yahoo.com"));  // replace with valid value 
           // myMessage.Bcc.Add(new MailAddress("ayodeleenitilo@gmail.com"));
            myMessage.From = new MailAddress("festusoluyide@gmail.com");  // replace with valid value
            myMessage.Subject = "ENQUIRY FOR CRUXEDGE";
            myMessage.Body = MessageFrom + "<br/>" + model.Message;

            myMessage.IsBodyHtml = true;

            using (var smtp = new SmtpClient())
            {
                var credential = new NetworkCredential
                {
                    UserName = "festusoluyide@gmail.com",  // replace with valid value
                    Password = "7343good"  // replace with valid value
                };
                smtp.Credentials = credential;
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.Send(myMessage);
            }
        }

       
        



        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        

        
    }
}