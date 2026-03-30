using UnityEngine;

public class newInQueueTest : MonoBehaviour
{
    [SerializeField] private WindowQueue queue;
    [SerializeField] private NPC target;

    private void OnMouseDown()
    {
        queue.AddToQueue(target);
    }
}
