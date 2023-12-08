class Solution {
    public String simplifyPath(String path) {
        String[] folders=path.split(String.valueOf('/'));
        
        Stack<String> stack=new Stack<>();
        
        for(int i=0;i<folders.length;i++)
        {
           // System.out.println(folders[i]);
            if(folders[i].equals("."))
                continue;
            if(folders[i].equals("..") && stack.size()>0)
            {
                stack.pop();
            }
            else if(!folders[i].isEmpty() && !folders[i].equals(".."))
            {
                stack.push(folders[i]);
            }
        }
        
        String resultPath="";
        
        while(stack.size()>0)
        {
            resultPath="/"+stack.pop()+resultPath;
        }
        
        return resultPath.isEmpty() ? "/" : resultPath;
    }
}