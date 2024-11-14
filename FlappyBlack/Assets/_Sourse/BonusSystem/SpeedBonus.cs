using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayerSystem;

namespace BonusSystem
{
    public class SpeedBonus : MonoBehaviour
    {
        [SerializeField] private float boostDuration = 5f;
        MovePlayer MovePlayer;
        CameraMove CameraMove;

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Player"))
            {
                StartCoroutine(ApplySpeedBoost(other.gameObject));
                StartCoroutine(DenySpeedBoost(other.gameObject,5f));
                Destroy(gameObject);
            }
        }

        private IEnumerator ApplySpeedBoost(GameObject player)
        {
            MovePlayer.moveSpeed += 4f;
            CameraMove.moveSpeed += 4f;

            yield return new WaitForSeconds(boostDuration);
        }
        private IEnumerator DenySpeedBoost(GameObject player, float delay)
        {
            CameraMove.moveSpeed -= 5f;
            MovePlayer.moveSpeed -= 5f;
            yield return new WaitForSeconds(boostDuration);
        }
    }
}

