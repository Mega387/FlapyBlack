using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LevelSystem
{
    public class SetActiveBoost : MonoBehaviour
    {
        public GameObject prefabToGenerate;
        public float generationDistance = 2f;

        public List<GameObject> objectsInsidePrefab;

        public int countToActivate = 1;

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Player"))
            {
                Vector2 triggerPosition = transform.position;
                Vector2 spawnPosition = triggerPosition + new Vector2(generationDistance, 0f);
                GameObject instantiatedPrefab = Instantiate(prefabToGenerate, spawnPosition, Quaternion.identity);
                ActivateRandomObjects(instantiatedPrefab);
            }
        }
        private void ActivateRandomObjects(GameObject prefabInstance)
        {
            if (objectsInsidePrefab.Count == 0 || countToActivate > objectsInsidePrefab.Count)
            {
                Debug.LogWarning("Список объектов пуст или недостаточно элементов для активации.");
                return;
            }

            List<GameObject> tempList = new List<GameObject>(objectsInsidePrefab);

            for (int i = 0; i < 1; i++)// i < countToActivate
            {
                int randomIndex = Random.Range(0, tempList.Count);
                tempList[randomIndex].SetActive(true);
                //tempList.RemoveAt(randomIndex);
            }
        }
    }
}
