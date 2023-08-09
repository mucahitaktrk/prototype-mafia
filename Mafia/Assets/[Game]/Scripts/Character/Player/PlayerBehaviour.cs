using UnityEngine;

namespace _Game_.Scripts.Character.Player
{
    public class PlayerBehaviour : MonoBehaviour
    {
        [SerializeField] private PlayerMovement playerMovement;

        private void FixedUpdate()
        {
            playerMovement.onUpdate?.Invoke();
        }
    }
}