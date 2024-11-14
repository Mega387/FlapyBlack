using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LevelSystem
{
    public class Generator : MonoBehaviour
    {

        public GameObject prefabToGenerate;

        public float generationDistance = 2f;

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Player"))
            {
                Vector2 triggerPosition = transform.position;

                Vector2 spawnPosition = triggerPosition + new Vector2(generationDistance, 0f);

                Instantiate(prefabToGenerate, spawnPosition, Quaternion.identity);
            }
        }

    }

}