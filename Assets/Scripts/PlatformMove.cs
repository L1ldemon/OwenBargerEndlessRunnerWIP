using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMove : MonoBehaviour
{
    [SerializeField] float currentspeed;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
        {
            transform.Translate(Vector3.left * currentspeed * Time.deltaTime);
        }
         
        private void OnTriggerEnter2D(Collider2D collider)
        {
            if(collider.gameObject.CompareTag("Deathlineforplatforms"))
            {
                Debug.Log("Platform go bye bye");
                Destroy(gameObject);
            }
        }
}