using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class PlanetarySystem : MonoBehaviour, IPlanetarySystem
{
    public GameObject planetPrefab;
    public double totalMass;
    public IEnumerable<IPlanetaryObject> planetaryObjects {get; set;}
    
    public void CreatePlanets(double mass)
    {
        totalMass = mass;
        planetPrefab = (GameObject)AssetDatabase.LoadAssetAtPath("Assets/Prefabs/Planet.prefab", typeof(GameObject));

        // TODO: use constants
        int planetsCount = Random.Range(2, 20);
        List <IPlanetaryObject> planetaryObjectsList = new List<IPlanetaryObject>();
        for (int i = 0; i < planetsCount; i++)
        {
            double planetMass = Random.Range(0, (float)totalMass / 2);
            totalMass -= planetMass;
            GameObject newPlanet = Instantiate(planetPrefab, this.transform);
            newPlanet.GetComponent<PlanetaryObject>().CreatePlanet(planetMass);
            planetaryObjectsList.Add(newPlanet.GetComponent<PlanetaryObject>());
        }

        planetaryObjects = planetaryObjectsList;
    }
}
