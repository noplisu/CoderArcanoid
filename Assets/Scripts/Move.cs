using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {
    Rigidbody rigid;
    public float speed = 10;

    // Use this for initialization
    void Start () {
        rigid = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        float horizontal = Input.GetAxis("Horizontal");
        rigid.velocity = Vector3.right * horizontal * Time.deltaTime * speed;
	}
}
