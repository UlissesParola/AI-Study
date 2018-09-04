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
		throw new System.NotImplementedException();
	}

	public void Execute(Miner entity)
	{
		throw new System.NotImplementedException();
	}

	public void Exit(Miner entity)
	{
		throw new System.NotImplementedException();
	}

	public bool OnMessage()
	{
		throw new System.NotImplementedException();
	}

}
