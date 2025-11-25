using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerScript : MonoBehaviour
{
    public float Force = 10f;
    public float speed = 5f;
    public Vector2 move;
    Rigidbody2D rb;
    PlayerInput input;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        input = GetComponent<PlayerInput>();
    }

    // Update is called once per frame
    void Update()
    {
        move = input.actions["Move"].ReadValue<Vector2>();

    }

	private void FixedUpdate()
	{
		rb.linearVelocityX = move.x * speed;
	}

	public void Jump(InputAction.CallbackContext callbackContext)
    {
        Debug.Log(callbackContext.phase);
        if (callbackContext.performed)
        {
			Debug.Log("Jumping");
            rb.AddForce(Vector2.up * Force, ForceMode2D.Impulse);
		}
      

    }
}
