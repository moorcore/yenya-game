using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GiveStar : MonoBehaviour
{
    public GameObject GamePanel;
    public GameObject star1;
    public GameObject star2;
    public GameObject star3;

    public int starsPlaced = 0;

    public void CreateStar()
    {
        if (starsPlaced == 0)
        {
            star1.GetComponent<Image>().color = Color.white;
            
        }
        else if (starsPlaced == 1)
        {
            star2.GetComponent<Image>().color = Color.white;
        }
        else if (starsPlaced == 2)
        {
            star3.GetComponent<Image>().color = Color.white;
        }
        
        starsPlaced++;
    }
}
