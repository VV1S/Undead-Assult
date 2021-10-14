using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class WeaponZoom : MonoBehaviour
{
    [SerializeField] Camera fpsCamera;
    [SerializeField] float zoomedOutFOV = 60;
    [SerializeField] float zoomedInFOV = 20;
    [SerializeField] float zoomOutSensitivity = 2f;
    [SerializeField] float zoomInSensitivity = 0.2f;

    RigidbodyFirstPersonController fpsController;

    bool zoomedInToggle = false;

    private void Start()
    {
        fpsController = GetComponent<RigidbodyFirstPersonController>();
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
           if( zoomedInToggle == false)
            {
                zoomedInToggle = true;
                ZoomIn();
            }
           else
            {
                zoomedInToggle = false;
                ZoomOut();
            }
        }
    }
    void ZoomIn()
    {
        fpsCamera.fieldOfView = zoomedInFOV;
        fpsController.mouseLook.XSensitivity = zoomInSensitivity;
        fpsController.mouseLook.YSensitivity = zoomInSensitivity;
    }

    void ZoomOut()
    {
        fpsCamera.fieldOfView = zoomedOutFOV;
        fpsController.mouseLook.XSensitivity = zoomOutSensitivity;
        fpsController.mouseLook.YSensitivity = zoomOutSensitivity;
    }
}
