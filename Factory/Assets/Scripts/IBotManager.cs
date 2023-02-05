using UnityEngine;

public interface IBotManager
{
    void TrySpawnBot(Vector2Int tile);
    void Init ();
}