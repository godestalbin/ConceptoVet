using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ConceptoVet.Models;

namespace ConceptoVet.Controllers
{
    public class QuotationController : Controller
    {
        [HttpPost]
        [ActionName("Quotation")]
        public ActionResult PostQuotation(Quotation quotation)
        {
            //Send the quotation by mail
            Mail mail = new Mail();
            mail.ContactQuotation(quotation).Send();

            return View();
        }

    }
}
