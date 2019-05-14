using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockKey : MonoBehaviour, IPickupable
{
    private bool pickedup;
    public GameObject particlePickup;
    public AudioSource AS;
    void Update()
    {
        if (pickedup)
        {
            PickupObject();
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
        pickedup = true;
    }
}
