﻿using UnityEditor;
using System.IO;

public class CustomPostImporting : AssetPostprocessor 
{
//	static void OnPostprocessAllAssets(string[] importedAssets, string[] deletedAssets, string[] movedAssets, string[] movedFromAssetPaths)
//	{
//		SetScriptingDefineSymbols();
//	}
//
//	static void SetScriptingDefineSymbols()
//	{  //1.3
//		string defines = "";
//		if (Directory.Exists("Assets/3rdParty/GoogleMobileAds"))
//			defines = defines + "; GOOGLE_MOBILE_ADS";
//		if (Directory.Exists("Assets/3rdParty/Chartboost"))
//			defines = defines + "; CHARTBOOST_ADS";
//		if (Directory.Exists("Assets/3rdParty/FacebookSDK")) {
//			defines = defines + "; FACEBOOK";
//			if (Directory.Exists("Assets/3rdParty/PlayFabSDK"))
//				defines = defines + "; PLAYFAB";
//			if (Directory.Exists("Assets/GameSparks"))
//				defines = defines + "; GAMESPARKS";
//
//		}
//		if (Directory.Exists("Assets/Plugins/UnityPurchasing"))
//			defines = defines + "; UNITY_INAPPS";
//		
////		#if UNITY_ANDROID
//		if (Directory.Exists("Assets/Appodeal"))
//		{
//			defines = defines + "; APPODEAL_ADS";
//		}
//
//		defines = defines + "; UNITY_ANALYTICS";
//
////		#elif UNITY_IOS
////		defines = defines + "; UNITY_ADS";
////
////		#endif
//		PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android, defines);
//		PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.iOS, defines);
////		PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.WSA, defines);//1.3.3
//	}
}
