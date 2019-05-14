using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour, IPickupable
{
    public GameObject pickupParticle;
    public GameObject player;
    public bool pickupobj;
    public bool Pickupobj
    {
        get { return pickupobj; }
        set { pickupobj = value; }
    }
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    void Update()
    {
        PickupObject();
    }
    public void PickupObject()
    {
        if (Pickupobj == true)
        {
            Destroy(gameObject);
            Instantiate(pickupParticle, transform.position, transform.rotation);
        }
    }
    public void OnMouseDown()
    {
        Pickupobj = true;
    }
}
