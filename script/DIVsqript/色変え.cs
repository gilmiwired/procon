using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class 色変え : MonoBehaviour
{
    public GameObject checker;
    // Start is called before the first frame update
    void Update () 
    {
        Image image;
        image = this.GetComponent<Image>();
        // Textコンポーネントを取得
        if(checker.activeSelf == false)
        {
            image.color = new Color(0.0f, 0.0f, 0.0f, 1.0f);        
        }else
        {
            image.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);             
        }
    }

}
