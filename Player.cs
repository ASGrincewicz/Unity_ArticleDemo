using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Transform))]
[RequireComponent(typeof(SphereCollider))]
[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
[RequireComponent(typeof(Rigidbody))]

    
public class Player : MonoBehaviour
{
    [SerializeField] private float _speed;
    private Transform _transform;
    private void Awake()
    {
        var meshFilter = GetComponent<MeshFilter>();
        var meshRenderer = GetComponent<MeshRenderer>();
        if (meshFilter)
            Debug.Log("Mesh Filter Found");
        if (meshRenderer)
            Debug.Log("Mesh Renderer Found");
    }

    private void Start()
    {
        _transform = transform;
    }

    private void Update()
    {
       Move();
    }

    private void Move()
    {
        var horizontal = Input.GetAxis("Left_Right");
        var vertical = Input.GetAxis("Forward_Backward");
        var direction = new Vector3(horizontal, 0.0f, vertical) ;

        _transform.Translate(direction * (_speed * Time.deltaTime));

    }
}
