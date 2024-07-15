using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    [SerializeField] GameObject gameOverPanel;
    [SerializeField] Button restart;

    [SerializeField] Button gameStart;
    [SerializeField] GameObject pause;
   
    [SerializeField] Player player;
    

    private void Awake()
    {
        Time.timeScale = 1f;
    }
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player") == null)
        {
            Time.timeScale = 0;
            gameOverPanel.SetActive(true);

        }
        
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
        
        
       
    }
    public void startGame()
    {

       
        Time.timeScale = 1.0f;
        
        
    }
    

    public void Pause()
    {
        pause.gameObject.SetActive(true);
        Time.timeScale = 0;
    }
    public void Home()
    {
        SceneManager.LoadScene("Menu");

    }
    public void Resume()
    {
        Time.timeScale = 1f;
        pause.gameObject.SetActive(false);
    }
   

}


