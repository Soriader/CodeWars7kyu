using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class DiscoverTheOriginalPriceTask
    {
        public static decimal DiscoverOriginalPrice(decimal discountedPrice, decimal salePercentage)
        {
            decimal originalPrice = discountedPrice * 100 / (100 - salePercentage);
            return Math.Round(originalPrice, 2);
        }
    }
}
//https://www.codewars.com/kata/552564a82142d701f5001228/train/csharp