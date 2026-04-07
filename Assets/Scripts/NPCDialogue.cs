using UnityEngine;

[CreateAssetMenu(fileName = "NPCDialogue", menuName = "Scriptable Objects/NPCDialogue")]
public class NPCDialogue : ScriptableObject
{
    public string text;
    public int dialogueL;
    public int dialogueR;
    public string optionL;
    public string optionR;
    public bool goAwayL;
    public bool goAwayR;
    public bool goInL;
    public bool goInR;
}
