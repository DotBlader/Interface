using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lock : MonoBehaviour, IPickupable
{
    private bool pickedup;
    public GameObject particlePickup;
    public GameObject grayKey;
    public AudioSource AS;
    public SpriteRenderer sr;
    public Sprite spriteUnlocked;
    void Update()
    {
        if (pickedup)
        {
            sr.sprite = spriteUnlocked;
            StartCoroutine(Unlock());
        }
    }
    public void PickupObject()
    {
        AS.Play();
        Instantiate(particlePickup, transform.position, transform.rotation);
        Destroy(gameObject);
    }
    public void OnMouseDown()
    {
        if (grayKey == null)
            pickedup = true;
    }
    IEnumerator Unlock()
    {
        yield return new WaitForSeconds(1f);
        PickupObject();
    }
}
