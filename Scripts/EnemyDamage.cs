using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    // Start is called before the first frame update
    private int health;
    public GameObject player;
    public GameObject enemy;
    private float thresholdX;
    private float thresholdZ;
    private float diffX;
    private float diffZ;
    void Start()
    {
        health = 100;
        thresholdX = 2;
        thresholdZ = 2;
    }

    // Update is called once per frame
    void Update()
    {
        diffX = Mathf.Abs(Mathf.Abs(enemy.transform.position.x) - Mathf.Abs(player.transform.position.x));
        diffZ = Mathf.Abs(Mathf.Abs(enemy.transform.position.z) - Mathf.Abs(player.transform.position.z));
        if (diffX <= thresholdX)
        {
            if (diffZ <= thresholdZ)
            {
                if (Input.GetKey(KeyCode.E) && ShowStamina.staminaNum >= 50)
                    health -= 20;
                else if (Input.GetKeyDown(KeyCode.Q) && ShowStamina.staminaNum >= 25)
                    health -= 10;
                else if (Input.GetKeyDown(KeyCode.Z))
                    health -= 5;
            }
        }
        if (health <= 0)
        {
            Destroy(enemy);
            StartEnemy.spawnWave++;
        }
    }
}
