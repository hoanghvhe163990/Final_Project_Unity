using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunWeapon : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GunRotation();
    }

    private void FixedUpdate()
    {

    }

    private void GunRotation()
    {
        Vector3 mousePouse = Input.mousePosition;
        Vector3 camWorldPosToMousePos = Camera.main.ScreenToWorldPoint(mousePouse);
        Vector3 targetMouseDir = camWorldPosToMousePos - transform.position;
        targetMouseDir.Normalize();

        float angle = Mathf.Atan2(targetMouseDir.y, targetMouseDir.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0, 0, angle);

        float eulerAngles = transform.eulerAngles.z;
    }
}
