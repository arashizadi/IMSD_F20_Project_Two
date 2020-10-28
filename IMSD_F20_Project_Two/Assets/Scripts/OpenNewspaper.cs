using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenNewspaper : MonoBehaviour
{
    public GameObject newspaper;
    void OnMouseDown()
    {
        newspaper.SetActive(true);
    }
}
