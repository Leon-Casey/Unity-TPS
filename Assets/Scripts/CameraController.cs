using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    private float sensitivity = 1f;

    public Transform crosshair;
    public Camera cam;
    public Transform muzzle;

    //private CinemachineComposer composer;

    private void Start()
    {
        //composer = GetComponent <CinemachineVirtualCamera>().GetCinemachineComponent<CinemachineComposer>();
    }

    private void Update()
    {


        //float vertical = Input.GetAxis("Mouse Y") * sensitivity;
        //float horizontal = Input.GetAxis("Mouse X") * sensitivity;

        //Vector3 mousePos = Input.mousePosition;
        //mousePos.z = transform.position.z - Camera.main.transform.position.z;
        //transform.position = Camera.main.ScreenToWorldPoint(mousePos);
    }
}
