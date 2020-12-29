using System;

namespace Ole.Orders.Models
{
    public static class IdGen
    {
        public static string Generate()
        {
            return $"{DateTime.Now:yyMMddhhmmss}";
        }
    }
}
