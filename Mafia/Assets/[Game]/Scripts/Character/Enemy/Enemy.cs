using System;
using UnityEngine;

namespace _Game_.Scripts.Character.Enemy
{
    public class Enemy : MonoBehaviour
    {
        [SerializeField] private Collider[] colliders;
        [SerializeField] private LayerMask playerLayer;
        
 
        private void FixedUpdate()
        {
            var size = Physics.OverlapSphereNonAlloc(transform.position, 2.5f, colliders, playerLayer);
            
        }

        private void OnDrawGizmos()
        {
            Gizmos.color = Color.green;
            Gizmos.DrawWireSphere(transform.position, 2.5f);
        }
    }
}