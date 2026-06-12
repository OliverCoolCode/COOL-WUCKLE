using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    [SerializeField] private Transform cameraPos;
    [SerializeField] private float mousesensX;
    [SerializeField] private float mousesensY;

    private float rotationX;
    private float rotationY;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * mousesensX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * mousesensY;

        rotationX -= mouseY;
        rotationY += mouseX;


        transform.rotation = Quaternion.Euler(rotationX, rotationY, 0);
        transform.position = cameraPos.position;
    }
}
