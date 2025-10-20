using UnityEngine;

public class RareCandy : Item
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public override void UseItem()
    {
        Debug.Log("Has subido de nivel, ahora eres todavía más homosexual!");
    }
}
