using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //camera settings for editor
    public float panSpeed = 30f;
    public float panBorderThickness = 10;
    private float camYRot;
    private float camZRot;
    public float scrollSpeed = 5f;


    [Header("CameraLimits")]
    public float leftLimit = 0f;
    public float rightLimit = 70f;
    public float upLimit = 65f;
    public float downLimit = -4f;
    public float minY = 10f; //zoom in limit
    public float maxY = 80f; //zoom out limit
    public float xRotationLowerLimit = 10f;
    public float xRotationUpperLimit = 90f;

    void Start()
    {
        //gets the current rotations
        camYRot = transform.rotation.y;
        camZRot = transform.rotation.z;
    }

    void Update()
    {
        //does movement. can change w, s, d, and a to arrow keys.

        float mouseY = Input.mousePosition.y;
        float mouseX = Input.mousePosition.x;


        if (mouseX >= 0 && mouseX <= Screen.width && mouseY >= 0 && mouseY <= Screen.height)
        {
            if ((Input.GetKey("w") || mouseY >= Screen.height - panBorderThickness) && transform.position.z < upLimit)
            {
                transform.Translate(Vector3.forward * panSpeed * Time.deltaTime, Space.World);
            }

            if ((Input.GetKey("s") || mouseY <= panBorderThickness) && transform.position.z > downLimit)
            {
                transform.Translate(Vector3.back * panSpeed * Time.deltaTime, Space.World);
            }

            if ((Input.GetKey("d") || mouseX >= Screen.width - panBorderThickness) && transform.position.x < rightLimit)
            {
                transform.Translate(Vector3.right * panSpeed * Time.deltaTime, Space.World);
            }

            if ((Input.GetKey("a") || mouseX <= panBorderThickness) && transform.position.x > leftLimit)
            {
                transform.Translate(Vector3.left * panSpeed * Time.deltaTime, Space.World);
            }

            float scroll = Input.GetAxis("Mouse ScrollWheel");
            if(scroll > 0 && transform.position.y > minY)
            {

                transform.Translate(Vector3.down * scrollSpeed * 100 * Time.deltaTime, Space.World);
                //transform.Rotate(-rotationPivotFactor* rotationSpeedPerFrame, 0f, 0f, Space.Self);
                if (transform.position.y > xRotationLowerLimit && transform.position.y < xRotationUpperLimit)
                    transform.rotation = Quaternion.Euler(transform.position.y, camYRot, camZRot);
            }
            if (scroll < 0 && transform.position.y < maxY)
            {

                transform.Translate(Vector3.up * scrollSpeed * 100 *  Time.deltaTime, Space.World);
                //transform.Rotate(rotationPivotFactor* rotationSpeedPerFrame, 0f, 0f, Space.Self);
                if (transform.position.y > xRotationLowerLimit && transform.position.y < xRotationUpperLimit)
                    transform.rotation = Quaternion.Euler(transform.position.y, camYRot, camZRot);
            }

        }

    }
}
