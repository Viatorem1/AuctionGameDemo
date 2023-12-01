using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MatchMaking : MonoBehaviour
{
    public GameObject Timer;
    public GameObject WaitSign;
    public GameObject PlayButton;
    public GameObject TimeIsUpPanel;
    void Start()
    {  
        StartCoroutine(StartGame());
        StartCoroutine(TýmeUp());
        StartCoroutine(ReturnToMenu());
    }

    public IEnumerator StartGame()
    {
        yield return new WaitForSeconds(10);
        WaitSign.SetActive(false);
        Timer.SetActive(true);
        PlayButton.SetActive(true);

        yield return new WaitForSeconds(20);
        TimeIsUpPanel.SetActive(true);
    }
    public IEnumerator TýmeUp()
    {
        yield return new WaitForSeconds(30);
        TimeIsUpPanel.SetActive(true);
        Timer.SetActive(false);
    }
    public IEnumerator ReturnToMenu()
    {
        yield return new WaitForSeconds(33);
        SceneManager.LoadScene(1);
    }
    public void StartAuction()
    {
        SceneManager.LoadScene(3);
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene(1);
    }
}
