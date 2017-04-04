﻿#if UNITY_EDITOR
using UnityEngine;
using UnityEditor;

namespace UMA.Editors
{
	[CustomEditor(typeof(UMAAssetCollection), true)]
	public class UMAAssetCollectionEditor : UnityEditor.Editor 
	{
		public override void OnInspectorGUI()
		{
			if (GUILayout.Button("Add to Scene"))
			{
				var collection = target as UMAAssetCollection;
				var overlayLibrary = UnityEngine.Object.FindObjectOfType<OverlayLibraryBase>();
				var slotLibrary = UnityEngine.Object.FindObjectOfType<SlotLibraryBase>();
				var raceLibrary = UnityEngine.Object.FindObjectOfType<RaceLibraryBase>();
				collection.AddToLibraries(overlayLibrary, slotLibrary, raceLibrary);
			}
			base.OnInspectorGUI();
		}

		[MenuItem("Assets/Create/UMA/Core/Asset Collection")]
		public static void CreateUMAAssetCollection()
		{
			UMA.Editors.CustomAssetUtility.CreateAsset<UMAAssetCollection>();
		}
	}
	#endif
}
