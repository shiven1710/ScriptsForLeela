using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageTaken : MonoBehaviour
{
    private bool regenActive;
    // Start is called before the first frame update
    void Start()
    {
        regenActive = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(ShowHealth.healthNum < 100)
        {
            if (ShowHealth.healthNum == 0)
                Destroy(gameObject);
            if (!regenActive)
            {
                StartCoroutine(regen());
            }
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
            ShowHealth.healthNum -= 5;
        else if (collision.gameObject.tag == "Boss")
            ShowHealth.healthNum -= 15;
    }

    IEnumerator regen()
    {
        if (ShowHealth.healthNum + 20 > 100)
            ShowHealth.healthNum = 100;
        else
            ShowHealth.healthNum += 20;
        regenActive = true;
        yield return new WaitForSeconds(30);
        regenActive = false;
    }
}
