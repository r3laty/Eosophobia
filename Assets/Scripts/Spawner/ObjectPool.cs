using UnityEngine;

public static class ObjectPool
{
    public static void PoolInstantiate(MonoBehaviour instance, Vector3 point)
    {
        instance.transform.position = point;
        instance.gameObject.SetActive(true);
    }
}
