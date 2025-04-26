using System.ComponentModel.DataAnnotations;

namespace Hotellerie_Khala.Models.HotellerieModel
{
    public class Hotel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Le nom est obligatoire.")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Le nom doit contenir entre 3 et 20 caractères.")]
        public required string Nom { get; set; }

        [Range(1, 5, ErrorMessage = "Le nombre d'étoiles doit être compris entre 1 et 5.")]
        public int Etoiles { get; set; }

        [Required(ErrorMessage = "La ville est obligatoire.")]
        public required string Ville { get; set; }

        [Required(ErrorMessage = "Le site Web est obligatoire.")]
        [Url(ErrorMessage = "Le site Web doit être une URL valide.")]
        [Display(Name = "Site Web")]
        public required string SiteWeb { get; set; }

        public required string Tel { get; set; }

        [Required]
        [StringLength(100)]
        public string Pays { get; set; } = "Tunisie";
        public virtual ICollection<Appreciation>? Appreciations { get; set; }
    }
}
