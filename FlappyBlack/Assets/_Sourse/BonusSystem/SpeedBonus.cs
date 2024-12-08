using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayerSystem;

namespace BonusSystem
{
    public class SpeedBonus : MonoBehaviour
    {
        [SerializeField] private float boostDuration = 2f;
        MovePlayer MovePlayer;
        CameraMove CameraMove;

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Player"))
            {
                StartCoroutine(ApplySpeedBoost(other.gameObject));
                //StartCoroutine(DenySpeedBoost(other.gameObject,boostDuration));
                Destroy(gameObject);
            }
        }

        private IEnumerator ApplySpeedBoost(GameObject player)
        {
            MovePlayer.moveSpeed += 4f;
            CameraMove.moveSpeed += 4f;
            Debug.Log("Активировано");

            yield return new WaitForSeconds(boostDuration);

            CameraMove.moveSpeed -= 5f;
            MovePlayer.moveSpeed -= 5f;
        }
        private IEnumerator DenySpeedBoost(GameObject player, float delay)
        {
            yield return new WaitForSeconds(boostDuration);
            CameraMove.moveSpeed -= 5f;
            MovePlayer.moveSpeed -= 5f;
            
        }
    }
}

