using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class MoveHeroes : MonoBehaviour
{
    private Rigidbody _rigHero;
    [SerializeField, Range(5, 20)]
    private float _speed;


    void Start()
    {
        _rigHero = GetComponent<Rigidbody>();
    }


    public void MoveHero(Vector3 direction)
    {
        _rigHero.AddForce(direction * _speed);
    }
}
