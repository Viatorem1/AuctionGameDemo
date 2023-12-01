using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarChange4 : MonoBehaviour
{
    public Sprite avatar;

    void Start()
    {
        StartCoroutine(ChangeAvatar4());
    }
    public IEnumerator ChangeAvatar4()
    {
        yield return new WaitForSeconds(10);
        this.gameObject.GetComponent<SpriteRenderer>().sprite = avatar;
    }
}
