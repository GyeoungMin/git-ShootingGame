using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    [SerializeField] private Transform firePoint;
    [SerializeField] private BulletGenerator bulletGenerator;

    private Coroutine coroutine;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.GetComponent<BulletController>().pool.Release(collision.gameObject);
            Damaged();
        }
    }

    void Damaged()
    {
        Destroy(gameObject);
    }

    void OnEnable()
    {
        coroutine = StartCoroutine(CoFire());
    }
    void OnDisable()
    {
        StopCoroutine(coroutine);
    }
    IEnumerator CoFire()
    {
        while (true)
        {
            bulletGenerator.Shot(firePoint);
            yield return new WaitForSeconds(0.125f);
        }
    }
}