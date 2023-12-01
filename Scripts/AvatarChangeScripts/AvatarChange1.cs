using System.Collections;
using UnityEngine;

public class AvatarChange1 : MonoBehaviour
{
    public Sprite avatar;

    void Start()
    {
        StartCoroutine(ChangeAvatar1());
    }
    public IEnumerator ChangeAvatar1()
    {
        yield return new WaitForSeconds(3);
        this.gameObject.GetComponent<SpriteRenderer>().sprite = avatar;
    }
}
