using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreenControl : MonoBehaviour
{
    public int desiredSceneNumber;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene(desiredSceneNumber);
        }
    }
}
