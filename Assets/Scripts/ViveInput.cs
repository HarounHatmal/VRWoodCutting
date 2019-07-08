using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class ViveInput : MonoBehaviour
{
    public SteamVR_Action_Vector2 touchPadAction;
    public Camera playerCamera;
    public float playerSpeed;
    public Rigidbody rb;

    void Update()
    {
        Vector2 touchpadValue = touchPadAction.GetAxis(SteamVR_Input_Sources.Any);

        // will move only foward in the camera's general direction for now with no vertical movement
        if(touchpadValue != Vector2.zero)
        {
            Vector3 cameraDirection = playerCamera.transform.forward;
            Vector3 moveDirection = new Vector3(cameraDirection.x, 0, cameraDirection.z);

            rb.MovePosition(moveDirection * playerSpeed * Time.deltaTime + transform.position);
            //transform.position += moveDirection * playerSpeed * Time.deltaTime;
        }
    }
}
