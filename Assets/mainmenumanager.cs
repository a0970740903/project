using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
using System.Xml.Linq;

public class mainmenumanager : MonoBehaviour
{

    public GameObject startButton_click;
    public GameObject optionsButton_click;
    public GameObject quitButton_click;
    public GameObject returnButton_click;
    public GameObject langSwitch;

    string startbtn;//按鈕內文字
    string optionsbtn;
    string quitbtn;
    string returnbtn;

    public string lngpath;//語言文件的路徑


    // Start is called before the first frame update
    void Start()
    {
        Loadxml();
        startButton_click.GetComponentInChildren<Text>().text = startbtn;//設定按鈕初始的文字
        optionsButton_click.GetComponentInChildren<Text>().text = optionsbtn;
        quitButton_click.GetComponentInChildren<Text>().text = quitbtn;
        returnButton_click.GetComponentInChildren<Text>().text = returnbtn;

    }

    // Update is called once per frame
    void Update()
    {
        Loadxml();
        Switchlng();
    }


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

    public void buttontext()
    {
        startButton_click.GetComponentInChildren<Text>().text = startbtn;//用來指定按鈕內顯示的文字

    }

    //讀取XML文件的程式
    public void Loadxml()
    {
        lngpath = "Assets/Languages/ChineseTrad/ButtonText.xml";
        var btntext = XDocument.Load(lngpath).Root;
        startbtn = btntext.Element("startbtn").Value;
        optionsbtn = btntext.Element("optionsbtn").Value;
        returnbtn = btntext.Element("returnbtn").Value;
        quitbtn = btntext.Element("quitbtn").Value;
    }

    public void Switchlng()
    {
        if (langSwitch.GetComponent<lansect>().ddvar == 0)
        {
            //Debug.Log("繁體中文");
            lngpath = "Assets/Languages/ChineseTrad/ButtonText.xml";
        }
        if (langSwitch.GetComponent<lansect>().ddvar == 1)
        {
            //Debug.Log("English");
            lngpath = "Assets/Languages/English/ButtonText.xml";
        }
    }

}
