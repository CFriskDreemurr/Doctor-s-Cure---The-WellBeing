using Microsoft.Unity.VisualStudio.Editor;
using TMPro;
using UnityEngine;

public class IllnessButton : MonoBehaviour
{
    public Illness currentIllness;
    [SerializeField] private TMP_Text illnessName;
    [SerializeField] private Image img;
    public void NewIllness(Illness i)
    {
        currentIllness = i;
        if (i.sprite != null)
        {
            img.Equals(i.sprite);
        }
        }
    }
