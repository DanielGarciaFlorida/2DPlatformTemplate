using UnityEngine;
//Import namespace to use callback
using UnityEngine.InputSystem;

public class PlayerScript : MonoBehaviour
{
    public float jumpForce = 10.0f;
    Rigidbody2D rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        
    }

    /*
    //Should be public
    public void Jump()
    {
        //This method is called 3 times:
        // - Starter: Starting Key down
        // - Performed: Performed Key down 
        // - Canceled: When key is released
        Debug.Log("Jumping");
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }
    */
    public void Jump(InputAction.CallbackContext callbackContext)
    {
        //This method is called 3 times:
        // - Starter: Starting Key down
        // - Performed: Performed Key down 
        // - Canceled: When key is released
        if (callbackContext.performed) { 
            Debug.Log("Jumping");
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
        //To check the interactions and phase understanding
        Debug.Log(callbackContext.phase);
    }
}
