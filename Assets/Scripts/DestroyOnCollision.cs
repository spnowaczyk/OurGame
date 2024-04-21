namespace OurGame
{
    using UnityEngine;
    public class DestroyOnCollision : MonoBehaviour
    {
        private const string Player = "Player";

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag(Player))
            {
                Destroy(gameObject);
            }
        }
    }
}

