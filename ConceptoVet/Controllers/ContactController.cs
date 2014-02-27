using ConceptoVet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ConceptoVet.Models;

namespace ConceptoVet.Controllers
{
    public class ContactController : Controller
    {
        public ActionResult Contact()
        {
            Contact contact = new Contact();
            contact.name = "go";
            contact.phone = "0123456789";
            contact.mail = "godestalbin@gmail.com";
            contact.zipCode = "4516";
            return View(contact);
        }

        [HttpPost]
        [ActionName("Contact")]
        public ActionResult PostContact(Contact contact)
        {
            //Send the quotation by mail
            Mail mail = new Mail();
            mail.Contact(contact).Send();

            return View();
        }

        private void InitQuotation(Quotation quotation)
        {
            //Quotation quotation = new Quotation();
            String imagePath = "https://s3.amazonaws.com/conceptovet/images/"; // "/Images/";
            List<Furniture> furnitures = new List<Furniture>() {
                new Furniture(1, "Meuble chiens 2,05m", 2300m, imagePath + "Chiens 205.png"),
                new Furniture(2, "Meuble chiens 2,75m", 2800m, imagePath + "Chiens 275.png"),
                new Furniture(3, "Meuble soin 1,35m", 1300m, imagePath + "Soins 135.png"),
                new Furniture(4, "Meuble soin 2,05m", 1700m, imagePath + "Soins 205.png"),
                new Furniture(5, "Meuble soins 2,75m", 2200m, imagePath + "Soins 275.png")
            };
            //quotation.zipCode = "59139";
            quotation.furnitures = furnitures;
            //return quotation;
        }


    }
}
