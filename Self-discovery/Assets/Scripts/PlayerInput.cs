using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GlobalString
{
    [RequireComponent(typeof(MoveHeroes))]
    public class PlayerInput : MonoBehaviour
    {
        private MoveHeroes _movement;
        private Vector3 _direction; 
        private float _horizontal;
        private float _vertical;

        void Start()
        {
            _movement = GetComponent<MoveHeroes>();
        }

        
        void Update()
        {
            _horizontal = Input.GetAxis(GlobalStringVar.Horizontal);
            _vertical = Input.GetAxis(GlobalStringVar.Vertical);
            _direction = new Vector3(_horizontal, 0, _vertical).normalized;
        }

        private void FixedUpdate()
        {
            _movement.MoveHero(_direction);
        }
    }
}

