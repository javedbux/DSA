

public class QueueUsingArray
{
    public int[] a;
    int capacity;
    public int rear;

    public QueueUsingArray(int capacity)
    {
        this.capacity = capacity;
        a = new int[capacity];
        rear = -1;
    }

    public void enqueue(int data)
    {
        if(rear == capacity-1)
        {
            return;
        }

        rear++;
        a[rear] = data;

    }

    public int dequeue()
    {
        if(rear ==-1)
            return -1;

        int result = a[0];
        for(int i=0; i < rear; i++)
        {
            a[i] = a[i +1];
        }
        rear --;
        return result;
    }

    public int GetFront()
    {
        if(rear == -1)
            return -1;
        return a[0];
    }
}