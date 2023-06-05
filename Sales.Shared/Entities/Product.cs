using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Sales.Shared.Entities
{
    public class Product
    {
        public int Id { get; set; }

        [Display(Name = "Producto")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres.")]
        public string Name { get; set; } = null!;

        public int CategoryId { get; set; }
        public Category? Category { get; set; }

        
        private decimal Price;
        [Display(Name = "precio")]
        [Required(ErrorMessage = "El campo {1} es obligatorio.")]
        public decimal price 
        {
            get { return Price; }
            set
            {
                if (value >= 0)
                    Price = value;
                else
                    throw new ArgumentOutOfRangeException("Price", "El precio no puede ser menor que 0.");
            }
        }

        [Display(Name = "Stock")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        private int stock;
        public int Stock
        {
            get { return stock; }
            set
            {
                if (value >= 0)
                    stock = value;
                else
                    throw new ArgumentOutOfRangeException("Stock", "El stock no puede ser menor que 0.");
            }
        }

    }
}
