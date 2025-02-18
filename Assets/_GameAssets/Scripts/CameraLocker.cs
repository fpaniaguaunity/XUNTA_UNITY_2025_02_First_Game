using UnityEngine;

public class CameraLocker : MonoBehaviour
{
    Vector3 cameraRotation;
    void Start()
    {
        cameraRotation = transform.localEulerAngles;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.localEulerAngles = cameraRotation;
    }
}
