using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarChange2 : MonoBehaviour
{
    public Sprite avatar;

    void Start()
    {
        StartCoroutine(ChangeAvatar2());
    }
    public IEnumerator ChangeAvatar2()
    {
        yield return new WaitForSeconds(5);
        this.gameObject.GetComponent<SpriteRenderer>().sprite = avatar;
    }
}
