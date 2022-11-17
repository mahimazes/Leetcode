public class Solution {
    public string Multiply(string num1, string num2) {
     
        int[] result=new int[num1.Length+num2.Length+1];
        
        if(num1=="0" || num2=="0")
            return "0";
        
        int temp=0,n2=0,n1=0;
        char[] na1=num1.ToCharArray();
        char[] na2=num2.ToCharArray();
        Array.Reverse(na1);
        Array.Reverse(na2);
        
        num1=string.Join("",na1);
        num2=string.Join("",na2);
               
        for(int i=0;i<num2.Length;i++)
        {
            for(int j=0;j<num1.Length;j++)
            {
                int.TryParse(num2[i].ToString(), out n2); 
                int.TryParse(num1[j].ToString(), out n1);
                temp=n1*n2;
                result[i+j]+=temp;
                result[i+j+1]+=result[i+j]/10;
                result[i+j]=result[i+j]%10;
            }
        }
        
        Array.Reverse(result);
        
        return string.Concat(result).TrimStart('0');
    }
}