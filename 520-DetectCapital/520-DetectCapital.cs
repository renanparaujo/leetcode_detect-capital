public class Solution {
    public bool DetectCapitalUse(string word) {
        if (string.IsNullOrWhiteSpace(word))
            return false;

        return word.Equals(word.ToUpper(), StringComparison.Ordinal) || 
               word.Equals(word.ToLower(), StringComparison.Ordinal) || 
               (char.IsUpper(word[0]) && word.Substring(1).Equals(word.Substring(1).ToLower(), StringComparison.Ordinal));
    }
}
