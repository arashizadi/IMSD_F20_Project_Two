using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextDay : MonoBehaviour
{
    public int day = 1;
    public DateTime date = DateTime.Today;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Today is: " + date.ToString());
    }
    void Update()
    {
        Click();
    }
    void Click()
    {
        if (Input.GetAxis("Fire1") > 0)
        {
            day++;
            date.AddDays(1);
            Debug.Log("Good Morning, Today is: " + date.ToString());
            Debug.Log("day int: " + day.ToString());
        }
    }
}
