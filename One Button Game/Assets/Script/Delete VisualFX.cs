using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DeleteVisualFX : MonoBehaviour
{
    public NoteData Data;

    private void Update()
    {
        if(Data.SequenceCompleted == true)
        {
            Destroy(gameObject);
        }
    }
}
