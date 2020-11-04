using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseNewspaper : MonoBehaviour
{
    public GameObject newspaper;

    public void ClosePaper()
    {
        newspaper.SetActive(false);
    }
    void OnMouseDown()
    {
        ClosePaper();
    }
}
