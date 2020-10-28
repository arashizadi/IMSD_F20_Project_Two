using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseNewspaper : MonoBehaviour
{
    float timer;
    public GameObject newspaper;
    void Update()
    {
        ClosePaper();
    }
    void ClosePaper()
    {
        timer += Time.deltaTime;
        if (timer >= 1)
        {
            timer = 0;
            if (Input.GetKey(KeyCode.C))
            {
                newspaper.SetActive(false);
            }
        }
    }
}
