using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContraller : MonoBehaviour
{
    public float speed = 5.0f;
    public float turnSpeed;
    public float horizantalInput;
    public float forwardInput;

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
 
       
         transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
         transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizantalInput);
    }
}
