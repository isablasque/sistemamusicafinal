using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace sistemamusicafinal.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Column("IdUsuario")]
        [Display(Name = "Código do Usuario")]
        public int Id { get; set; }

        [Column("NomeUsuario")]
        [Display(Name = "Nome")]
        public string NomeUsuario { get; set; } = string.Empty;

        [Column("EmailUsuario")]
        [Display(Name = "E-mail")]
        public string EmailUsuario { get; set; } = string.Empty;

        [Column("SenhaUsuario")]
        [Display(Name = "Senha")]
        public string SenhaUsuario { get; set; } = string.Empty;
    }
}
