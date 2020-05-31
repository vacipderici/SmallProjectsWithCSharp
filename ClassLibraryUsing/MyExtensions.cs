using System;

namespace ClassLibraryUsing
{
    public static class MyExtensions
    {
        public static bool isCift(this int sayi)
        {
            return sayi % 2 == 0;
        }
        public static bool isNumeric(this string sayi)
        {
            return double.TryParse(sayi, out double rakamMi);
        }
    }
}
