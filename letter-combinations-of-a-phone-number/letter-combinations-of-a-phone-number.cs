public class Solution {

        Dictionary<char,string> map=new Dictionary<char,string>();

        List<string> result=new List<string>();  


    public IList<string> LetterCombinations(string digits) {
        
                
        map.Add('2',"abc");
        map.Add('3',"def");
        map.Add('4',"ghi");
        map.Add('5',"jkl");
        map.Add('6',"mno");
        map.Add('7',"pqrs");
        map.Add('8',"tuv");
        map.Add('9',"wxyz");

        BackTrack(0,"",digits.ToCharArray());
        return result;
    
    }

    public void BackTrack(int index, string comb,char[] digit)
    {
        if(digit.Length==0)
        {
            return;
        }

        char[] combarr=comb.ToCharArray();

        if(digit.Length==combarr.Length)
        {
            result.Add(comb);
            return;
        }

        char[] digitarr=map[digit[index]].ToCharArray();

        foreach(var c in digitarr)
        {
            BackTrack(index+1,comb+c,digit);
        }
    }

}
/*
public class Solution {

        Dictionary<char,string> map=new Dictionary<char,string>();



    public IList<string> LetterCombinations(string digits) {
        
                
        map.Add('2',"abc");
        map.Add('3',"def");
        map.Add('4',"ghi");
        map.Add('5',"jkl");
        map.Add('6',"mno");
        map.Add('7',"pqrs");
        map.Add('8',"tuv");
        map.Add('9',"wxyz");

        /*List<string> result=new List<string>();
        char[] digitArray=digits.ToCharArray();
        string first;

        if(digits.Length>0 && map.ContainsKey(digitArray[0]))
        {
             first=map[digitArray[0]];
        }
        else
        {
            return result;
        }

        if(digits.Length==1)
        {
            return map[digitArray[0]].ToCharArray().Select( c => c.ToString()).ToList();
        }

        IEnumerable<String> combo=new List<String>();
        for(int i=1;i<digitArray.Length;i++)
        {
            combo=GetStringCombo(first,map[digitArray[i]]);
            Console.WriteLine(map[digitArray[i]]);
           // result.Add(combo.ToString());
        }

        return combo.ToList();
    
    }

    public IEnumerable<string> GetStringCombo(string s1,string s2)
    {
        char[] s1Array=s1.ToCharArray();
        char[] s2Array=s2.ToCharArray();

        for(int i=0;i<s1Array.Length;i++)
        {
            for(int j=0;j<s2Array.Length;j++)
            {
                yield return s1Array[i]+""+s2Array[j];
            }
        }
    }
}*/
/*
public class Solution {

    Dictionary<int, string> dictionary = new Dictionary<int, string>
            {
                {2, "abc"},
                {3, "def"},
                {4, "ghi"},
                {5, "jkl"},
                {6, "mno"},
                {7, "pqrs"},
                {8, "tuv"},
                {9, "wxyz"}
            };

    public IList<string> LetterCombinations(string digits) {
        
        if(string.IsNullOrEmpty(digits))
            return Array.Empty<string>();

        var prev = ToStringArray(digits, 0);

        if(digits.Length == 1)
        {
            return prev.ToList();
        }

        for(int i = 1; i < digits.Length; i++)
        {
            prev = Combine(prev, ToStringArray(digits, i));
        }

        return prev.ToList();
    }

    private IEnumerable<string> ToStringArray(string digits, int p)
    {
        return dictionary[digits[p] - '0'].Select(x => x.ToString());
    }

    private IEnumerable<string> Combine(IEnumerable<string> str1, IEnumerable<string> str2)
    {
    	var arr1 = str1.ToArray();
	    var arr2 = str2.ToArray();
	    for (int i = 0; i < arr1.Length; i++)
		    for (int j = 0; j < arr2.Length; j++)
			    yield return arr1[i] + arr2[j];
    }
}*/