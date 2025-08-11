public class Solution
{
    public bool IsPalindrome(int x) 
    {
        int a = 0; 
        int b = x;

        while (b > 0)
        {
            int digit = b % 10;
            a = (a * 10) + digit;
            b = b / 10;
        }

        return x == a; 
    }
}