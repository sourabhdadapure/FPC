using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    private Vector2 mouseDirection;
    // Start is called before the first frame update

    private Transform myBody;
    void Start()
    {
        myBody = this.transform.parent.transform;
    }

    // Update is called once per frame
    void Update()
    {
        //how much has the mouse moved
        Vector2 mouseChange = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));

        mouseDirection += mouseChange;

        this.transform.localRotation = Quaternion.AngleAxis(-mouseDirection.y, Vector3.right);
        myBody.localRotation = Quaternion.AngleAxis(mouseDirection.x,Vector3.up);
    }
}
