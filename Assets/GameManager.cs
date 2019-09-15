using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
   private bool GameHasEnded = false;

    public Rotator rotator;
    public Spawner spawner;
    public Animator animator;


   public void EndGame()
    {
        if (GameHasEnded)
            return;

        

        rotator.enabled = false;
        spawner.enabled = false;

        animator.SetTrigger("EndGame");

        GameHasEnded = true;
    }

    public void RestartLevel ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
