using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TriggerActivation : MonoBehaviour
{
    public TriggerData Data;
    public GameObject[] Note;

    private void Awake()
    {
        Data.FirstTrigger = false;
        Data.SecondTrigger = false;
        Data.ThirdTrigger = false;
    }

    private void Start()
    {
        Note = new GameObject[1];
    }
    private void OnTriggerStay(Collider other)
    {
        if (CompareTag("First"))
        {
            Data.FirstTrigger = true;
            Note[0] = other.gameObject;
        }
        if (CompareTag("Second"))
        {
            Data.SecondTrigger = true;
        }
        if (CompareTag("Third"))
        {
            Data.ThirdTrigger = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (CompareTag("First"))
        {
            Data.FirstTrigger = false;
        }
        if (CompareTag("Second"))
        {
            Data.SecondTrigger = false;
        }
        if (CompareTag("Third"))
        {
            Data.ThirdTrigger = false;
        }
        if((Data.FirstTrigger == false) && (Data.SecondTrigger == false) && (Data.ThirdTrigger == false))
        {
            Array.Clear(Note, 0, Note.Length);
        }
    }

    
}
