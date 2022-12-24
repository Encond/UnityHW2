using UnityEngine;

namespace Environment.Player.Scripts
{
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField] private float _speed = 5f;
        [SerializeField] private float _rotationSpeed = 100f;

        void FixedUpdate()
        {
            float horizontalInput = Input.GetAxis("Horizontal") * _rotationSpeed * Time.fixedDeltaTime;
            float verticalInput = Input.GetAxis("Vertical") * _speed * Time.fixedDeltaTime;

            transform.Translate(0f, 0f, verticalInput);
            transform.Rotate(0f, horizontalInput, 0f);
        }
    }
}