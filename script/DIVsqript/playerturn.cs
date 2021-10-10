using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerturn : MonoBehaviour
{
    public GameObject div;
    public GameObject group;
    public GameObject me;
    public GameObject you;
    // Update is called once per frame
    public void pushme()
    {
        div.SetActive(true);
        group.SetActive(false);
        me.SetActive(true);
        you.SetActive(false);
    }
}
