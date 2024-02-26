using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamepadController : Singleton<GamepadController>
{
    private bool m_isAttack; 
    private bool m_canMoveLeft;
    private bool m_canMoveRight;
    private bool m_canMoveUp;
    private bool m_canMoveDown;
    private bool m_isStatic;

    private bool m_isOnMobile;


    public bool IsAttack { get => m_isAttack; }
    public bool CanMoveLeft { get => m_canMoveLeft;  }
    public bool CanMoveRight { get => m_canMoveRight; }
    public bool CanMoveUp { get => m_canMoveUp;  }
    public bool CanMoveDown { get => m_canMoveDown; }

    public bool IsStatic
    {
        get => m_isStatic = !m_canMoveLeft && !m_canMoveRight && !m_canMoveUp && !m_canMoveDown;
    }

    public override void Awake()
    {
        MakeSingleton(false);
    }

    private void Update()
    {
        if (!m_isOnMobile)
        {
            float hozCheck = Input.GetAxisRaw("Horizontal");
            float vertCheck = Input.GetAxisRaw("Vertical");

            m_canMoveLeft = hozCheck < 0 ? true : false;
            m_canMoveRight = hozCheck > 0 ? true : false;
            m_canMoveDown = vertCheck < 0 ? true : false;
            m_canMoveUp = vertCheck > 0 ? true : false;

            m_isAttack = Input.GetMouseButtonDown(0);
        }
    }

}
