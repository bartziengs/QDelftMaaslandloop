using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication6.Pages
{
    public class SponsoringModel : PageModel
    {
        public void OnGet()
        {

        }

        public ActionResult DownloadDocument()
        {
            string filePath = @"\BestelformulierMaaslandloop2019-wijnactieQDelft.xlsx";
            string fileName = "Bestelformulier";

            byte[] fileBytes = System.IO.File.ReadAllBytes(filePath);

            return File(fileBytes, "application/force-download", fileName);
        }
    }
}