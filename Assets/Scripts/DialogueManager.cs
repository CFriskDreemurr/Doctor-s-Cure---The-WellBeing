using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    [SerializeField] private NPCManager manager;
    [SerializeField] private TMP_Text DialogueText;
    [SerializeField] private TMP_Text buttonLText;
    [SerializeField] private TMP_Text buttonRText;
    [SerializeField] private Progress progress;

    public NPC currentNPC;
    public NPCDialogue currentDialogue;

    void OnEnable()
    {
        currentNPC = manager.inQueue;
        currentDialogue = currentNPC.currentDialogue;
        NewDialogue();
    }

    public void OnClickL()
    {
        if (currentDialogue.goInL)
        {
            currentNPC.currentDialogue = currentNPC.dialogueList[currentDialogue.dialogueL];
            progress.sickness += currentDialogue.sickL;
            progress.suspicion += currentDialogue.susL;
            manager.WindowToEvaluation();
            this.gameObject.SetActive(false);
        }
        else if (currentDialogue.goAwayL)
        {
            currentNPC.currentDialogue = currentNPC.dialogueList[currentDialogue.dialogueL];
            progress.sickness += currentDialogue.sickL;
            progress.suspicion += currentDialogue.susL;
            manager.WindowGoAway();
            this.gameObject.SetActive(false);
        }
        else
        {
            currentNPC.currentDialogue = currentNPC.dialogueList[currentDialogue.dialogueL];
            currentDialogue = currentNPC.dialogueList[currentDialogue.dialogueL];
            progress.sickness += currentDialogue.sickL;
            progress.suspicion += currentDialogue.susL;
            NewDialogue();
        }
    }
    public void OnClickR()
    {
        if (currentDialogue.goInR)
        {
            currentNPC.currentDialogue = currentNPC.dialogueList[currentDialogue.dialogueR];
            progress.sickness += currentDialogue.sickR;
            progress.suspicion += currentDialogue.susR;
            manager.WindowToEvaluation();
            this.gameObject.SetActive(false);
        }
        else if (currentDialogue.goAwayR)
        {
            currentNPC.currentDialogue = currentNPC.dialogueList[currentDialogue.dialogueR];
            progress.sickness += currentDialogue.sickR;
            progress.suspicion += currentDialogue.susR;
            manager.WindowGoAway();
            this.gameObject.SetActive(false);
        }
        else
        {
            currentNPC.currentDialogue = currentNPC.dialogueList[currentDialogue.dialogueR];
            currentDialogue = currentNPC.dialogueList[currentDialogue.dialogueR];
            progress.sickness += currentDialogue.sickR;
            progress.suspicion += currentDialogue.susR;
            NewDialogue();
        }
    }
    public void NewDialogue()
    {
        DialogueText.text = currentDialogue.text;
        buttonLText.text = currentDialogue.optionL;
        buttonRText.text = currentDialogue.optionR;
    }
}
