using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Optomm : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Button>().onClick.AddListener (tomm);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void tomm()
    {
        Debug.Log("load to mainmenu");
        SceneManager.LoadScene("Assets/Scenes/mainmenu");
    }

}
