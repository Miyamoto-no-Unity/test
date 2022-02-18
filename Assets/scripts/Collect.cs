using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collect : MonoBehaviour
{
   public int score;
   public Text points;
   private Camera mainCamera;
   public GameObject Button;
   private void OnTriggerEnter2D(Collider2D kickAss)
   {
    if(kickAss.gameObject.tag == "Circle")
     {
       score++; 
       kickAss.gameObject.SetActive(false);
       points.text = score.ToString(); 
     }
     if(score >= 5f)
     {
        Destroy (gameObject);
        Button.SetActive(true);
        
     }
   }
}
