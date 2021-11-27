using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public Button resume;
    public Button exit;
    private Vector3 ResumehidePos;
    private Vector3 ResumeshowPos;
    private Vector3 ExithidePos;
    private Vector3 ExitshowPos;
    // Start is called before the first frame update
    void Start()
    {
        resume = resume.GetComponent<Button>();
        exit = exit.GetComponent<Button>();
        ResumehidePos = new Vector3(0, 1000, 0);
        resume.gameObject.GetComponent<RectTransform>().localPosition = ResumehidePos;
        ResumeshowPos = new Vector3(0, 174, 0);
        ExithidePos = new Vector3(0, 1000, 0);
        ExitshowPos = new Vector3(0, 43, 0);
        resume.interactable = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0;
            resume.gameObject.GetComponent<RectTransform>().localPosition = ResumeshowPos;
            exit.gameObject.GetComponent<RectTransform>().localPosition = ExitshowPos;
            resume.interactable = true;
            exit.interactable = true;
        }
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        resume.gameObject.GetComponent<RectTransform>().localPosition = ResumehidePos;
        exit.gameObject.GetComponent<RectTransform>().localPosition = ExithidePos;
        resume.interactable = false;
        exit.interactable = false;
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
