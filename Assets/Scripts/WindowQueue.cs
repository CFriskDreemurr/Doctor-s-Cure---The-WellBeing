using System;
using System.Collections.Generic;
using UnityEngine;

public class WindowQueue : MonoBehaviour
{
    public Queue<NPC> windowQueue = new Queue<NPC>();
    [SerializeField] private NPCManager npcManager;
    public void AddToQueue(NPC objectt)
    {
        windowQueue.Enqueue(objectt);
        if (windowQueue.Count < 4) {
            npcManager.NewInQueue(objectt);
        }
    }
    public void MoveQueue()
    {
        windowQueue.Dequeue();
    }

    
}

