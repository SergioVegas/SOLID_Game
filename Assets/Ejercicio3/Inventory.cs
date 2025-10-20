using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class Inventory: MonoBehaviour
{
    [SerializeField] private List<Item> ItemInventory;
    [SerializeField] private Item currentItem;
    private void Awake()
    {
        currentItem = ItemInventory[Random.Range(0, ItemInventory.Count)];
    }
    public void UseItem()
    {
        currentItem.UseItem();
    }
    public void Update()
    {
        UseItem();
    }
}
