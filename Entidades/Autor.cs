using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiAutores.Entidades
{
    public class Autor
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es requirido")]
        [StringLength(5, ErrorMessage ="El campo {0} no puede tener mas de {1} caracteres")]
        public string Name { get; set; }

        [Range(18,25)]
        [NotMapped]
        public int edad { get; set; }

        [CreditCard]
        [NotMapped]
        public string tarjetaDeCredito { get; set; }

        public List<Libro> Libros { get; set; }

    }
}
