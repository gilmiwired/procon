using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 一定時間後消滅 : MonoBehaviour
{
    public GameObject me;

    void Update () 
    {
        if(me.activeSelf == true)
        {
            Invoke("del",1f);
        }
    }

    public void del()
    {
        me.SetActive(false);
    }
}
