using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Key : MonoBehaviour
{
    public string sceneName; //string för namnet på scenen man vill byta till
    public Pickup pickup; //accessar scriptet
    private void Start()
    {
        pickup = GetComponent<Pickup>(); //hittar skriptet som komponent
    }
    private void Update()
    {
        if (pickup.Pickupobj)   //om boolen är true i skriptet
            SceneManager.LoadScene(sceneName); //byter scen till den man skrivit
    }
    
}
