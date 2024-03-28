using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;

public class FruitManager : MonoBehaviour
{
    [Header("Elements")]
    [SerializeField] GameObject fruitPrefab;

    [Header("Settings")]
    [SerializeField] float fruitYSpawnPoisition;
    void Start()
    {

    }

    void Update()
    {
        if(UnityEngine.Input.GetMouseButtonDown(0))
        { 
            ManagePlayerInput();
        }
    }
    void ManagePlayerInput()
    {
        Instantiate(fruitPrefab, GetClickedWorldPostion(), Quaternion.identity);
        Vector2 pos = GetClickedWorldPostion();
        pos.y = fruitYSpawnPoisition;
    }
    public Vector2 GetClickedWorldPostion()
    {
        return Camera.main.ScreenToWorldPoint(UnityEngine.Input.mousePosition);
    }
}
