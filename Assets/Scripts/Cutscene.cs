using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cutscene : MonoBehaviour
{
    [SerializeField] GameObject button, tittle, wizard, bubble, play;

    

    public void turnOff()
    {
        button.SetActive(false);
        tittle.SetActive(false);
        wizard.SetActive(true);
        bubble.SetActive(true);


    }
}
