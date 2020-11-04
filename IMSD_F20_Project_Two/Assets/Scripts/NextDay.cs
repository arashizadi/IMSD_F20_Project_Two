using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextDay : MonoBehaviour
{
    public int day = 1;
    float timer;
    public string dateString;
    public DateTime date = DateTime.Now;

    public NewspaperScript newspaper;

    // Start is called before the first frame update
    void Awake()
    {
    }
    void Start()
    {
        //Debug.Log("Today is: " + date.ToString());
        Debug.Log("Good Morning. It's " + date);
        Debug.Log("Pick up the NEWSPAPER on the table. It's from NY Tykes...");
    }
    void Update()
    {
    }
    public void GoToNextDay()
    {
        if (newspaper.level != day)
        {
            day++;
            date = date.AddDays(1);
            //Debug.LogWarning("It is next DAY!, Today is now: " + date.ToString());
            Debug.Log("Good Night!");
            date.AddDays(1);
            Debug.Log("Good Morning! It's: " + date.ToString());
            if (day == 2)
                Debug.Log("Pick up the NEWSPAPER on the table. It's from Fuks News...");
            else if (day == 3)
                Debug.Log("Pick up the NEWSPAPER on the table. It's from CMM...");
        }
        else
        {
            Debug.Log("You are not tiered yet! Keep your mind busy.");
        }

    }
    void OnMouseDown()
    {
        GoToNextDay();
    }

}
