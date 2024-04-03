using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HUDManagement : MonoBehaviour
{
    public TextMeshProUGUI Text;
    public NoteData Data;

    private void Awake()
    {
        Text = gameObject.GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        if(CompareTag("Combo") == true)
        {
            Text.text = Data.Combo.ToString();
        }
        if(CompareTag("Misses") == true)
        {
            Text.text = Data.Misses.ToString();
        }
        if(CompareTag("Health") == true)
        {
            Text.text = Data.PlayerHealth.ToString();
        }
    }
}
