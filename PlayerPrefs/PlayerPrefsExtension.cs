using UnityEngine;

namespace NS {
	public class PlayerPrefs {
		public static void SetInt(string key, int value){
			UnityEngine.PlayerPrefs.SetInt(key, value);
		}

		public static int GetInt(string key){
			int i;
			i = UnityEngine.PlayerPrefs.GetInt(key);
			return i;
		}

		public static void SetFloat(string key, float value){
			UnityEngine.PlayerPrefs.SetFloat(key, value);
		}

		public static float GetFloat(string key){
			float i;
			i = UnityEngine.PlayerPrefs.GetFloat(key);
			return i;
		}

		public static void SetString(string key, string text){
			UnityEngine.PlayerPrefs.SetString(key, text);
		}

		public static string GetString(string key){
			string i;
			i = UnityEngine.PlayerPrefs.GetString(key);
			return i;
		}

		public static void SetBool(string key, bool state){
			int i = 0;
			if(state == true){
				i = 1;
			}else if(state == false){
				i = 0;
			}
	        NS.PlayerPrefs.SetInt(key, i);
	    }
 
	    public static bool GetBool(string key){
			int value = NS.PlayerPrefs.GetInt(key);
	        if (value == 1){
	            return true;
	        }else{
	            return false;
	        }
	    }

		public static void SetVector2(string key, Vector2 vector){
			Vector2 i = vector;
			NS.PlayerPrefs.SetFloat(key + ".X", i.x);
			NS.PlayerPrefs.SetFloat(key + ".Y", i.y);
		}

		public static Vector2 GetVector2(string key){
			float x; float y;
			x = NS.PlayerPrefs.GetFloat(key + ".X");
			y = NS.PlayerPrefs.GetFloat(key + ".Y");
			Vector2 i = new Vector2(x, y);
			return i;
		}

		public static void SetVector3(string key, Vector3 vector){
			Vector3 i = vector;
			NS.PlayerPrefs.SetFloat(key + ".X", i.x);
			NS.PlayerPrefs.SetFloat(key + ".Y", i.y);
			NS.PlayerPrefs.SetFloat(key + ".Z", i.z);
		}

		public static Vector3 GetVector3(string key){
			float x; float y; float z;
			x = NS.PlayerPrefs.GetFloat(key + ".X");
			y = NS.PlayerPrefs.GetFloat(key + ".Y");
			z = NS.PlayerPrefs.GetFloat(key + ".Z");
			Vector3 i = new Vector3(x, y, z);
			return i;
		}

		public static void SetQuaternion(string key, Quaternion quaternion){
			Quaternion i = quaternion;
			NS.PlayerPrefs.SetFloat(key + ".X", i.x);
			NS.PlayerPrefs.SetFloat(key + ".Y", i.y);
			NS.PlayerPrefs.SetFloat(key + ".Z", i.z);
			NS.PlayerPrefs.SetFloat(key + ".W", i.w);
		}

		public static Quaternion GetQuaternion(string key){
			float x; float y; float z; float w;
			x = NS.PlayerPrefs.GetFloat(key + ".X");
			y = NS.PlayerPrefs.GetFloat(key + ".Y");
			z = NS.PlayerPrefs.GetFloat(key + ".Z");
			w = NS.PlayerPrefs.GetFloat(key + ".W");
			Quaternion i = new Quaternion(x, y, z, w);
			return i;
		}

		public static void SetColorSplit(string key, Color color){
			float r; float g; float b; float a;
			r = color.r; g = color.g; b = color.b; a = color.a;
			NS.PlayerPrefs.SetFloat(key + ".r", r);
			NS.PlayerPrefs.SetFloat(key + ".g", g);
			NS.PlayerPrefs.SetFloat(key + ".b", b);
			NS.PlayerPrefs.SetFloat(key + ".a", a);
		}

		public static Color GetColorSplit(string key){
			float r; float g; float b; float a;
			r = NS.PlayerPrefs.GetFloat(key + ".r");
			g = NS.PlayerPrefs.GetFloat(key + ".g");
			b = NS.PlayerPrefs.GetFloat(key + ".b");
			a = NS.PlayerPrefs.GetFloat(key + ".a");
			Color i = new Color(r, g, b, a);
			return i;
		}

		public static void SetColor(string key, Color color){
			float r; float g; float b; float a;
			r = color.r; g = color.g; b = color.b; a = color.a;
			NS.PlayerPrefs.SetString(key, r + ", " + g + ", " + b + ", " + a);
		}

		public static Color GetColor(string key){
			string[] t = NS.PlayerPrefs.GetString(key).Split(", "[0]);
			float r; float g; float b; float a;
			r = float.Parse(t[0]); g = float.Parse(t[1]); b = float.Parse(t[2]); a = float.Parse(t[3]);
			Color i = new Color(r, g, b, a);
			return i;
		}

		public static void SetStringArray(string key, string[] array){
			string i = array[0].ToString();
			int y = 0;
			foreach (var item in array) {
				if(y != 0){
					i = i + ", " + item;
				}
				y++;
			}
			NS.PlayerPrefs.SetString(key, i);
		}

		public static string[] GetStringArray(string key){
			string[] t = NS.PlayerPrefs.GetString(key).Split(", "[0]);
			return t;
		}

		public static void SetIntArray(string key, int[] array){
			string i = array[0].ToString();
			int y = 0;
			foreach (var item in array) {
				if(y != 0){
					i = i + ", " + item;
				}
				y++;
			}
			NS.PlayerPrefs.SetString(key, i);
		}

		public static int[] GetIntArray(string key){
			string[] t = NS.PlayerPrefs.GetString(key).Split(", "[0]);
			int[] array = new int[t.Length];
			for (int i = 0; i < array.Length; i++) {
				string y = t[i];
				array[i] = int.Parse(y);
			}
			return array;
		}

		public static void SetFloatArray(string key, float[] array){
			string i = array[0].ToString();
			int y = 0;
			foreach (var item in array) {
				if(y != 0){
					i = i + ", " + item;
				}
				y++;
			}
			NS.PlayerPrefs.SetString(key, i);
		}

		public static float[] GetFloatArray(string key){
			string[] t = NS.PlayerPrefs.GetString(key).Split(", "[0]);
			float[] array = new float[t.Length];
			for (int i = 0; i < array.Length; i++) {
				string y = t[i];
				array[i] = float.Parse(y);
			}
			return array;
		}

		public static void SetBoolArray(string key, bool[] array){
			int[] u = new int[array.Length];
			for (int t = 0; t < array.Length; t++) {
				if(array[t] == false){
					u[t] = 0;
				}else if(array[t] == true){
					u[t] = 1;
				}
			}
			string i = u[0].ToString();
			int y = 0;
			foreach (var item in u) {
				if(y != 0){
					i = i + ", " + item;
				}
				y++;
			}
			NS.PlayerPrefs.SetString(key, i);
		}

		public static bool[] GetBoolArray(string key){
			string[] t = NS.PlayerPrefs.GetString(key).Split(", "[0]);
			int[] u = new int[t.Length];
			for (int i = 0; i < u.Length; i++) {
				string y = t[i];
				u[i] = int.Parse(y);
			}
			bool[] array = new bool[t.Length];
			for (int o = 0; o < u.Length; o++) {
				if(u[o] == 0){
					array[o] = false;
				}else if(u[o] == 1){
					array[o] = true;
				}
			}
			return array;
		}
	}
}