using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ConceptoVet.Models
{
    public class Furniture
    {
        public int Id { get; set; }
        public String Description { get; set; }
        //[DisplayFormat(DataFormatString = "{0:d}")]
        [DisplayFormat(DataFormatString = "{0:0,0}")]
        public Decimal Retail { get; set; }
        public Decimal Qty { get; set; }
        public String Picture { get; set; }

        public Furniture() { }
        //Used to create the catalogue
        public Furniture(int id, String description, Decimal retail, String picture)
        {
            Id = id;
            Description = description;
            Retail = retail;
            Picture = picture;
        }
        //Used to display the quotation
        public Furniture(int id, String description, int qty, Decimal retail, String picture)
        {
            Id = id;
            Description = description;
            Qty = qty;
            Retail = retail;
            Picture = picture;
        }
    }
}