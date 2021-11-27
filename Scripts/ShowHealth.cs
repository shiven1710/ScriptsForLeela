using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowHealth : MonoBehaviour
{
    public Text health;
    public static int healthNum;
    // Start is called before the first frame update
    void Start()
    {
        health = GetComponent<Text>();
        healthNum = 100;
        health.text = "Health:" + healthNum.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (MissionChange.missionNum == 3)
        {
            if (ObjectiveList.objectiveNum == 4)
            {
                health.enabled = true;
                health.text = "Health:" + healthNum.ToString();
            }
            else
                health.enabled = false;
        }
        else if (MissionChange.missionNum == 4)
        {
            if (ObjectiveList.objectiveNum == 2)
            {
                health.enabled = true;
                health.text = "Health:" + healthNum.ToString();
            }
            else
                health.enabled = false;
        }
        else
            health.enabled = false;
    }
}
