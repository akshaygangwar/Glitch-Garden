using UnityEngine;
using System.Collections;

public class PlayerPrefsManager : MonoBehaviour {

	const string MASTER_VOLUME_KEY = "master_volume";
	const string DIFF_KEY = "difficulty";
	const string LEVEL_KEY = "level_unlocked_key_";

	public static void SetMasterVolume(float volume) {
		if (volume > 0f && volume < 1f) {
			PlayerPrefs.SetFloat (MASTER_VOLUME_KEY, volume);
		} else {
			Debug.LogError("Master volume out of range");
		}
	}

	public static float GetMasterVolume() {
		return PlayerPrefs.GetFloat (MASTER_VOLUME_KEY);
	}

	public static void UnlockLevel(int level){
		if (level <= Application.levelCount - 1) {
			PlayerPrefs.SetInt(LEVEL_KEY + level.ToString(), 1);
		} else {
			Debug.LogError("Level not in build order");
		}
	}

	public static bool IsLevelUnlocked(int level) {
		if (level <= Application.levelCount - 1) {
			int flag = PlayerPrefs.GetInt (LEVEL_KEY + level.ToString ());
			if (flag == 1) {
				return true;
			} else {
				return false;
			}
		} else {
			Debug.LogError("Level does not exist in build order.");
			return false;
		}
	}

	public static void SetDifficulty(float difficulty) {
		if (difficulty >= 0f && difficulty <= 1f) {
			PlayerPrefs.SetFloat (DIFF_KEY, difficulty);
		} else {
			Debug.LogError("Difficulty value out of range");
		}
	}

	public static float GetDifficulty() {
		return PlayerPrefs.GetFloat(DIFF_KEY);
	}

	public static void DeleteAllKeys() {
		PlayerPrefs.DeleteAll ();
	}
}
