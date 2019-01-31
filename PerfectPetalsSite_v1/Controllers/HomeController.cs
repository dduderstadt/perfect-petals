using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PerfectPetalsSite_v1.Models; // added
using System.Net.Mail; // added

namespace PerfectPetalsSite_v1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        // GET: ServicesPricing
        public ActionResult ServicesPricing()
        {
            return View();
        }

        // GET: Testimonials (LoveNotes)
        public ActionResult Testimonials()
        {
            return View();
        }

        // GET: Gallery
        public ActionResult Gallery()
        {
            return View();
        }

        // GET: Connect
        public ActionResult Connect()
        {
            return View();
        }

        // POST: Connect
        [HttpPost]
        public ActionResult Connect(string name, string email, string subject, string message)
        {
            //TODO: add a Try/Catch for any exceptions coming back for security issues

            // Setup the contact message
            ContactViewModel contact = new ContactViewModel()
            {
                Name = name,
                Email = email,
                Subject = subject,
                Message = message
            };

            // Create a body for the email
            string body = String.Format("Name: {0}<br/>Email: {1}<br/>Subject: {2}<br/>Date: {3}<br/>Message: {4}",
                contact.Name,
                contact.Email,
                contact.Subject,
                contact.Date,
                contact.Message);

            // Create the MailMessage object
            MailMessage msg = new MailMessage(
                "contact@perfectweddingsandeventsfloristkc.com",
                "perfectweddingsandevents@yahoo.com",
                "Contact Form",
                body);

            // Configure MailMessage object
            msg.IsBodyHtml = true;
            msg.Priority = MailPriority.Normal;

            // Create and configure SmtpClient
            using (SmtpClient client = new SmtpClient())
            {
                //client.EnableSsl = true;
                client.UseDefaultCredentials = false;
                client.Credentials = new System.Net.NetworkCredential(
                    "contact@perfectweddingsandeventsfloristkc.com", "password"); // this will be email client setup for business contact
                client.Host = "[hosting was not renewed by client]";
                client.Port = 80;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;

                // Send the message
                client.Send(msg);
            } // end using SmtpClient object

            return RedirectToAction("Index", contact);

        } // end Connect POST

        #region FAQ 
        // GET: FAQ -- commented out, site owner wanted FAQ removed; moved to '_archive' folder in case needed later
        //public ActionResult FAQ()
        //{
        //    return View();
        //}
        #endregion
    }
}