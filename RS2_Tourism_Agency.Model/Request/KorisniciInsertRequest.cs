using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RS2_Tourism_Agency.Model.Request
{
    public class KorisniciInsertRequest
    {

        [Required(AllowEmptyStrings=false)]
        public string Ime { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string Prezime { get; set; }

        [MinLength(4)]
        [Required(AllowEmptyStrings = false)]
        public string UserName { get; set; }
        public string Password { get; set; }

        public string PasswordConfirm { get; set; }

        [Required(AllowEmptyStrings = false)]
        [EmailAddress()]
        public string Email { get; set; }
        public string Telefon { get; set; }
        public bool? Status { get; set; }

        public List<int> UlogeIdList { get; set; } = new List<int> { };

    }
}
