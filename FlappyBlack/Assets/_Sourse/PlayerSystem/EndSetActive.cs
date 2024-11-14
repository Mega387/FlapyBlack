using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlayerSystem
{
    public class EndSetActive : MonoBehaviour
    {
        public static bool isAllow = false;

        public GameObject targetObject;
        void Update()
        {
            CheckAndActivateObject();
        }
        public void CheckAndActivateObject()
        {
            if (isAllow == true)
            {
                targetObject.SetActive(true);
            }
        }
    }

}
