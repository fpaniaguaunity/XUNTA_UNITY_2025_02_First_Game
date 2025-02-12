using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public InputActionReference moveIARef;
    public InputActionReference fireIARef;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    private void OnEnable()
    {
        fireIARef.action.started += Fire;
    }
    private void OnDisable()
    {
        fireIARef.action.started -= Fire;
    }

    // Update is called once per frame
    void Update()
    {
        print(moveIARef.action.ReadValue<Vector2>());
    }
    void Fire(InputAction.CallbackContext obj)
    {
        print("Fire...");
    }
}
