using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Movement : MonoBehaviour
{

    [SerializeField] float thrustAmount = 1000;
    [SerializeField] float rotateSpeed = 1000;
    [SerializeField] AudioClip mainEngine;
    [SerializeField] ParticleSystem jetParticles;
    [SerializeField] ParticleSystem leftBooster;
    [SerializeField] ParticleSystem rightBooster;
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

    void ProcessThrusting()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            
            StartThrusting();
        }
        else
        {
            StopThrusting();
        }
    }
    void ProcessRotation()
    {
        if (Input.GetKey(KeyCode.A))
        {
            BoostLeft();
        }
        else if (Input.GetKey(KeyCode.D))
        {
            BoostRight();
        }
        else
        {
            StopBoosting();
        }
    }
    void StartThrusting()
    {
        rb.AddRelativeForce(Vector3.up * thrustAmount * Time.deltaTime);
        if (!audioSource.isPlaying)
        {
            audioSource.PlayOneShot(mainEngine);
            jetParticles.Play();
        }
    }

    void StopThrusting()
    {
        audioSource.Stop();
        jetParticles.Stop();
    }

    void BoostLeft()
    {
        ApplyRotation(rotateSpeed);
        if (!rightBooster.isPlaying)
        {
            rightBooster.Play();
        }
    }
    void BoostRight()
    {
        ApplyRotation(-rotateSpeed);
        if (!leftBooster.isPlaying)
        {
            leftBooster.Play();
        }
    }

    void StopBoosting()
    {
        leftBooster.Stop();
        rightBooster.Stop();
    }

    void ApplyRotation(float rotation)
    {
        rb.freezeRotation = true;
        transform.Rotate(Vector3.forward * rotation * Time.deltaTime);
        rb.freezeRotation = false;
    }

}
