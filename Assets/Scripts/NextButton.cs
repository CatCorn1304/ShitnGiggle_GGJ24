using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextButton : MonoBehaviour
{
    public GameObject pButton;
    void Start()
    {
        StartCoroutine(countPlay());
    }

    IEnumerator countPlay()
    {
       
        yield return new WaitForSeconds(5);
        print(Time.time);
    }
    // Update is called once per frame
    void Update()
    {
       
    }
}
