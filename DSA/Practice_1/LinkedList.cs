namespace src.Practice_1;

//head -> 10 -> 20 -> 30 -> null
public class CustomLinkedList
{
    private Node lastNode;
    private Node headNode;
    public CustomLinkedList()
    {
        headNode = new Node(0);
        lastNode = headNode;
    }
    public void AddNewNode(int data)
    {
        Node newNode = new Node(data);
        lastNode.Next = newNode;
        lastNode = newNode;
    }

    public bool DeleteNode(int data)
    {
        Node prevNode = headNode;
        Node currNode = headNode.Next;
        while (currNode != null)
        {
            if (currNode.Data == data)
            {
                prevNode.Next = currNode.Next;
                if (currNode == lastNode)
                {
                    lastNode = prevNode;
                }
                return true;
            }
            prevNode = currNode;
            currNode = currNode.Next;
        }
        return false;
    }

    public Node GetNode(int data)
    {
        Node curNode = headNode.Next;
        while (curNode != null)
        {
            if (curNode.Data == data)
            {
                return curNode;
            }
            curNode = curNode.Next;
        }
        return null;
    }

    public Node UpdateNode(int prevData, int newData)
    {
        Node curNode = headNode.Next;
        while (curNode != null)
        {
            if (curNode.Data == prevData)
            {
                curNode.Data = newData;
                return curNode;
            }
            curNode = curNode.Next;
        }
        return null;
    }

    public Node ReverseLinkedList()
    {
        Node prevNode = null;
        Node currNode = headNode.Next;

        Node oldHead = currNode;

        while (currNode != null)
        {
            Node nextNode = currNode.Next;
            currNode.Next = prevNode;
            prevNode = currNode;
            currNode = nextNode;
        }
        headNode.Next = prevNode;
        lastNode = oldHead;
        return headNode.Next;
    }
}

public class Node
{
    public int Data { get; set; }
    public Node Next { get; set; }

    public Node(int data)
    {
        Data = data;
        Next = null;
    }

}