using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class IllnessButton : MonoBehaviour
{
    public Illness currentIllness;
    [SerializeField] private TMP_Text illnessName;
    private UnityEngine.UI.Image imagee;
    private void Start()
    {
        imagee = GetComponent<UnityEngine.UI.Image>();
    }
    public void NewIllness(Illness i)
    {
        imagee = GetComponent<UnityEngine.UI.Image>();
        currentIllness = i;
        if (i.sprite != null)
        {
            imagee.sprite = i.sprite;
        }
    }
}
