using System;
using UnityEngine;

namespace _Game_.Scripts.Character.Player
{
    [Serializable]
    public class PlayerMovement
    {
        [SerializeField] private CharacterController characterController;
        [SerializeField] private Vector3 moveVector;
        
        private const string Horizontal = "Horizontal";
        private const string Vertical = "Vertical";

        public Action onUpdate;

        private PlayerMovement()
        {
            onUpdate += Movement;
            onUpdate += Rotation;
        }

        private void Movement()
        {
            var horizontal = Input.GetAxis(Horizontal);
            var vertical = Input.GetAxis(Vertical);
            moveVector = horizontal * Vector3.right + vertical * Vector3.forward;
            characterController.Move(moveVector + Vector3.up * -.1f);
        }

        private void Rotation()
        {
            if(moveVector == Vector3.zero) return;
            var transform = characterController.transform;
            Quaternion toRotation = Quaternion.LookRotation(moveVector, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, 720 * Time.deltaTime);
        }
    }
}
