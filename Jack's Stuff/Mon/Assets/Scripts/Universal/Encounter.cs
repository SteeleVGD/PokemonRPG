using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Encounter : MonoBehaviour
{


    public float encounterRate;
    public float randomNum;

    public bool checkEncounter;



    void Update()
    {

        if(checkEncounter == true)
        {
            randomNum = Random.Range(0, 10f);

            if(randomNum <= encounterRate)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
            else
            {
                checkEncounter = false;
            }
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Grass"))
        {
            checkEncounter = true;
        }
    }
}
