using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeManLoot : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> _loot = new List<GameObject>();


    public void DropLoot(Transform spawnposition)
    {
        foreach (var lootItem in _loot)
        {
            GameObject pickUpObject;
            Rigidbody2D rigidbody2D;

            pickUpObject = Instantiate(lootItem,spawnposition.position,Quaternion.identity);

            rigidbody2D = pickUpObject.AddComponent<Rigidbody2D>();
            rigidbody2D.AddForce(new Vector2(Random.value,Random.value),ForceMode2D.Impulse);
            rigidbody2D.angularDrag = 5f;
            rigidbody2D.drag = 1f;

        }
    }
}
