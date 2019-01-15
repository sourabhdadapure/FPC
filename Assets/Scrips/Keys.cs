using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keys : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        int myValue = 10;
        Debug.Log("VALUE OF THE VARIABLE "+ myValue);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow)){
            Debug.Log("Up Arrow pressed");
        }
        if(Input.GetKeyDown(KeyCode.DownArrow)){
            Debug.Log("Down Arrow Pressed");
        }
        if(Input.GetKeyDown(KeyCode.Return)){
            Debug.Log("Enter Pressed");
        }
    }
}
