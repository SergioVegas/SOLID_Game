using UnityEngine;

public class CharacterEX2 : MonoBehaviour, IDammageable
{
    protected int HP;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Hurt(int dmg)
    {
        Debug.Log("Ay");
        HP = -dmg;
    }
}
