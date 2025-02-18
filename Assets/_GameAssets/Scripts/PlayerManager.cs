using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerManager : MonoBehaviour
{
    public InputActionReference moveIARef;
    public InputActionReference fireIARef;
    public int force = 100; //Fuerza del impulso
    public bool onFloor = false;
    
    private void OnEnable()
    {
        fireIARef.action.started += Jump; //Referencia al método Jump de este script
    }
    private void OnDisable()
    {
        fireIARef.action.started -= Jump; //Referencia al método Jump de este script
    }
    void Update()
    {
        Vector2 direccion = moveIARef.action.ReadValue<Vector2>();
        int gradosY = 0;
        if (direccion.x > 0)
        {
            gradosY = 90;
        } else if (direccion.x < 0)
        {
            gradosY = -90;
        }
        transform.eulerAngles = new Vector3(0, gradosY, 0);
        if (direccion.y<0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
    }
    void Jump(InputAction.CallbackContext obj) //Método Jump
    {
        if (onFloor)
        {
            GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0, 2, 1) * force);//Ejecución del impulso
            GetComponent<AudioSource>().Play(); //Reproduce el fichero de audio
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        onFloor = true;        
    }
    private void OnCollisionExit(Collision collision)
    {
        onFloor = false;
    }
}