using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Transform cameraHolder;
    [SerializeField] float mouseSensitivity;

    public float mouseSense;

    private float verticalookrotation;

    private void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        mouseSense = 1f;
    }
    private void Update()
    {
        if (!PauseMenu.GamePaused)
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            transform.Rotate(Vector3.up * Input.GetAxisRaw("Mouse X") * mouseSense);
            verticalookrotation -= Input.GetAxisRaw("Mouse Y") * mouseSense;
            verticalookrotation = Mathf.Clamp(verticalookrotation, -90f, 90f);
            cameraHolder.localEulerAngles = new Vector3(verticalookrotation, 0, 0);
        }
        else
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
