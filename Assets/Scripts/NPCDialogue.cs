using UnityEngine;

[CreateAssetMenu(fileName = "NPCDialogue", menuName = "Scriptable Objects/NPCDialogue")]
public class NPCDialogue : ScriptableObject
{
    public string text;
    public int dialogue1;
    public int dialogue2 = -1;
    public int dialogue3 = -1;
    public int dialogue4 = -1;
    public string option1;
    public string option2;
    public string option3;
    public string option4;
    public bool goAway1;
    public bool goAway2;
    public bool goAway3;
    public bool goAway4;
    public bool goIn1;
    public bool goIn2;
    public bool goIn3;
    public bool goIn4;
    public float sick1;
    public float sick2;
    public float sick3;
    public float sick4;
    public float sus1;
    public float sus2;
    public float sus3;
    public float sus4;
}
