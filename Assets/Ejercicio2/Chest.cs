using UnityEngine;

public class Chest : MonoBehaviour, IDammageable
{
    public void Hurt(int dmg)
    {
        Open();
    }
    public void Open()
    {
        Debug.Log("Me he abierto");
    }
}
