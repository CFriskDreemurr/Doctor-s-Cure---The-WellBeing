using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DayQueue", menuName = "Scriptable Objects/DayQueue")]
public class DayQueue : ScriptableObject
{
    [SerializeField] public List<NPC> dailyQueue;
}
