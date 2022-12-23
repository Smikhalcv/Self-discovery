using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GlobalString
{
    public class FollowTheHero : MonoBehaviour
    {
        private GameObject _hero;
        private Vector3 _heroPos;
        [SerializeField, Range(-50, 50)]
        private float _rangeX;
        [SerializeField, Range(0, 50)]
        private float _rangeY;
        [SerializeField, Range(-50, 50)]
        private float _rangeZ;


        void Start()
        {
            _hero = GameObject.FindGameObjectWithTag(GlobalStringVar.Hero);            
        }

        // Update is called once per frame
        void Update()
        {           
            transform.position = new Vector3(_heroPos.x + _rangeX, _heroPos.y + _rangeY, _heroPos.z + _rangeZ);
        }

        private void FixedUpdate()
        {
            _heroPos = _hero.transform.position;
        }
    }
}

