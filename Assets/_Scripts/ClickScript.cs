using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickScript : MonoBehaviour
{
    public bool move; //bool för om man ska röra sig eller ej
    public Vector3 mousePos; //en vector3 som används för muspositionen

    private void OnMouseDown() //när man klickar på objektet
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition); //sätter vectorn till musens position på skärmen
        move = true; //sätter bool till true så att man ska röra sig
    }
}
