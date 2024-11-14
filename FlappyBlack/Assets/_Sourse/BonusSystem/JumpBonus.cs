using PlayerSystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayerSystem;

public class JumpBonus : MonoBehaviour
{
    public class SpeedBonus : MonoBehaviour
    {
        [SerializeField] private float boostDuration = 7f;
        private MovePlayer _movePlayer;
        void Start()
        {
            _movePlayer = FindObjectOfType<MovePlayer>();
        }



        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Player"))
            {
                StartCoroutine(ApplySpeedBoost(other.gameObject));
                Destroy(gameObject);
            }
        }

        private IEnumerator ApplySpeedBoost(GameObject player)
        {
            MovePlayer.jumpForce += 100f;
            //_movePlayer.mass();

            yield return new WaitForSeconds(boostDuration);

            MovePlayer.jumpForce -= 100f;
        }
    }
}
