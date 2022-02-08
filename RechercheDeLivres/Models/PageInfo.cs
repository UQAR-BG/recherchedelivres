using System.ComponentModel.DataAnnotations;

namespace RechercheDeLivres.Models
{
    public class PageInfo
    {
        [Required(ErrorMessage = "Champs requis !")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Champs requis !")]
        public int? PageNumber { get; set; }
    }
}