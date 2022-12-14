using UnityEngine;

public class InputManager : MonoBehaviour
{
  public static InputManager Instance { get;  set; }
  
  [SerializeField] private GameObject lights;
  [SerializeField] private PlayerController playerController;

  private void Awake()
  {
    if (Instance == null)
      Instance = this;
    else
      Destroy(gameObject);
  }

  private void Update()
  {
    if (Input.GetKeyDown(KeyCode.E))
    {
      var boolLight = lights.activeInHierarchy;
      lights.SetActive(!boolLight);
    }

    if (Input.GetKeyDown(KeyCode.LeftShift))
    {
      playerController.speed = 10f;
    }
    if (Input.GetKeyUp(KeyCode.LeftShift))
    {
      playerController.speed = 5f;
    }
  }
  
}
