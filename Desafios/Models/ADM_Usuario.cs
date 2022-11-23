using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafios.Models
{
    internal class ADM_Usuario
    {
        [Key]
        [Required]
        public byte USU_Id { get; set; }
        public byte USU_ENT_Id { get; set; }
        public string USU_Nome { get; set; }
        public string USU_Login { get; set; }
        public string USU_Senha { get; set; }
        public bool USU_Bloqueado { get; set; }

        [Required(ErrorMessage = "O campo USU_DataAcesso é obrigatório")]
        public DateTime USU_DataAcesso { get; set; }
    }
}
