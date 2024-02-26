using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Actor : MonoBehaviour
{
    [Header("Component References: ")]
    public ActorStat actorStat;
    public CapsuleCollider2D capSunCollider;
    public GameObject knockBackVfx;

    [Header("Layer - Actor: ")]
    public LayerMask normal;
    public LayerMask knockBack;
    public LayerMask invincible;
    public LayerMask deadLayer;

    protected Rigidbody2D m_rb;
    protected float m_currentSpeed;

    public virtual void Awake()
    {
        
    }

}
