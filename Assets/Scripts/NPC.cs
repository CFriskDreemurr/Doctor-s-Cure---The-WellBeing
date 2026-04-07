using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


[CreateAssetMenu(fileName = "NPC", menuName = "Scriptable Objects/NPC")]
public class NPC : ScriptableObject
{

    public string NPCName;

    public List<Sprite> NPCSprites;

    public List<NPCDialogue> dialogueList;

    public NPCDialogue currentDialogue;
}
