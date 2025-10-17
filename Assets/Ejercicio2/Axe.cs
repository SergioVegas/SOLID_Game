using UnityEngine;

public class Axe : MonoBehaviour
{
    public int dammage = 3;
    private bool _canAttack = true;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.TryGetComponent<IDammageable>(out IDammageable iDmg) && _canAttack)
        {
            iDmg.Hurt(dammage);
            _canAttack = false;
            Invoke("CanAttackAgain", 2f);
        }
    }
    public void CanAttackAgain()
    {

    }
}
