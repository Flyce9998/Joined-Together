using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Change_Scene : MonoBehaviour
{
    public int levelID;
    public bool[] buttonList;
    private int boolN;
    private bool loaded = false;

    private void Update()
    {
        boolN = 0;
        for (int i = 0; i < buttonList.Length; i++)
        {
            if (buttonList[i] == true)
            {
                boolN++;
            }
        }
        if (boolN == ButtonPress.totalButtons && ButtonPress.totalButtons > 0)
        {
            ButtonPress.buttonsPressed = 0;
            LoadNext();
        }

        if (Input.GetKeyDown("r") && (levelID != 0) && (levelID != 11))
        {
            FindObjectOfType<AudioManager>().Play("Reload");
            StartCoroutine(Load(levelID));
        }

    }

    public void MainMenu()
    {
        StartCoroutine(Load(0));
    }
    public void Load1()
    {
        StartCoroutine(Load(1));
    }

    public void LoadNext()
    {
        if (!loaded)
        {
            FindObjectOfType<AudioManager>().Play("Win");
            StartCoroutine(Load(levelID + 1));
            loaded = true;
        }

    } 

    IEnumerator Load(int LevelID)
    {
        yield return new WaitForSeconds(1.5f);
        FindObjectOfType<AudioManager>().Play("Start");
        SceneManager.LoadScene(LevelID);
    }
}
