using UnityEngine;

public class CharacterEX2 : MonoBehaviour, IDammageable
{
    protected int HP;
    public void Hurt(int dmg)
    {
        Debug.Log("Ay");
        HP -= dmg;
    }
}
