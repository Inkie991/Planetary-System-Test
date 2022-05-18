using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPlanetarySystem
{
    public IEnumerable<IPlanetaryObject> planetaryObjects { get; set; }
}