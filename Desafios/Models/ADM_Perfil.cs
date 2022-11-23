using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafios.Models
{
    internal class ADM_Perfil
    {
        [Key]
        [Required]
        public short PER_Id { get; set; }
        public byte PER_SIS_Id { get; set; }
        public string PER_Nome { get; set; }
    }
}
