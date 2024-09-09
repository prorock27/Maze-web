
using UnityEngine;

public class TileFloorGenerator : MonoBehaviour
{
    public GameObject CellPrefab; // ������ ������ ����
    public int width = 1;         // ������ � �������
    public int length = 1;        // ����� � �������
    public float tileSize = 1f;    // ������ ������

    void Start()
    {
        GenerateFloor();
    }

    void GenerateFloor()
    {
        if (CellPrefab == null)
        {
            Debug.LogError("������ ������ �� ����������!");
            return;
        }

        for (int x = 0; x < width; x++)
        {
            for (int z = 0; z < length; z++)
            {
                // ��������� ������� ������
                Vector3 position = new Vector3(x * tileSize, 0, z * tileSize);
                
                // ������� ������
                Instantiate(CellPrefab, position, Quaternion.identity, transform);
            }
        }
    }
}
