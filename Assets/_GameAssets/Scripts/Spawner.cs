using UnityEngine;

public class Spawner : MonoBehaviour
{
    [Header("Prefab del objeto a instanciar (spawnear)")]
    public GameObject prefab;
    [Header("Tiempo en segundos entre instanciaciones")]
    [Range(1,100)]
    public float spawnRateTime = 1;
    void Start()
    {
        InvokeRepeating("spawnGameObject", 0, spawnRateTime);
    }

    private void spawnGameObject()
    {
        Instantiate(prefab, transform.position, transform.rotation);
    }
}
