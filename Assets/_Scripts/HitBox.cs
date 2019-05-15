using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBox : MonoBehaviour
{
    public bool isTouching; //bool för om man nuddar

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isTouching = true; //sätter nuddar till sant om man kolliderar med nåt
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        isTouching = false; //sätter den till false
    }
}
