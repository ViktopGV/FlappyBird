using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadGameScene()
    {
        SceneManager.LoadSceneAsync("Game");
    }

    public void LoadMainMenuScene()
    {
        SceneManager.LoadSceneAsync("MainMenu");
    }
}
