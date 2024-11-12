using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndSetActive : MonoBehaviour
{
    public static bool isAllow = false;

    public GameObject targetObject;
    void Update()
    {
        CheckAndActivateObject();
        Debug.Log("конец");
    }
    public void CheckAndActivateObject()
    {
        if (isAllow == true)
        {
            targetObject.SetActive(true);
        }
    }
}
