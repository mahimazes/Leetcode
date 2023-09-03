public class Solution {
    public bool CheckIfPangram(string sentence) {
        
        HashSet<char> AlphabetSet=new HashSet<char>();
        
        for(int i=0;i<sentence.Length;i++)
        {
            AlphabetSet.Add(sentence[i]);   
        }
        
        return AlphabetSet.Count==26;
        
    }
}