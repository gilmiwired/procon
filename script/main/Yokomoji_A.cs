using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Yokomoji_A : MonoBehaviour
{

    public InputField yoko;
    public Yokomoji yo;
    public Text yokotext;
    public Text name;
    public void clickyoko() {
        name.text = yoko.GetComponent<InputField>().text;
        yokotext.text=yo.Yokomoji2(yoko.GetComponent<InputField>().text);
    }
}
