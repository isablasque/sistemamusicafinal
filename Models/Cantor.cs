using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace sistemamusicafinal.Models
{
    [Table("Cantor")]
    public class Cantor
    {
        [Column("IdCantor")]
        [Display(Name = "Código Cantor")]
        public int Id { get; set; }

        [Column("NomeCantor")]
        [Display(Name = "Nome do Cantor")]
        public string NomeCantor { get; set; } = string.Empty;

        [Column("GeneroCantor")]
        [Display(Name = "Gênero Musical")]
        public string GeneroCantor { get; set; } = string.Empty;
    }
}
