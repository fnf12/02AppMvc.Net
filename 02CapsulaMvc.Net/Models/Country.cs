using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _02CapsulaMvc.Net.Models
{
    public class Country
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<State> States { get; set; }
    }
}
