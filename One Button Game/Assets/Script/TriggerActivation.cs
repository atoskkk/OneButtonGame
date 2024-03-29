using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TriggerActivation : MonoBehaviour
{
    public TriggerData Data;
    private Collider Trigger;


    private void Awake()
    {
        Data.FirstTrigger = false;
        Data.SecondTrigger = false;
        Data.ThirdTrigger = false;
        Data.IsOccupied = false;
    }


    private void OnTriggerStay(Collider other)
    {

        if (CompareTag("First"))
        {
            Data.FirstTrigger = true;
        }
        if (CompareTag("Second"))
        {
            Data.SecondTrigger = true;
        }
        if (CompareTag("Third"))
        {
            Data.ThirdTrigger = true;
        }
        Trigger = other;
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
    }


}
