using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPlanetaryObject
{
    public MassClassEnum massClass { get; set; }
    
    public double mass { get; set; }
}
