using UnityEngine;

public class CameraFOV : MonoBehaviour
{
    Camera camara;

    void Start()
    {
        camara = GetComponent<Camera>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            camara.fieldOfView -= 5;
        }

        if (Input.GetKeyDown(KeyCode.Y))
        {
            camara.fieldOfView += 5;
        }

        camara.fieldOfView = Mathf.Clamp(camara.fieldOfView, 50, 120);
    }
}