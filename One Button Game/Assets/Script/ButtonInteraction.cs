using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonInteraction : MonoBehaviour
{

    public GameObject ButtonVisual, DestroyNote, VisualFX, GameOver;
    public TriggerData Data;
    public Animator Button;
    public NoteData Note;
    public AudioSource Music;

    private ComboManagement Combo;
    private void Start()
    {
        Note.Combo = 0;
        Note.Misses = 0;
        Note.PlayerHealth = 100;
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

            if((Note.PlayerHealth < 100) && (Data.IsOccupied == true))
            {
                Note.PlayerHealth += 5;
            }
            Note.SequenceCompleted = true;
        }
        if(Note.PlayerHealth <= 0)
        {
            Music.Stop();
            Destroy(ButtonVisual);
            GameOver.SetActive(true);
        }
    }


}
