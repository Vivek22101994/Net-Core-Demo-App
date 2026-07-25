using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models
{
    public class NewPrdocut
    {
        [Required(ErrorMessage="Prodcu Name Requiered")]

        public string ProductName { get; set; }

        
       
        public string SupplierEmail { get; set; }

        public IFormFile Photo { get; set; }
    }
}
