using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Button startGame;
    public Button exitGame;
    public Text gameName;
    public Text missionName;
    public Text objectiveName;
    private Vector3 ExithidePos;
    // Start is called before the first frame update
    void Start()
    {
        ExithidePos = new Vector3(0, 1000, 0);
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        Time.timeScale = 1;
        startGame.gameObject.SetActive(false);
        gameName.gameObject.SetActive(false);
        exitGame.gameObject.GetComponent<RectTransform>().localPosition = ExithidePos;
        missionName.gameObject.SetActive(true);
        objectiveName.gameObject.SetActive(true);

    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
