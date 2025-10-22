using UnityEngine;
using UnityEngine.InputSystem;
[RequireComponent(typeof(MoveBehavior))]
[RequireComponent(typeof(JumpBehavior))]
public class Player : MonoBehaviour
{
    protected MoveBehavior _mb;
    protected JumpBehavior _jm;
    private Vector2 initialPosition = new Vector2(1, 1);
    private float timeJump = 1f;
    private void Awake()
    {
        transform.position = initialPosition;
        _mb = GetComponent<MoveBehavior>();
        _jm = GetComponent<JumpBehavior>();
    }
 
    public void Update()
    {
        _mb.MoveCharacterHorizontal(new Vector2(Input.GetAxis("Horizontal"), 0));

        if (Input.GetKeyDown(KeyCode.Space))
        {
            _jm.Jump(timeJump);
        }
    }
}
        