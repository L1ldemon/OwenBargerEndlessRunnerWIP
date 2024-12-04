using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour

{
    public GameOver gameOver;
    [SerializeField] float force;
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
            rb.AddForce(Vector3.right * force);
            Debug.Log("Key D has been pressed");
        }
      if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector3.left * force);
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
            rb.AddForce(Vector3.right * force);
            Debug.Log("Key Right Arrow has been pressed");
        }
      if (Input.GetKey(KeyCode.LeftArrow))     
        {
            rb.AddForce(Vector3.left * force);
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
            Debug.Log ("Sad Spongebob Music WOMP WOMP XD");
            Destroy(gameObject);
            gameOver.isAlive = false;
          }
     
        
      }
}