using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(quitgame);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void quitgame()
    {
        //用來結束遊戲用的
        Application.Quit();
        Debug.Log("QUIT");
    }
}
