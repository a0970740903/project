using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lansect : MonoBehaviour
{

    Dropdown dropdown;
    List<string> tempNames;
    public int ddvar;

    void Awake()
    {
        dropdown = GetComponent<Dropdown>();
        tempNames = new List<string>();
    }

    private void updatedropdownview(List<string> showNames)
    {
        dropdown.options.Clear();
        Dropdown.OptionData tempData;
        for (int i = 0; i < showNames.Count; i++)
        {
            tempData = new Dropdown.OptionData();
            tempData.text = showNames[i];
            dropdown.options.Add(tempData);
        }
        dropdown.captionText.text = showNames[0];
    }

    private void addNames()
    {
        string s1 = "繁體中文";
        string s2 = "English";

        tempNames.Add(s1);
        tempNames.Add(s2);
    }

    // Start is called before the first frame update
    void Start()
    {
        addNames();
        updatedropdownview(tempNames);
    }

    // Update is called once per frame
    void Update()
    {
        ddvar = dropdown.value;
    }
}
