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
    int numberOfFailedAttempts = 0;
    void Start()
    {
        factCheck.onClick.AddListener(Check);
        Debug.Log("Pick up the NEWSPAPER on the table. It's from NY Types...");
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Check()
    {
        if (userText.text == "Guess The Amount")
            Debug.LogWarning("Please use the YELLOW text field in order to input the correct count then use \"Fact Check\" button to check the answer.");
        else 
            foreach (char num in userText.text)
        {
            if (!char.IsDigit(num))
            {
                Debug.Log("Wrong input! You must only enter a number value.");
                numberOfFailedAttempts++;
            }
            else
            {
                if ((level == 1 && userText.text == "22")
                    || (level == 2 && userText.text == "4")
                    || (level == 3 && userText.text == "9"))
                {
                    Debug.Log("Well Done | You have just one step ");
                    level++;
                    if (numberOfFailedAttempts == 0)
                        Debug.Log("Bravo, In your first attempt you were able to win this round. You are trully a wise person.");
                    else
                        Debug.Log("You tried " + numberOfFailedAttempts + " times in order to succeed to the next round.");

                    Debug.Log("Your current Level: " + level);
                    newspaperObject.SetActive(false);
                    numberOfFailedAttempts = 0;
                }

                else
                {
                    numberOfFailedAttempts++;
                    Debug.Log("You did not answer correctly. Please try again.");
                    if (numberOfFailedAttempts > 9)
                        Debug.Log("Stop Looking, Open Your Eyes and Start Seeing. You must shift your awareness completely and watch the reality from the unbias point of view.");
                    if (numberOfFailedAttempts > 19)
                        Debug.Log("Pro Tip: You need to start reading some books and stop watching same TV channel all the time.");
                }
            }
        }

    }
}
