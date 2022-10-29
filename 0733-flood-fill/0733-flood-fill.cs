public class Solution {
    public int[][] FloodFill(int[][] image, int sr, int sc, int color) {
        
        int oldValue=image[sr][sc];
        //image[sr][sc]=color;
        if(color!=oldValue)
            RecursiveFloodFill(image,sr,sc,color,oldValue);
        
        return image;
        
    }
    
    public void RecursiveFloodFill(int[][] image, int sr,int sc,int color,int oldValue)
    {
        if(image[sr][sc]!=oldValue || sr>=image.Length ||sc>=image[0].Length || sr<0 ||sc<0)
            return;
        
        if(image[sr][sc]==oldValue)
        {
            image[sr][sc]=color;
            
            if(sr>=1)
                RecursiveFloodFill(image,sr-1,sc,color,oldValue);
            if(sc>=1)
                RecursiveFloodFill(image,sr,sc-1,color,oldValue);
            if(sr<image.Length-1)
                RecursiveFloodFill(image,sr+1,sc,color,oldValue);
            if(sc<image[0].Length-1)
             RecursiveFloodFill(image,sr,sc+1,color,oldValue);
        }
    }
}