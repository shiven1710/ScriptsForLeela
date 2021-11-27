using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowStamina : MonoBehaviour
{
    public Text stamina;
    public static int staminaNum;
    // Start is called before the first frame update
    void Start()
    {
        stamina = GetComponent<Text>();
        staminaNum = 100;
        stamina.text = "Stamina:" + staminaNum.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (MissionChange.missionNum == 3)
        {
            if (ObjectiveList.objectiveNum == 4)
            {
                stamina.enabled = true;
                stamina.text = "Stamina:" + staminaNum.ToString();
            }
            else
                stamina.enabled = false;
        }
        else if (MissionChange.missionNum == 4)
        {
            if (ObjectiveList.objectiveNum == 2)
            {
                stamina.enabled = true;
                stamina.text = "Stamina:" + staminaNum.ToString();
            }
            else
                stamina.enabled = false;
        }
        else
            stamina.enabled = false;
    }
}
