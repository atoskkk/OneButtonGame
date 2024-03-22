using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonInteraction : MonoBehaviour
{

    public GameObject ButtonVisual, DestroyNote;
    public TriggerData Data;
    public ComboManagement Combo;


    private void Start()
    {
        Combo = gameObject.GetComponent<ComboManagement>();
    }

    // Update is called once per frame
    void Update()
    {
        GameObject Trigger = DestroyNote.GetComponent<TriggerActivation>().Note[0];
        Debug.Log(Trigger);
        if (Input.GetKeyDown("space"))
        {
            Combo.Combo_feedback();

            ButtonVisual.GetComponent<SpriteRenderer>().color = Color.white;
            Data.IsOccupied = true;
            Data.FirstTrigger = false;
            Data.SecondTrigger = false;
            Data.ThirdTrigger = false;
            GameObject.Destroy(Trigger);
        }

    }


}
