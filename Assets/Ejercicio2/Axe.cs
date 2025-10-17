using UnityEngine;

public class Axe : MonoBehaviour
{
    public int dammage = 3;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.TryGetComponent<IDammageable>(out IDammageable iDmg))
        {
            iDmg.Hurt();
        }
        Attack();
    }
    public void Attack()
    {

    }
}
