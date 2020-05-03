using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeTraderCore.Models.ViewModels
{
    public class CashFlowViewModel
    {
        public IEnumerable<FinanceCashFlow> FinanceCashFlow { get; set; }
        public string StockName { get; set; }
        public FinanceCashFlow FinanceCashFlowDescription { get; set; }
    }
}