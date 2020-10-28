using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseNewspaper : MonoBehaviour
{
    public GameObject newspaper;
    void OnMouseDown()
    {
        newspaper.SetActive(false);
    }
}
