using UnityEngine;

public class StateMachine<IEntity>
{
	public IState<IEntity> GlobalState;
	public IState<IEntity> CurrentState;
	public IState<IEntity> PreviousState;
	public IEntity Entity;


	public void ChangeState(IState<IEntity> newState)
	{
		try
		{
			CurrentState.Exit(Entity);
			PreviousState = CurrentState;
			CurrentState = newState;
			CurrentState.Enter(Entity);
		}
		catch (System.Exception ex)
		{
			Debug.Log($"Erro: {ex.Message}");
		}
	}

	public void RevertToPreviousState()
	{
		ChangeState(PreviousState);
	}

	public void ExecuteState()
	{
		CurrentState.Execute(Entity);
	}

	//public void InitialConfig(IEntity entity, IState<IEntity> globalState, IState<IEntity> currentState)
	//{
	//	Entity = entity;
	//	GlobalState = globalState;
	//	CurrentState = currentState;
	//}
}