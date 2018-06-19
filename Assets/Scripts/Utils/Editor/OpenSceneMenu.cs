﻿//Autogenerated class by script: Assets/Scripts/Utils/Editor/OpenSceneReloadMenu.cs
using UnityEngine;
using UnityEditor;

public static class OpenSceneMenu {

	[MenuItem("Open scene/EntryScene", false, 0)]
	static void OpenEntryScene() {
		OpenScene("Assets/Scenes/EntryScene.unity");
	}

	[MenuItem("Open scene/main", false, 0)]
	static void Openmain() {
		OpenScene("Assets/Scenes/main.unity");
	}

	static void OpenScene(string scenePath) {
	if (UnityEditor.SceneManagement.EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo()) {
			UnityEditor.SceneManagement.EditorSceneManager.OpenScene(scenePath);
		}
	}
}