using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyGameObject : MonoBehaviour
{
    [SerializeField] private float timeDestroy;

    void Start()
    {
        Destroy(gameObject, timeDestroy);   
    }
}
