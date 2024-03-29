using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NoteData", menuName = "ScriptableObjects/NoteData", order = 2)]
public class NoteData : ScriptableObject
{
    public float NoteSpeed = 10;
    public int Misses = 0;
    public int Combo = 0;
    public bool SequenceCompleted = false;
}