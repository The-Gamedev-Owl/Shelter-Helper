using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Animal : MonoBehaviour, IPointerClickHandler
{
    public AnimalStats stats;

    [SerializeField] private float _moveSpeed;

    private void OnEnable()
    {
        StartCoroutine(MoveRandomly());
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        DisplayAnimalStats.Instance.DisplayCurrentAnimalStats(stats, gameObject);
    }

    private IEnumerator MoveRandomly()
    {
        Vector2 randomPoint;

        while (gameObject != null)
        {
            randomPoint = DisplayAnimals.Instance.GenerateRandomSpawnPoint();

            // MoveSpeed is randomized between -10% and +10% from basic _moveSpeed
            float randomMoveSpeed = Random.Range(_moveSpeed - (_moveSpeed * 0.5f), _moveSpeed + (_moveSpeed * 0.5f));
            
            while (Vector2.Distance(transform.position, randomPoint) > 0.001f)
            {
                transform.position = Vector3.MoveTowards(transform.position, randomPoint, randomMoveSpeed * Time.deltaTime);
                yield return null;
            }
            transform.position = randomPoint;
            
            yield return new WaitForSeconds(Random.Range(1f, 5f));
        }
    }
}
