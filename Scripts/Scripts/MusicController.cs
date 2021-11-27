using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{
    public AudioSource[] phases;
    private bool phase1;
    private bool phase2;
    private bool phase3;
    private bool phase4;
    // Start is called before the first frame update
    void Start()
    {
        phases[0].Play();
        phase1 = false;
        phase2 = false;
        phase3 = false;
        phase4 = false;
    }

    void Update()
    {
        if(!phase1)
        {
            if (MissionChange.missionNum == 3 && ObjectiveList.objectiveNum < 4)
            {
                PlayPhase1();
                phase1 = true;
            }
        }
        else if(!phase2)
        {
            if(MissionChange.missionNum == 3 && ObjectiveList.objectiveNum == 4)
            {
                PlayPhase2();
                phase2 = true;
            }
        }
        else if(!phase3)
        {
            if(MissionChange.missionNum == 4 && ObjectiveList.objectiveNum == 2)
            {
                PlayPhase3();
                phase3 = true;
            }
        }
        else if(!phase4)
        {
            if(MissionChange.missionNum == 4 && ObjectiveList.objectiveNum == 3)
            {
                PlayPhase4();
                phase4 = true;
            }
        }
    }

    void PlayPhase1()
    {
        phases[0].Stop();
        phases[1].Play();
    }

    void PlayPhase2()
    {
        phases[1].Stop();
        phases[2].Play();
    }

    void PlayPhase3()
    {
        phases[2].Stop();
        phases[3].Play();
    }
    void PlayPhase4()
    {
        phases[1].Play(); 
    }
}
