using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDrawer : MonoBehaviour
{
    public GameObject openDrawer;
    public GameObject closedDrawer;
    public GameObject interactMenu;
    public bool opened = false;
    // Start is called before the first frame update
    void Start()
    {
        openDrawer.SetActive(false);
        closedDrawer.SetActive(true);
        interactMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (opened)
        {
            closedDrawer.SetActive(false);
            openDrawer.SetActive(true);
        }
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player" && opened == false)
        {
            interactMenu.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player" && interactMenu.activeSelf == true)
        {
            interactMenu.SetActive(false);
        }
    }
    public void Open()
    {
        opened = true;
    }
}
