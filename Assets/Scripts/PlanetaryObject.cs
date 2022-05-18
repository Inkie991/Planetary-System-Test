using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Random = UnityEngine.Random;

public class PlanetaryObject : MonoBehaviour, IPlanetaryObject
{
    public MassClassEnum massClass { get; set; }
    public double mass { get; set; }
    private float radius;

    private float angle = 0; // угол 
    private float orbitRadius; // радиус
    private float speed;

    public void CreatePlanet(double planetMass)
    {
        mass = planetMass;
        // TODO: make mass class a computable property
        if (mass < 0.00001)
        {
            massClass = MassClassEnum.Asteroidan;
            radius = Random.Range(0.00001f, 0.03f);
        } else if (mass < 0.1)
        {
            massClass = MassClassEnum.Mercurian;
            radius = Random.Range(0.03f, 0.7f);
        } else if (mass < 0.5)
        {
            massClass = MassClassEnum.Subterran;
            radius = Random.Range(0.5f, 1.2f);
        } else if (mass < 2)
        {
            massClass = MassClassEnum.Terran;
            radius = Random.Range(0.8f, 1.9f);
        } else if (mass < 10)
        {
            massClass = MassClassEnum.Superterran;
            radius = Random.Range(1.3f, 3.3f);
        } else if (mass < 50)
        {
            massClass = MassClassEnum.Neptunian;
            radius = Random.Range(2.1f, 5.1f);
        } else if (mass < 5000)
        {
            massClass = MassClassEnum.Jovian;
            radius = Random.Range(3.5f, 27f);
        }

        orbitRadius = Random.Range(1f, 50f);
        speed = Random.Range(0.001f, 1f);
        transform.localScale = new Vector3(radius, radius, 0);
        transform.GetComponent<SpriteRenderer>().color = Random.ColorHSV();
    }
    void Update()
    {
        angle += Time.deltaTime; // меняется плавно значение угла

        var x = Mathf.Cos (angle * speed) * orbitRadius;
        var y = Mathf.Sin (angle * speed) * orbitRadius;
        transform.position = new Vector2(x, y);
    }

    
}

