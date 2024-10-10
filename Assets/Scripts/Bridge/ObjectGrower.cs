using UnityEngine;

public class ObjectGrower : MonoBehaviour
{
    [SerializeField] private float _growSpeed;

    private Transform _objectToGrow;

    public void SetObjectToGrow(Transform obj)
    {
        _objectToGrow = obj;
    }
    
    public void Grow()
    {
        Vector3 lastScale = _objectToGrow.localScale;

        _objectToGrow.localScale = new Vector3(lastScale.x, lastScale.y + Time.deltaTime * _growSpeed, lastScale.z);
    }
}
