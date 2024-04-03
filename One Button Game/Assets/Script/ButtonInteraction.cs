using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonInteraction : MonoBehaviour
{

    public GameObject ButtonVisual, DestroyNote;
    public TriggerData Data;
    public GameObject VisualFX;
    public Animator Button;
    public NoteData Note;

    private ComboManagement Combo;
    private void Start()
    {
        Note.Combo = 0;
        Note.Misses = 0;
        Combo = gameObject.GetComponent<ComboManagement>();
    }

    // Update is called once per frame
    void Update()
    {
        GameObject Trigger = DestroyNote.GetComponent<EnterButton>().Note[0];
        Debug.Log(Trigger);
        Note.SequenceCompleted = false;
        if (Input.GetKeyDown("space"))
        {
            
            Combo.Combo_feedback();
            Button.SetTrigger("Pushed");
            Instantiate(VisualFX);

            Data.IsOccupied = false;
            Data.FirstTrigger = false;
            Data.SecondTrigger = false;
            Data.ThirdTrigger = false;
            GameObject.Destroy(Trigger);
            Note.SequenceCompleted = true;
        }
    }


}
