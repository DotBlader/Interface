using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDrawer : MonoBehaviour
{
    public GameObject openDrawer; //objekt för den öppna byrålådans sprite
    public GameObject closedDrawer; //objekt för den stängda lådans sprite
    public GameObject interactMenu; //menyn i UI för när man går nära byrålådan
    public GameObject Lock; //objekt för låset som eventuellt hindrar lådan från att öppnas
    public AudioSource AS; //audio source för när lådan öppnas
    public bool opened = false; //bool för när lådan ska öppnas 
    // Start is called before the first frame update
    void Start()
    {
        openDrawer.SetActive(false); //sätter objekt till false eller true
        closedDrawer.SetActive(true);
        interactMenu.SetActive(false);
        AS = GameObject.FindGameObjectWithTag("Open").GetComponent<AudioSource>(); //hittar objektet med rätt tag och den komponenten
    }

    // Update is called once per frame
    void Update()
    {
        if (opened) //om lådan ska öppnas
        {
            closedDrawer.SetActive(false); //sätter på och stänger av objekt så att lådan ser öppnad ut
            openDrawer.SetActive(true);

        }
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player" && opened == false) //om lådans trigger nuddar spelarn
        {
            interactMenu.SetActive(true); //sätter igång menyn i UI
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player" && interactMenu.activeSelf == true) //om lådans trigger slutar nudda spelarn
        {
            interactMenu.SetActive(false); //stänger av menyn
        }
    }
    public void Open() //funktion för att öppna lådan
    {
        if (transform.tag == "Interact2") //om byrålådan har den taggen
        {
            if (Lock == null) //om låset är borta, dvs lådan går att öppna
                opened = true; //visar att lådan ska öppnas
        }
        else
        {
            opened = true; //visar att lådan kan öppnas om taggen inte stämmer
        }
        AS.Play(); //spelar ljudet
    }
}
