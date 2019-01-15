using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("START METHOD IS RUNNING");
    }

    void Awake() {
        Debug.Log("AWAKE METHOD IS RUNNING");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("UPDATE TIME: " + Time.deltaTime);
    }

    void FixedUpdate()
    {
        Debug.Log("Fixed Update Time: " + Time.deltaTime);
    }
   
    void LateUpdate()
    {
        
    }
}
