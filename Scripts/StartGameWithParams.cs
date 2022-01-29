using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class StartGameWithParams : MonoBehaviour
{
    public Sprite[] moves;
    public GameObject currentSprite;
    public int spriteCounter;
    public string title;
    public string description;
    public int cyclesPassed = 0;
    public float lastUpdate;
    public float cyclesDuration = 2;
    public bool gameRunning;
    public GameObject star1;
    public GameObject star2;
    public GameObject star3;
    public GameObject giveStarButton;
    public GameObject counter;
    public GameObject canvas;
    GameData gameData;
    GiveStar giveStar;


    void Start()
    {
        gameData = canvas.GetComponent<GameData>();
        giveStar = giveStarButton.GetComponent<GiveStar>();
    }
    public void InitializeGame()
    {
        moves = gameData.moves;
        giveStar.starsPlaced = 0;
        spriteCounter = 0;

        star1.GetComponent<Image>().color = new Color(1f, 1f, 1f, 0.16f);
        star2.GetComponent<Image>().color = new Color(1f, 1f, 1f, 0.16f);
        star3.GetComponent<Image>().color = new Color(1f, 1f, 1f, 0.16f);

        currentSprite.GetComponent<Image>().sprite = moves[0];
    }
    void Update()
    {
        if (gameRunning)
        {
            if (lastUpdate < 0)
            {
                lastUpdate = Time.time;
            }
            else if (Time.time > lastUpdate + cyclesDuration / moves.Length)
            { 
                lastUpdate = Time.time;

                spriteCounter = (spriteCounter + 1) % moves.Length;

                currentSprite.GetComponent<Image>().sprite = moves[spriteCounter];

                if (spriteCounter == 0)
                {
                    cyclesPassed++;

                    counter.GetComponent<TMP_Text>().text = cyclesPassed.ToString();
                }
            }
        }
        else if (!gameRunning && lastUpdate >= 0)
        {
            lastUpdate = -1;
        }
    }

    public void PauseGame()
    {
        gameRunning = !gameRunning;
    }
}

