using UnityEngine;

namespace PlayerInput
{
    public class FakeInput : IInput
    {
        public bool LeftMouseButtonPressed() => true;

        public Vector2Int GetTilePosition(Transform factoryMarker) => Vector2Int.zero;
    }
}