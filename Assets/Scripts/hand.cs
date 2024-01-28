using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hand : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the collider we collided with has a specific tag
        if (collision.CompareTag("Bottle"))
        {
            Debug.Log("Collision with target!");
            Destroy(collision.gameObject,0);
            // You can add additional actions or logic here
        }   
    }
}
