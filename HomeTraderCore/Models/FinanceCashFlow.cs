using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HomeTraderCore.Models
{
    public class FinanceCashFlow
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string ComapanyName { get; set; }
        public int RaportYear { get; set; }

        #region Cash Flow
        public int PrzeplywyZDzialalnosciOperacyjnej { get; set; }
        public int PrzeplywyZDzialalnosciInvestycyjnej { get; set; }
        public int PrzeplywyZDzialalnosciFinansowej { get; set; }
        public int PrzeplywyRazem { get; set; }
        #endregion
    }
}
