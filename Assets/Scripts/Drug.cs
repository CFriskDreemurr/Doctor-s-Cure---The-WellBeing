using UnityEngine;

[CreateAssetMenu(fileName = "Drug", menuName = "Scriptable Objects/Drug")]
public class Drug : ScriptableObject
{
    public string drugName;
    public int amount;
}
