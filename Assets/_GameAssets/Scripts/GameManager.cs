using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject canvas;
    void Start()
    {
        canvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void mostrarCanvas()
    {
        canvas.SetActive(true);
    }
}
