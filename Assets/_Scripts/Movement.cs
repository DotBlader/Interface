using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Movement : MonoBehaviour
{
    public ClickScript clickScript; //accessar skriptet

    // Update is called once per frame
    void Update()
    {
        if (clickScript.move == true) //om boolen för att man kan röra sig är true
        {
            GetComponent<NavMeshAgent>().SetDestination(clickScript.mousePos); //genom AI navigation sätter sin destination till muspositionen
            
            if (transform.position == clickScript.mousePos) //om ens position är muspositionen
            {
                clickScript.move = false; //ändrar så att man inte ska röra sig
            }
        }
        transform.rotation = new Quaternion(0, 0, 0, 10); //sätter rotationen till 0 på alla axlar för att undvika rotation
    }
}
