using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour

{
    public GameOver gameOver;
    public float maxSpeed = 7f;
    public float force;
  //Jumpforce variable
  [SerializeField] int jumpforce;

    //a true or false variable that checks the ground
    [SerializeField] bool isGrounded = false;

    [SerializeField] float horizontalMove;
    
    public Animator animator;
    
    private Rigidbody2D rb; 
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        horizontalMove = Input.GetAxisRaw("walk");
        animator.SetFloat("speed", Mathf.Abs(horizontalMove));
      if (horizontalMove > 0)
      {
        animator.SetFloat("speed", -1);
      }
      else if (horizontalMove < 0)
      {
        animator.SetFloat("speed", 1);
      }


      if (gameOver.isAlive == true)
     { 
      if (Input.GetKey(KeyCode.D))
        {
            force = 3f;
            rb.velocity = new Vector3(force * maxSpeed, rb.velocity.y);
            Vector3 movement = new Vector3(force, 0);
            rb.AddForce(Vector3.right * maxSpeed);
            Debug.Log("Key D has been pressed");
        }
      if (Input.GetKey(KeyCode.A))
        {
            force = -3f;
            rb.AddForce(Vector3.left * maxSpeed);
            Debug.Log("Key A has been pressed");
        }
      if (Input.GetKey(KeyCode.Space))     
        {
            if (isGrounded != false)
            {
              isGrounded = false;
              rb.AddForce(Vector3.up * jumpforce);
              Debug.Log("Key Space has been pressed");
            }
        }
      if (Input.GetKey(KeyCode.W))     
        {
            if (isGrounded != false)
            {
              isGrounded = false;
              rb.AddForce(Vector3.up * jumpforce);
              Debug.Log("Key W has been pressed");
            }
        }
      if (Input.GetKey(KeyCode.UpArrow))     
        {
            if (isGrounded != false)
            {
              isGrounded = false;
              rb.AddForce(Vector3.up * jumpforce);
              Debug.Log("Key Up Arrow has been pressed");
            }
        }  
      if (Input.GetKey(KeyCode.RightArrow))     
        {
            force = 3f;
            rb.AddForce(Vector3.right * maxSpeed);
            Debug.Log("Right Arrow Key has been pressed");
        }
      if (Input.GetKey(KeyCode.LeftArrow))     
        {
            force = -3f;
            rb.AddForce(Vector3.left * maxSpeed);
            Debug.Log("Key Left Arrow has been pressed");
        }
     }
    }
      //Checks if player colides with ground
      private void OnCollisionEnter2D(Collision2D collider)
      {
        if (isGrounded == false)
          {
            if (collider.gameObject.CompareTag("Ground"))
              {
                isGrounded = true;
                Debug.Log("Ground is detected");
              }
        
          }
            if(collider.gameObject.CompareTag("DeathLine"))
          {
            Debug.Log("WOMP WOMP");
            Destroy(gameObject);
            gameOver.isAlive = false;
          }
     
        
      }
}