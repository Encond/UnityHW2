using Environment.Map.Items.Scripts;
using Unity.VisualScripting;
using UnityEngine;

namespace Environment.Player.Scripts
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private int _score = 0;

        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent(out Coin coin))
            {
                Destroy(coin.GameObject());
                print($"Score: {++_score}");
            }
        }
    }
}