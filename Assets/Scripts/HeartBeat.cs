using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartBeat : MonoBehaviour
{
    [Tooltip("Movement speed in meters per second")]
    [SerializeField]
    float objectSpeed ;
    [SerializeField]
    float motionLimit ; 
    [SerializeField]
    float reduceEnlarge;
    float objectScale;


    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("Start");
        objectSpeed = 1;
        motionLimit = 3f;
        reduceEnlarge = 1;
    }

    
    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Update");
        reduceEnlarge += Time.deltaTime;
        objectScale = Mathf.Sin(reduceEnlarge * objectSpeed) * motionLimit;
        transform.localScale = new Vector3(objectScale,objectScale ,objectScale );
    }
}
