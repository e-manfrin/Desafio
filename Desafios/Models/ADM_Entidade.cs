using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafios.Models
{
    internal class ADM_Entidade
    {
        [Key]
        [Required]
        public byte ENT_Id { get; set; }
        public string ENT_Nome { get; set; }
        public string ENT_Responsavel { get; set; }

        [Required(ErrorMessage = "O campo ENT_TerminalPrefixo é obrigatório")]
        public byte ENT_TerminalPrefixo { get; set; }
    }
}
