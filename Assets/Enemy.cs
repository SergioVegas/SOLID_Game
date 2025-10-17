using UnityEngine;

[RequireComponent(typeof(MoveBehavior))]
[RequireComponent(typeof(JumpBehavior))]
public class Enemy : MonoBehaviour
{
    protected MoveBehavior _mb;
    protected JumpBehavior _jm;
    private Vector2 initialPosition = new Vector2(0, 2);
    private float _enemyLimitPositionXPositive = 5;
    private float _enemyLimitPositionXNegative = -5;
    private float timeJump;

    private void Awake()
    {
        transform.position = initialPosition;
        timeJump = Random.Range(1,3);
        _mb = GetComponent<MoveBehavior>();
        _jm = GetComponent<JumpBehavior>();
    }
    void Update()
    {
        _mb.EnemyPatrol(_enemyLimitPositionXPositive, _enemyLimitPositionXNegative);
        _jm.Jump(timeJump);
    }
}
