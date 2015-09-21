using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Application.Models
{
    public class EducationViewModel
    {
        public String Country { get; set; }
        public String City { get; set; }

        public String School { get; set; }

        public DateTime From { get; set; }
        public DateTime To { get; set; }

        public Boolean notEndedYet { get; set; }

        public IEnumerable<SelectListItem> GetCountries()
        {
            IList<SelectListItem> items = new List<SelectListItem>
            {
                new SelectListItem{Text = "Ukraine", Value = "1"},
                new SelectListItem{Text = "Russia", Value = "2"},

            };
            return items;
        }
    }
}