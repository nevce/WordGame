using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    public string nextSceneName; 

    public void GoToNextScene()
    {
        SceneManager.LoadScene(1);
    }
}
