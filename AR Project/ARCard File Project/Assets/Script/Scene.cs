using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Scene : MonoBehaviour
{

    public void SceneName(string scene_name)
    {
        SceneManager.LoadScene(scene_name);
    }
    public void doExitGame()
    {
        Application.Quit();
    }
}
