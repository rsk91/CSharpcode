public class SpiralMatrix
{
    public static int[,] GetMatrix(int size)
    {
        int[,] a=new int[size,size];
        int cnt=1;
        int left=0, right=size-1, top=0, bottom=size-1;
        while(cnt<=size*size)
        {
            for(int i=left;i<=right;i++)
              a[top,i]=cnt++;
            top++;
            for(int i=top;i<=bottom;i++)
                a[i,right]=cnt++;
            right--;
            for(int i=right;i>=left;i--)
                a[bottom,i]=cnt++;
            bottom--;
            for(int i=bottom;i>=top;i--)
                a[i,left]=cnt++;
            left++;
        }
        return a; 
    }
}
