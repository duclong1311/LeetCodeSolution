public class Solution {
    public int LengthOfLastWord(string s) {
        s = s.TrimEnd();
        int count = 0;
        for (int i = s.Length; i >= 0; i--){
            if (s[i] != ' '){
                count++; 
            }
            else 
                break;
        }
        return count;
    }
}