using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    Rigidbody rigidbody;
    [SerializeField] float thrust;
    [SerializeField] float rotationthrust;
    // Start is called before the first frame update
    void Start()
    {
        print("love");
        rigidbody = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {if(Input.GetKey(KeyCode.Space))
        {
            rigidbody.AddRelativeForce(Vector3.up * thrust * Time.deltaTime);
        }
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Rotate(-Vector3.forward * rotationthrust * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Rotate(Vector3.forward * rotationthrust * Time.deltaTime);
            }
        }
    }
}
