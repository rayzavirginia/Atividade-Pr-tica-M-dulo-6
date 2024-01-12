using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destinos.Model
{
    [Table("destinos")]
    public class Destino
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("destino_nome")]
        public string Nome { get; set; } = string.Empty;

        [Column("destino_estado")]
        public string Estado { get; set; } = string.Empty;

        [Column("destino_pais")]
        public required string Pais { get; set; }

        [Column("destino_url")]
        public string destinoUrl { get; set;} = string.Empty;
        
        [Column("destino_valor")]
        public required string Valor { get; set; }
    }
}
