using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.EventSystems;

public class DrugNShoot : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;

    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint( Mouse.current.position.ReadValue());

        if (Mouse.current.leftButton.isPressed)
        {
            _rigidbody2D.isKinematic = true;
            _rigidbody2D.position = mousePosition;
        }
        else if (Mouse.current.leftButton.isPressed == false)
        {
            _rigidbody2D.isKinematic = false;
        }
    }

}