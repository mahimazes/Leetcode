public class Solution {
    
    public struct PricePair
    {
       public int minPrice=0;
       public int maxPrice=0;
    }
    
    static int profit=0;
    
    public PricePair RecursiveMaxProfit(int[] prices,int start,int end)
    {
        PricePair fh,sh;
        
        if(start==end)
        {
            PricePair d=new PricePair();
            d.minPrice=prices[start];
            d.maxPrice=prices[end];
          
            
            return d;
        }
        
        int mid=(start+end)/2;
        
        //find min max in first half
        fh=RecursiveMaxProfit(prices,start,mid);
        
        //find min max in second half
        sh=RecursiveMaxProfit(prices,mid+1,end);
        
        //compare and find profit;
        if(sh.maxPrice-fh.minPrice>profit)
        {
            profit= sh.maxPrice-fh.minPrice;
        }
        
        PricePair result=new PricePair();
        
        result.minPrice=Math.Min(fh.minPrice,sh.minPrice);
        result.maxPrice=Math.Max(fh.maxPrice,sh.maxPrice);
        
        return result;
        //return min max from both first and second half
        
    }
    
    public int MaxProfit(int[] prices) {
        
        PricePair result=new PricePair();
        
        profit=0;
        
        result=RecursiveMaxProfit(prices,0,prices.Length-1);
    
        return profit;
        
    }
}