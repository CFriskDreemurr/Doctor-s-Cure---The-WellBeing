using System.Collections;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    private DayQueue todayQueue;
    [SerializeField] private DayQueue day1Queue;
    [SerializeField] private DayQueue day2Queue;
    [SerializeField] private WindowQueue daQueue;
    [SerializeField] private int nrOfCycles;
    [SerializeField] private float cycleLenght;
    private int daCounter;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        todayQueue = day1Queue;
        StartDay();
        
    }
    public void StartDay()
    {
        daQueue.AddToQueue(todayQueue.dailyQueue[0]);
        daQueue.AddToQueue(todayQueue.dailyQueue[1]);
        daQueue.AddToQueue(todayQueue.dailyQueue[2]);
        daCounter = 3;
        StartCoroutine(DayCycle());

    }
    public void EndDay()
    {
        Debug.Log("Da Day Haths Ended.");
    }
    IEnumerator DayCycle()
    {
        for (int i = 0; i < nrOfCycles; i++)
        {
            yield return new WaitForSeconds(cycleLenght);
            if (daCounter < todayQueue.dailyQueue.Count)
            {
                daQueue.AddToQueue(todayQueue.dailyQueue[daCounter]);
            }
            else
            {
                Debug.Log("hihi");
            }
                daCounter += 1;
        }
        EndDay();
    }
}
