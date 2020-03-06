using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Game
{
    private int playersCount;

    public abstract void initializeGame();
    public abstract void StartGame();
    public abstract void EndGame();

    public void StartPlay()
    {
        initializeGame();
        StartGame();
        EndGame();
    }
}
