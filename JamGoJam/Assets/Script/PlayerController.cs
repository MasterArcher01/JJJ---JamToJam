using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float _speed;

    Rigidbody _rigid;

    void Awake()
    {
        _rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        float Xspeed, Yspeed, Zspeed;

        Xspeed = Input.GetAxis("Horizontal") * _speed;
        
        Zspeed = Input.GetAxis("Vertical") * _speed;
        Yspeed = 0;
        _rigid.velocity = new Vector3(Xspeed, Yspeed, Zspeed);
        Yspeed = 0;

        Xspeed = _rigid.velocity.x;

        Zspeed = _rigid.velocity.z;
        _rigid.velocity = new Vector3(Xspeed, Yspeed, Zspeed);
    }
}
