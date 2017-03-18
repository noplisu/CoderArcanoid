using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class Brick : MonoBehaviour {
    public Material[] materials;
    Renderer render;
    [Range(1, 3)]
    public int lives = 3;

    void Start()
    {
        render = GetComponent<Renderer>();
    }

    void Update()
    {
        if (lives == 0) { Destroy(gameObject); }
        else
        {
            render.material = materials[lives - 1];
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ball")
        {
            lives--;
        }
    }
}
