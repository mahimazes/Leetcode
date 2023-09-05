public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        
        Dictionary<char,int> map=new Dictionary<char,int>();
        
        for(int i=0;i<magazine.Length;i++)
        {
            if(map.ContainsKey(magazine[i]))
            {
                map[magazine[i]]++;
            }
            else
                map.Add(magazine[i],1);
        }
        
        for(int i=0;i<ransomNote.Length;i++)
        {
            if(map.ContainsKey(ransomNote[i]))
            {
                if(map[ransomNote[i]]==1)
                {
                    map.Remove(ransomNote[i]);
                }
                else
                {
                    map[ransomNote[i]]--;
                }
            }
            else
            {
                return false;
            }
        }
        
        return true;
    }
}