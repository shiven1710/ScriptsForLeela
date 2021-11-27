using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowSpell : MonoBehaviour
{
    // Start is called before the first frame update
    public ParticleSystem spell;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q) && ShowStamina.staminaNum >= 25)
            spell.Play();
        else if(Input.GetKey(KeyCode.E) && ShowStamina.staminaNum >= 50)
            spell.Play();
        else
            spell.Stop();

    }
}
