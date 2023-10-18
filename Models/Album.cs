using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace sistemamusicafinal.Models
{

        [Table("Album")]
        public class Album
        {
            [Column("IdAlbum")]
            [Display(Name = "Código Álbum")]
            public int Id { get; set; }

            [Column("TituloAlbum")]
            [Display(Name = "Titulo do Álbum")]
            public string TituloAlbum { get; set; } = string.Empty;

            [Column("GeneroAlbum")]
            [Display(Name = "Gênero do Álbum")]
            public string GeneroAlbum { get; set; } = string.Empty;

            [Column("CapaAlbum")]
            [Display(Name = "Capa do Álbum")]
            public byte[]? CapaAlbum { get; set; }

            [ForeignKey("CantorId")]
            [Display(Name = "Cantor")]
            public int CantorId { get; set; }

            public Cantor? Cantor { get; set; }
        }
}
