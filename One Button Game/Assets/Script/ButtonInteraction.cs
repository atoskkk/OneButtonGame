using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonInteraction : MonoBehaviour
{

    public GameObject ButtonVisual, DestroyNote;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space"))
        {
            ButtonVisual.GetComponent<SpriteRenderer>().color = Color.white;
        }
        else
        {
            ButtonVisual.GetComponent<SpriteRenderer>().color = Color.gray;
        }
        GameObject Flour = DestroyNote.GetComponent<TriggerActivation>().Note[0];
        Debug.Log(Flour);
    }


}
