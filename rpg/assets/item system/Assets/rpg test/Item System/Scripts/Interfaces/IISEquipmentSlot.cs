using UnityEngine;
using System.Collections;

namespace testRPG.ItemSystem
{
public interface IISEquipmentSlot
	{
		string Name { get; set; }
		Sprite Icon { get; set; }
	}
}
