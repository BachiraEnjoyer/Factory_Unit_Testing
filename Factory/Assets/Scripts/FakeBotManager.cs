using UnityEngine;

public class FakeBotManager : IBotManager
{
    public int SpawnedBots { get; set; }

    public void TrySpawnBot(Vector2Int tile)
    {
        SpawnedBots++;
    }

    public void Init()
    {
    }
}