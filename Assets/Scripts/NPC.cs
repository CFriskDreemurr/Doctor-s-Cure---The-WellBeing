using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


[CreateAssetMenu(fileName = "NPC", menuName = "Scriptable Objects/NPC")]
public class NPC : ScriptableObject
{

    public string NPCName;

    public bool isAlive = true;

    public List<Sprite> NPCSprites;

    public List<NPCDialogue> dialogueList;

    public NPCDialogue currentDialogue;

    public Illness currentIllness;
    public Illness diagnosedIllness;
}
