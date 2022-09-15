public class Solution {
    public string FractionToDecimal(int numerator, int denominator) {
        
        
       if (numerator == 0)
                return "0";

            String fraction = String.Empty;

            if (numerator < 0 ^ denominator < 0)
                fraction = fraction + "-";

            long dividend = Math.Abs(Convert.ToInt64(numerator));
            long divisor = Math.Abs(Convert.ToInt64(denominator));

            fraction = fraction + Convert.ToString(dividend / divisor);
            long remainder = dividend % divisor;
            if (remainder == 0)
            {
                return Convert.ToString(fraction);
            }

            fraction = fraction + ".";
            Dictionary<long, int> map = new Dictionary<long, int>();
            int value;
            while (remainder != 0)
            {
                if (map.TryGetValue(remainder, out value))
                {
                    fraction=fraction.Insert(Convert.ToInt32(value), "(");
                    fraction = fraction + ")";
                    break;
                }

                map.Add(remainder, fraction.Length);
                remainder = remainder * 10;
                fraction = fraction + Convert.ToString(remainder / divisor);
                remainder = remainder % divisor;
            }
        
           return fraction;
      
    }
}