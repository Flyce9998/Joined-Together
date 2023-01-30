using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPress : MonoBehaviour
{
    static public int totalButtons;
    static public int buttonsPressed;
    AudioManager AM;
    public int buttonID;
    Change_Scene CS;

    private void Start()
    {
        CS = GameObject.Find("Scene Manager").GetComponent<Change_Scene>();
        AM = FindObjectOfType<AudioManager>();
        totalButtons = GameObject.FindGameObjectsWithTag("Button").Length;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        CS.buttonList[buttonID] = true;
        FindObjectOfType<AudioManager>().Play("Switch");
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        CS.buttonList[buttonID] = false;
        FindObjectOfType<AudioManager>().Play("Switch");
    }
}
