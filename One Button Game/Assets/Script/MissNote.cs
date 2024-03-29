using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissNote : MonoBehaviour
{
    public NoteData Note;
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        Note.Misses++;
        Note.Combo = 0;
    }
}
