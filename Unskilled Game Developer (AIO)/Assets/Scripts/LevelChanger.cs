using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour
{
    public void ChangeLevel(int LevelNumber)
    {
        SceneManager.LoadScene(LevelNumber);
    }

    public void ExitTheGame()
    {
        Application.Quit();
    }
}
