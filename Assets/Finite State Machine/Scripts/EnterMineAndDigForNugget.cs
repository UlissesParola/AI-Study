using UnityEngine;

public class EnterMineAndDigForNugget<T> : IState<Miner>
{
	private static EnterMineAndDigForNugget<Miner> _instance;

	public static EnterMineAndDigForNugget<Miner> Instance
	{
		get
		{
			if (_instance == null)
			{
				_instance = new EnterMineAndDigForNugget<Miner>();
			}

			return _instance;
		}
		
	}

	public void Enter(Miner miner)
	{
		if (miner.Location != Location.Mine)
		{
			Debug.Log($"{miner.Name}: I'am going to the Mine find some gold.");
			miner.Location = Location.Mine;
		}
	}

	public void Execute(Miner miner)
	{
		float prob = Random.Range(0, 1);
		if (prob <= 0.1)
		{
			Debug.Log($"{ miner.Name}: Oh, luck! I find some gold here!");
			miner.GoldCarried++;
		}

		if (miner.Thirst)
		{
			miner.StateMachine.ChangeState()
		}

	}

	public void Exit(Miner miner)
	{
		throw new System.NotImplementedException();
	}

	public bool OnMessage()
	{
		throw new System.NotImplementedException();
	}


}
