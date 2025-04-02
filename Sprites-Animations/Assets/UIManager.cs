using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public void LoadScene(int sceneIndex)
    {
        // Load the scene with the specified index
        SceneManager.LoadScene(sceneIndex);
    }
}
