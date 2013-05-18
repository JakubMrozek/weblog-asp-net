using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Blog.Models
{
    public class User
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [DisplayName("Titul před jménem (nepovinné)")]
        public string DegreeBefore { get; set; }

        [Required]
        [DisplayName("Jméno")]
        public string Name { get; set; }

        [Required]
        [DisplayName("Příjmení")]
        public string Surname { get; set; }

        [DisplayName("Titul za jménem (nepovinné)")]
        public string DegreeAfter { get; set; }

        [Required]
        [DisplayName("Ulice")]
        public string Street { get; set; }

        [Required]
        [DisplayName("Číslo popisné")]
        [DataType(DataType.Text)]
        public int StreetNumber { get; set; }

        [Required]
        [DisplayName("Město")]
        public string Town { get; set; }

        [Required]
        [DisplayName("PSČ")]
        [DataType(DataType.Text)]
        public int Zipcode { get; set; }

    }
}