using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HomeTraderCore.Models
{
    public class FinanceBalance
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Display(Name = "Nazwa")]
        public string ComapanyName { get; set; }
        [Display(Name = "rok")]
        public int RaportYear { get; set; }

        #region Bilans
        [Display(Name = "Aktywa trwale")]
        public int AktywaTrwale { get; set; }
        [Display(Name = "AktywaObrotowe")]
        public int AktywaObrotowe { get; set; }
        [Display(Name = "AktywaRazem")]
        public int AktywaRazem { get; set; }
        [Display(Name = "KapitalWlasnyAkcjonariuszyJednostkiDominujacej")]
        public int KapitalWlasnyAkcjonariuszyJednostkiDominujacej { get; set; }
        [Display(Name = "UdzialyNiekontrolujace")]
        public int UdzialyNiekontrolujace { get; set; }
        [Display(Name = "ZobowiazaniaDlugoterminowe")]
        public int ZobowiazaniaDlugoterminowe { get; set; }
        [Display(Name = "ZobowiazaniaKrotkoterminowe")]
        public int ZobowiazaniaKrotkoterminowe { get; set; }
        [Display(Name = "PasywaRazem")]
        public int PasywaRazem { get; set; }
        #endregion
    }
}
