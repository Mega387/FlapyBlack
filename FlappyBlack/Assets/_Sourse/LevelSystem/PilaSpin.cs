using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PilaSpin : MonoBehaviour
{
    public Transform centerPoint;
    public float radius = 0f;
    public float speed = 90.0f;

    private float angle;
    void Start()
    {
        angle = 0.0f;
    }

    void Update()
    {
        angle += Time.deltaTime * speed;
        float radians = Mathf.Deg2Rad * angle;

        float x = centerPoint.position.x + radius * Mathf.Cos(radians);
        float y = centerPoint.position.y + radius * Mathf.Sin(radians);


        transform.position = new Vector3(x, y, transform.position.z);
    }
}
