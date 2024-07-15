using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneTransition : MonoBehaviour
{
   
    [SerializeField] Button start;
    private  Animator animator;

    private void Awake()
    {
       animator = GetComponent<Animator>();
    }
    private void Update()
    {


        if (Input.GetMouseButton(0))
        {
            animator.SetTrigger("On");
        }
            
            StartCoroutine(loadScene());

        


    }
    public void startGame()
    {
         SceneManager.LoadScene("Lv1");
         
        
    }

    IEnumerator loadScene()
    {
        
            
            yield return new WaitForSeconds(2.3f);
            startGame();
        
        
    }
}
