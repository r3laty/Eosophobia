using UnityEngine;

public static class ObjectPool
{
    public static void PoolInstantiate(GameObject instance, Vector3 point)
    {
        instance.transform.position = point;
        instance.gameObject.SetActive(true);
    }
    public static void PoolDestroy(GameObject instance)
    {
        instance.gameObject.SetActive(false);
    }
}
