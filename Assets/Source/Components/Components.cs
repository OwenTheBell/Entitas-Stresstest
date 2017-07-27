using UnityEngine;
using Entitas;
using Entitas.CodeGeneration.Attributes;

[Game]
public class IntensityComponent : IComponent {
    public int value;
}

[Game]
public class X : IComponent {}
[Game]
public class Y : IComponent {}
[Game]
public class Z : IComponent {}

[Game, Unique]
public class EntityTracker : IComponent {
    public int value;
}

[Game]
public class RemainingTime : IComponent {
    public float value;
}

[Game, Unique]
public class TickTracker : IComponent {
    public float tick;
    public float time;
    public float scale;
}