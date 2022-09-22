
public class QueueWithCircularArray
{
    public int[] arr ;
    public int size;
    public int rear = -1;
    public int front = -1;

    public QueueWithCircularArray(int size)
    {
        arr = new int[size];
        this.size = size;

    }

    public bool IsEmpty()
    {
        return rear == -1 & front == -1;
    }
    //EnQueue
    public void enqueue(int data)
    {
        if((rear+1)% size == front)
        {
            return;
        }
        if(front == -1)
        {
            front = 0;
        }
        rear = (rear+1) %size;

        arr[rear] = data;
    }

//DeQueue
    public int dequeue()
    {
        if(front == -1)
        {
            return -1;
        }

        int ans = arr[front];

        if(front == rear)
        {
            front = rear = -1;
        }
        else 
            front = (front + 1) % size;

        return ans;
    }

    public int GetFront()
    {
        if(rear ==-1 && front == -1)
            return -1;

        return arr[front];
    }
}