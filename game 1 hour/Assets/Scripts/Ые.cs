using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ые : MonoBehaviour
{
   public void PlayGame()
    {     
        SceneManager.LoadScene(1); // Загружает сцену с игрой (укажи нужный индекс или название сцены)
    }
}

