using System.ComponentModel.DataAnnotations;

namespace PriscilaZuniga_WebCodeFirst.Models
{
    public class Burger
    {
        public int BurgerID { get; set; }
        [Required]
        public string? Name { get; set; }
        public bool WithCheese { get; set; }
        [Range(0.01, 9999.99)]
        [VerificarRango]
        public decimal Precio { get; set; }
        
        
    }

    public class VerificarRango : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            decimal valor = (decimal)value;
            if (valor < 20)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }

}
