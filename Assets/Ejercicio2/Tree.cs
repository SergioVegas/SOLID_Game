using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour, IDammageable
{
    private List<string> _items; //0: fulla, 1: fusta, 2:poma
    private int maxNumberOfDropsApple = 5;
    private int _currentDrops = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Hurt(int dmg)
    {
        Drop();
    }
    public void Drop()
    {
        Debug.Log("drop" + _items[0]);
        Debug.Log("drop" + _items[1]);
        float rand = Random.Range(0, 5);
        if (rand == 0 && _currentDrops < maxNumberOfDropsApple)
        {
            Debug.Log("drop" + _items[2]);

        }
        
    }
}
