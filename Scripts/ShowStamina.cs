using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowStamina : MonoBehaviour
{
    // Start is called before the first frame update
    public Text stamina;
    private Text staminaCounter;
    void Start()
    {
        staminaCounter = stamina.GetComponent<Text>();
        staminaCounter.text = "Stamina:100";
        stamina.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
