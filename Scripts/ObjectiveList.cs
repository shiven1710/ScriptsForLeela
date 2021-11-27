using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectiveList : MonoBehaviour
{
    // Start is called before the first frame update
    private Text objectiveName;
    public static int objectiveNum = 1;
    void Start()
    {
        objectiveName = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if(MissionChange.missionNum == 1)
        {
            if (objectiveNum == 1)
                objectiveName.text = "Talk to Hugh";
            else if (objectiveNum == 2)
                objectiveName.text = "Deliver the fish to Agnes";
            else
            {
                objectiveName.text = "Mission Complete";
                MissionChange.missionNum++;
                objectiveNum = 1;
            }
        }
        else if(MissionChange.missionNum == 2)
        {
            if (objectiveNum == 1)
                objectiveName.text = "Go to your room beside the docks";
            else if (objectiveNum == 2)
                objectiveName.text = "Leave the village";
            else
            {
                objectiveName.text = "Mission Complete";
                MissionChange.missionNum++;
                objectiveNum = 1;
            }
        }
        else if(MissionChange.missionNum == 3)
        {
            if (objectiveNum == 1)
                objectiveName.text = "Find the apple tree";
            else if (objectiveNum == 2)
                objectiveName.text = "Shoot down the apple on the tallest branch";
            else if (objectiveNum == 3)
                objectiveName.text = "Collect the apples";
            else if (objectiveNum == 4)
                objectiveName.text = "Defeat the soldiers";
            else
            {
                objectiveName.text = "Mission Complete";
                MissionChange.missionNum++;
                objectiveNum = 1;
            }
        }
        else if(MissionChange.missionNum == 4)
        {
            if (objectiveNum == 1)
                objectiveName.text = "Go to your room in the village";
            else if (objectiveNum == 2)
                objectiveName.text = "Defeat the Brute";
            else if (objectiveNum == 3)
                objectiveName.text = "Escape the village";
            else
            {
                objectiveName.text = "";
                MissionChange.missionNum++;
                objectiveNum = 1;
            }
        }
    }
}
