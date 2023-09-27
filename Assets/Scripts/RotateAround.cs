using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class RotateAround : MonoBehaviour
    {
        public Transform target;
        public float speed;

        private void Start()
        {
            if (target != null) return;

            target = gameObject.transform;

            Debug.Log(message:"Target não informado, padronizando para o próprio objet.");

        }

        private void Update()
        {
            transform.RotateAround(target.position, new Vector3(0, 1, 0), speed);
        }
    }
}