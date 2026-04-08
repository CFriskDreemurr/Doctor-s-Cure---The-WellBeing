using System;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;

public class WindowQueue : MonoBehaviour
{
    public Queue<NPC> windowQueue = new Queue<NPC>();
    [SerializeField] private NPCManager npcManager;
    public bool isEvening = false;
    public void AddToQueue(NPC objectt)
    {
        if (!isEvening)
        {
            windowQueue.Enqueue(objectt);
            if (windowQueue.Count < 4)
            {
                npcManager.NewInQueue(objectt);
            }
        }
        }
    public void MoveQueue()
    {
        windowQueue.Dequeue();
    }
    public void ClearQueue()
    {
        windowQueue.Clear();
    }
    public void SpecialAdd(NPC npc)
    {
        windowQueue.Enqueue(npc);
    }
}

