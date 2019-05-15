using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour, IPickupable //ärver från interfacet
{
    public GameObject pickupParticle; //objekt för partikelsystem
    public GameObject player; //objekt för spelarn
    public OpenDrawer openDrawer; //accessar scriptet
    public bool pickupobj; //bool för om lådan är öppen så att nyckeln kan tas upp
    public bool Pickupobj //ett försök till en property som använder boolen
    {
        get { return pickupobj; } //get:ar den boolens värde
        set { pickupobj = value; } //set:ar den boolens värde till whatever man specifierar när man använder den
    }
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player"); //hittar objektet med rätt tag
    }
    void Update()
    {
        if (Pickupobj == true) //om man kan ta upp objektet
        {
            PickupObject(); //kör funktionen
        }
    }
    public void PickupObject() //funktion som krävs av interfacet
    {
        Instantiate(pickupParticle, transform.position, transform.rotation); //spawnar partikelsystem (som knappt syns för den byter scen)
    }
    public void OnMouseDown()
    {
        if (openDrawer.opened) //om lådan är öppnad
            Pickupobj = true; //objektet kan tas upp
    }
}
