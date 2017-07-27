using Entitas;

public class CleanupSystem : ICleanupSystem {

	readonly GameContext _gameContext;
	readonly IGroup<GameEntity> _lifeTrackers;

	public CleanupSystem(Contexts contexts) {
		_gameContext = contexts.game;
		_lifeTrackers = contexts.game.GetGroup(GameMatcher.RemainingTime);
	}

	public void Cleanup() {
		foreach (var e in _lifeTrackers.GetEntities()) {
			e.remainingTime.value -= _gameContext.tickTracker.tick;
			if (e.remainingTime.value <= 0f) {
				e.Destroy();
			}
		}
	}
}