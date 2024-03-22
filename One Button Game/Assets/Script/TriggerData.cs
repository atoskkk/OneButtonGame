using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/TriggerData", order = 1)]
public class TriggerData : ScriptableObject
{
    public bool FirstTrigger = false;
    public bool SecondTrigger = false;
    public bool ThirdTrigger = false;
    public bool IsOccupied = false;
}
