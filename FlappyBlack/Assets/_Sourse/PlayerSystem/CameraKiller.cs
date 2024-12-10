using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

                CameraMove.PlayerDeath = true;
                EndSetActive.isAllow = true;
                Destroy(gameObject);
            }
        }
    }

}
