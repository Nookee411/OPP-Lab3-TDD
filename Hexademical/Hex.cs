using System;
using System.Collections.Concurrent;
using System.Globalization;
using System.Linq;

namespace Hexademical
{
    public static class HexInt
    {
        //Constructor

        //Methods
        public static string DecToHex(int a)
        {
            return a.ToString("X");
        }

        public static int HexToDec(string a)
        {
            return int.Parse(a, NumberStyles.HexNumber);
        }

        public static string Add(string a, string b)
        {
            string res;
            if (HexInt.IsHex(a) && HexInt.IsHex(b))
            {
                int temp = int.Parse(a, NumberStyles.HexNumber) + int.Parse(b, NumberStyles.HexNumber);
                res = temp.ToString("X");
            }
            else
                throw new ArgumentException("Wrong Hex provided.");
            return res;
        }
        public static string Subsruct(string a, string b)
        {
            string res;
            if (HexInt.IsHex(a) && HexInt.IsHex(b))
            {
                int temp = int.Parse(a, NumberStyles.HexNumber) - int.Parse(b, NumberStyles.HexNumber);
                res = temp.ToString("X");
            }
            else
                throw new ArgumentException("Wrong Hex provided.");
            return res;
        }
        public static bool IsHex(string s)
        {
            try
            {
                int.Parse(s, NumberStyles.HexNumber);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static string And(string a, string b)
        {
            if (HexInt.IsHex(a) && HexInt.IsHex(b))
            {
                a = String.Join(String.Empty, a.Select(c => Convert.ToString(Convert.ToInt32(c.ToString(), 16), 2).PadLeft(4, '0')));
                b = String.Join(String.Empty, b.Select(c => Convert.ToString(Convert.ToInt32(c.ToString(), 16), 2).PadLeft(4, '0')));
                return HexInt.DecToHex(Convert.ToInt32(new string(a.Zip(b, (x, y) => (x == '1' && y == '1') ? '1' : '0').ToArray()),2));
            }
            else
                throw new ArgumentException();
        }

        public static string Or(string a, string b)
        {
            if (HexInt.IsHex(a) && HexInt.IsHex(b))
            {
                a = String.Join(String.Empty, a.Select(c => Convert.ToString(Convert.ToInt32(c.ToString(), 16), 2).PadLeft(4, '0')));
                b = String.Join(String.Empty, b.Select(c => Convert.ToString(Convert.ToInt32(c.ToString(), 16), 2).PadLeft(4, '0')));
                return HexInt.DecToHex(Convert.ToInt32(new string(a.Zip(b, (x, y) => (x == '1' || y == '1') ? '1' : '0').ToArray()), 2));
            }
            else
                throw new ArgumentException();
        }

    }
}
