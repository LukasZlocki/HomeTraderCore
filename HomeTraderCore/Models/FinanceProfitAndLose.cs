using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HomeTraderCore.Models
{
    public class FinanceProfitAndLose
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Display(Name = "Nazwa")]
        public string ComapanyName { get; set; }

        [Display(Name = "Rok")]
        public int RaportYear { get; set; }

        #region Rachunek zyskow i strat
        [Display(Name = "Przychody")]
        public int PrzychodyZeSprzedazy { get; set; }
        [Display(Name = "Zysk")]
        public int ZyskZeSprzedazy { get; set; }
        [Display(Name = "Zysk Operacyjny")]
        public int ZyskOperacyjny { get; set; }
        [Display(Name = "Zysk z dzialalnosci gospodarczej")]
        public int ZyskZDzialalnosciGospodarczej { get; set; }
        [Display(Name = "Zysk przed opodatkowaniem")]
        public int ZyskPrzedOpodatkowaniem { get; set; }

        [Display(Name = "Zysk Netto")]
        public int ZyskNetto { get; set; }
        public int ZyskNettoAkcjonariuszyJednostkiDominujacej { get; set; }

        [Display(Name = "EBITDA")]
        public int EBITDA { get; set; }
        #endregion
    }
}
