using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaminaUse : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (ShowStamina.staminaNum >= 25)
        {
            if (Input.GetKey(KeyCode.E) && ShowStamina.staminaNum >= 50)
                ShowStamina.staminaNum -= 50;
            else if (Input.GetKeyDown(KeyCode.Q) && ShowStamina.staminaNum >= 15)
                ShowStamina.staminaNum -= 25;
        }
        else
            StartCoroutine(rest());
    }

    IEnumerator rest()
    {
        yield return new WaitForSeconds(10);
        ShowStamina.staminaNum = 100;
    }
}
