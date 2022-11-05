public class Solution {
    public string GetHint(string secret, string guess) {
        
        Dictionary<int,int> secretDict=new Dictionary<int,int>();
        Dictionary<int,int> guessDict=new Dictionary<int,int>();
        
        for(int i=0;i<secret.Length;i++)
        {
            if(secretDict.ContainsKey(secret[i]))
            {
                secretDict[secret[i]]++;
            }
            else
            {
                secretDict.Add(secret[i],1);
            }
        }
        
        int correct=0;
        int wrong=0;
        
        for(int i=0;i<guess.Length;i++)
        {
            if(secretDict.ContainsKey(guess[i]))
            {
               // if(secretDict.Where(x=> x.Value==guess[i] && x.Key==i).Any())
                if(guess[i]==secret[i])
                {
                    correct++;
                    
                    if(secretDict[guess[i]]<=0)
                    {
                        wrong--;
                    }
                    
                }
                else
                {
                    if(secretDict[guess[i]]>0)
                        wrong++;
                }

                    secretDict[guess[i]]--;
                
            }
        }
        
        return correct+"A"+wrong+"B";
    }
}