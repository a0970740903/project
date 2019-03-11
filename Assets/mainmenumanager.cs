using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class mainmenumanager : MonoBehaviour
{

    public GameObject startButton_click;
    public GameObject optionsButton_click;
    public GameObject quitButton_click;
    public GameObject returnButton_click;

    // Start is called before the first frame update
    void Start()
    {
        //GetComponent<Button>().onClick.AddListener(tooptions);
        //GetComponent<Button>().onClick.AddListener();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //public void tooptions()
    //{
    //Debug.Log("load to options");
    //SceneManager.LoadScene("options", LoadSceneMode.Additive);
    //}

    //進入設定頁面
    public void Setting()
    {
        startButton_click.SetActive(false);
        quitButton_click.SetActive(false);
        optionsButton_click.SetActive(false);
        returnButton_click.SetActive(true);
    }

    public void Quit()
    {
        //用來結束遊戲用的
        Application.Quit();
        Debug.Log("QUIT");
    }

    //用來回到主畫面的按鈕
    public void ReturnMenu()
    {
        startButton_click.SetActive(true);
        quitButton_click.SetActive(true);
        optionsButton_click.SetActive(true);
        returnButton_click.SetActive(false);
    }
}
