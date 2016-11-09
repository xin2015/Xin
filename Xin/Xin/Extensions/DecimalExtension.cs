using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xin.Extensions
{
    public static class DecimalExtension
    {
        public static decimal? Round(this decimal? d)
        {
            if (d.HasValue) return decimal.Round(d.Value);
            else return null;
        }

        public static decimal? Round(this decimal? d, int decimals)
        {
            if (d.HasValue) return decimal.Round(d.Value, decimals);
            else return null;
        }

        public static decimal? Round(this decimal? d, int decimals, MidpointRounding mode)
        {
            if (d.HasValue) return decimal.Round(d.Value, decimals, mode);
            else return null;
        }
    }
}
