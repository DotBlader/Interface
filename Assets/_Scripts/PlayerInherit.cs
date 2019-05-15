using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInherit : Player //ärver från spelar skriptet, gör exakt samma sak som det skriptet fast med en anna bool, kolla "Player" skriptet för kommentarer
{
    public bool interact2; //har en annan bool för om man interagerar med en låda
    public override void Update()
    {
        base.Update(); //gör samma som spelar skriptet
        if (interact2 == true && Input.GetKeyDown(KeyCode.E)) //gör också detta, samma som innan men med den andra boolen istället
        {
            opendrawer.Open();
            playsound = false;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Interact")
        {
            interact = true;
            if (other.gameObject.GetComponent<OpenDrawer>() != null)
            {
                opendrawer = other.gameObject.GetComponent<OpenDrawer>();
                playsound = true;
            }
        }
        else if (other.gameObject.tag == "Interact2")
        {
            interact2 = true;
            if (other.gameObject.GetComponent<OpenDrawer>() != null)
                opendrawer = other.gameObject.GetComponent<OpenDrawer>();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Interact")
        {
            interact = false;
        }
        else if (other.gameObject.tag == "Interact2")
        {
            interact2 = false;
        }
    }
}
