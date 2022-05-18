using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class PlanetarySystemFactory : MonoBehaviour, IPlanetarySystemFactory
{
    private GameObject systemPrefab;
    private double mass;

    public IPlanetarySystem Create(double mass)
    {
        systemPrefab = (GameObject) AssetDatabase.LoadAssetAtPath("Assets/Prefabs/Planetary System.prefab", typeof(GameObject));
        GameObject newSystem = Instantiate(systemPrefab);
        newSystem.GetComponent<PlanetarySystem>().CreatePlanets(mass);
        return newSystem.GetComponent<IPlanetarySystem>();
    }
    
}
