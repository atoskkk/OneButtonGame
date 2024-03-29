using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class EnterButton : MonoBehaviour
{
    public TriggerData Data;
    public GameObject[] Note;
    public Collider Trigger;

    private void Start()
    {
        Note = new GameObject[1];
    }

    private void OnTriggerStay(Collider other)
    {
        if (Data.IsOccupied == false)
        {
            if (Note[0] != null)
            {
                Note[0] = Trigger.gameObject;
            }
            else
            {
                Note[0] = other.gameObject;
                Data.IsOccupied = true;
            }
        }
        if (Note[0] == null)
        {
            Data.IsOccupied = false;
        }
        Trigger = other;
    }

    private void OnTriggerExit(Collider other)
    {
        Data.IsOccupied = false;
    }

}
