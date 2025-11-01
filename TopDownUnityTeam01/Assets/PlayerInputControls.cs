using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class PlayerInputControls : MonoBehaviour
{
    Rigidbody2D rigidbody2D;
    Animator animator;
    [SerializeField] private float moveSpeed = 2f;

    void Awake()

    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();

    }
    [SerializeField] UnityEvent triggered;
    public void OnInteract(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            triggered?.Invoke();
        }
    }
   
}
