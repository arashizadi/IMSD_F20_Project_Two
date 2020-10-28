using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using System.Xml.Linq;

public class NewsAPI : MonoBehaviour
{
    string apiReturn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator GetNews()
    {
        UnityWebRequest www = UnityWebRequest.
            Get("http://api.openweathermap.org/data/2.5/weather?zip=" + "zip" + "&mode=xml&APPID=" + "key");
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
