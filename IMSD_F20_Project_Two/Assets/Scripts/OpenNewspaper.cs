using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenNewspaper : MonoBehaviour
{
    public GameObject newspaper;
    float timer;
    void Update()
    {
        OpenPaper();
    }
    void OpenPaper()
    {
        timer += Time.deltaTime;
        if (timer >= 1)
        {
            timer = 0;
            if (Input.GetKey(KeyCode.X))
            {
                newspaper.SetActive(true);
            }
        }
    }
}
