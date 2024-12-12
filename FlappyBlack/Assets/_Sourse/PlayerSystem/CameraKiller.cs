using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace PlayerSystem
{
    public class CameraKiller : MonoBehaviour
    {
        private string sceneName = "Menu";
        CameraMove cameramove;
        EndSetActive EndSetActive;
        void OnBecameInvisible()
        {
            if (gameObject.CompareTag("Player"))
            {

                CameraMove.PlayerDeath = true;
                EndSetActive.CheckAndActivateObject(true);
                Destroy(gameObject);
                
            }
        }
    }

}
