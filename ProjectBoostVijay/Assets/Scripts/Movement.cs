using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Movement : MonoBehaviour
{
    [SerializeField] float mainThrusts = 1000f; 
    [SerializeField] float rotationThrust = 1f; 
    Rigidbody rb;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody>();
       audioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        ProcessThrust();
        ProcessRotation();
    }

    void ProcessThrust(){
        if(Input.GetKey(KeyCode.Space)) 
        {
            rb.AddRelativeForce(Vector3.up * mainThrusts * Time.deltaTime);
            if(!audioSource.isPlaying)
           {
               audioSource.Play();
           }

        }  
        else
        {
            audioSource.Stop();
        }
    }

    void ProcessRotation()
    {
        if(Input.GetKey(KeyCode.A))
        {
           ApplyRotation(rotationThrust);
        }
        else if(Input.GetKey(KeyCode.D))
        {
           ApplyRotation(-rotationThrust);
        }
    }



    private void ApplyRotation(float rotationThisFrame)
    { 
        rb.freezeRotation = true;
        transform.Rotate(Vector3.forward * rotationThisFrame * Time.deltaTime);
        rb.freezeRotation = false;
    }
}
