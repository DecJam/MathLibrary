using System;

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

		// V = V + V	(point translated by a vector)
		public static Vector2 operator +(Vector2 lhs, Vector2 rhs)
		{
			Vector2 result;
			result.x = lhs.x + rhs.x;
			result.y = lhs.y + rhs.y;

			return result;
		}

		// V = V –V		(point translated by a vector)
		public static Vector2 operator -(Vector2 lhs, Vector2 rhs)
		{
			Vector2 result;
			result.x = lhs.x - rhs.x;
			result.y = lhs.y - rhs.y;

			return result;
		}
		// V = V x f	(vector scale)
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
		// V = V.Cross(V)
		public Vector4 Cross(Vector4 rhs)
		{
			Vector4 result;
			result.x = (y * rhs.z) - (z * rhs.y);
			result.y = (z * rhs.x) - (x * rhs.z);
			result.z = (x * rhs.y) - (y * rhs.x);
			result.w = 0;
			return result;
		}
		// f = V.Dot(V )
		public float Dot(Vector4 rhs)
		{
			return ((x * rhs.x) + (y * rhs.y) + (z * rhs.z) + (w * rhs.w));
		}
	}
	public class Matrix3
    {

		public float m1 = 0, m2 = 0, m3 = 0, m4 = 0, m5 = 0, m6 = 0, m7 = 0, m8 = 0, m9 = 0;

		public Matrix3(float m1, float m2, float m3, float m4, float m5, float m6, float m7, float m8, float m9)
		{
			this.m1 = m1; this.m2 = m2; this.m3 = m3;		
			this.m4 = m4; this.m5 = m5; this.m6 = m6;		
			this.m7 = m7; this.m8 = m8; this.m9 = m9;       
		}
		public readonly static Matrix3 identity = new Matrix3(1, 0, 0, 0, 1, 0, 0, 0, 1);

		//M = M x M		(matrix concatenation)
		public static Matrix3 operator *(Matrix3 lhs, Matrix3 rhs)
		{
			return new Matrix3
			(
				//Row major matrix multiplication
				//lhs.m1 * rhs.m1 + lhs.m2 * rhs.m4 + lhs.m3 * rhs.m7, lhs.m1 * rhs.m2 + lhs.m2 * rhs.m5 + lhs.m3 * rhs.m8, lhs.m1 * rhs.m3 + lhs.m2 * rhs.m6 + lhs.m3 * rhs.m9,
				//lhs.m4 * rhs.m1 + lhs.m5 * rhs.m4 + lhs.m6 * rhs.m7, lhs.m4 * rhs.m2 + lhs.m5 * rhs.m5 + lhs.m6 * rhs.m8, lhs.m4 * rhs.m3 + lhs.m5 * rhs.m6 + lhs.m6 * rhs.m9,
				//lhs.m7 * rhs.m1 + lhs.m8 * rhs.m4 + lhs.m9 * rhs.m7, lhs.m7 * rhs.m2 + lhs.m8 * rhs.m5 + lhs.m9 * rhs.m8, lhs.m7 * rhs.m3 + lhs.m8 * rhs.m6 + lhs.m9 * rhs.m9

				//Collumn major matrix multiplication
				lhs.m1 * rhs.m1 + lhs.m4 * rhs.m2 + lhs.m7 * rhs.m3, lhs.m1 * rhs.m4 + lhs.m4 * rhs.m5 + lhs.m7 * rhs.m6, lhs.m1 * rhs.m7 + lhs.m4 * rhs.m8 + lhs.m7 * rhs.m9,
				lhs.m2 * rhs.m1 + lhs.m5 * rhs.m2 + lhs.m8 * rhs.m3, lhs.m2 * rhs.m4 + lhs.m5 * rhs.m5 + lhs.m8 * rhs.m6, lhs.m2 * rhs.m7 + lhs.m5 * rhs.m8 + lhs.m8 * rhs.m9,
				lhs.m3 * rhs.m1 + lhs.m6 * rhs.m2 + lhs.m9 * rhs.m3, lhs.m3 * rhs.m4 + lhs.m6 * rhs.m5 + lhs.m9 * rhs.m6, lhs.m3 * rhs.m7 + lhs.m6 * rhs.m8 + lhs.m9 * rhs.m9
			);
		}
		public static Vector3 operator *(Matrix3 lhs, Vector3 rhs)
		{
			Vector3 result;
			result.x = lhs.m1 * rhs.x + lhs.m4 * rhs.x + lhs.m7 * rhs.x;
			result.y = lhs.m2 * rhs.y + lhs.m5 * rhs.y + lhs.m8 * rhs.y;
			result.z = lhs.m3 * rhs.z + lhs.m6 * rhs.z + lhs.m9 * rhs.z;
			return result;
		}


		//M.setRotateX(f)
		public void SetRotateX(float fRadians)
		{	
			m5 = (float)Math.Cos(fRadians);
			m6 = (float)-Math.Sin(fRadians);
			m8 = (float)Math.Sin(fRadians);
			m9 = (float)Math.Cos(fRadians);		
		}

		//M.setRotateY(f)
		public void SetRotateY(float fRadians)
		{
			m1 = (float)Math.Cos(fRadians);
			m3 = (float)Math.Sin(fRadians);
			m7 = (float)-Math.Sin(fRadians);
			m9 = (float)Math.Cos(fRadians);
		}

		//M.setRotateZ(f)
		public void SetRotateZ(float fRadians)
		{
			m1 = (float)Math.Cos(fRadians);
			m2 = (float)-Math.Sin(fRadians);
			m4 = (float)Math.Sin(fRadians);
			m5 = (float)Math.Cos(fRadians);
		}

		public void SetTranslation(float x, float y)
		{
			m7 = x;
			m8 = y;
		}

		public void SetTranslation(Vector2 pos)
		{
			m7 = pos.x;
			m8 = pos.y;
		}

		public void SetScale(float x, float y)
		{
			m1 = x;
			m5 = y;
		}

		public void SetScale(Vector2 scale)
		{
			m1 = scale.x;
			m5 = scale.y;
		}

	}
	public class Matrix4
	{

		public float m1 = 0, m2 = 0, m3 = 0, m4 = 0, m5 = 0, m6 = 0, m7 = 0, m8 = 0, m9 = 0, m10 = 0, m11 = 0, m12 = 0, m13 = 0, m14 = 0, m15 = 0, m16 = 0;

		public Matrix4(float m1, float m2, float m3, float m4, float m5, float m6, float m7, float m8, float m9, float m10, float m11, float m12, float m13, float m14, float m15, float m16)
		{
			this.m1 = m1; this.m2 = m2; this.m3 = m3; this.m4 = m4;         
			this.m5 = m5; this.m6 = m6; this.m7 = m7; this.m8 = m8;         
			this.m9 = m9; this.m10 = m10; this.m11 = m11; this.m12 = m12;   
			this.m13 = m13; this.m14 = m14; this.m15 = m15; this.m16 = m16; 
		}
		public readonly static Matrix4 identity = new Matrix4(1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1);

		//M = M x M		(matrix concatenation)
		public static Matrix4 operator *(Matrix4 lhs, Matrix4 rhs)
		{
			return new Matrix4
			(
				//Row major matrix multiplication
				//lhs.m1 * rhs.m1 + lhs.m2 * rhs.m5 + lhs.m3 * rhs.m9 + lhs.m4 * rhs.m13, lhs.m1 * rhs.m2 + lhs.m2 * rhs.m6 + lhs.m3 * rhs.m10 + lhs.m4 * rhs.m14, lhs.m1 * rhs.m3 + lhs.m2 * rhs.m7 + lhs.m3 * rhs.m11 + lhs.m4 * rhs.m15, lhs.m1 * rhs.m4 + lhs.m2 * rhs.m8 + lhs.m3 * rhs.m12 + lhs.m4 * rhs.m16,
				//lhs.m5 * rhs.m1 + lhs.m6 * rhs.m5 + lhs.m7 * rhs.m9 + lhs.m8 * rhs.m13, lhs.m5 * rhs.m2 + lhs.m6 * rhs.m6 + lhs.m7 * rhs.m10 + lhs.m8 * rhs.m14, lhs.m5 * rhs.m3 + lhs.m6 * rhs.m7 + lhs.m7 * rhs.m11 + lhs.m8 * rhs.m15, lhs.m5 * rhs.m4 + lhs.m6 * rhs.m8 + lhs.m7 * rhs.m12 + lhs.m8 * rhs.m16,
				//lhs.m9 * rhs.m1 + lhs.m10 * rhs.m5 + lhs.m11 * rhs.m9 + lhs.m12 * rhs.m13, lhs.m9 * rhs.m2 + lhs.m10 * rhs.m6 + lhs.m11 * rhs.m10 + lhs.m12 * rhs.m14, lhs.m9 * rhs.m3 + lhs.m10 * rhs.m7 + lhs.m11 * rhs.m11 + lhs.m12 * rhs.m15, lhs.m9 * rhs.m4 + lhs.m10 * rhs.m8 + lhs.m11 * rhs.m12 + lhs.m12 * rhs.m16,
				//lhs.m13 * rhs.m1 + lhs.m14 * rhs.m5 + lhs.m15 * rhs.m9 + lhs.m16 * rhs.m13, lhs.m13 * rhs.m2 + lhs.m14 * rhs.m6 + lhs.m15 * rhs.m10 + lhs.m16 * rhs.m14, lhs.m13 * rhs.m3 + lhs.m14 * rhs.m7 + lhs.m15 * rhs.m11 + lhs.m16 * rhs.m15, lhs.m13 * rhs.m4 + lhs.m14 * rhs.m8 + lhs.m15 * rhs.m12 + lhs.m16 * rhs.m16

				//Collumn major matrix multiplication
				lhs.m1 * rhs.m1 + lhs.m5 * rhs.m2 + lhs.m9 * rhs.m3 + lhs.m13 * rhs.m4, lhs.m1 * rhs.m5 + lhs.m5 * rhs.m6 + lhs.m9 * rhs.m7 + lhs.m13 * rhs.m8, lhs.m1 * rhs.m9 + lhs.m5 * rhs.m10 + lhs.m9 * rhs.m11 + lhs.m13 * rhs.m12, lhs.m1 * rhs.m13 + lhs.m5 * rhs.m14 + lhs.m9 * rhs.m15 + lhs.m13 * rhs.m16,
				lhs.m2 * rhs.m1 + lhs.m6 * rhs.m2 + lhs.m10 * rhs.m3 + lhs.m14 * rhs.m4, lhs.m2 * rhs.m5 + lhs.m6 * rhs.m6 + lhs.m10 * rhs.m7 + lhs.m14 * rhs.m8, lhs.m2 * rhs.m9 + lhs.m6 * rhs.m10 + lhs.m10 * rhs.m11 + lhs.m14 * rhs.m12, lhs.m2 * rhs.m13 + lhs.m6 * rhs.m14 + lhs.m10 * rhs.m15 + lhs.m14 * rhs.m16,
				lhs.m3 * rhs.m1 + lhs.m7 * rhs.m2 + lhs.m11 * rhs.m3 + lhs.m15 * rhs.m4, lhs.m3 * rhs.m5 + lhs.m7 * rhs.m6 + lhs.m11 * rhs.m7 + lhs.m15 * rhs.m8, lhs.m3 * rhs.m9 + lhs.m7 * rhs.m10 + lhs.m11 * rhs.m11 + lhs.m15 * rhs.m12, lhs.m3 * rhs.m13 + lhs.m7 * rhs.m14 + lhs.m11 * rhs.m15 + lhs.m15 * rhs.m16,
				lhs.m4 * rhs.m1 + lhs.m8 * rhs.m2 + lhs.m12 * rhs.m3 + lhs.m16 * rhs.m4, lhs.m4 * rhs.m5 + lhs.m8 * rhs.m6 + lhs.m12 * rhs.m7 + lhs.m16 * rhs.m8, lhs.m4 * rhs.m9 + lhs.m8 * rhs.m10 + lhs.m12 * rhs.m11 + lhs.m16 * rhs.m12, lhs.m4 * rhs.m13 + lhs.m8 * rhs.m14 + lhs.m12 * rhs.m15 + lhs.m16 * rhs.m16
			);
		}

		public static Vector4 operator *(Matrix4 lhs, Vector4 rhs)
		{
			Vector4 result;
			result.x = lhs.m1 * rhs.x + lhs.m5 * rhs.x + lhs.m9 * rhs.x + lhs.m13 * rhs.x;
			result.y = lhs.m2 * rhs.y + lhs.m6 * rhs.y + lhs.m10 * rhs.y + lhs.m14 * rhs.y;
			result.z = lhs.m3 * rhs.z + lhs.m7 * rhs.z + lhs.m11 * rhs.z + lhs.m15 * rhs.z;
			result.w = lhs.m4 * rhs.w + lhs.m8 * rhs.w + lhs.m12 * rhs.w + lhs.m16 * rhs.w;
			return result;
		}

		//M.setRotateX(f)
		public static Matrix4 SetRotateX(Matrix4 current, float fRadians)
		{
			current.m6 = (float)Math.Cos(fRadians);
			current.m7 = (float)-Math.Sin(fRadians);
			current.m10 = (float)Math.Sin(fRadians);
			current.m11 = (float)Math.Cos(fRadians);
			return current;
		}

		//M.setRotateY(f)
		public static Matrix4 SetRotateY(Matrix4 current, float fRadians)
		{
			current.m1 = (float)Math.Cos(fRadians);
			current.m3 = (float)Math.Sin(fRadians);
			current.m9 = (float)-Math.Sin(fRadians);
			current.m11 = (float)Math.Cos(fRadians);
			return current;
		}

		//M.setRotateZ(f)
		public static Matrix4 SetRotateZ(Matrix4 current, float fRadians)
		{
			current.m1 = (float)Math.Cos(fRadians);
			current.m2 = (float)-Math.Sin(fRadians);
			current.m5 = (float)Math.Sin(fRadians);
			current.m6 = (float)Math.Cos(fRadians);
			return current;
		}

		public void SetTranslation(float x, float y, float z)
		{
			m13 = x;
			m14 = y;
			m15 = z;
		}

		public void SetTranslation(Vector3 pos)
		{
			m13 = pos.x;
			m14 = pos.y;
			m15 = pos.z;
		}

		public void SetScale(float x, float y, float z)
		{
			m1 = x;
			m6 = y;
			m11 = z;

		}

		public void SetScale(Vector3 scale)
		{
			m1 = scale.x;
			m6 = scale.y;
			m11 = scale.z;
		}
	}

	public class Colour
	{
		public UInt32 colour;

		public Colour()
		{
			colour = 0;
		}

		public Colour(byte red, byte green, byte blue, byte alpha)
		{ }

		public void SetRed(byte red)
		{
			colour = colour & 0x00ffffff;
			colour |= colour & (UInt32)(red << 24);
		}
		public uint GetRed(byte red)
		{
			return red;
		}

		public void SetGreen(byte green)
		{
			colour = colour & 0xff00ffff;
			colour |= colour & (UInt32)(green << 16);
		}
		public uint GetGreen(byte green)
		{
			return green;
		}
		public void SetBlue(byte blue)
		{
			colour = colour & 0xffff00ff;
			colour |= colour & (UInt32)(blue << 8);
		}
		public uint GetBlue(byte blue)
		{
			return blue;
		}
		public void SetAlpha(byte alpha)
		{
			colour = colour & 0xffffff00;
			colour |= colour & (UInt32)(alpha << 0);
		}
		public uint GetAlpha(byte alpha)
		{
			return alpha;
		}
		public void SetColour(byte red, byte green, byte blue, byte alpha)
        {


			colour = (UInt32)(red << 24);
			colour += (UInt32)(green << 16);
			colour += (UInt32)(blue << 8);
			colour += (UInt32)(alpha << 0);
        }
		
		public UInt32 GetColour()
        {
			return colour;
        }
	}
}
