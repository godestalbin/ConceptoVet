using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.Web.Mvc;

namespace ConceptoVet.Models
{
    public class Contact
    {
        [DisplayName("Prénom et nom:")]
        [Required(ErrorMessage = "Donnée obligatoire")]
        [RegularExpression(@"[a-zA-Z ]{3,}", ErrorMessage = "Au moins trois caractères")]
        public String name { get; set; }
        [DisplayName("Téléphone:")]
        [Required(ErrorMessage = "Donnée obligatoire")]
        [RegularExpression(@"^0[1-9][0-9]{8}", ErrorMessage = "Exactement huit chiffres (zéro en premier chiffre)")]
        public String phone { get; set; }
        [DisplayName("Mail:")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Adresse mail incorrecte")]
        public String mail { get; set; }
        [DisplayName("Code postal:")]
        [Required(ErrorMessage = "Donnée obligatoire")]
        [RegularExpression(@"[0-9]{5}", ErrorMessage = "Exactement cinq chiffres")]
        public String zipCode { get; set; }

        //For testing display and mail
        public void TestInit() {
            name = "GO";
            phone = "8182";
            mail = "go@go.go";
            zipCode = "59139";
        }
    }


}