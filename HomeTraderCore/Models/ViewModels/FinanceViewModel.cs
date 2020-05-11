using System.Collections.Generic;

namespace HomeTraderCore.Models.ViewModels
{
    public class FinanceViewModel
    {     
        public IEnumerable<FinanceCashFlow> FinanceCashFlow { get; set; }
        public IEnumerable<FinanceProfitAndLose> FinanceProfitAndLose { get; set; }
        public IEnumerable<FinanceBalance> FinanceBalance { get; set; }

        public GpwCompany Company { get; set; }

        public FinanceCashFlow FinanceCashFlowDescription { get; set; }
        public FinanceProfitAndLose FinanceProfitAndLoseDescription { get; set; }
        public FinanceBalance FinanceBalanceDescription { get; set; }
    }
}
