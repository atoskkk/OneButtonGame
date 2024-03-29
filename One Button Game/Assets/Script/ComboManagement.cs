using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ComboManagement : MonoBehaviour
{
    public TriggerData Data;
    public NoteData Note;

    private void Start()
    {
        Note.Combo = 0;
        Note.Misses = 0;
    }
    public void Combo_feedback()
    {
        if ((Data.FirstTrigger == true) && (Data.SecondTrigger == true) && (Data.ThirdTrigger == true))
        {
            Note.Combo++;
            Debug.Log("SICK !!!");
            return;
        }
        if (((Data.FirstTrigger == true) && (Data.SecondTrigger == true) && (Data.ThirdTrigger == false)) || ((Data.ThirdTrigger == true) && (Data.SecondTrigger == true) && (Data.FirstTrigger == false)))
        {
            Note.Combo++;
            Debug.Log("Okay !");
            return;
        }
        if (((Data.FirstTrigger == true) && (Data.ThirdTrigger == false) && (Data.SecondTrigger == false)) || ((Data.ThirdTrigger == true)) && (Data.FirstTrigger == false) && (Data.SecondTrigger == false))
        {
            Note.Combo++;
            Debug.Log("Meh...");
            return;
        }

        return;
    }
}
