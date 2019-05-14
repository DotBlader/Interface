﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool interact = false;
    public OpenDrawer opendrawer;

    // Update is called once per frame
    public virtual void Update()
    {
        if (interact == true && Input.GetKeyDown(KeyCode.E))
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
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Interact")
        {
            interact = false;
        }
    }
}
