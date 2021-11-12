using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MissionChange : MonoBehaviour
{
    // Start is called before the first frame update
    private Text missionName;
    public static int missionNum = 1;
    void Start()
    {
        missionName = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (missionNum == 1)
            missionName.text = "Mission: A Slow Start";
        else if (missionNum == 2)
            missionName.text = "Mission: Time for Myself";
        else if (missionNum == 3)
            missionName.text = "Mission: Broken Solace";
        else if (missionNum == 4)
            missionName.text = "Mission: Into the Ashes";
        else
            missionName.text = "Game Complete!";
    }
}
