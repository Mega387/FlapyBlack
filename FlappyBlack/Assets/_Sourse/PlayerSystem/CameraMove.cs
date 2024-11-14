using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlayerSystem
{
    public class CameraMove : MonoBehaviour
    {
        private Rigidbody2D rb;
        public static float moveSpeed = 4.9f;
        public static bool PlayerDeath = false;
        void Start()
        {
            rb = GetComponent<Rigidbody2D>();
        }

        void Update()
        {
            //if (PlayerDeath == false)
            //{
            //    //transform.Translate(Vector2.right * Time.deltaTime * moveSpeed);  
            //    rb.velocity = new Vector2(moveSpeed, rb.velocity.y);
            //}
            if (PlayerDeath == true)
            {
                Debug.Log("True");
                rb.constraints = RigidbodyConstraints2D.FreezePosition;
            }
            else
                Move();
        }
        void Move()
        {
            if (PlayerDeath != true)
            {
                rb.velocity = new Vector2(moveSpeed, rb.velocity.y);

                Debug.Log("False");
            }
            //transform.Translate(Vector2.right * Time.deltaTime * moveSpeed);  
            //��������� ������� ������ � �� �� ��� �� ���� 
        }
    }

}