using UnityEngine;

public class ColumnSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _columnPrefab;

    [SerializeField] private float _minColumnWidth;
    [SerializeField] private float _maxColumnWidth;

    private void RandomSize(GameObject column)
    {
        float columnWidth = Random.Range(_minColumnWidth, _maxColumnWidth);

        column.transform.localScale = new Vector3
            (
            column.transform.localScale.x, 
            columnWidth, 
            column.transform.localScale.z
            );
    }

    public GameObject SpawnColumn()
    {
        GameObject column = Instantiate(_columnPrefab, transform.position, Quaternion.identity, transform);

        RandomSize(column);

        return column;
    }
}