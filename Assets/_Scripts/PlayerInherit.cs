using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInherit : Player
{
    public bool interact2;
    public GameObject Lock;
    public override void Update()
    {
        base.Update(); 
        if (interact2 == true && Input.GetKeyDown(KeyCode.E) && Lock == null)
        {
            opendrawer.Open();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Interact")
        {
            interact = true;
            if (other.gameObject.GetComponent<OpenDrawer>() != null)
                opendrawer = other.gameObject.GetComponent<OpenDrawer>();
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
