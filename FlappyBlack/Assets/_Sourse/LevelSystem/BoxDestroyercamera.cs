using PlayerSystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxDestroyercamera : MonoBehaviour
{
    void OnBecameInvisible()
    {
        if (gameObject.CompareTag("boxtag"))
        {

            Destroy(gameObject);
        }
    }
}
