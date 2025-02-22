﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeExamples
{
	public class SealedModifierExample
	{
		public static void SealedModifierExampleMain()
		{
			Console.WriteLine("\n *********** SEALED MODIFIER EXAMPLES *********** \n");
			///'sealed' members provide a slight performance optimization

			var shapes = new List<ShapeObjects.BaseShape>(); //List of 'Shape' as objects below all inherit from 'Shape'
			shapes.Add(new ShapeObjects.Circle());
			shapes.Add(new ShapeObjects.Square());
			shapes.Add(new ShapeObjects.Triangle());

			foreach(var shape in shapes)
			{
				shape.Draw();
			}
		}

		//All Shapes
		public class ShapeObjects
		{
			//The class must be declared as 'abstract' if it impliments abstract members
			//'abstract' classes CANNOT be instantiated
			public abstract class BaseShape
			{
				//Fields do not have to be marked abstract
				public int Width;
				public int Height;

				//'abstract' designation allows derived objects to replace this default method when inherited
				//Derived objects MUST impliment members marked as 'abstract'
				//All members (except fields) must be marked 'abstract' when declaring 'abstract'
				public abstract void Draw();
				public abstract void OtherMethod();

			}

			//'sealed' classes cannot be inherited
			public sealed class Circle : BaseShape
			{
				public int Radius;

				//'sealed' members can only apply to 'override' cases
				public sealed override void Draw()  //Replacement of inherited method by using 'override'
				{ Console.WriteLine("Circle: This abstract 'Draw' method has been overridden."); }

				public override void OtherMethod()
				{ }
			}

			public class Square : BaseShape
			{
				public int Diameter;

				public override void Draw()  //Replacement of inherited method by using 'override'
				{ Console.WriteLine("Square: This abstract 'Draw' method has been overridden."); }

				public override void OtherMethod()
				{ }
			}

			public class Triangle : BaseShape
			{
				public int Tangent;

				public override void Draw()  //Replacement of inherited method by using 'override'
				{ Console.WriteLine("Triangle: This abstract 'Draw' method has been overridden."); }

				public override void OtherMethod()
				{ }
			}
		}
	}
}
