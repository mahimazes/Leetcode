class Solution {
    public boolean badCharPair(char a, int b)
    {
        return (((Character.isUpperCase(a) && Character.isLowerCase(b)) || (Character.isLowerCase(a) && Character.isUpperCase(b))) && Character.toLowerCase(a)==Character.toLowerCase(b));
    }
    public String makeGood(String s) {
        
        StringBuilder stack=new StringBuilder();
        
        stack.append(s.charAt(0));
        for(int i=1;i<s.length();i++)
        {
            if(stack.length()>0 && badCharPair(stack.charAt(stack.length()-1),s.charAt(i)))
            {
                stack.deleteCharAt(stack.length()-1);
            }
            else
                stack.append(s.charAt(i));
        }
        
        return stack.toString();
    }
}