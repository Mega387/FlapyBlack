using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlayerSystem
{
    public class AnglePlayer : MonoBehaviour
    {
        private Rigidbody2D rb;
        private float maxRotationDuration = 2f;
        private float startRotationTime;
        private bool isRotating;
        private float stabilizationSila = 20f;
        private bool isInContactWithOtherObject;
        private float contactTimer;

        void Start()
        {
            rb = GetComponent<Rigidbody2D>();
        }

        void OnCollisionEnter2D(Collision2D collision)
        {
            isInContactWithOtherObject = true;
            contactTimer = 0f;
        }

        void OnCollisionExit2D(Collision2D collision)
        {
            isInContactWithOtherObject = false;
        }

        void Update()
        {
            if (!isRotating && rb.angularVelocity != 0)
            {
                isRotating = true;
                startRotationTime = Time.time;
            }
            if (isRotating && Time.time - startRotationTime >= maxRotationDuration)
            {
                if (!isInContactWithOtherObject && contactTimer > 3f)
                {
                    StabilizePlayer();
                }
            }
            if (!isInContactWithOtherObject)
            {
                contactTimer += Time.deltaTime;
            }
        }

        void StabilizePlayer()
        {
            isRotating = false;
            StartCoroutine(SmoothlyRotateToZero());
        }

        IEnumerator SmoothlyRotateToZero()
        {
            float angularVelocity = rb.angularVelocity;
            float timeElapsed = 0f;
            float duration = 1f;

            while (timeElapsed < duration)
            {
                float t = timeElapsed / duration;
                float newAngularVelocity = Mathf.Lerp(angularVelocity, 0f, t);
                rb.angularVelocity = newAngularVelocity;
                rb.AddTorque(-newAngularVelocity * stabilizationSila);

                timeElapsed += Time.fixedDeltaTime;
                yield return new WaitForFixedUpdate();
            }

            //rb.angularVelocity = 0f;
        }
    }

}
