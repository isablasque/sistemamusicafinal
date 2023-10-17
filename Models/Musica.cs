using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace sistemamusicafinal.Models
{
    [Table("Musica")]
    public class Musica
    {
        [Column("IdMusica")]
        [Display(Name = "Código Música")]
        public int Id { get; set; }

        [Column("TituloMusica")]
        [Display(Name = "Titulo da Música")]
        public string TituloMusica { get; set; } = string.Empty;


        [Column("DuracaoMusica")]
        [Display(Name = "Duração da Música")]
        public string DuracaoMusica { get; set; } = string.Empty;

        [ForeignKey("AlbumId")]
        public int AlbumId { get; set; }

        public Album? Album { get; set; }

    }
}
