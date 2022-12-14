using UnityEngine;

public class CameraLookController : MonoBehaviour
{
    [Range(50, 500)] [SerializeField] private float sensitivity;
       [SerializeField] private Transform player;
       [SerializeField] private float xRot;
   
       private void OnValidate()
       {
           player = transform.parent;
       }

       private void Start()
       {
           xRot = 0f;
       }

       private void Update()
       {
           float rotX = Input.GetAxisRaw("Mouse X") * sensitivity * Time.deltaTime;
           float rotY = Input.GetAxisRaw("Mouse Y") * sensitivity * Time.deltaTime;

           xRot -= rotY;
           xRot = Mathf.Clamp(xRot, -80f, 30f);

           transform.localRotation = Quaternion.Euler(xRot, 0f, 0f);
           player.Rotate(Vector3.up * rotX);
       }
}
