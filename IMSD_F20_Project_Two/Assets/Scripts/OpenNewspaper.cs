﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenNewspaper : MonoBehaviour
{
    public GameObject newspaper;

    public void OpenPaper()
    {
        newspaper.SetActive(true);
    }
    void OnMouseDown()
    {
        OpenPaper();
    }
}
