﻿using UnityEngine;
using System.Collections;

namespace testRPG.ItemSystem.Editor
{
	public partial class ISObjectEditor
	{
		void BottomStatusBar()
		{
			GUILayout.BeginHorizontal("Box", GUILayout.ExpandWidth(true));
			GUILayout.Label("StatusBar");
			GUILayout.EndHorizontal();
		}
	}
}