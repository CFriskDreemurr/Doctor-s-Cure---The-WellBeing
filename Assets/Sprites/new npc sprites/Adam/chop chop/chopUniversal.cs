using TMPro;
using UnityEngine;

public class chopUniversal : MonoBehaviour
{
    public Sprite nextSpriteF;
    public Sprite nextSpriteM;
    public int killVallue;
    [SerializeField] private NPCManager manager;
    public TMP_Text text;
    private void OnEnable()
    {
        text.gameObject.SetActive(false);
        if (manager.currentNPC == null)
        {
            this.gameObject.SetActive(false);
        }
        else
        {
            if (manager.currentNPC.isDyng + killVallue >= 2)
            {
                text.gameObject.SetActive(true);
            }
        }
    }
    public void Chop()
    {
        if (manager.currentNPC.isDyng + killVallue >= 2)
        {
            manager.currentNPC.isAlive = false;
            manager.OperatingOut();
            this.gameObject.SetActive(false);
        }
        else
        {
            if (manager.currentNPC.m)
            {
                manager.currentNPC.NPCSprites[3] = nextSpriteM;
                manager.currentNPC.isDyng += killVallue;
                manager.operatingSprite.sprite = nextSpriteM;
                this.gameObject.SetActive(false);

            }
            else
            {
                manager.currentNPC.NPCSprites[3] = nextSpriteF;
                manager.currentNPC.isDyng += killVallue;
                manager.operatingSprite.sprite = nextSpriteF;
                this.gameObject.SetActive(false);
            }
        }

    }
}
