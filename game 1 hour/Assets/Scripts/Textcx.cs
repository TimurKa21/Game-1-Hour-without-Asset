using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Textcx : MonoBehaviour
{

    [SerializeField] private TMP_Text text;
    private int number = 0;


    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Asteroid"))
        {

            number++;
            text.text = "Count " + number;

            Destroy(other.gameObject);
        }
    }
}