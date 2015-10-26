using UnityEngine;
using System.Collections;

public abstract class Monster{
	public abstract Monster clone();
}

public class Ghost : Monster{
	private int health_;
	private int speed_;

	public Ghost()
	{
		Debug.Log("Ghost");
	}

	public Ghost(int health, int speed)
	{
		health_ = health;
		speed_ = speed;
	}

	public override Monster clone()
	{
		return new Ghost(health_, speed_);
	}
}

public class Demon : Monster{
	private int health_;
	private int speed_;
	public Demon(int health, int speed)
	{
		health_ = health;
		speed_ = speed;
	}
	
	public override Monster clone()
	{
		return new Demon(health_, speed_);
	}
}

public class Sorcerer : Monster{
	private int health_;
	private int speed_;
	public Sorcerer(int health, int speed)
	{
		health_ = health;
		speed_ = speed;
		Debug.Log("Sorcerer");
	}
	
	public override Monster clone()
	{
		return new Sorcerer(health_, speed_);
	}
}