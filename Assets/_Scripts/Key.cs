using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Key : MonoBehaviour
{
    public string sceneName;
    private void OnDestroy()
    {
        SceneManager.LoadScene(sceneName);
    }
}
