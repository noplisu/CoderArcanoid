using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{

    public float speed = 10;
    Vector3 direction;
    Rigidbody rigid;

    // Use this for initialization
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        
        direction = (Vector3.right + Vector3.up).normalized;
    }

    // Update is called once per frame
    void Update()
    {
        rigid.velocity = direction * speed;
    }

    void OnCollisionEnter(Collision collision)
    {
        speed += 0.1f;
        direction = Vector3.Reflect(direction, collision.contacts[0].normal);
    }
}
