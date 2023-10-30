class Solution {
    public int numPairsDivisibleBy60(int[] time) {
        
        for(int i=0;i<time.length;i++)
        {
            time[i]=time[i]%60;
        }

        HashMap<Integer,Integer> map=new HashMap<Integer,Integer>();

        int count=0;
        for(int i=0;i<time.length;i++)
        {
            int rem=60-time[i];
            //if(!map.containsKey(rem))
            //{
            //}
            if(map.containsKey(rem))
            {
                count=count+map.get(rem);
            }

            if(time[i] != 0)
                map.put(time[i], map.getOrDefault(time[i], 0) + 1);
            else
                map.put(60, map.getOrDefault(60, 0) + 1);

        }

        return count;
    }
}