using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ボタンで表示 : MonoBehaviour
{
    public GameObject me;
    public GameObject he;
    public GameObject she;   
    // Start is called before the first frame update
    public void Clickthis()
    {
        me.SetActive(true);
        she.SetActive(false);
        he.SetActive(false);
    }

}
