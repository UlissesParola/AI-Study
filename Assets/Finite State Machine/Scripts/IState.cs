public interface IState<IEntity>
{
	void Enter(IEntity entity);
	void Execute(IEntity entity);
	void Exit(IEntity entity);
	bool OnMessage();
}