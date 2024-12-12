using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayerSystem;
using UnityEngine.SceneManagement;

public class DestroyPlayerCollider : MonoBehaviour
{
    EndSetActive EndSetActive;
    private string sceneName = "Menu";
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(other.gameObject);
            EndSetActive.CheckAndActivateObject(true);
            SceneManager.LoadScene(sceneName);
        }
        if (other.CompareTag("boxtag"))
        {
            Destroy(other.gameObject);
        }
    }
}
