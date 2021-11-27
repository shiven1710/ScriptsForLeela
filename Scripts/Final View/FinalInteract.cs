using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FinalInteract : MonoBehaviour
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
    private Vector3 hidePos = new Vector3(740, 1000, 0);
    private Vector3 showPos = new Vector3(740, 348, 0);
    void Start()
    {
        talk = GetComponent<Button>();
        talk.gameObject.GetComponent<RectTransform>().localPosition = hidePos;
        talktext.text = "Interact";
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
                if (MissionChange.missionNum == 4)
                {
                    talk.gameObject.GetComponent<RectTransform>().localPosition = showPos;
                    if (ObjectiveList.objectiveNum == 3)
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
