using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropApple : MonoBehaviour
{
    public GameObject player;
    public GameObject tree;
    public Rigidbody[] apples;
    private int ind;
    private Vector3 tree_pos;
    private float diffX;
    private float diffZ;
    private float thresholdX;
    private float thresholdZ;
    // Start is called before the first frame update
    void Start()
    {
        tree_pos = tree.transform.position;
        ind = 0;
        thresholdX = 5;
        thresholdZ = 5;
    }

    // Update is called once per frame
    void Update()
    {
        diffX = Mathf.Abs(Mathf.Abs(tree_pos.x) - Mathf.Abs(player.transform.position.x));
        diffZ = Mathf.Abs(Mathf.Abs(tree_pos.z) - Mathf.Abs(player.transform.position.z));
        if (diffX <= thresholdX)
        {
            if (diffZ <= thresholdZ)
            {
                if (Input.GetKey(KeyCode.Q) || Input.GetKeyDown(KeyCode.E))
                {
                    if (ind < 6)
                    {
                        apples[ind].useGravity = true;
                        StopAllCoroutines();
                        StartCoroutine(Wait());
                    }
                }
            }
        }
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(2);
        ind++;
        if (ind == 6)
            ObjectiveList.objectiveNum++;
    }
}
