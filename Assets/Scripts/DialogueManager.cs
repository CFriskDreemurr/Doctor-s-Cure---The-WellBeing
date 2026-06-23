using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    [SerializeField] private NPCManager manager;
    [SerializeField] private TMP_Text DialogueText;
    [SerializeField] private TMP_Text button1Text;
    [SerializeField] private TMP_Text button2Text;
    [SerializeField] private TMP_Text button3Text;
    [SerializeField] private TMP_Text button4Text;
    [SerializeField] private Button button2;
    [SerializeField] private Button button3;
    [SerializeField] private Button button4;

    [SerializeField] private Progress progress;
    [SerializeField] private CameraScreenTransition cameraa;

    public NPC currentNPC;
    public NPCDialogue currentDialogue;

    void OnEnable()
    {
        if (manager.currentScene == 1)
        {
            currentNPC = manager.currentNPC;
            currentDialogue = currentNPC.currentDialogue;
            cameraa.isAbleToMove = false;
            NewDialogue();
        }
        else if (manager.currentScene == 2)
        {
            currentNPC = manager.currentNPC;
            currentDialogue = currentNPC.currentDialogue2;
            cameraa.isAbleToMove = false;
            NewDialogue();
        }
    }
    public void Close()
    {
        cameraa.isAbleToMove = true;
        this.gameObject.SetActive(false);
    }
    public void OnClick1()
    {
        if (manager.currentScene == 1)
        {
            if (currentDialogue.goIn1 && manager.currentScene == 1)
            {
                progress.sickness += currentDialogue.sick1;
                progress.suspicion += currentDialogue.sus1;
                currentNPC.currentDialogue = currentNPC.dialogueList[currentDialogue.dialogue1];
                manager.WindowToEvaluation();
                cameraa.isAbleToMove = true;
                this.gameObject.SetActive(false);
            }
            else if (currentDialogue.goAway1 && manager.currentScene == 1)
            {
                progress.sickness += currentDialogue.sick1;
                progress.suspicion += currentDialogue.sus1;
                currentNPC.currentDialogue = currentNPC.dialogueList[currentDialogue.dialogue1];
                manager.WindowGoAway();
                cameraa.isAbleToMove = true;
                this.gameObject.SetActive(false);
            }
            else
            {
                progress.sickness += currentDialogue.sick1;
                progress.suspicion += currentDialogue.sus1;
                currentNPC.currentDialogue = currentNPC.dialogueList[currentDialogue.dialogue1];
                currentDialogue = currentNPC.dialogueList[currentDialogue.dialogue1];
                NewDialogue();
            }
        }
        else if (manager.currentScene == 2)
        {
            progress.sickness += currentDialogue.sick1;
            progress.suspicion += currentDialogue.sus1;
            currentNPC.currentDialogue = currentNPC.dialogueList2[currentDialogue.dialogue1];
            currentDialogue = currentNPC.dialogueList2[currentDialogue.dialogue1];
            if (currentDialogue.goAway1)
            {
                cameraa.isAbleToMove = true;
                this.gameObject.SetActive(false);
            }
            else { NewDialogue(); }
            
        }
    }
    public void OnClick2()
    {
        if (manager.currentScene == 1)
        {
            if (currentDialogue.goIn2 && manager.currentScene == 1)
            {
                progress.sickness += currentDialogue.sick2;
                progress.suspicion += currentDialogue.sus2;
                currentNPC.currentDialogue = currentNPC.dialogueList[currentDialogue.dialogue2];
                manager.WindowToEvaluation();
                cameraa.isAbleToMove = true;
                this.gameObject.SetActive(false);
            }
            else if (currentDialogue.goAway2 && manager.currentScene == 1)
            {
                progress.sickness += currentDialogue.sick2;
                progress.suspicion += currentDialogue.sus2;
                currentNPC.currentDialogue = currentNPC.dialogueList[currentDialogue.dialogue2];
                manager.WindowGoAway();
                cameraa.isAbleToMove = true;
                this.gameObject.SetActive(false);
            }
            else
            {
                progress.sickness += currentDialogue.sick2;
                progress.suspicion += currentDialogue.sus2;
                currentNPC.currentDialogue = currentNPC.dialogueList[currentDialogue.dialogue2];
                currentDialogue = currentNPC.dialogueList[currentDialogue.dialogue2];
                NewDialogue();
            }
        }
        else if (manager.currentScene == 2)
        {
            progress.sickness += currentDialogue.sick2;
            progress.suspicion += currentDialogue.sus2;
            currentNPC.currentDialogue = currentNPC.dialogueList2[currentDialogue.dialogue2];
            currentDialogue = currentNPC.dialogueList2[currentDialogue.dialogue2];
            if (currentDialogue.goAway2)
            {
                cameraa.isAbleToMove = true;
                this.gameObject.SetActive(false);
            }
            else { NewDialogue(); }

        }
    }
        public void OnClick3()
    {
        if (manager.currentScene == 1)
        {
            if (currentDialogue.goIn3 && manager.currentScene == 1)
            {
                progress.sickness += currentDialogue.sick3;
                progress.suspicion += currentDialogue.sus3;
                currentNPC.currentDialogue = currentNPC.dialogueList[currentDialogue.dialogue3];
                manager.WindowToEvaluation();
                cameraa.isAbleToMove = true;
                this.gameObject.SetActive(false);
            }
            else if (currentDialogue.goAway3 && manager.currentScene == 1)
            {
                progress.sickness += currentDialogue.sick3;
                progress.suspicion += currentDialogue.sus3;
                currentNPC.currentDialogue = currentNPC.dialogueList[currentDialogue.dialogue3];
                manager.WindowGoAway();
                cameraa.isAbleToMove = true;
                this.gameObject.SetActive(false);
            }
            else
            {
                progress.sickness += currentDialogue.sick3;
                progress.suspicion += currentDialogue.sus3;
                currentNPC.currentDialogue = currentNPC.dialogueList[currentDialogue.dialogue3];
                currentDialogue = currentNPC.dialogueList[currentDialogue.dialogue3];
                NewDialogue();
            }
        }
        else if (manager.currentScene == 2)
        {
            progress.sickness += currentDialogue.sick3;
            progress.suspicion += currentDialogue.sus3;
            currentNPC.currentDialogue = currentNPC.dialogueList2[currentDialogue.dialogue3];
            currentDialogue = currentNPC.dialogueList2[currentDialogue.dialogue3];
            if (currentDialogue.goAway3)
            {
                cameraa.isAbleToMove = true;
                this.gameObject.SetActive(false);
            }
            else { NewDialogue(); }

        }
    }
    public void OnClick4()
    {
        if (manager.currentScene == 1)
        {
            if (currentDialogue.goIn4 && manager.currentScene == 1)
            {
                progress.sickness += currentDialogue.sick4;
                progress.suspicion += currentDialogue.sus4;
                currentNPC.currentDialogue = currentNPC.dialogueList[currentDialogue.dialogue4];
                manager.WindowToEvaluation();
                cameraa.isAbleToMove = true;
                this.gameObject.SetActive(false);
            }
            else if (currentDialogue.goAway4 && manager.currentScene == 1)
            {
                progress.sickness += currentDialogue.sick4;
                progress.suspicion += currentDialogue.sus4;
                currentNPC.currentDialogue = currentNPC.dialogueList[currentDialogue.dialogue4];
                manager.WindowGoAway();
                cameraa.isAbleToMove = true;
                this.gameObject.SetActive(false);
            }
            else
            {
                progress.sickness += currentDialogue.sick4;
                progress.suspicion += currentDialogue.sus4;
                currentNPC.currentDialogue = currentNPC.dialogueList[currentDialogue.dialogue4];
                currentDialogue = currentNPC.dialogueList[currentDialogue.dialogue4];
                NewDialogue();
            }
        }
        else if (manager.currentScene == 2)
        {
            progress.sickness += currentDialogue.sick4;
            progress.suspicion += currentDialogue.sus4;
            currentNPC.currentDialogue = currentNPC.dialogueList2[currentDialogue.dialogue4];
            currentDialogue = currentNPC.dialogueList2[currentDialogue.dialogue4];
            if (currentDialogue.goAway4)
            {
                cameraa.isAbleToMove = true;
                this.gameObject.SetActive(false);
            }
            else { NewDialogue(); }

        }
    }


    public void NewDialogue()
    {
        DialogueText.text = currentDialogue.text;
        button1Text.text = currentDialogue.option1;
        if (currentDialogue.dialogue2 < 0)
        {
            button2.gameObject.SetActive(false);
        }
        else
        {
            button2.gameObject.SetActive(true);
            button2Text.text = currentDialogue.option2;
        }
        if (currentDialogue.dialogue3 < 0)
        {
            button3.gameObject.SetActive(false);
        }
        else
        {
            button3.gameObject.SetActive(true);

            button3Text.text = currentDialogue.option3;
        }
        if (currentDialogue.dialogue4 < 0)
        {
            button4.gameObject.SetActive(false);
        }
        else
        {
            button4.gameObject.SetActive(true);
            button4Text.text = currentDialogue.option4;
        }

    }
}
