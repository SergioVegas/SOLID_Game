using UnityEngine;

public class Chest : MonoBehaviour, IDammageable
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Hurt()
    {
        Open();
    }
    public void Open()
    {
        Debug.Log("Me he abierto");
    }
}
