using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool interact = false; //bool för när man interactar med en byrålåda
    public bool playsound; //bool för att endast spela upp audiosoure en gång
    public OpenDrawer opendrawer; //acessar skriptet

    // Update is called once per frame
    public virtual void Update()
    {
        if (interact == true && Input.GetKeyDown(KeyCode.E) && playsound) //om man interagerar med byrån och klickar
        {
            opendrawer.Open(); //öppnar lådan
            playsound = false; //ändrar så att ljudet inte kan spelas igen
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Interact") //om det man krockar med har rätt tag
        {
            interact = true; //visar att man interagerar med objektet
            if (other.gameObject.GetComponent<OpenDrawer>() != null) //om det man nuddar har skriptet på sig
            {
                opendrawer = other.gameObject.GetComponent<OpenDrawer>(); //accessar skriptet
                playsound = true; //visar att ljudet kan spelas
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Interact") //om taggen stämmer med de man inte längre krockar med
        {
            interact = false; //visar att man inte längre interagerar med objektet
        }
    }
}
