using UnityEngine;

public abstract class Item : MonoBehaviour
{
    protected int Quantity;
    protected string Name;
    protected string Description;

    public abstract void UseItem();
}
