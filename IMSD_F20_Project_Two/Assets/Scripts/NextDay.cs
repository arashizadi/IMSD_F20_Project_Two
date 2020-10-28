using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextDay : MonoBehaviour
{
    public int day = 1;
    float timer;
    public DateTime date = DateTime.Today;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Today is: " + date.ToString());
    }
    void Update()
    {
        GoToNextDay();
    }
    void GoToNextDay()
    {
        timer += Time.deltaTime;
        if (timer >= 1)
        {
            timer = 0;
            if (Input.GetKey(KeyCode.Space))
            {
                day++;
                date = date.AddDays(1);
                Debug.LogWarning("It is next DAY!, Today is now: " + date.ToString());
                Debug.Log("day int: " + day.ToString());
            }
        }
    }

}
