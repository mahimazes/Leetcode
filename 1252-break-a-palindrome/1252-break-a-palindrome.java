class Solution {
    public String breakPalindrome(String palindrome) {
        
        StringBuilder sb=new StringBuilder();

        if(palindrome.length()<=1)
            return sb.toString();

        sb.append(palindrome);

        boolean onlya=true;
        for(int i=0;i<palindrome.length()/2;i++)
        {
            if(palindrome.charAt(i)!='a')
            {
                onlya=false;
                sb.replace(i,i+1,"a");
                break;
            }
        }

        if(onlya)
        {
            sb.replace(palindrome.length()-1,palindrome.length(),"b");
        }

        return sb.toString();
    }
}