using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HpBAr : MonoBehaviour
{
    public Image[] lives;
    private int currentLives = 3;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Asteroid")) 
        {
            LoseLife();
        }
    }

    void LoseLife()
    {
        if (currentLives > 0)
        {
            currentLives--;
            lives[currentLives].enabled = false; 

            if (currentLives == 0)
            {
                RestartScene();
            }
        }
    }

    void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}