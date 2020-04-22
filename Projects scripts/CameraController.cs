
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float panSpeed = 20f;
    public float panBorderThickness = 15f;
    public Vector2 panLimit;
    public float scrollSpeed = 20f;

    public float minY = 8f;
    public float maxY = 40f;

    public float turnSpeedH = 3f;
    public float turnSpeedV = 3f;

    private float yaw = 0f;
    private float pitch = 0f;

    // Update is called once per frame
    void Update()
    {

        Vector3 pos = transform.position;
        if (Input.GetKey(KeyCode.Mouse1))
        {
            yaw += turnSpeedH * Input.GetAxis("Mouse X");
            pitch -= turnSpeedV * Input.GetAxis("Mouse Y");

            transform.eulerAngles = new Vector3(pitch, yaw, 0f);
        }

        if (Input.GetKey("w"))
        {
            pos.z += panSpeed * Time.deltaTime;

        }

        if (Input.GetKey("s"))
        {
            pos.z -= panSpeed * Time.deltaTime;

        }

        if (Input.GetKey("d"))
        {
            pos.x += panSpeed * Time.deltaTime;

        }

        if (Input.GetKey("a"))
        {
            pos.x -= panSpeed * Time.deltaTime;

        }

        float scroll = Input.GetAxis("Mouse ScrollWheel");
        pos.y -= scroll * scrollSpeed * 100f * Time.deltaTime;


        

        pos.x = Mathf.Clamp(pos.x, -panLimit.x, panLimit.x);
        pos.y = Mathf.Clamp(pos.y, minY, maxY);
        pos.z = Mathf.Clamp(pos.z, -panLimit.y, panLimit.y);

        transform.position = pos;


    }
}
