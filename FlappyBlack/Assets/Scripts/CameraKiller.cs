using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraKiller : MonoBehaviour
{
    CameraMove cameramove;
    void OnBecameInvisible()
    {
        if (gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            CameraMove.PlayerDeath = true;
            Debug.Log("Здох");
        }
    }
}
