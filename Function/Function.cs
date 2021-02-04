using System;

namespace Function
{
    public enum SortOrder { Ascending, Descending }
    public static class Function
    {
        public static bool IsSorted(int[] array, SortOrder order)
        {
            for (int i = 1; i < array.Length; i++)
            {
                switch (order)
                {
                    case SortOrder.Ascending when array[i - 1] > array[i]:
                    case SortOrder.Descending when array[i - 1] < array[i]:
                        return false;
                }
            }

            return true;
        }

        public static void Transform(int[] array, SortOrder order)
        {
            if (!IsSorted(array, order)) return;

            for (var i = 0; i < array.Length; i++)
            {
                array[i] += i;
            }
        }

        public static double MultArithmeticElements(double a, double t, int n)
        {
            double result = a;
            for (int i = 0; i < n - 1; i++)
            {
                a += t;
                result *= a;
            }

            return result;
        }

        public static double SumGeometricElements(double a, double t, double alim)
        {
            double result = 0;

            if (t < 0 || t > 1) return result;

            while (a > alim)
            {
                result += a;
                a *= t;

            }

            return result;
        }
    }
}
