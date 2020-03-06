using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Football : Game
{
    public override void EndGame()
    {
        Debug.Log("結束─足球");
    }

    public override void initializeGame()
    {
        Debug.Log("初始化─足球");
    }

    public override void StartGame()
    {
        Debug.Log("開始─足球");
    }
}
