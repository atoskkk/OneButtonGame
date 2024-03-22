using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TriggerActivation : MonoBehaviour
{
    public TriggerData Data;
    public GameObject[] Note;
    private Collider Trigger;


    private void Awake()
    {
        Data.FirstTrigger = false;
        Data.SecondTrigger = false;
        Data.ThirdTrigger = false;
        Data.IsOccupied = false;
    }

    private void Start()
    {
        Note = new GameObject[1];
    }
    private void OnTriggerStay(Collider other)
    {

        if ((CompareTag("First")) && (Data.IsOccupied == false))
        {
            Data.FirstTrigger = true;
            if (Note[0] != null)
            {
                Note[0] = Trigger.gameObject;
                Debug.Log("Executed");
                Data.IsOccupied = true;
            }
            else
            {
                Note[0] = other.gameObject;
                Debug.Log("Executed");
                Data.IsOccupied = true;
            }
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

    private void Update()
    {
        if ((Data.FirstTrigger == false) && (Data.SecondTrigger == false) && (Data.ThirdTrigger == false))
        {
            Array.Clear(Note, 0, Note.Length);
            Data.IsOccupied = false;
        }
    }

}
