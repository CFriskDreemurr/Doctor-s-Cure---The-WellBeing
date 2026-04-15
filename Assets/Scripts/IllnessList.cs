using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "IllnessList", menuName = "Scriptable Objects/IllnessList")]
public class IllnessList : ScriptableObject
{
    [SerializeField] public List<Illness> illnessList;
}
