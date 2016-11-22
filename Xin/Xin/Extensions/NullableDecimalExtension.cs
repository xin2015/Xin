using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xin.Extensions
{
    public static class NullableDecimalExtension
    {
        public static decimal? Round(this decimal? d)
        {
            return d.HasValue ? decimal.Round(d.Value) : d;
        }

        public static decimal? Round(this decimal? d, int decimals)
        {
            return d.HasValue ? decimal.Round(d.Value, decimals) : d;
        }

        public static decimal? Round(this decimal? d, int decimals, MidpointRounding mode)
        {
            return d.HasValue ? decimal.Round(d.Value, decimals, mode) : d;
        }
    }
}
