using UnityEngine;

public class WaterDetector : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Auga"))
        {
            //Desvincular la c�mara del player
            Camera.main.transform.SetParent(null);
            //Destruir el player
            Destroy(gameObject);
        }
    }
}
