using UnityEngine;

public class WaterDetector : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Auga"))
        {
            //Desvincular la cámara del player
            Camera.main.transform.SetParent(null);
            //Destruir el player
            Destroy(gameObject);
        }
    }
}
