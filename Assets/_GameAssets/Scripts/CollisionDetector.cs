using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
    public GameObject prefabExplosion;//Prefab de la explosión
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Destructor"))
        {
            //Desvincular la cámara del player
            Camera.main.transform.SetParent(null);
            //Generar el sistema de partículas
            Instantiate(prefabExplosion, transform.position, transform.rotation);
            //Destruir el player
            Destroy(gameObject);
            //Activar el canvas
            GameObject.Find("GameManagerContainer").GetComponent<GameManager>().mostrarCanvas();
        }
    }
}