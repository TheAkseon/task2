using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conveyor : MonoBehaviour
{
    [SerializeField] float _speed;
    private bool _cubeOnConveyor = false;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out Cube cube))
        {
            _cubeOnConveyor = true;
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if(_cubeOnConveyor == true)
        {
            collision.transform.position += Vector3.forward * _speed * Time.deltaTime;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out Cube cube))
        {
            _cubeOnConveyor = false;
        }
    }
}
