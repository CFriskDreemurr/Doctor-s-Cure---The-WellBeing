using System;
using System.Collections.Generic;
using UnityEngine;

public class WindowQueue : MonoBehaviour
{
    public Queue<NPC> windowQueue = new Queue<NPC>();
    public void AddToQueue(NPC objectt)
    {
        windowQueue.Enqueue(objectt);
    }
    public void MoveQueue()
    {
        windowQueue.Dequeue();
    }

    
}

