class Mutation
{
    String currGene;
    int steps;
    
    public Mutation(String Gene,int step)
    {
        currGene=Gene;
        steps=step;
    }
}

class Solution {
    
     HashSet<String> seen=new HashSet<>();
    
    public boolean getDiff(String str1,String str2)
    {
        int diffChar=0;
        for(int i=0;i<str1.length();i++)
        {
            if(str1.charAt(i)!=str2.charAt(i))
            {
                diffChar++;
            }
        }
        
        return diffChar==1;
    }
    
    public int minMutation(String startGene, String endGene, String[] bank) {
        
        HashMap<String, List<String>> map=new HashMap<>();
        
        if(bank.length==0)
            return -1;
        
        for(int i=0;i<bank.length;i++)
        {
            for(int j=0;j<bank.length;j++)
            {
                if(getDiff(bank[i],bank[j]))
                {
                    if(!map.containsKey(bank[i]))
                    {
                        map.put(bank[i],new ArrayList<String>());
                    }
                    if(!map.containsKey(bank[j]))
                    {
                        map.put(bank[j],new ArrayList<String>());
                    }
                    
                    map.get(bank[i]).add(bank[j]);
                    map.get(bank[j]).add(bank[i]);
                    
                }
            }
        }
        
        for(int i=0;i<bank.length;i++)
        {
            if(getDiff(bank[i],startGene))
            {
                if(!map.containsKey(startGene))
                {
                    map.put(startGene,new ArrayList<String>());
                }
                
                if(!map.containsKey(bank[i]))
                {
                    map.put(bank[i],new ArrayList<String>());
                }
                
                map.get(startGene).add(bank[i]);
                map.get(bank[i]).add(startGene);
            }
        }
        
       
        //seen.add(startGene);
        //dfs(startGene, endGene, map);
        
        Stack<Mutation> stack=new Stack<>();
        
        stack.add(new Mutation(startGene,0));
        
        while(stack.size()>0)
        {
            Mutation curr=stack.pop();
            //System.out.println(curr.currGene);
            for(String gene: map.get(curr.currGene))
            {
                if(!seen.contains(gene))
                {
                    seen.add(gene);
                    stack.push(new Mutation(gene,curr.steps+1));
                   // System.out.println(curr.currGene+"-"+gene);

                    if(gene.equals(endGene))
                        return curr.steps+1;
                }
            }
        }
        
        return -1;
    }
    
}
