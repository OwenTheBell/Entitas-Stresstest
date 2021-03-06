//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameContext {

    public GameEntity tickTrackerEntity { get { return GetGroup(GameMatcher.TickTracker).GetSingleEntity(); } }
    public TickTracker tickTracker { get { return tickTrackerEntity.tickTracker; } }
    public bool hasTickTracker { get { return tickTrackerEntity != null; } }

    public GameEntity SetTickTracker(float newTick, float newTime, float newScale) {
        if (hasTickTracker) {
            throw new Entitas.EntitasException("Could not set TickTracker!\n" + this + " already has an entity with TickTracker!",
                "You should check if the context already has a tickTrackerEntity before setting it or use context.ReplaceTickTracker().");
        }
        var entity = CreateEntity();
        entity.AddTickTracker(newTick, newTime, newScale);
        return entity;
    }

    public void ReplaceTickTracker(float newTick, float newTime, float newScale) {
        var entity = tickTrackerEntity;
        if (entity == null) {
            entity = SetTickTracker(newTick, newTime, newScale);
        } else {
            entity.ReplaceTickTracker(newTick, newTime, newScale);
        }
    }

    public void RemoveTickTracker() {
        tickTrackerEntity.Destroy();
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public TickTracker tickTracker { get { return (TickTracker)GetComponent(GameComponentsLookup.TickTracker); } }
    public bool hasTickTracker { get { return HasComponent(GameComponentsLookup.TickTracker); } }

    public void AddTickTracker(float newTick, float newTime, float newScale) {
        var index = GameComponentsLookup.TickTracker;
        var component = CreateComponent<TickTracker>(index);
        component.tick = newTick;
        component.time = newTime;
        component.scale = newScale;
        AddComponent(index, component);
    }

    public void ReplaceTickTracker(float newTick, float newTime, float newScale) {
        var index = GameComponentsLookup.TickTracker;
        var component = CreateComponent<TickTracker>(index);
        component.tick = newTick;
        component.time = newTime;
        component.scale = newScale;
        ReplaceComponent(index, component);
    }

    public void RemoveTickTracker() {
        RemoveComponent(GameComponentsLookup.TickTracker);
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

    static Entitas.IMatcher<GameEntity> _matcherTickTracker;

    public static Entitas.IMatcher<GameEntity> TickTracker {
        get {
            if (_matcherTickTracker == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.TickTracker);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherTickTracker = matcher;
            }

            return _matcherTickTracker;
        }
    }
}
