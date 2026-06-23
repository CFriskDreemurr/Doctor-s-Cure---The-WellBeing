using UnityEngine;

[CreateAssetMenu(fileName = "Illness", menuName = "Scriptable Objects/Illness")]
public class Illness : ScriptableObject
{
    public string illnessName;
    public string cureName;
    public Sprite sprite;
    public Drug cure = null;
}
