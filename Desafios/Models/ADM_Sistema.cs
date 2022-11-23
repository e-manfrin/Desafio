using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafios.Models
{
    internal class ADM_Sistema
    {
        [Key]
        [Required]
        public byte Id { get; set; }
        public string SIS_Nome { get; set; }

        [Required(ErrorMessage = "O campo SIS_Link é obrigatório")]
        public string SIS_Link { get; set; }
    }
}
