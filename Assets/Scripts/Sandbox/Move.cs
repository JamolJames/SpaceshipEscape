using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] float thrustSpeed = 1000f;
    [SerializeField] float rotationSpeed = 100f;
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
        ProcessThrusting();
        ProcessRotation();
    }

    void ProcessThrusting() {
        if (Input.GetKey(KeyCode.Space))
        {
            if(!audioSource.isPlaying) {
                audioSource.Play();
            } 
            rb.AddRelativeForce(Vector3.up * thrustSpeed * Time.deltaTime);
        } else {
            audioSource.Stop();
        }
    }
    void ProcessRotation() {
        if (Input.GetKey(KeyCode.A))
        {
            DoRotation(rotationSpeed);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            DoRotation(-rotationSpeed);        
        }
    }

    void DoRotation(float rotationValue)
    {
        transform.Rotate(Vector3.forward * rotationValue * Time.deltaTime);
    }
}
