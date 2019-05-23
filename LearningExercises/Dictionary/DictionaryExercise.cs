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

		public List<KeyValue> GetKeyValuePairs(Dictionary<string, int> dictionary)
		{
			throw new NotImplementedException();
		}
	}
}
