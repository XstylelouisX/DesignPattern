using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Baseball : Game
{
    public override void EndGame()
    {
        Debug.Log("結束─棒球");
    }

    public override void initializeGame()
    {
        Debug.Log("初始化─棒球");
    }

    public override void StartGame()
    {
        Debug.Log("開始─棒球");
    }
}
