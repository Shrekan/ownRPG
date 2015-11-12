using UnityEngine;
using System.Collections;

namespace testRPG.ItemSystem
{
public interface IISObject {
	//name
	string Name { get; set; }

	//value - gold value
	int Value { get; set; }

	//icon
	Sprite Icon { get; set; }

	//qualitylevel
	ISQuality Quality { get; set; }

	//equip
	//questitem flag
}
}
