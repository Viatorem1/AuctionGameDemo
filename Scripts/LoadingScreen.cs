using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadingScreen : MonoBehaviour
{
    public GameObject Slider;
    public GameObject StartButton;
    public Slider LoadingBar;
    public float LoadingTime;

    void Start()
    {
        LoadingBar.maxValue = LoadingTime;
        LoadingBar.value = LoadingTime;
    }
    void Update()
    {

        float load = LoadingTime - Time.timeSinceLevelLoad;
        if (load <= 0)
        {
            Slider.SetActive(false);
            StartButton.SetActive(true);
        }
        LoadingBar.value = load;
    }
    public void startButton()
    {
        SceneManager.LoadScene(1);
    }
}
