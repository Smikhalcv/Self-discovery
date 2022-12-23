using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointRaycast : MonoBehaviour
{
    private Camera _camera;
    private Vector3 _corHit = new Vector3();

    private void Awake()
    {
        _camera = Camera.main;
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Click mouse");
            Ray _ray = _camera.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(_ray, out RaycastHit hitInfo))
            {
                Debug.Log("work ray");
                Debug.Log(hitInfo.collider.gameObject.name);
                _corHit = hitInfo.point;
                Debug.Log($"cor x {_corHit.x} y {_corHit.y} z {_corHit.z}");
            }
        }
    }
}
