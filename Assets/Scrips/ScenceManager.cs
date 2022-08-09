using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ScenceManager : MonoBehaviour
{

    // Update is called once per frame
    public void StartGame()
    {
        SceneManager.LoadScene(0,LoadSceneMode.Single);
    }
    public void Exit()
    {
        Application.Quit();
    }
}
