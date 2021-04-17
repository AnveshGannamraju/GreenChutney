using System;
using System.Collections.Generic;
public class MessageFIFOQueue : IMessageFIFOQueue
{
    private List<FIFOMessage> ParentQueue;
    public MessageFIFOQueue()
    {
        ParentQueue = new List<FIFOMessage>();
    }

    public FIFOMessage ReadMessage(string messageHeader)
    {
        FIFOMessage returnMessage = ParentQueue[0];
        ParentQueue.Remove(returnMessage);
        return returnMessage;
    }
    public QueueResponse WriteMessage(FIFOMessage fifoMessage)
    {
        ParentQueue.Add(fifoMessage);
        return QueueResponse.Success;
    }
    public int _countMessagesInQueue(string messageHeader)
    {
        return ParentQueue.Count;
    }

    public int ClearQueue()
    {
        ParentQueue.Clear();
        return 1;
    }

}
public class FIFOMessage
{
    public DateTime messageTime { get; set; }
    public dynamic messageBody { get; set; }
    public dynamic messageHeader { get; set; }
}

public interface IMessageFIFOQueue
{
    public FIFOMessage ReadMessage(string messageHeader);
    public QueueResponse WriteMessage(FIFOMessage fifoMessage);
    public int _countMessagesInQueue(string messageHeader);
    public int ClearQueue();
}

public enum QueueResponse
{
    Success = 1,
    Failed = 2
}
