using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lock : MonoBehaviour, IPickupable //ärver från interfacen 
{
    private bool pickedup; //bool för om man ska ta upp objektet
    public GameObject particlePickup; //objekt för partikelsystemet som spawnas 
    public GameObject grayKey; //nyckeln för att låsa upp hänglåset
    public AudioSource AS; //audio source för när objektet tas upp
    public SpriteRenderer sr; //sprite renderern
    public Sprite spriteUnlocked; //spriten för när hänglåset är upplåst
    void Update()
    {
        if (pickedup) //om objektet ska tas upp
        {
            sr.sprite = spriteUnlocked; //visar att låset är upplåst genom att byta sprite
            StartCoroutine(Unlock()); //startar timern för när låset tas upp
        }
    }
    public void PickupObject() //funktionen som krävs av interfacet
    {
        AS.Play(); //spelar upp ljudet
        Instantiate(particlePickup, transform.position, transform.rotation); //spawnar partikelsystemet
        Destroy(gameObject); //förstör objektet
    }
    public void OnMouseDown() //när man klickar på objektet
    {
        if (grayKey == null) //om nyckeln är borta, dvs att mna har tagit upp den
            pickedup = true; //visar att man kan ta upp och låsa upp låset
    }
    IEnumerator Unlock() //ienumerator för när man ska ta upp låset när det har låsts upp
    { 
        yield return new WaitForSeconds(1f); //väntar en sekund
        PickupObject(); //kör funktionen
    }
}
