using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Movement : MonoBehaviour
{
    public Rigidbody rbody;
    public ClickScript clickScript;

    // Update is called once per frame
    void Update()
    {
        if (clickScript.move == true)
        {
            GetComponent<NavMeshAgent>().SetDestination(clickScript.mousePos);
            
            if (transform.position == clickScript.mousePos)
            {
                clickScript.move = false;
            }
        }
        transform.rotation = new Quaternion(0, 0, 0, 10);
    }
}
