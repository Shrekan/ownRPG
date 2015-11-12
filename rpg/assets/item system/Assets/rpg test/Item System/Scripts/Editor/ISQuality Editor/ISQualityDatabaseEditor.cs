using UnityEditor;
using UnityEngine;
using System.Collections;

namespace testRPG.ItemSystem.Editor
{
	public partial class ISQualityDatabaseEditor : EditorWindow
	{
		ISQualityDatabase qualityDatabase;
		Texture2D selectedTexture;
		int selectedIndex = -1;
		Vector2 _scrollPos;				//scroll position for the list view



		const int SPRITE_BUTTON_SIZE = 46;

		const string Database_Name = @"ShrekanQualityDatabase.asset";
		const string Database_Path = @"Database";
//		const string DATABASE_FULL_PATH = @"Assets/"+ Database_Path + "/" + Database_Name;


		[MenuItem("Shrekan/Database/Quality Editor %#w")]
		public static void Init()
		{
			ISQualityDatabaseEditor window = EditorWindow.GetWindow<ISQualityDatabaseEditor>();
			window.minSize = new Vector2(400, 300);
			GUIContent titleContent = new GUIContent ("Quality Database"); //google
			window.titleContent = titleContent;
			window.Show ();
		}



		void OnEnable()
		{
			if( qualityDatabase == null)
			qualityDatabase = ISQualityDatabase.GetDatabase<ISQualityDatabase>(Database_Path, Database_Name);
		}
			




		void OnGUI()
		{
			if (qualityDatabase == null)
			{
				Debug.LogWarning("qualityDatabase not loaded");
				return;
			}

			ListView();

			GUILayout.BeginHorizontal("Box", GUILayout.ExpandWidth(true));
			BottomBar ();
			GUILayout.EndHorizontal();
		}


		void BottomBar()
		{
			//count
			GUILayout.Label("Qualities: " + qualityDatabase.Count);
			//addbutton
			if(GUILayout.Button("Add"))
			{
				qualityDatabase.Add(new ISQuality());
			}
		}
	}
}