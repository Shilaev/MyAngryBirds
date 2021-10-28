using UnityEngine;
using UnityEngine.InputSystem;

public class DrugNShoot : MonoBehaviour
{
    private RaycastHit2D _hit;
    private Vector2 _newPos;
    private PlayerInputSystem _playerInputSystem;

    private void Start()
    {
        _playerInputSystem = new PlayerInputSystem();
        _playerInputSystem.Enable();

        _playerInputSystem.Player.SelectAndMove.performed += context =>
        {
            _hit = Physics2D.Raycast(_newPos, Vector2.zero);
        };

        _playerInputSystem.Player.SelectAndMove.canceled += context => { _hit = new RaycastHit2D(); };
    }

    private void HandleDrag()
    {
        _newPos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        if (_hit) _hit.transform.position = _newPos;
    }

    private void Update()
    {
        HandleDrag();
    }
}