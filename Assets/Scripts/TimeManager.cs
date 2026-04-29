using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    private DayQueue todayQueue;
    public List<DayQueue> queueList;
    [SerializeField] private WindowQueue daQueue;
    [SerializeField] private int nrOfCycles;
    [SerializeField] private float cycleLenght;
    [SerializeField] private NPCManager npcManager;
    [SerializeField] private GameObject endDayCanvas;
    [SerializeField] private CameraScreenTransition cameraa;
    [SerializeField] private DrugManager drugManager;
    private int daCounter;
    private int dayNr = 0;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartDay();
        
    }
    public void StartDay()
    {
        dayNr += 1;
        todayQueue = queueList[dayNr - 1];
        endDayCanvas.SetActive(false);
        daQueue.ClearQueue();
        daQueue.AddToQueue(todayQueue.dailyQueue[0]);
        daQueue.AddToQueue(todayQueue.dailyQueue[1]);
        daQueue.AddToQueue(todayQueue.dailyQueue[2]);
        daCounter = 3;
        cameraa.isAbleToMove = true;
        cameraa.MoveToScreen(1);
        drugManager.UpdateDrugz();
        StartCoroutine(DayCycle());

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
        Debug.Log("Da Evening Haths Came.");
        npcManager.Evening();
    }
}
