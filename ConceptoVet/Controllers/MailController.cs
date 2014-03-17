using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc.Mailer;
using System.Net.Mail;
using ConceptoVet.Models;

namespace ConceptoVet.Controllers
{
    public class MailController : Controller
    {
        //Testing views for displaying mail content
        public ActionResult Contact()
        {
            //Send the mail
            //Mail mail = new Mail();
            //mail.Contact().Send();
            //Show the view with for contact
            return View(TestContact());
        }

        public ActionResult ContactData()
        {
            //Show the view with for contact
            Quotation quotation = new Quotation();
            quotation.InitQuotation();

            //Send the mail
            //Mail mail = new Mail();
            //mail.ContactQuotation(quotation).Send();
            
            return View(quotation);
        }

        private Contact TestContact() {
            Contact contact = new Contact();
            contact.name = "GuyO";
            contact.zipCode = "59139";
            return contact;
        }
    } //class MailController for testing mail view

    public class Mail : MailerBase
    {

        //Send us contact form with full data
        public virtual MvcMailMessage Contact(Contact contact)
        {
            //User user = db.User.Find(userId); //Retrieve user
            //ViewBag.account = user.Account;
            ViewData.Model = contact; // TestContact(); //Set the strongly typed object for the view
            //Add embedded pictures
            //var resources = new Dictionary<string, string>();
            //resources["signature"] = HttpContext.Current.Server.MapPath("~/Content/Images/Commute mail signature.png");
            return Populate(x =>
            {
                x.Subject = "Créadismo - Nouveau contact"; //Resources.Welcome;
                x.ViewName = "Contact"; //Views/Mail/Welcome
                //x.Bcc.Add("godestalbin@gmail.com"); //send me a copy of the mail
                //x.To.Add("godestalbin@gmail.com, axelle.munch@gmail.com"); //user.EmailAddress);
                //x.Bcc.Add("godestalbin@gmail.com"); //send me a copy of the mail
                //x.LinkedResources = resources; //Embedded images - Commute signature
            });
        }

        //Send us contact form with full data
        public virtual MvcMailMessage ContactQuotation(Quotation quotation)
        {
            //User user = db.User.Find(userId); //Retrieve user
            //ViewBag.account = user.Account;
            ViewData.Model = quotation; //Set the strongly typed object for the view
            //Add embedded pictures
            //var resources = new Dictionary<string, string>();
            //resources["signature"] = HttpContext.Current.Server.MapPath("~/Content/Images/Commute mail signature.png");
            return Populate(x =>
            {
                x.Subject = "Créadismo - Nouveau devis"; //Resources.Welcome;
                x.ViewName = "ContactData"; //Views/Mail/Welcome
                x.To.Add(quotation.contact.mail); //user.EmailAddress);
                //x.Bcc.Add("godestalbin@gmail.com"); //send me a copy of the mail
                //x.Bcc.Add("godestalbin@gmail.com, axelle.munch@gmail.com"); //send me a copy of the mail
                //x.LinkedResources = resources; //Embedded images - Commute signature
            });
        }

        private Contact TestContact()
        {
            Contact contact = new Contact();
            contact.name = "GuyO";
            contact.phone = "0781828688";
            contact.mail = "go@go.go";
            contact.zipCode = "59139";
            return contact;
        }
    } //class Mail
}
