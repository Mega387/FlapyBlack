using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 20f;
    private bool SpeedAllow = true;
    CameraMove cameramove;

    private Rigidbody2D rb;
    void Speed()
    {
        moveSpeed += 1;
        Debug.Log($"Скорость увеличена {moveSpeed}");
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
        rb.velocity = new Vector2 (moveSpeed, rb.velocity.y);
        if ( SpeedAllow == true)
        {
            SpeedAllow = false;
            Invoke("Speed", 15f);
        }
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Mouse0))
        {
            Jump();
        }
    }

    void Jump()
    {
        rb.velocity = Vector2.zero;
        rb.AddForce(Vector2.up * jumpForce);
    }
}
