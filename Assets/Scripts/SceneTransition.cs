using Unity.VectorGraphics;
using UnityEditor.PackageManager.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    void Update()
    {
        // Check if the assigned key was pressed down this exact frame
        if (Input.GetKeyDown("1"))
        {
            LoadTargetScene("Window");
        }
        if (Input.GetKeyDown("2"))

        {
            LoadTargetScene("Examination");
        }
    }

    private void LoadTargetScene(string name)
    {
        SceneManager.LoadScene(name, LoadSceneMode.Additive);
    }
}