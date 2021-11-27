using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] enemies;
    public static int spawnWave;
    void Start()
    {
        spawnWave = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(MissionChange.missionNum == 3)
        {
            if(ObjectiveList.objectiveNum == 4)
            {
                if(spawnWave == 0)
                {
                    enemies[0].SetActive(true);
                    enemies[1].SetActive(true);
                }
                else if(spawnWave == 2)
                {
                    enemies[2].SetActive(true);
                    enemies[3].SetActive(true);
                    enemies[4].SetActive(true);
                }
                else if(spawnWave == 5)
                {
                    enemies[5].SetActive(true);
                    enemies[6].SetActive(true);
                }
                else if(spawnWave == 7)
                    ObjectiveList.objectiveNum++;
            }
        }
        else if(MissionChange.missionNum == 4)
        {
            if (ObjectiveList.objectiveNum == 2 && spawnWave == 7)
                enemies[7].SetActive(true);
            else if (spawnWave == 8)
                ObjectiveList.objectiveNum++;
        }
    }
}
