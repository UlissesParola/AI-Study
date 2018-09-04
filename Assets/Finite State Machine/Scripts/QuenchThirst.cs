using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuenchThirst<T> : IState<Miner> {

	private static QuenchThirst<Miner> _instance;
	public static QuenchThirst<Miner> Instance
	{
		get
		{
			if (_instance == null)
			{
				_instance = new QuenchThirst<Miner>();
			}

			return _instance;
		}
	}

	public void Enter(Miner entity)
	{
		if (entity.Location != Location.Saloon)
		{
			entity.Location = Location.Saloon;
		}
	}

	public void Execute(Miner entity)
	{
		Debug.Log($"{entity.Name}: Hey, bartender, bring me a beer!");
		entity.Drink();
		entity.StateMachine.ChangeState(EnterMineAndDigForNugget<Miner>.Instance);
	}

	public void Exit(Miner entity)
	{
		Debug.Log($"{entity.Name}: Nothing like a cold beer!");
	}

	public bool OnMessage()
	{
		throw new System.NotImplementedException();
	}

	


}
