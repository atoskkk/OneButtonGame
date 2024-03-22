using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteMove : MonoBehaviour
{
    public NoteData data;
    private float Velocity;

    // Update is called once per frame
    void Update()
    {
        Velocity = transform.position.x + data.NoteSpeed * Time.deltaTime * -1;
        transform.position = new Vector3(Velocity, transform.position.y, transform.position.z);
    }
}
