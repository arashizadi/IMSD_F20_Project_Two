using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseNewspaper : MonoBehaviour
{
    float timer;
    public GameObject newspaper;

    public void ClosePaper()
    {
        newspaper.SetActive(false);
    }
}
