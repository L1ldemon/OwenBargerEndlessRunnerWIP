using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Difficulty : MonoBehaviour
{
    [SerializeField] GameObject Player;

    [SerializeField] List <GameObject> player_spawns = new List <GameObject> {};
    
    [SerializeField] public bool easy;
    
    [SerializeField] public bool medium;
    
    [SerializeField] public bool hard;
    
    [SerializeField] public bool insane;

    private Rigidbody2D rb;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        if(easy == true)
        {
            medium = false;
            hard = false;
            insane = false;
            transform.position = new Vector3 (1.2f, -1.66f, 0f);
            rb.constraints = RigidbodyConstraints2D.FreezeRotation;
            Debug.Log("Easy Mode selected");
        }
    if(medium == true)
        {
            easy = false;
            hard = false;
            insane = false;
            transform.position = new Vector3 (1.2f, 141.88f, 0f);
            rb.constraints = RigidbodyConstraints2D.FreezeRotation;
            Debug.Log("Medium Mode selected");
        }
    if(hard == true)
        {
            medium = false;
            easy = false;
            insane = false;
            transform.position = new Vector3 (-197.57f, 141.88f, 0f);
            rb.constraints = RigidbodyConstraints2D.FreezeRotation;
            Debug.Log("Hard Mode selected");
        }
    if(insane == true)
        {
            medium = false;
            hard = false;
            easy = false;
            transform.position = new Vector3 (-197.57f, -1.26f, 0f);
            rb.constraints = RigidbodyConstraints2D.None;
            Debug.Log("Insane Mode selected");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
