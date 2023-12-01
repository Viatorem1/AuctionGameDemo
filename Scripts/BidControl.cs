using TMPro;
using UnityEngine;

public class BidControl : MonoBehaviour
{
    public GameObject ConfirmBid;
    public TMP_Text Number;
    public TMP_Text PadNumber;
    public TMP_Text ChoosenNumer;
    public void SetNumber()
    {
        ConfirmBid.SetActive(true);
        Number.text = "Bid " + PadNumber.text + " $?";
        ChoosenNumer.text = PadNumber.text;
    }
}
