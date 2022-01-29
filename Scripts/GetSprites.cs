using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetSprites : MonoBehaviour
{
    public Sprite[] sprites;
    public GameObject canvas;

    public void PassSprites()
    {
        canvas.GetComponent<GameData>().moves = sprites;
    }
}
