using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeTraderCore.Models
{
    public class GpwCompany
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Ticker { get; set; }
        public string Index { get; set; }
        public string ISIN { get; set; }
    }
}
