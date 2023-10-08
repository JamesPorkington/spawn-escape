using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseCanvas;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            Time.timeScale = 0f;
                pauseCanvas.SetActive(true);
                Cursor.visible = true;
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!pauseCanvas.activeSelf)
            {
                Time.timeScale = 0f;
                pauseCanvas.SetActive(true);
                Cursor.visible = true;
            }
            else
            {
                Time.timeScale = 1f;
                pauseCanvas.SetActive(false);
                Cursor.visible = false;
            }
        }
        
    }

    public void quitLevel()
    {
        //it should return to start menu scene
    }

    public void resume()
    {
        Time.timeScale = 1f;
        pauseCanvas.SetActive(false);
        Cursor.visible = false;
    }
}
