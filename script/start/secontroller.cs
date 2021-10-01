using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class secontroller : MonoBehaviour
{

    public AudioClip sound1;
    public AudioClip sound2;
    public AudioClip sound3;
    public AudioClip sound4;

    AudioSource audioSource;

    void Start()
    {
        //ComponentÇéÊìæ
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        // ç∂
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            audioSource.PlayOneShot(sound1);
        }
        // âE
        if (Input.GetKey(KeyCode.RightArrow))
        {
            audioSource.PlayOneShot(sound2);
        }
        // è„
        if (Input.GetKey(KeyCode.UpArrow))
        {
            audioSource.PlayOneShot(sound3);
        }
        // â∫
        if (Input.GetKey(KeyCode.DownArrow))
        {
            audioSource.PlayOneShot(sound4);
        }
    }

}