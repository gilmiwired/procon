using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startclicmanager : MonoBehaviour
{
    [SerializeField] GameObject room;
    public FadeControll fc;
    public GameObject fd;

    public void OnClickMainButton()
    {
        room.SetActive(true);
    }
    public void OnClickExplainButton()
    {
        SceneManager.LoadScene("Explain");
    }
    public void OnClickDemoButton()
    {
        SceneManager.LoadScene("Demo");
    }
    public void OnClickroomEButton() {
        SceneManager.LoadScene("Main");
    }
    public void OnClickroomMButton() {
        fd.SetActive(true);
        Invoke("OnClickroomEButton",2f);
    
    }
    public void OnClickreturnButton() {
        room.SetActive(false);
    }
}
