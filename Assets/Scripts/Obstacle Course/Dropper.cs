using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer mRenderer;
    Rigidbody rBody;
    [SerializeField] int timeLimit = 3;

    // Start is called before the first frame update
    void Start()
    {
        mRenderer = GetComponent<MeshRenderer>();
        rBody = GetComponent<Rigidbody>();

        mRenderer.enabled = false;
        rBody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > timeLimit){
            // Debug.Log("Three seconds has elapsed");
            mRenderer.enabled = true;
            rBody.useGravity = true;
        }
    }

}
