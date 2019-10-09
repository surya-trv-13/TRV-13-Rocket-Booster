using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    Rigidbody rigidBody;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();  //This works similar to the Java Generics is a C# Generics...  
    }

    // Update is called once per frame
    void Update()
    {
        processKey();
    }

    private void processKey()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rigidBody.AddRelativeForce(Vector3.up); /*This will move upward... Along Y , 
                                                    *This take the  component of rocket and make Relative force(along a certain direction) 
                                                    *and Vector3 contain the value of x,y,z direction of Rocket.
                                                    * Make Sure the mass must be small so that it could fly...*/
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.forward);
        }else if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(-Vector3.forward);
        }
    }
}
