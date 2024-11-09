using System.Collections;
using UnityEngine;
using System.Collections.Generic;
/*
 * Duncan Barner
 * Inventory.cs
 * Assignment 6
 * Manages inventory items
 */

public class Inventory : MonoBehaviour
    {
    [SerializeField] private InventoryItem item;
    public List<InventoryItem> inventory;

        // Use this for initialization
        void Start()
        {
        item = new InventoryItem();
        inventory = new List<InventoryItem>();

        }

        // Update is called once per frame
        void Update()
        {

        }
    }