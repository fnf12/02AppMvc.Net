using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _02CapsulaMvc.Net.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Ingrese un Nombre y Apellido")]
        [StringLength(255, MinimumLength = 5,
            ErrorMessage = "El nombre debe tener un minimo de 5 caracteres")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Ingrese un Mail")]
        [EmailAddress(ErrorMessage ="No es un mail valido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Ingrese la Calle")]
        [StringLength(255, MinimumLength = 3,
            ErrorMessage = "El nombre debe tener un minimo de 3 caracteres")]
        public string Street { get; set; }

        [Required(ErrorMessage = "Ingrese la altura")]
        public int Number { get; set; }

        public int? CountryId { get; set; }
        public int? StateId { get; set; }

        public virtual Country Country { get; set; }
        public virtual State State { get; set; }
    }
}
