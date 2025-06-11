using UnityEngine;
using System;
using System.Collections.Generic;
using TMPro;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManagerStatic;

    int selectedZombiePosition = 0;
    public GameObject selectedZombie;
    //public List<GameObject> zombies = new List<GameObject>(); 
    public GameObject[] zombies;
    public Vector3 selectedSize;
    public Vector3 defaultSize;
    public TMP_Text scoreText;
    public GameObject gameOver;
    public int score = 0;
    public int zombieCount = 4;

    public bool gameOn = true;

void Start()
    {
        
        gameManagerStatic = this;
        
        GameObject newZombie = zombies[0];
        SelectZombie(newZombie);
        scoreText.text = "Score: " + score;

        if (gameOver != null)
        {
            gameOver.SetActive(false);
        }
    }

    void Update()
    {
        if(zombieCount == 0)
        {
            GameEnd();
        }
        if (Input.GetKeyDown("left")) GetZombieLeft();

        if (Input.GetKeyDown("right")) GetZombieRight();

        if (Input.GetKeyDown("up")) PushUp();
        
    }

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

    void PushUp()
    {
        Rigidbody rb = selectedZombie.GetComponent<Rigidbody>(); rb.AddForce(0, 0, 10, ForceMode.Impulse);
    }

    public void AddScore()
    {
        score = score + 1;
        scoreText.text = "Score: " + score;
    }

    public void GameEnd()
    {
    
        gameOn = false;
        gameOver.SetActive(true);
       
     }

     public void Restart()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

}
