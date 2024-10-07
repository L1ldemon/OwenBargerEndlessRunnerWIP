using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour
{
    [SerializeField] GameOver gameOver;
    
    [SerializeField] GameObject platform;
    
    [SerializeField] List <GameObject> spawnPositions = new List <GameObject> {};
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
    
    //Makes next platform
    private void GenerateNextPlatform()
    {
      float randomWait = Random.Range(2.0f, 5.0f);
      Invoke ("GeneratePlatform", randomWait);
      
    }
    
    private void GeneratePlatform()
    {
     foreach (var spawnpoint in spawnPositions)
     { 
      Vector3 pos = new Vector3 (spawnpoint.transform.position.x, spawnpoint.transform.position.y, spawnpoint.transform.position.z);
      GameObject platformInstantiate = Instantiate(platform, pos, Quaternion.identity);
     }
    }
    
    private void OnTriggerEnter2D(Collider2D collider)
    {  
      if(gameOver.isAlive != false)
      {
        Debug.Log("Game be functioning :)");
        if (collider.gameObject.CompareTag("Ground"))
        {
          Debug.Log("Platform is ready to be made");
          GenerateNextPlatform();
        }
      }
    }
}