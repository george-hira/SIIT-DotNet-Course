Queue<string> messageQueue = new Queue<string>();

// add messages to the queue
messageQueue.Enqueue("message1");
messageQueue.Enqueue("message2");
messageQueue.Enqueue("message3");
messageQueue.Enqueue("message4");

Console.WriteLine("Peek the first element in the queue is: " + messageQueue.Peek());


// cum parcurgem un queue

while(messageQueue.Count > 0)
{
    var nextInLine = messageQueue.Dequeue();
    // sterge si returneaza obiectul de la inceputul cozii

    Console.WriteLine($"next in line is: {messageQueue.Dequeue()}");
}

