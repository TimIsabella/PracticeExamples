﻿using System;
using System.Collections.Generic;

namespace PracticeExamples
{
	public class PropertiesExamples
	{
		public static void PropertiesExerciseMain()
		{
			Console.WriteLine("\n *********** PROPERTIES EXAMPLES *********** \n");

			var person = new Person();
			person.PrivateNameProperty = "Private Name Property";
			person.UnsetAccessNameProperty = "Unset Access Name";
			person.PublicName = "Public Name";
			person.InternalName = "Internal Name";

			Console.WriteLine(person.GetNames()[2]);
			Console.WriteLine(person.CurrentTime);
			person.ListInts = new List<int> { 1, 2, 3 };
			Console.WriteLine(person.ListInts[0]);
			Console.WriteLine(person.LoopOfInts[1]);
		}

		public class Person
		{
			private string _privateName;
			string UnsetAccessName;

			//Fields and properties are separated

			public string PrivateNameProperty
			{
				get { return _privateName; }
				set { _privateName = value; }
			}

			public string UnsetAccessNameProperty
			{
				get { return UnsetAccessName; }
				set { UnsetAccessName = value; }
			}

			//Fields with auto-implemented properties
			//Properties can be auto-implimented only while fields are accessable (public and internal)
			public string PublicName { get; set; }
			internal string InternalName { get; set; }

			//Returns current time and cannot be set
			public DateTime CurrentTime
			{
				get { return DateTime.Now; }
			}

			//List of ints property
			public List<int> ListInts { get; set; }

			//List of ints property with getter logic
			public List<int> LoopOfInts
			{
				get
				{
					var returnListInts = new List<int>();

					for(int i = 0; i < ListInts.Count; i++)
					{
						returnListInts.Add(ListInts[i] + 11);
					}
					
					return returnListInts;
				}
			}

			/////////////////////////////////
			public string[] GetNames()
			{
				var returnString = new string[] { PublicName, InternalName, _privateName, UnsetAccessName };
				return returnString;
			}
		}
	}
}
