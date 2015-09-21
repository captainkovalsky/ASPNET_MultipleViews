using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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
    }
}