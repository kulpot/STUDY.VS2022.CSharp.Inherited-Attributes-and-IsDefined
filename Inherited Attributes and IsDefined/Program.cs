using System;

//ref link:https://www.youtube.com/watch?v=P-7HJ838qG4&list=PLRwVmtr-pp05brRDYXh-OTAIi-9kYcw3r&index=10
//
/*  Extension Method
 *  
 *  public static void P(this IEnumerable<object> arr)
		{
			foreach (var o in arr)
			{
				Console.WriteLine(o.ToString());
			}
		}
 */

[AttributeUsage(AttributeTargets.All, Inherited = false)]
class MeAttribute : Attribute 
{ 
	public MeAttribute() 
	{
        Console.WriteLine("MeAttribute()");
    }
}

[Me]
class Base { }
//[Me]
class Derived : Base { }

class MainClass
{
    static void Main()
    {
		//typeof(Derived).GetCustomAttributes(true).P(); //(true) will get only once the inherit custom attribute// P method (P short for PRINT) will iterate the array custom attribute
		//typeof(Derived).IsDefined(typeof(MeAttribute), true).P();
	}
}