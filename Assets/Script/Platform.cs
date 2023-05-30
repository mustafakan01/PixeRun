using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class Platform : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] Rigidbody2D _rb2d;
    [SerializeField] private GameObject _platformPrefab;
    [SerializeField] private float currentXSpawnPoit = 12f;
    [SerializeField] private bool collectionChecks=true;
    [SerializeField] private int maxPoolSize = 15;
    public IObjectPool<GameObject> m_pool{ get; set; }
    void Update()
    {
        _rb2d.velocity = new Vector2(-1 * _speed,0);

    }
}
