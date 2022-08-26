using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversaoDeMoedas
{
    public class Moedascs
    {
        public string Currency { get; set; } = default!;
        public double Rate { get; set; }

        public Moedascs(string currency, double rate)
        {
            Currency = currency;
            Rate = rate;
        }
        public override string ToString()
        {
            return Currency + " " + Rate;
        }
    }
}
