using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //använder UI

public class SceneChanger : MonoBehaviour
{
    public void SceneChange(string namn) //funktion där scenen byts till den man specifierar
    {
        SceneManager.LoadScene(namn); //laddar scenen
    }
    public void QuitGame() //funktion för att avsluta spelet
    {
        Application.Quit(); //avslutar spelet
    }
}
