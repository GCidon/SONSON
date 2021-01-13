using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    
    public void changeScene(string scene)
    {
        Debug.Log("Cambio de escena (se supone)");
        SceneManager.LoadScene(scene);
    }
}
