using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NewPiece : MonoBehaviour
{
    [SerializeField] GameObject[] Arts;
    void Start()
    {
        ChoosenArt();
    }
    void ChoosenArt()
    {
        GameObject gameObject = Instantiate(Arts[Random.Range(0, Arts.Length)]);
        gameObject.transform.SetParent(GameObject.FindGameObjectWithTag("Screen").transform, false);
    }

    
}
