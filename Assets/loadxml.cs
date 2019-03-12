using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml.Linq;
using System;

public class loadxml : MonoBehaviour
{
    string startbtn;
    string optionsbtn;
    string quitbtn;
    string returnbtn;

    void Start()
    {
        var btntext = XDocument.Load("Assets/Languages/ChineseTrad/ButtonText.xml").Root;
        startbtn = btntext.Element("startbtn").Value;
        Debug.Log(startbtn);
        
    }

    void Update()
    {
        
    }
}
