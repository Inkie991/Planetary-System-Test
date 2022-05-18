using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartSimulation : MonoBehaviour
{
    void Start()
    {
        IPlanetarySystemFactory factory = new PlanetarySystemFactory();
        IPlanetarySystem system = factory.Create(Random.Range(0.5f, 15000f));
    }
}
