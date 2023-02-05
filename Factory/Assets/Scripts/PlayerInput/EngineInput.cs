using UnityEngine;

namespace PlayerInput
{
    public class EngineInput : IInput
    {
        private Camera _mainCamera;
        private Camera MainCamera => _mainCamera ??= Camera.main;
        public bool LeftMouseButtonPressed() => Input.GetMouseButtonDown(0);


        public Vector2Int GetTilePosition(Transform factoryMarker)
        {
            Vector3 mousePos = MainCamera.ScreenToWorldPoint(Input.mousePosition);
            mousePos = factoryMarker.InverseTransformPoint(mousePos);
            Vector2Int tile = new Vector2Int(Mathf.FloorToInt(mousePos.x + .5f), Mathf.FloorToInt(mousePos.z + .5f));
            return tile;
        }
    }
}