using System;
using System.Collections.Generic;
using System.Text;

namespace LearningExercises.Dictionary
{
	public class DictionaryExercise
	{
		public int FindItemByKey(string key, Dictionary<string, int> dictionary)
		{
			throw new NotImplementedException();
		}

		public int SumValues(Dictionary<string, int> dictionary)
		{
			throw new NotImplementedException();
		}

		public class KeyValue
		{
			public string Key { get; set; }
			public int Value { get; set; }
			public override bool Equals(object obj)
			{
				return Key == (obj as KeyValue).Key && Value == (obj as KeyValue).Value;
			}
			public override int GetHashCode()
			{
				return base.GetHashCode();
			}
		}

		/// <summary>
		/// Hint: Map the items from the dictionary into a list of KeyValue objects. Try to use the Linq equivelant of an array "Map" function 
		/// </summary>
		public List<KeyValue> GetKeyValuePairs(Dictionary<string, int> dictionary)
		{
			throw new NotImplementedException();
		}
	}
}
