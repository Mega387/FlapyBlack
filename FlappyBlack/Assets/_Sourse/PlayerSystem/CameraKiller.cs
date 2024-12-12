using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using PlayerSystem;

namespace PlayerSystem
{
    public class CameraKiller : MonoBehaviour
    {
        CameraMove cameramove;
        EndSetActive EndSetActive;
        void OnBecameInvisible()
        {
            if (gameObject.CompareTag("Player"))
            {
                ActiveteDeath();
                SceneManager.LoadScene("Menu");
            }
        }
        private void ActiveteDeath()
        {
            CameraMove.PlayerDeath = true;
            Destroy(gameObject);
            EndSetActive.CheckAndActivateObject(true);
            //Destroy(gameObject); не умирает если тут 

        }
    }

}
