using Godot;
using System;

public  class CLib
{
	  /// <summary>
    /// a simplified script raycast - should only be used in PhysicsUpdate for Godot reasons.
    /// </summary>
    /// <returns></returns>
	public static Godot.Collections.Dictionary EasyRaycast3D(Node3D caster, Vector3 origin, Vector3 direction, float length)
	{

		Vector3 target = direction * length;

		var spaceState = caster.GetWorld3D().DirectSpaceState; 

		var query = PhysicsRayQueryParameters3D.Create(origin, target);
    	return spaceState.IntersectRay(query);
	}

	/// <summary>
    /// basic sorter
    /// </summary>
    /// <returns></returns>
    public static int BubbleSort(int a, int b) 
    {
        if (a < b)
        {
            return 1;
        }
        else if (a > b)
        {
            return -1;
        }
        return 0;
    }

    /// <summary>
    /// basic sorter
    /// </summary>
    /// <returns></returns>
    public static int BubbleSort(float a, float b)
    {
        if (a < b)
        {
            return 1;
        }
        else if (a > b)
        {
            return -1;
        }
        return 0;
    }
    
    public static int Negate (int number)
    {
         return -1 * number;
    }
    
    public static float Negate (float number)
    {
         return -1 * number;
    }
}
