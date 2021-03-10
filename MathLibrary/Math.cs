﻿using System;

namespace MathLibrary
{
	public struct Vector2
	{
		public float x;
		public float y;

		public Vector2(float x = 0f, float y = 0f)
		{
			this.x = x;
			this.y = y;
		}
		//Operator overloading

		// V = V + V (point translated by a vector)
		public static Vector2 operator +(Vector2 lhs, Vector2 rhs)
		{
			Vector2 result;
			result.x = lhs.x + rhs.x;
			result.y = lhs.y + rhs.y;

			return result;
		}

		// V = V –V (point translated by a vector)
		public static Vector2 operator -(Vector2 lhs, Vector2 rhs)
		{
			Vector2 result;
			result.x = lhs.x - rhs.x;
			result.y = lhs.y - rhs.y;

			return result;
		}
		// V = V x f(vector scale)
		public static Vector2 operator *(Vector2 lhs, float rhs)
		{
			Vector2 result;
			result.x = lhs.x * rhs;
			result.y = lhs.y * rhs;
			return result;
		}
		// V = f x V (vector scale)
		public static Vector2 operator *(float lhs, Vector2 rhs)
		{
			Vector2 result;
			result.x = lhs * rhs.x;
			result.y = lhs * rhs.y;
			return result;
		}
		// f = V.Magnitude()
		public float Magnitude()
		{
			return (float)Math.Sqrt((x * x) + (y * y));
		}
		// V.Normalise()
		public float Normalise()
		{
			float magnitude = Magnitude();
			if (magnitude != 0)
			{
				x /= magnitude;
				y /= magnitude;
				return magnitude;
			}
			return magnitude;
		}
		// f = V.Dot(V )
		public float Dot(Vector2 rhs)
		{
			return ((x * rhs.x) + (y * rhs.y));
		}

		//public Vector2 GetRightAngle()
		//{
		//	Vector2 result;
		//	result.x = -y;
		//	result.y = x;
		//	return result;
		//}
		//public static float GetAngleBetween(Vector2 lhs, Vector2 rhs)
		//{
		//	lhs.Normalise();
		//	rhs.Normalise();
		//	float fDot = lhs.Dot(rhs);

		//	//get angle
		//	float angle = (float)Math.Acos(fDot);

		//	//check if angle is clockwise or anticlockwise
		//	Vector2 rightAngle = lhs.GetRightAngle();
		//	float fRightDot = rhs.Dot(rightAngle);
		//	if (fRightDot < 0)
		//		angle = angle * -1.0f;

		//		return angle;


		//}
	}
	public struct Vector3
	{
		public float x;
		public float y;
		public float z;

		public Vector3(float x = 0f, float y = 0f, float z = 0f)
		{
			this.x = x;
			this.y = y;
			this.z = z;
		}
		//Operator overloading

		// V = V + V (point translated by a vector)
		public static Vector3 operator +(Vector3 lhs, Vector3 rhs)
		{
			Vector3 result;
			result.x = lhs.x + rhs.x;
			result.y = lhs.y + rhs.y;
			result.z = lhs.z + rhs.z;

			return result;
		}

		// V = V –V (point translated by a vector)
		public static Vector3 operator -(Vector3 lhs, Vector3 rhs)
		{
			Vector3 result;
			result.x = lhs.x - rhs.x;
			result.y = lhs.y - rhs.y;
			result.z = lhs.z - rhs.z;
			return result;
		}
		// V = V x f(vector scale)
		public static Vector3 operator *(Vector3 lhs, float rhs)
		{
			Vector3 result;
			result.x = lhs.x * rhs;
			result.y = lhs.y * rhs;
			result.z = lhs.z * rhs;
			return result;
		}
		// V = f x V (vector scale)
		public static Vector3 operator *(float lhs, Vector3 rhs)
		{
			Vector3 result;
			result.x = lhs * rhs.x;
			result.y = lhs * rhs.y;
			result.z = lhs * rhs.z;
			return result;
		}
		// f = V.Magnitude()
		public float Magnitude()
		{
			return (float)Math.Sqrt((x * x) + (y * y) + (z * z));
		}
		// V.Normalise()
		public float Normalise()
		{
			float magnitude = Magnitude();
			if (magnitude != 0)
			{
				x /= magnitude;
				y /= magnitude;
				z /= magnitude;
				return magnitude;
			}
			return magnitude;
		}
		// f = V.Dot(V )
		public float Dot(Vector3 rhs)
		{
			return ((x * rhs.x) + (y * rhs.y) + (z * rhs.z));
		}
		// V = V.Cross(V )
		public Vector3 Cross(Vector3 rhs)
		{
			Vector3 result;
			result.x = (y * rhs.z) - (z * rhs.y);
			result.y = (z * rhs.x) - (x * rhs.z);
			result.z = (x * rhs.y) - (y * rhs.x);
			return result;
		}

	}
	public struct Vector4
	{
		public float x;
		public float y;
		public float z;
		public float w;

		public Vector4(float x = 0f, float y = 0f, float z = 0f, float w = 0f)
		{
			this.x = x;
			this.y = y;
			this.z = z;
			this.w = w;
		}
		//Operator overloading

		// V = V + V (point translated by a vector)
		public static Vector4 operator +(Vector4 lhs, Vector4 rhs)
		{
			Vector4 result;
			result.x = lhs.x + rhs.x;
			result.y = lhs.y + rhs.y;
			result.z = lhs.z + rhs.z;
			result.w = lhs.w + rhs.w;
			return result;
		}

		// V = V –V (point translated by a vector)
		public static Vector4 operator -(Vector4 lhs, Vector4 rhs)
		{
			Vector4 result;
			result.x = lhs.x - rhs.x;
			result.y = lhs.y - rhs.y;
			result.z = lhs.z - rhs.z;
			result.w = lhs.w - rhs.w;
			return result;
		}
		// V = V x f(vector scale)
		public static Vector4 operator *(Vector4 lhs, float rhs)
		{
			Vector4 result;
			result.x = lhs.x * rhs;
			result.y = lhs.y * rhs;
			result.z = lhs.z * rhs;
			result.w = lhs.w * rhs;
			return result;
		}
		// V = f x V (vector scale)
		public static Vector4 operator *(float lhs, Vector4 rhs)
		{
			Vector4 result;
			result.x = lhs * rhs.x;
			result.y = lhs * rhs.y;
			result.z = lhs * rhs.z;
			result.w = lhs * rhs.w;
			return result;
		}
		// f = V.Magnitude()
		public float Magnitude()
		{
			return (float)Math.Sqrt((x * x) + (y * y) + (z * z) + (w * w));
		}
		// V.Normalise()
		public float Normalise()
		{
			float magnitude = Magnitude();
			if (magnitude != 0)
			{
				x /= magnitude;
				y /= magnitude;
				z /= magnitude;
				w /= magnitude;
				return magnitude;
			}
			return magnitude;

		}
		// V = V.Cross(V )
		public Vector4 Cross(Vector4 rhs)
		{
			Vector4 result;
			result.x = (y * rhs.z) - (z * rhs.y);
			result.y = (z * rhs.x) - (x * rhs.z);
			result.z = (x * rhs.y) - (y * rhs.x);
			result.w = 0;
			return result;
		}
	}
}
