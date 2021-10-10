using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ON : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject me;
      
    // Start is called before the first frame update
    public void Clickthis()
    {
        me.SetActive(true);
    }
}
