using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowHealth : MonoBehaviour
{
    // Start is called before the first frame update
    public Text health;
    private Text healthCounter;
    void Start()
    {
        healthCounter = health.GetComponent<Text>();
        healthCounter.text = "Health:100";
        health.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
