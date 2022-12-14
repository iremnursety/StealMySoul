using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private CharacterController controller;

    [SerializeField] private bool isGrounded;
    [SerializeField] private Transform ground;
    [SerializeField] private float distance = 0.3f;

    public float speed = 2f;
    [SerializeField] private float jumpHeight = 1f;
    [SerializeField] private float gravity = -20f;


    [SerializeField] private LayerMask mask;

    [SerializeField] private float horizontal;
    [SerializeField] private float vertical;

    private Vector3 velocity;

    private void OnValidate()
    {
        controller = GetComponent<CharacterController>();
    }

    private void Start()
    {
        speed = 5f;
        Cursor.lockState = CursorLockMode.Locked;
        gravity = -20f;
    }

    private void Update()
    {
        #region Movement

        MoveCharacter();
        /*if (Input.GetKeyDown(KeyCode.W))
        {
            animator.SetBool("isWalking", true);
        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            animator.SetBool("isWalking", false);
        }*/

        #endregion


        #region Jump Zıplama

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            velocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravity);
        }

        // if (Input.GetKeyUp(KeyCode.Space) && isGrounded || !isGrounded)
        // {
        //     //animator.SetBool("isJumping", false);
        // }

        #endregion

        #region Gravity Yerçekimi

        isGrounded = Physics.CheckSphere(ground.position, distance, mask);
        if (isGrounded && velocity.y < 0)
        {
            velocity.y = 0f;
        }

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);

        #endregion
    }

    private void MoveCharacter()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        Vector3 move = transform.right * horizontal + transform.forward * vertical;
        controller.Move(Time.deltaTime*speed * move );
    }
}