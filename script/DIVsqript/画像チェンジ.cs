using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class chgSprite : MonoBehaviour {

    public Sprite spriteMae;
    public Sprite spriteAto;

    public void changeSprite()
    {

        this.gameObject.GetComponent<Image> ().sprite = spriteAto;

    }

}