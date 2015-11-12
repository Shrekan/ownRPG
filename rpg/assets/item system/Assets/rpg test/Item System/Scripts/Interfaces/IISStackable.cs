using UnityEngine;
using System.Collections;

namespace testRPG.ItemSystem.Editor
{
public interface IISStackable
	{
		int MaxStack { get; }
		int Stack(int amount); //default value of 0
	}
}
