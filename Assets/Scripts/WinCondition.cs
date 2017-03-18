using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCondition : MonoBehaviour {
	// Update is called once per frame
	void FixedUpdate () {
        if(transform.childCount == 0)
        {
            print("Win");
        }
	}
}
