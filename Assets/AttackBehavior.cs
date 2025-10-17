using UnityEngine;

public class AttackBehavior : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Attack(GameObject target)
    {
        // Aquí puedes aplicar daño al objetivo si tiene un componente de salud
        var health = target.GetComponent<Health>();
        if (health != null)
        {
            health.TakeDamage(damage);
            Debug.Log($"{weaponName} hit {target.name} for {damage} damage.");
        }
    }
}
