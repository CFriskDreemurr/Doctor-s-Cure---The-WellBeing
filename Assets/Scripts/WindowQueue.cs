using System;
using System.Collections.Generic;
using UnityEngine;

public class WindowQueue : MonoBehaviour
{
    public Queue<GameObject> windowQueue = new Queue<GameObject>();
    public void AddToQueue(GameObject objectt)
    {
        windowQueue.Enqueue(objectt);
    }
    public void MoveQueue()
    {
        windowQueue.Dequeue();
    }

    internal void AddToQueue(Func<GameObject> gameObject)
    {
        Debug.Log("huh");
        Debug.Log(gameObject);
    }
}

