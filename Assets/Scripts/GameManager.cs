using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;


    public Button loadButton;
    public Button newGameButton;
    public Button clearButton;

    public Scene LevelOne;

    //public string levelOne;
    //public Scene levelOne = SceneManager.GetSceneByName(LevelOne);
    // Start is called before the first frame update

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        Instance = this;
    }
    void Start()
    {
    }

    public enum Scene
    {
        MainMenu,
        Level01,
    }

    public void LoadScene(Scene scene)
    {
        SceneManager.LoadScene(scene.ToString());
    }
        
    

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NewGame()
    {
        //SceneManager.LoadScene( SceneManager.GetActiveScene().name );
        //SceneManager.LoadScene(SceneManager.GetSceneByName(LevelOne).name);
        SceneManager.LoadScene("LevelOne");
        //Debug.Log("new game was clicked");
        //SceneManager.LoadScene(LevelOne.ToString());
    }

}
