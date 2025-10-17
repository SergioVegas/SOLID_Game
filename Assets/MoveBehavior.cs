using UnityEngine;

public class MoveBehavior : MonoBehaviour
{
    private Rigidbody2D _rb;
    public float speed;
    private int _direction = 1;
    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }
    public void MoveCharacterHorizontal(Vector2 direction)
    {
        if (Mathf.Abs(direction.x) > 0) //Usamos Abs, para saber si hay movimeinto en X, nos da igual si es negativo o positivo.
        {
            _rb.linearVelocity = direction.normalized * speed;
        }
        else
        {
            _rb.linearVelocity = Vector2.zero;
        }
    }
    public void EnemyPatrol(float _enemyLimitPositionXPositive, float _enemyLimitPositionXNegative)
    {
        if (transform.position.x >= _enemyLimitPositionXPositive)
        {
            _direction = -1;
        }
        else if (transform.position.x <= _enemyLimitPositionXNegative)
        {
            _direction = 1;
        }

        _rb.linearVelocity = new Vector2(_direction * speed, 0);
    }
}

