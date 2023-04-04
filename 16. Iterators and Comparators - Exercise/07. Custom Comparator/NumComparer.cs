namespace _07._Custom_Comparator
{
    using System;
    using System.Collections.Generic;
    public class NumComparer : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            if (x % 2 == 0 && Math.Abs(y) % 2 == 1)
                return -1;
            if (Math.Abs(x) % 2 == 1 && y % 2 == 0)
                return 1;
            return x.CompareTo(y);
        }
    }
}
