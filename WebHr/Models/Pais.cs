using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebHr.Models
{
    public class Pais
    {
        [DisplayName("Codigo Pais")]
        [Required(ErrorMessage ="Codigo de pais se debe ingresar")]
        [MinLength(2, ErrorMessage ="Codigo de pais debe de ser 2 carecteres")]
        [MaxLength(2, ErrorMessage = "Codigo de pais debe ser 2 carecteres")]
        [RegularExpression("([a-zA-Z]+)", ErrorMessage ="El texto ingresado no es valido")]
        public string country_id { get; set; }

        [DisplayName("Nombre")]
        [MaxLength(40, ErrorMessage = "Nombre de pais debe ser 40 carecteres")]
        [Required(ErrorMessage ="Nombre de pais se debe ingresar")]
        public string country_name { get; set; }

        [DisplayName("Region")]
        public int region_id { get; set; }

    }
}