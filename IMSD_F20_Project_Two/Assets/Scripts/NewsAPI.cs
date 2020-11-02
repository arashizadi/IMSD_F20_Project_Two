﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class NewsAPI : MonoBehaviour
{
    string apiReturn, limit = "2", source = "bbc";
    NextDay day;
    // Start is called before the first frame update
    void Start()
    {
        day = GetComponent<NextDay>();
        StartCoroutine(GetNews());
    }

    // Update is called once per frame
    void Update()
    {
    }
    IEnumerator GetNews()
    {
        UnityWebRequest www = UnityWebRequest.Get("http://api.mediastack.com/v1/news?access_key=6817e29d6cd6cb31ebe53d5e74813df9&sources=" + 
            source + "&limit=" + limit);        // + "&date=" + day.date.ToString("yyyy-MM-dd")

        yield return www.SendWebRequest();
        if (!www.isNetworkError && !www.isHttpError)
        {
            // Get text content like this:
            Debug.Log(www.downloadHandler.text);
            apiReturn = www.downloadHandler.text;
        }
        else
        {
            Debug.Log(www.error + " " + www);
        }
    }
}

    
/*    {
        XDocument doc = XDocument.Parse(apiReturn);
        XAttribute _currentTemp = doc.Element("current").Element("temperature").Attribute("value");
        currentTemp = Double.Parse(_currentTemp.Value);
    }*/
