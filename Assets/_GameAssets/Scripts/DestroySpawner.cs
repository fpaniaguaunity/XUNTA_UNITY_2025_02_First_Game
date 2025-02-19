using UnityEngine;

public class DestroySpawner : MonoBehaviour
{
    public GameObject prefabToSpawn;

    private void OnDestroy()
    {
        Instantiate(prefabToSpawn, transform.position, transform.rotation);
    }
}
