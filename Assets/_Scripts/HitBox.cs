using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBox : MonoBehaviour
{
    public bool isTouching;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isTouching = true;
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        isTouching = false;
    }
}
