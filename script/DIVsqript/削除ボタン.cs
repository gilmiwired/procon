using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 削除ボタン : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject obj;
    // Start is called before the first frame update
    public void del(){
        obj.SetActive(false);
    }
}
