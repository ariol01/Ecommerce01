using System.ComponentModel.DataAnnotations;

namespace EcommerceMod1.Models
{
    public class Departaments
    {
        [Key]
        public int DepartamentsId { get; set; }
        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        [MinLength(2,ErrorMessage = "Minimo 2 caracteres é aceito.")]
        public string Name { get; set; }


    }
}