using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ConceptoVet.Models;

namespace ConceptoVet.Models
{
    public class Quotation
    {
        public Contact contact { get; set; }
        public List<Furniture> furnitures { get; set; }
        public Decimal serviceFee { get; set; }

        public Quotation()
        {
            contact = new Contact();
            furnitures = null;
        }

        //Used for testing the display of quotation
        public void InitQuotation()
        {
            //Quotation quotation = this; // new Quotation();
            //Contact contact = new Contact();
            this.contact.name = "GO";
            this.contact.phone = "0781828688";
            this.contact.mail = "go@go.go";
            this.contact.zipCode = "59139";
            String imagePath = "https://s3.amazonaws.com/conceptovet/images/"; // "/Images/";
            List<Furniture> furnitures = new List<Furniture>() {
                new Furniture(1, "Meuble chiens 2,05m", 1, 2300m, imagePath + "Chiens 205.png"),
                new Furniture(2, "Meuble chiens 2,75m", 2, 2800m, imagePath + "Chiens 275.png"),
                new Furniture(3, "Meuble soin 1,35m", 1, 1300m, imagePath + "Soins 135.png"),
                new Furniture(4, "Meuble soin 2,05m", 2, 1700m, imagePath + "Soins 205.png"),
                new Furniture(12, "Meuble accueil simple gauche", 1, 1500m, imagePath + "Accueil gauche.png"),
                new Furniture(99, "Transport et installation sur site", 1, 3390.53m, null) //Delivery fee
            };
            this.furnitures = furnitures;
            //return quotation;
        }
    }
}