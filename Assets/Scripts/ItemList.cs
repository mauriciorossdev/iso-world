using UnityEngine;
using UnityEngine.UI;

public class ItemList : MonoBehaviour
{

    public GameObject buttonPrefab;
    public GameObject buttonParent;


    private void OnEnable()
    {
        for (int i = 0; i < 10; i++)
        {
            GameObject button = Instantiate(buttonPrefab, buttonParent.transform);
        }
    }
}
