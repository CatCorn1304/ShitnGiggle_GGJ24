using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class head : MonoBehaviour
{

    public int health = 10;
    public Sprite[] diffAces;
    private int index;
    SpriteRenderer heads;

    private void Awake()
    {
        heads = gameObject.GetComponent<SpriteRenderer>();
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
            health--;

            var index = UnityEngine.Random.Range(0, diffAces.Length);
            heads.sprite = diffAces[index];

            if (health == 0)
            {

            }
        }   
    }
    private void OnCollisionEnter2D(Collision2D collision){
        Destroy(collision.gameObject);
    }
}
