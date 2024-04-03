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
        Note.PlayerHealth -= 10;
        Note.Combo = 0;
    }
}
