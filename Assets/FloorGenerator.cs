
using UnityEngine;

public class TileFloorGenerator : MonoBehaviour
{
    public GameObject CellPrefab; // Префаб плитки пола
    public int width = 1;         // Ширина в клетках
    public int length = 1;        // Длина в клетках
    public float tileSize = 1f;    // Размер плитки

    void Start()
    {
        GenerateFloor();
    }

    void GenerateFloor()
    {
        if (CellPrefab == null)
        {
            Debug.LogError("Префаб плитки не установлен!");
            return;
        }

        for (int x = 0; x < width; x++)
        {
            for (int z = 0; z < length; z++)
            {
                // Вычисляем позицию плитки
                Vector3 position = new Vector3(x * tileSize, 0, z * tileSize);
                
                // Создаем плитку
                Instantiate(CellPrefab, position, Quaternion.identity, transform);
            }
        }
    }
}
