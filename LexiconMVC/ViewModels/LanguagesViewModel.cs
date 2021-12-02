using LexiconMVCData.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LexiconMVCData.ViewModels
{
    public class LanguagesViewModel
    {
        [Display (Name="Person name")]
        public string PersonName { get; set; }
        [Display (Name ="Language")]
        public string LanguageName { get; set; }
        public List<LanguagesWithPersons> LanguagesWithPersonsList { get; set; }

    }
}
