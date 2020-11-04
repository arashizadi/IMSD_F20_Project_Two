using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NewspaperScript : MonoBehaviour
{
    public Button factCheck;
    public TMP_InputField userText;
    public GameObject newspaperObject;

    int level = 1;
    void Start()
    {
        factCheck.onClick.AddListener(Check);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Check()
    {
        foreach (char num in userText.text)
        {
            if (!char.IsDigit(num))
            {
                Debug.Log("Wrong input! You must only enter a number value.");
            }
            else
            {
                if (level == 1 && userText.text == "22")
                {
                    Debug.Log("Well Done");
                    level++;
                    Debug.Log("Your current Level: " + level);
                    newspaperObject.SetActive(false);
                }
                else if (level == 2 && userText.text == "22")
                {

                }
            }
        }

    }
}
