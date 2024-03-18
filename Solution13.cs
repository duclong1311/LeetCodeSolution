﻿public class Solution
{
    public int RomanToInt(string s)
    {
        Dictionary<char, int> m = new Dictionary<char, int>();

        m['I'] = 1;
        m['V'] = 5;
        m['X'] = 10;
        m['L'] = 50;
        m['C'] = 100;
        m['D'] = 500;
        m['M'] = 1000;

        int ans = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if (m[s[i]] < m[s[i + 1]])
            {
                ans -= m[s[i]];
            }
            else
            {
                ans += m[s[i]];
            }
        }
        return ans;
    }
}