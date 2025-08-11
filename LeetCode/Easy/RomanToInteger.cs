public class Solution {
    public int RomanToInt(string s) {
        Dictionary<char, int> numerals = new Dictionary<char, int>()
        {
            {'I', 1}, 
            {'V', 5}, 
            {'X', 10},
            {'L', 50}, 
            {'C', 100}, 
            {'D', 500},
            {'M', 1000}
        };

        int total = 0;
        
        for (int i = 0; i < s.Length; i++)
        {
            char ch = s[i];
            int numeralValue = numerals[ch];

            if (i < s.Length - 1 && numerals[s[i + 1]] > numeralValue)
                total -= numeralValue;
            else
                total += numeralValue;
        }

        return total;
    }
}
