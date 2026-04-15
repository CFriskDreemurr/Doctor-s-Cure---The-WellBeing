using UnityEngine;
using FMODUnity;
using UnityEngine.UIElements;

public class UIManagerAudio : MonoBehaviour
{
    public static UIManagerAudio Instance;

    [SerializeField] private EventReference clickSound;
    [SerializeField] private EventReference hoverSound;

    void Awake()
    {
        Instance = this;
    }

    public void PlayClick()
    {
        RuntimeManager.PlayOneShot(clickSound);
    }

    public void PlayHover()
    {
        RuntimeManager.PlayOneShot(hoverSound);
    }
   
}