using UnityEngine;

namespace PlayerInput
{
    public interface IInput
    {
        bool LeftMouseButtonPressed();
        Vector2Int GetTilePosition(Transform factoryMarker);
    }
}