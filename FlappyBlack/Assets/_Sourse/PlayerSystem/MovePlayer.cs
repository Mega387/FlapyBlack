using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlayerSystem
{
    public class MovePlayer : MonoBehaviour
    {
        public static float moveSpeed = 5f;
        public static float jumpForce = 200f;
        //private float initialMass;
        //private float increasedMass = 10f;
        private bool SpeedAllow = true;
        CameraMove cameramove;
        private Rigidbody2D rb;
        //public void mass()
        //{
        //    initialMass = rb.mass;

        //    ChangeMass(increasedMass);
        //    Invoke("ResetMass", 2f);
        //}
        //void ChangeMass(float mass)
        //{
        //    rb.mass = mass;
        //}
        //void ResetMass()
        //{
        //    rb.mass = initialMass;
        //}
        void Speed()
        {
            moveSpeed += 1;
            SpeedAllow = true;
            CameraMove.moveSpeed += 1f;


        }
        void Start()
        {
            rb = GetComponent<Rigidbody2D>();
        }

        void Update()
        {
            //transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);
            rb.velocity = new Vector2(moveSpeed, rb.velocity.y);
            if (SpeedAllow == true)
            {
                SpeedAllow = false;
                Invoke("Speed", 15f);
            }
            if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Mouse0))
            {
                Jump();
                Debug.Log($"Скорость - {moveSpeed}");
            }
            
        }

        void Jump()
        {
            rb.velocity = Vector2.zero;
            rb.AddForce(Vector2.up * jumpForce);
        }
    }

}
