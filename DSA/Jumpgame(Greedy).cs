namespace DSA;
public class Jumpgame_Greedy
{
    public static bool CanJump(int[] nums)
    {
       int maxReach = 0;
       for (int i = 0; i < nums.Length-1; i++)
       {
            if (i > maxReach)
                return false;

            maxReach = Math.Max(maxReach, i+ nums[i]);
           if (maxReach >= nums.Length - 1)
                return true;
        }
       return false;
    }

    public static void TestCanJump()
    {
        Console.WriteLine("TestCanJump Result");
        //var res = CanJump(new int[] {1, 2, 0});
        //var res = CanJump(new int[] { 1, 0, 2 });
        //var res = CanJump(new int[] { 2, 0, 1, 0 });
        var res = CanJump(new int[] { 1, 0, 2, 0 });
        Console.WriteLine(res);        
    }
}
