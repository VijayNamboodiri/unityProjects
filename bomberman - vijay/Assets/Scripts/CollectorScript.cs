using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectorScript : MonoBehaviour
{
    public Text scoreText;
    private int score = 0;

    void IncreaseScore(){
        score++;

        scoreText.text  = "Score:" + score;
    }


    void OnTriggerEnter2D(Collider2D target){ // tells us when we touch another collider
        if(target.tag == "Bomb"){

            IncreaseScore ();
            target.gameObject.SetActive (false);
        }
        

    }
}
