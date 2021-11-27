using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartFlames : MonoBehaviour
{
    // Start is called before the first frame update
    public ParticleSystem[] fires;
    void Start()
    {
        for (int i = 0; i < fires.Length; i++)
            fires[i] = transform.GetChild(i).gameObject.GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if(MissionChange.missionNum == 3)
        {
            if(ObjectiveList.objectiveNum == 4)
            {
                for(int i = 0; i < fires.Length; i++)
                {
                    fires[i].Play();
                }
            }
        }
    }
}
