using UnityEngine;
using System;
using System.Collections.Generic;
using TMPro;
//using System.Collections;

public class GameManager : MonoBehaviour
{
    int selectedZombiePosition = 0;
    public GameObject selectedZombie;
    //public List<GameObject> zombies = new List<GameObject>(); 
    public GameObject[] zombies;
    public Vector3 selectedSize;
    public Vector3 defaultSize;
    public TMP_Text scoreText;
    int score = 0;


   // void GetZombieLeft()
   //{
    //    if (selectedZombiePosition == 0)
   //     {
   //         SelectZombie(zombies[3]);
    //    }
    //    else
    //    {
    //        SelectZombie(zombies[selectedZombiePosition - 1]);
    //    }
    //}
       void GetZombieLeft()
    {
        selectedZombiePosition--;
        if (selectedZombiePosition < 0)
        {
            selectedZombiePosition = zombies.Length - 1;
        }
            SelectZombie(zombies[selectedZombiePosition]);
        
    }

    void GetZombieRight()
    {
        selectedZombiePosition++;
        if (selectedZombiePosition >= zombies.Length)
        {
            selectedZombiePosition = 0;
        }
            SelectZombie(zombies[selectedZombiePosition]);
        
    }


    void SelectZombie(GameObject newZombie)
    {
        if (selectedZombie != null)
        {
            selectedZombie.transform.localScale = defaultSize;
        }
            selectedZombie = newZombie;
            selectedZombie.transform.localScale = selectedSize;
            selectedZombiePosition = Array.IndexOf(zombies, newZombie);
    }

    void Update()
    {
        if (Input.GetKeyDown("left")) GetZombieLeft();

        if (Input.GetKeyDown("right")) GetZombieRight();

        if (Input.GetKeyDown("up")) PushUp();
    }

    void Start()
    {
        GameObject newZombie = zombies[0];
        SelectZombie(newZombie);
        scoreText.text = "Score: " + score;
    }

    void PushUp()
    {
        Rigidbody rb = selectedZombie.GetComponent<Rigidbody>(); rb.AddForce(0, 0, 10, ForceMode.Impulse);
    }

    public void AddScore()
    {
        score = score + 1;
        scoreText.text = "Score: " + score;
    }

}
