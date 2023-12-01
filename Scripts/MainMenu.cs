using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject mainPanel;
    public GameObject optionsPanel;
    public void OptionsMenu()
    {
        optionsPanel.SetActive(true);
    }

    public void BackToMain()
    {
        optionsPanel.SetActive(false);
    }
    public void StartGame()
    {
        SceneManager.LoadScene(2);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
