using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarChange3 : MonoBehaviour
{
    public Sprite avatar;

    void Start()
    {
        StartCoroutine(ChangeAvatar3());
    }
    public IEnumerator ChangeAvatar3()
    {
        yield return new WaitForSeconds(8);
        this.gameObject.GetComponent<SpriteRenderer>().sprite = avatar;
    }
}
