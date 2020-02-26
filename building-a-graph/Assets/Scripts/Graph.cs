using UnityEngine;

public class Graph : MonoBehaviour
{
    public Transform pointPrefab;
    [Range(10,100)] public int resolution = 10;

    private void Awake()
    {

        Transform point;
        Vector3 position = Vector3.zero;
        float step = 2f / resolution;
        Vector3 scale = Vector3.one * step;

        for (int i=0; i<resolution; i++)
        {
            point = Instantiate(pointPrefab);
            // point.localPosition = Vector3.right * ((i + 0.5f) / 5f - 1f); /// right is a static property -> Class.getX() where getX() is a static function

            position.x = (i + 0.5f) * step - 1f;
            position.y = position.x * position.x;
            point.localPosition = position;

            point.localScale = scale;
            point.SetParent(transform, false); /// transform is an inherited property
        }
    }
}
