using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoHomeAndSleepUntilRested<T> : IState<Miner>{

	private static GoHomeAndSleepUntilRested<Miner> _instace;
	public static GoHomeAndSleepUntilRested<Miner> Instance
	{
		get
		{
			if (_instace == null)
			{
				_instace = new GoHomeAndSleepUntilRested<Miner>();
			}

			return _instace;
		}
	}

	public void Enter(Miner entity)
	{
		if (entity.Location != Location.House)
		{
			entity.Location = Location.House;
		}

		Debug.Log($"{entity.Name}: I will take a nap.");
	}

	public void Execute(Miner entity)
	{
		entity.Rest();
		Debug.Log($"{entity.Name}: Zzzz");

		if (entity.Fatigued == false)
		{
			entity.StateMachine.ChangeState(EnterMineAndDigForNugget<Miner>.Instance);
		}
	}

	public void Exit(Miner entity)
	{
		Debug.Log($"{entity.Name}: I'm feeling rested now.");
	}

	public bool OnMessage()
	{
		throw new System.NotImplementedException();
	}

}
