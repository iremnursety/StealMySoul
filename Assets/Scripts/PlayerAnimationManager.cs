using UnityEngine;

public class PlayerAnimationManager : MonoBehaviour
{
    public static PlayerAnimationManager Instance { get; set; }

    [SerializeField] private Animator playerAnimator;
    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    public void Running()
    {
        playerAnimator.SetBool("Running",true);
    }

    public void Idle()
    {
        playerAnimator.SetBool("Running",false);
    }

    public void Crouch()
    {
        playerAnimator.SetBool("CrouchIdle",true);
    }

    public void CrouchWalking()
    {
        playerAnimator.SetBool("CrouchWalking",true);
    }
}