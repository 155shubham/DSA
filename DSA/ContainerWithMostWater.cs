namespace src;
public class ContainerWithMostWater
{
    public static int MaxArea(int[] height)
    {
        int maxArea = 0;
        int j = height.Length - 1;
        int i = 0;
        while (i < j)
        {
            maxArea = Math.Max(maxArea, Math.Min(height[i], height[j]) * (j - i));
            if (height[i] < height[j])
                i++;
            else
                j--;
        }

        return 0;
    }

    public static void TestMaxArea()
    {
        var res = MaxArea(new int[] {5,4,3,2});
    }
}
