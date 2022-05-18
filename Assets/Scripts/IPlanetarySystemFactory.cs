using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPlanetarySystemFactory
{
        public IPlanetarySystem Create(double mass);
}
