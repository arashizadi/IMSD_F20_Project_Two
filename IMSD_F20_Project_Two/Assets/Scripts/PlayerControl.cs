using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerControl : MonoBehaviour
{
    NextDay nextDay;
    OpenNewspaper openNewspaper;
    CloseNewspaper closeNewspaper;
    // Start is called before the first frame update
    void Awake()
    {
        nextDay = GetComponent<NextDay>();
        openNewspaper = GetComponent<OpenNewspaper>();
        closeNewspaper = GetComponent<CloseNewspaper>();
    }

    // Update is called once per frame
    void OnMouseDown()
    {
            Debug.Log(name);
    }
}
