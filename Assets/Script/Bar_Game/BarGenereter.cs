using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarGenereter : MonoBehaviour
{
    public GameObject blockPrefab;
    private GameObject currentBlock;

    public float minY = -350f;
    public float maxY = 50f;

    public float minWidth = 120f;
    public float maxWidth = 400f;

    void Start()
    {
        SpawnBlock();
    }

    void Update()
    {
        if (currentBlock != null && currentBlock.transform.position.x > -1200f)
        {
            Destroy(currentBlock);
            StartCoroutine(RespawnAfterDelay());
        }
    }

    IEnumerator RespawnAfterDelay()
    {
        yield return new WaitForSeconds(1f);
        SpawnBlock();
    }

    void SpawnBlock()
    {
        float randomY = Random.Range(minY, maxY);
        float randomWidth = Random.Range(minWidth, maxWidth);

        currentBlock = Instantiate(
            blockPrefab,
            new Vector3(transform.position.x, randomY, transform.position.z),
            Quaternion.identity
        );

        Vector3 scale = currentBlock.transform.localScale;
        scale.x = randomWidth;
        currentBlock.transform.localScale = scale;
    }
}