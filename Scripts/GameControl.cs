using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    public GameObject ConfirmationPanel;
    public GameObject ConfirmBid;
    public GameObject WinnerPanel;
    public GameObject PadsPanel;
    public TMP_Text PlayerBid;
    public TMP_Text PlayerNumer;
    public TMP_Text ChoosenNumer;
    public TMP_Text RivalNumber1;
    public TMP_Text RivalNumber2;
    public TMP_Text RivalNumber3;
    public TMP_Text RivalNumber4;
    public void BackToMenu()
    {
        ConfirmationPanel.SetActive(true);
    }
    public void YesClicked()
    {
        SceneManager.LoadScene(1);
    }
    public void NoClicked()
    {
        ConfirmBid.SetActive(false);
    }

    public void BidYes()
    {
        ConfirmBid.SetActive(false);
        PlayerNumer.text = ChoosenNumer.text;

        PickRandomPad1();
        PickRandomPad2();
        PickRandomPad3();
        PickRandomPad4();
        theWinner();
        PadsPanel.SetActive(false);
        WinnerPanel.SetActive(true);
    }
    public void BidNo()
    {
        ConfirmBid.SetActive(false);
    }
    void PickRandomPad1()
    {
        int[] pads = new int[] {10, 25, 50, 100, 250, 500, 1000 };
        int randomPad = pads[Random.Range(0,pads.Length)];
        RivalNumber1.text = randomPad.ToString();
    }
    void PickRandomPad2()
    {
        int[] pads = new int[] { 10, 25, 50, 100, 250, 500, 1000 };
        int randomPad = pads[Random.Range(0, pads.Length)];
        RivalNumber2.text = randomPad.ToString();
    }
    void PickRandomPad3()
    {
        int[] pads = new int[] { 10, 25, 50, 100, 250, 500, 1000 };
        int randomPad = pads[Random.Range(0, pads.Length)];
        RivalNumber3.text = randomPad.ToString();
    }
    void PickRandomPad4()
    {
        int[] pads = new int[] { 10, 25, 50, 100, 250, 500, 1000 };
        int randomPad = pads[Random.Range(0, pads.Length)];
        RivalNumber4.text = randomPad.ToString();
    }
    void theWinner()
    {

    }
    public void NextAuction()
    {
        SceneManager.LoadScene(3);
    }
}
