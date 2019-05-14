using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickScript : MonoBehaviour
{
    public bool move;
    public Vector3 mousePos;

    private void OnMouseDown()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        move = true;
    }
}
