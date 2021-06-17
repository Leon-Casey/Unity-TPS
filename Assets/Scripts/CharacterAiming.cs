using UnityEngine;
using Cinemachine;

public class CharacterAiming : MonoBehaviour
{
    //[SerializeField]
    //private float sensitivity = 1f;
    [SerializeField]
    public float turnSpeed = 15f;

    //private CinemachineVirtualCamera cinemachineCamera;
    Camera mainCamera;

    // Start is called before the first frame update
    void Start()
    {
        //cinemachineCamera = GetComponent<CinemachineVirtualCamera>();
        mainCamera = Camera.main;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        //float vertical = Input.GetAxis("Mouse Y") * sensitivity;
        //float horizontal = Input.GetAxis("Mouse X") * sensitivity;

        //cinemachineCamera.GetInputAxisProvider()

        float yawCamera = mainCamera.transform.rotation.eulerAngles.y;
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, yawCamera, 0), turnSpeed * Time.deltaTime);
    }
}
