using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Hotellerie_Khala.Models.HotellerieModel
{
    public class Appreciation
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Nom Personne")]
        public string NomPers { get; set; } = null!;

        [Required]
        [DataType(DataType.MultilineText)]
        public string Commentaire { get; set; } = null!;

        // Clé étrangère
        [ForeignKey("Hotel")]
        public int HotelId { get; set; }

        // Navigation property vers l'hôtel (nullable comme demandé)
        public virtual Hotel? Hotel { get; set; }

        [Required(ErrorMessage = "La note est obligatoire.")]
        [Range(1, 10, ErrorMessage = "La note doit être entre 1 et 10.")]
        public int Note { get; set; }
    }
}
