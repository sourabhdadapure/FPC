using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPC : MonoBehaviour
{
    public float speed = 10.0F;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float translation = Input.GetAxis("Vertical") * speed;
        float sideMovements = Input.GetAxis("Horizontal") * speed;
        translation *= Time.deltaTime;
        sideMovements *= Time.deltaTime;

        transform.Translate(sideMovements, 0, translation);
    }
}
