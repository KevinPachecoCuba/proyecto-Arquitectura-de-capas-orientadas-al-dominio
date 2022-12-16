using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace prueba.Models.ViewModels
{
    public class vmestudiante
    {
        public int idestudiante { get; set; }

        [Required]
        [StringLength(8)]
        [Display(Name = "dni")]
        public String dni { get; set; }

        [Required]
        [StringLength(150)]
        public String nombre { get; set; }

        public String ape_pat { get; set; }
        public String ape_mat { get; set; }
        public String direccion { get; set; }
        public String celular { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Correo electtronico")]
        public String correo { get; set; }
        public DateTime fec_nac { get; set; }

    }
}