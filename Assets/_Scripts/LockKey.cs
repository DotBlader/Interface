using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockKey : MonoBehaviour, IPickupable //ärver från interfacet
{
    private bool pickedup; //bool för om objektet kan tas upp
    public GameObject particlePickup; //partikelsystem som spawnas
    public OpenDrawer openDrawer; //accessar skriptet
    public AudioSource AS; //audio source för när objektet tas upp
    void Update()
    {
        if (pickedup) //om man kan ta upp objektet
        {
            PickupObject(); //kör funktionen där objektet tas upp
        }
    }
    public void PickupObject() //funktion som krävs av interface där objektet tas upp
    {
        AS.Play(); //spelar ljudet
        Instantiate(particlePickup, transform.position, transform.rotation); //spawnar partikel systemet
        Destroy(gameObject); //förstör objektet
    }
    public void OnMouseDown() //när man klickar på objektet
    {
        if (openDrawer.opened) //om byrålådan är öppen
        {
            pickedup = true; //objektet kan tas upp
        }
    }
}
