using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeelaContinueDialogue : MonoBehaviour
{
    // Start is called before the first frame update
    public Button talk;
    public Text talktext;
    public GameObject NPC;
    public GameObject Player;
    private float thresholdX;
    private float thresholdZ;
    private float diffX;
    private float diffZ;
    private Vector3 hidePos = new Vector3(740, 500, 0);
    private Vector3 showPos = new Vector3(740, 290, 0);
    void Start()
    {
        talk = GetComponent<Button>();
        talk.gameObject.GetComponent<RectTransform>().localPosition = hidePos;
        talktext.text = "Continue";
        talk.interactable = false;
        thresholdX = 2;
        thresholdZ = 2;
    }
    void Update()
    {
        diffX = Mathf.Abs(Mathf.Abs(NPC.transform.position.x) - Mathf.Abs(Player.transform.position.x));
        diffZ = Mathf.Abs(Mathf.Abs(NPC.transform.position.z) - Mathf.Abs(Player.transform.position.z));
        if (diffX <= thresholdX)
        {
            if (diffZ <= thresholdZ)
            {
                talk.gameObject.GetComponent<RectTransform>().localPosition = showPos;
                if (MissionChange.missionNum == 2)
                {
                    if (ObjectiveList.objectiveNum == 1)
                        talk.interactable = true;
                    else
                        talk.interactable = false;
                }
                else
                    talk.interactable = false;
            }
            else
            {
                talk.gameObject.GetComponent<RectTransform>().localPosition = hidePos;
                talk.interactable = false;
            }
        }
        else
        {
            talk.gameObject.GetComponent<RectTransform>().localPosition = hidePos;
            talk.interactable = false;
        }
    }
}
