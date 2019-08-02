using System;
using System.ComponentModel.DataAnnotations;

namespace EcommerceMod1.Models
{
    public class City
    {
        [Key]
        public int CityId { get; set; }
        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        [MinLength(2, ErrorMessage = "Minimo 2 caracteres é aceito.")]
        [Display(Name = "Cidade")]
        public string Name { get; set; }
        [Required(ErrorMessage = "O campo Departamento é obrigatório")]
        [Display(Name = "Departamento")]
        [Range(1,Double.MaxValue, ErrorMessage = "Selecione um departamento")]
        public int DepartamentsId { get; set; }
        public  virtual Departaments Departaments { get; set; }
    }
}