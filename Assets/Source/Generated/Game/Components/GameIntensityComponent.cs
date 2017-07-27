//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public IntensityComponent intensity { get { return (IntensityComponent)GetComponent(GameComponentsLookup.Intensity); } }
    public bool hasIntensity { get { return HasComponent(GameComponentsLookup.Intensity); } }

    public void AddIntensity(int newValue) {
        var index = GameComponentsLookup.Intensity;
        var component = CreateComponent<IntensityComponent>(index);
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceIntensity(int newValue) {
        var index = GameComponentsLookup.Intensity;
        var component = CreateComponent<IntensityComponent>(index);
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveIntensity() {
        RemoveComponent(GameComponentsLookup.Intensity);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherIntensity;

    public static Entitas.IMatcher<GameEntity> Intensity {
        get {
            if (_matcherIntensity == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Intensity);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherIntensity = matcher;
            }

            return _matcherIntensity;
        }
    }
}