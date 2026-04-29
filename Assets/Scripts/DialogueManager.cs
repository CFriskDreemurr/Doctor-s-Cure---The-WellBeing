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
    [SerializeField] private CameraScreenTransition cameraa;

    public NPC currentNPC;
    public NPCDialogue currentDialogue;

    void OnEnable()
    {
        currentNPC = manager.inQueue;
        currentDialogue = currentNPC.currentDialogue;
        cameraa.isAbleToMove = false;
        NewDialogue();
    }

    public void OnClickL()
    {
        if (currentDialogue.goInL)
        {
            progress.sickness += currentDialogue.sickL;
            progress.suspicion += currentDialogue.susL;
            currentNPC.currentDialogue = currentNPC.dialogueList[currentDialogue.dialogueL];
            manager.WindowToEvaluation();
            cameraa.isAbleToMove = true;
            this.gameObject.SetActive(false);
        }
        else if (currentDialogue.goAwayL)
        {
            progress.sickness += currentDialogue.sickL;
            progress.suspicion += currentDialogue.susL;
            currentNPC.currentDialogue = currentNPC.dialogueList[currentDialogue.dialogueL];
            manager.WindowGoAway();
            cameraa.isAbleToMove = true;
            this.gameObject.SetActive(false);
        }
        else
        {
            progress.sickness += currentDialogue.sickL;
            progress.suspicion += currentDialogue.susL;
            currentNPC.currentDialogue = currentNPC.dialogueList[currentDialogue.dialogueL];
            currentDialogue = currentNPC.dialogueList[currentDialogue.dialogueL];
            NewDialogue();
        }
    }
    public void OnClickR()
    {
        if (currentDialogue.goInR)
        {
            progress.sickness += currentDialogue.sickR;
            progress.suspicion += currentDialogue.susR;
            currentNPC.currentDialogue = currentNPC.dialogueList[currentDialogue.dialogueR];
            manager.WindowToEvaluation();
            cameraa.isAbleToMove = true;
            this.gameObject.SetActive(false);
        }
        else if (currentDialogue.goAwayR)
        {
            progress.sickness += currentDialogue.sickR;
            progress.suspicion += currentDialogue.susR;
            currentNPC.currentDialogue = currentNPC.dialogueList[currentDialogue.dialogueR];
            manager.WindowGoAway();
            cameraa.isAbleToMove = true;
            this.gameObject.SetActive(false);
        }
        else
        {
            progress.sickness += currentDialogue.sickR;
            progress.suspicion += currentDialogue.susR;
            currentNPC.currentDialogue = currentNPC.dialogueList[currentDialogue.dialogueR];
            currentDialogue = currentNPC.dialogueList[currentDialogue.dialogueR];
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
