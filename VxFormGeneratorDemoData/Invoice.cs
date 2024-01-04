
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using VxFormGenerator.Core;
using VxFormGenerator.Models;

namespace VxFormGeneratorDemoData
{
    public class Invoice
    {
        [Display(Name = "Number")] 
        public int Number { get; set; }

        [Display(Name = "Date")] 
        public DateTime Date { get; set; }

        [Display(Name = "Customer name")] 
        public string Customer { get; set; }

    }

}
