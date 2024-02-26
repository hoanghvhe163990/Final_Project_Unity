using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
    public float moveSpeed;

    private float m_horizontal;
    private float m_vertical;

    private Rigidbody2D m_rb; 
    private GamepadController gPad;

    // Start is called before the first frame update
    void Start()
    {
        m_rb = GetComponent<Rigidbody2D>();
        gPad = GamepadController.Ins;
        m_rb.gravityScale = 0f;
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void FixedUpdate()
    {
        MoveChecking();
    }

    private void Moving(Direction direction)
    {
        FlipCharacters(direction);

        if (direction == Direction.Left || direction == Direction.Right)
        {
            m_horizontal = direction == Direction.Left ? -1 : 1;
            m_rb.velocity = new Vector2(m_horizontal * moveSpeed, m_rb.velocity.y);
        }

        if (direction == Direction.Up || direction == Direction.Down)
        {
            m_vertical = direction == Direction.Down ? -1 : 1;
            m_rb.velocity = new Vector2(m_rb.velocity.x, m_vertical * moveSpeed);
        }
    }

    private void MoveChecking()
    {
        if (gPad.IsStatic)
        {
            m_rb.velocity = Vector2.zero;
            return;
        }

        if (gPad.CanMoveLeft)
        {
            Moving(Direction.Left);
        }

        if (gPad.CanMoveRight)
        {
            Moving(Direction.Right);
        }

        if (gPad.CanMoveUp)
        {
            Moving(Direction.Up);
        }

        if (gPad.CanMoveDown)
        {
            Moving(Direction.Down);
        }
    }

    public void FlipCharacters(Direction direction)
    {
        switch (direction)
        {
            case Direction.Left:
                if (transform.localScale.x > 0)
                {
                    transform.localScale = new Vector3(transform.localScale.x * -1f, transform.localScale.y, transform.localScale.z);
                }
                break;
            case Direction.Right:
                if (transform.localScale.x < 0)
                {
                    transform.localScale = new Vector3(transform.localScale.x * -1f, transform.localScale.y, transform.localScale.z);
                }
                break;
            case Direction.Up:
                if (transform.localScale.y < 0)
                {
                    transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y * -1f, transform.localScale.z);
                }
                break;
            case Direction.Down:
                if (transform.localScale.y > 0)
                {
                    transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y * -1f, transform.localScale.z);
                }
                break;
        }
    }

}
