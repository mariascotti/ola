using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody RB;
    float direcX;
    public float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent <Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
      direcX = Input.acceleration.x * speed;
      transform.position = new Vector3(Mathf.Clamp(transform.position.x, -7.5f, 7.5f), transform.position.y);


    }

    private void FixedUpdate()
    {
        RB.velocity = new Vector3 (direcX, 0, 0);
    }
}
