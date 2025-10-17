using UnityEngine;

[RequireComponent(typeof(MoveBehavior))]
[RequireComponent(typeof(JumpBehavior))]
public class Enemy : MonoBehaviour
{
    protected MoveBehavior _mb;
    protected JumpBehavior _jm;
    private Vector2 initialPosition = new Vector2(2, 1);
    private float _enemyLimitPositionXPositive = 5;
    private float _enemyLimitPositionXNegative = -3;
    private float _nextJumpTime;
    private float _currentJumpInterval;
    private void Awake()
    {
        transform.position = initialPosition;
        _mb = GetComponent<MoveBehavior>();
        _jm = GetComponent<JumpBehavior>();
    }
    private void Update()
    {
        _mb.EnemyPatrol(_enemyLimitPositionXPositive, _enemyLimitPositionXNegative);

        if (Time.time >= _nextJumpTime)
        {
            _jm.Jump(_currentJumpInterval); 
            SetNextJump();
        }
    }

    private void SetNextJump()
    {
        _currentJumpInterval = Random.Range(1f, 4f);
        _nextJumpTime = Time.time + _currentJumpInterval;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.layer == 6)//El numero es la layer en la que esta el player
        {
           
        }
        if (collision.gameObject.layer == 8)
        {
            Destroy(collision.gameObject);
            spawner.Push(gameObject);
        }
    }
}
