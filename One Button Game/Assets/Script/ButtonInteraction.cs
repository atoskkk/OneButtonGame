using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonInteraction : MonoBehaviour
{

    public GameObject ButtonVisual;
    public GameObject TriggerZone;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            ButtonVisual.GetComponent<SpriteRenderer>().color = Color.green;
        }
        else
        {
            ButtonVisual.GetComponent<SpriteRenderer>().color = Color.red;
        }

    }
}
