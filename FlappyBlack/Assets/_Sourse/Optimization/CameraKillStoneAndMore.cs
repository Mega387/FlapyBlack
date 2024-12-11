using System.Collections;
using System.Collections.Generic;
using PlayerSystem;
using UnityEngine;

public class CameraKillStoneAndMore : MonoBehaviour
{
    void OnBecameInvisible()
    {
        if (gameObject.CompareTag("Stone"))
        {
            Destroy(gameObject);
        }
    }
}
