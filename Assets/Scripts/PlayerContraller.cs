using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContraller : MonoBehaviour
{
    // private variables 
    private float speed = 5.0f;
    private float turnSpeed = 25.0f;
    private float horizantalInput;
    private float forwardInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // This is where we got players input
        horizantalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
 
         // we movce the vehicle forward
         transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
         // we turn the vehicle
         transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizantalInput);
    }
}
