namespace DSA;
public class MinStack_WithOneStack
{
    Stack<(int val, int minSoFar)> _st;
    public MinStack_WithOneStack() 
    { 
       _st = new Stack<(int val, int minSoFar)> ();    
    }

    public void Push(int val) 
    {

        if (_st.Count() == 0)
        {
            _st.Push((val, val));
        }
        else
        {
            var currMin = _st.Peek().minSoFar;
            var newMin = Math.Min(currMin, val);
            _st.Push((val, newMin));
        }            
    }

    public void Pop() 
    {
        if (_st.Count>0)
            _st.Pop();
        
    }

    public int Top() 
    {
        return _st.Peek().val;
    }

    public int GetMin() 
    { 
        if (_st.Count > 0)
            return _st.Peek().minSoFar; 
        return 0;
    }

}

public class MinStack_WithTwoStacks
{
    private Stack<int> stack;
    private Stack<int> minStack;

    public MinStack_WithTwoStacks()
    {
        stack = new Stack<int>();
        minStack = new Stack<int>();
    }

    public void Push(int val)
    {
        stack.Push(val);

        if (minStack.Count == 0 || val <= minStack.Peek())
        {
            minStack.Push(val);
        }
        else
        {
            minStack.Push(minStack.Peek());
        }
    }

    public void Pop()
    {
        stack.Pop();
        minStack.Pop();
    }

    public int Top()
    {
        return stack.Peek();
    }

    public int GetMin()
    {
        return minStack.Peek();
    }
}
public class TestMinStack
{
    public static void Test_MinStack_WithOneStack()
    {
        MinStack_WithOneStack minStack = new MinStack_WithOneStack();
        minStack.Push(-2);
        minStack.Push(0);
        minStack.Push(-3);
        int param_1 = minStack.GetMin(); // return -3
        minStack.Pop();
        int param_2 = minStack.Top();    // return 0
        int param_3 = minStack.GetMin(); // return -2
        Console.WriteLine($"param_1: {param_1} param_2: {param_2}, param_3: {param_3}");
    }
    public static void Test_MinStack_WithTwoStacks()
    {
        MinStack_WithTwoStacks minStack_2 = new MinStack_WithTwoStacks();
        minStack_2.Push(-2);
        minStack_2.Push(0);
        minStack_2.Push(-3);
        int param_4 = minStack_2.GetMin(); // return -3
        minStack_2.Pop();
        int param_5 = minStack_2.Top();    // return 0
        int param_6 = minStack_2.GetMin(); // return -2
        Console.WriteLine($"param_4: {param_4} param_5: {param_5}, param_6: {param_6}");
    }
}