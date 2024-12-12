using System.Collections;
using System.Collections.Generic;
using PlayerSystem;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneButton : MonoBehaviour
{
    CameraMove CameraMove;
    EndSetActive EndSetActive;
    public string sceneName;
    public int valueToSend;

    public void LevelLoader()
    {
        PlayerPrefs.SetInt("MyValue", valueToSend);
        SceneManager.LoadScene(sceneName);
        CameraMove.PlayerDeath = false;
        EndSetActive.CheckAndActivateObject(false);
        Application.LoadLevel(Application.loadedLevel);
    }
}
