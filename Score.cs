using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System; 
public class Score : MonoBehaviour
{   
    //score
    [SerializeField] TextMeshProUGUI scoreText;
    private float score;

    //score max
    [SerializeField] TextMeshProUGUI highScoreTxt;
    private float highScore;
    

    

    private void Awake()
    {
        
         //đã Có Điểm cao nhất  từ trước
        if (PlayerPrefs.HasKey("Highscore"))
        {
            highScore = PlayerPrefs.GetFloat("Highscore");
            
        }

        //chưa có điểm cao nhiêu game chưa chơi lần nào
        else
        {
            highScore = 0;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Hien thi diem cao nhat
        highScoreTxt.text = "High Score: "+((int)highScore).ToString();
        
        //Hien thi Diem Ra man hinh
        scoreText.text = ((int)score).ToString();

        // Player vẫn còn sống + Điểm qua mỗi frame 
        if (GameObject.FindGameObjectWithTag("Player") != null  )
        {
            
            score += 1*Time.deltaTime;
            
        }
        
        else
        {
            Die();
            scoreText.gameObject.SetActive(false);
            
        }
    }



    // in diem cao nhat neu score lớn hơn highScore khi nhân vật die
    public void Die()
    {
        if(score > highScore)
        {
            PlayerPrefs.SetFloat("Highscore", score);
            PlayerPrefs.Save();
            
        }
    }
}
