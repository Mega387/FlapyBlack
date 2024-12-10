using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinDestroy : MonoBehaviour
{
    void OnBecameInvisible()
    {
        if (gameObject.CompareTag("spin"))
        {

            Destroy(gameObject);
        }
    }
}
