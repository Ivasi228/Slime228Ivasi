using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    public class Patrul : MonoBehaviour
    {
        Vector3 _dir = Vector3.left;
        [SerializeField] float _speed;
        [SerializeField] Rigidbody2D _rb;
        private void FixedUpdate()
        {
                _rb.AddForce(_dir * _speed);
        }
        private void OnCollisionEnter2D(Collision2D collision)
        {
            _dir *= -1;
        }
    }
}
