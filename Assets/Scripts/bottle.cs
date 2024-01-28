using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bottle : MonoBehaviour
{

    public float speed = 0.5f;
    public float rSpeed = 0.5f;

    public Transform targetObject; // The object to move towards

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        if (targetObject != null)
        {
            MoveTowardsTarget();
        }
        else
        {
            //Debug.LogError("Target object not assigned. Please assign a target object in the Inspector.");
        }

    }

    void MoveTowardsTarget()
    {
        // Calculate the direction to the target
        Vector3 direction = targetObject.position - transform.position;

        // Normalize the direction to get a unit vector
        direction.Normalize();

        // Move towards the target
        transform.Translate(direction * speed * Time.deltaTime);
    }
}
