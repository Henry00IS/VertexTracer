﻿using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;

namespace AlpacaIT.DynamicLighting
{
    /// <summary>
    /// Internal math library with advanced general-purpose computations that use unsafe operations
    /// to speed up equations significantly and provides in-place modification of the original structs.
    /// <para>These functions have all been benchmarked in the Unity Editor environment.</para>
    /// <para>There are no copy&amp;paste variations for all possible types, only proven fast functions.</para>
    /// </summary>
    internal static unsafe class UMath
    {
        /// <summary>Applies the componentwise absolute value of a float3 vector.</summary>
        /// <param name="value">Input value.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Abs(float3* value)
        {
            *(uint*)&value->x &= 0x7FFFFFFFu;
            *(uint*)&value->y &= 0x7FFFFFFFu;
            *(uint*)&value->z &= 0x7FFFFFFFu;
        }

        /// <summary>Applies the componentwise absolute value of a Vector3 vector.</summary>
        /// <param name="value">Input value.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Abs(Vector3* value)
        {
            *(uint*)&value->x &= 0x7FFFFFFFu;
            *(uint*)&value->y &= 0x7FFFFFFFu;
            *(uint*)&value->z &= 0x7FFFFFFFu;
        }

        /// <summary>Applies the result of a componentwise multiplication operation on a float2 vector and a float value.</summary>
        /// <param name="lhs">Left hand side float2 to use to compute componentwise multiplication.</param>
        /// <param name="rhs">Right hand side float to use to compute componentwise multiplication.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Scale(float2* lhs, float rhs)
        {
            lhs->x *= rhs;
            lhs->y *= rhs;
        }

        /// <summary>Applies the result of a componentwise multiplication operation on a Vector2 vector and a float value.</summary>
        /// <param name="lhs">Left hand side Vector2 to use to compute componentwise multiplication.</param>
        /// <param name="rhs">Right hand side float to use to compute componentwise multiplication.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Scale(Vector2* lhs, float rhs)
        {
            lhs->x *= rhs;
            lhs->y *= rhs;
        }

        /// <summary>Applies the result of a componentwise multiplication operation on a float3 vector and a float value.</summary>
        /// <param name="lhs">Left hand side float3 to use to compute componentwise multiplication.</param>
        /// <param name="rhs">Right hand side float to use to compute componentwise multiplication.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Scale(float3* lhs, float rhs)
        {
            lhs->x *= rhs;
            lhs->y *= rhs;
            lhs->z *= rhs;
        }

        /// <summary>Applies the result of a componentwise multiplication operation on a Vector3 vector and a float value.</summary>
        /// <param name="lhs">Left hand side Vector3 to use to compute componentwise multiplication.</param>
        /// <param name="rhs">Right hand side float to use to compute componentwise multiplication.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Scale(Vector3* lhs, float rhs)
        {
            lhs->x *= rhs;
            lhs->y *= rhs;
            lhs->z *= rhs;
        }

        /// <summary>Applies the result of a componentwise multiplication operation on two Vector3 vectors.</summary>
        /// <param name="lhs">Left hand side Vector3 to use to compute componentwise multiplication.</param>
        /// <param name="rhs">Right hand side Vector3 to use to compute componentwise multiplication.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Scale(Vector3* lhs, Vector3* rhs)
        {
            lhs->x *= rhs->x;
            lhs->y *= rhs->y;
            lhs->z *= rhs->z;
        }

        /// <summary>Applies the result of a componentwise addition operation on a float2 vector and a float value.</summary>
        /// <param name="lhs">Left hand side float2 to use to compute componentwise addition.</param>
        /// <param name="rhs">Right hand side float to use to compute componentwise addition.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Add(float2* lhs, float rhs)
        {
            lhs->x += rhs;
            lhs->y += rhs;
        }

        /// <summary>Applies the result of a componentwise addition operation on a Vector2 vector and a float value.</summary>
        /// <param name="lhs">Left hand side Vector2 to use to compute componentwise addition.</param>
        /// <param name="rhs">Right hand side float to use to compute componentwise addition.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Add(Vector2* lhs, float rhs)
        {
            lhs->x += rhs;
            lhs->y += rhs;
        }

        /// <summary>Applies the result of a componentwise addition operation on two float3 vectors.</summary>
        /// <param name="lhs">Left hand side float3 to use to compute componentwise addition.</param>
        /// <param name="rhs">Right hand side float3 to use to compute componentwise addition.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Add(float3* lhs, float3* rhs)
        {
            lhs->x += rhs->x;
            lhs->y += rhs->y;
            lhs->z += rhs->z;
        }

        /// <summary>Applies the result of a componentwise addition operation on two Vector3 vectors.</summary>
        /// <param name="lhs">Left hand side Vector3 to use to compute componentwise addition.</param>
        /// <param name="rhs">Right hand side Vector3 to use to compute componentwise addition.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Add(Vector3* lhs, Vector3* rhs)
        {
            lhs->x += rhs->x;
            lhs->y += rhs->y;
            lhs->z += rhs->z;
        }

        /// <summary>Applies the result of a componentwise addition operation on a Vector3 vector and a float value.</summary>
        /// <param name="lhs">Left hand side Vector3 to use to compute componentwise addition.</param>
        /// <param name="rhs">Right hand side float to use to compute componentwise addition.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Add(Vector3* lhs, float rhs)
        {
            lhs->x += rhs;
            lhs->y += rhs;
            lhs->z += rhs;
        }

        /// <summary>Applies the result of a componentwise multiplication operation on a float value and adding a float value.</summary>
        /// <param name="lhs">Left hand side Vector3 to use to compute componentwise multiplication.</param>
        /// <param name="mul">Right hand side float to use to compute componentwise multiplication.</param>
        /// <param name="add">Right hand side float to use to compute componentwise addition.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Mad(Vector3* lhs, float mul, float add)
        {
            lhs->x = lhs->x * mul + add;
            lhs->y = lhs->y * mul + add;
            lhs->z = lhs->z * mul + add;
        }

        /// <summary>Applies the result of a componentwise multiplication operation on a Vector3 vector and adding a float value.</summary>
        /// <param name="lhs">Left hand side Vector3 to use to compute componentwise multiplication.</param>
        /// <param name="mul">Right hand side Vector3 to use to compute componentwise multiplication.</param>
        /// <param name="add">Right hand side float to use to compute componentwise addition.</param>
        public static void Mad(Vector3* lhs, Vector3* mul, float add)
        {
            lhs->x = lhs->x * mul->x + add;
            lhs->y = lhs->y * mul->y + add;
            lhs->z = lhs->z * mul->z + add;
        }

        /// <summary>Applies the result of a componentwise unary minus operation on a float3 vector.</summary>
        /// <param name="val">Value to use when computing the componentwise unary minus.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Negate(float3* val)
        {
            val->x = -val->x;
            val->y = -val->y;
            val->z = -val->z;
        }

        /// <summary>Applies the result of a componentwise unary minus operation on a Vector3 vector.</summary>
        /// <param name="val">Value to use when computing the componentwise unary minus.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Negate(Vector3* val)
        {
            val->x = -val->x;
            val->y = -val->y;
            val->z = -val->z;
        }

        /// <summary>Applies the result of a componentwise subtraction operation on two float3 vectors.</summary>
        /// <param name="lhs">Left hand side float3 to use to compute componentwise subtraction.</param>
        /// <param name="rhs">Right hand side float3 to use to compute componentwise subtraction.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Subtract(float3* lhs, float3* rhs)
        {
            lhs->x -= rhs->x;
            lhs->y -= rhs->y;
            lhs->z -= rhs->z;
        }

        /// <summary>Applies the result of a componentwise subtraction operation on two Vector3 vectors.</summary>
        /// <param name="lhs">Left hand side Vector3 to use to compute componentwise subtraction.</param>
        /// <param name="rhs">Right hand side Vector3 to use to compute componentwise subtraction.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Subtract(Vector3* lhs, Vector3* rhs)
        {
            lhs->x -= rhs->x;
            lhs->y -= rhs->y;
            lhs->z -= rhs->z;
        }

        /// <summary>Applies the result of a componentwise subtraction operation on two Vector2 vectors.</summary>
        /// <param name="lhs">Left hand side Vector2 to use to compute componentwise subtraction.</param>
        /// <param name="rhs">Right hand side Vector2 to use to compute componentwise subtraction.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Subtract(Vector2* lhs, Vector2* rhs)
        {
            lhs->x -= rhs->x;
            lhs->y -= rhs->y;
        }

        /// <summary>Returns the dot product of two float3 vectors.</summary>
        /// <param name="x">The first vector.</param>
        /// <param name="y">The second vector.</param>
        /// <returns>The dot product of two vectors.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Dot(float3* x, float3* y)
        {
            return x->x * y->x + x->y * y->y + x->z * y->z;
        }

        /// <summary>Returns the dot product of two Vector3 vectors.</summary>
        /// <param name="x">The first vector.</param>
        /// <param name="y">The second vector.</param>
        /// <returns>The dot product of two vectors.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Dot(Vector3* x, Vector3* y)
        {
            return x->x * y->x + x->y * y->y + x->z * y->z;
        }

        /// <summary>
        /// Returns the square magnitude of the given vector.
        /// <para>Same as dot(x, x).</para>
        /// </summary>
        /// <param name="x">The first vector.</param>
        /// <returns>The square magnitude of the vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float SqrMagnitude(float3* x)
        {
            return x->x * x->x + x->y * x->y + x->z * x->z;
        }

        /// <summary>
        /// Returns the square magnitude of the given vector.
        /// <para>Same as dot(x, x).</para>
        /// </summary>
        /// <param name="x">The first vector.</param>
        /// <returns>The square magnitude of the vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float SqrMagnitude(Vector3* x)
        {
            return x->x * x->x + x->y * x->y + x->z * x->z;
        }

        /// <summary>Applies a normalized version of the float3 vector x by scaling it by 1 / length(x).</summary>
        /// <param name="v">Vector to normalize.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Normalize(float3* v)
        {
            // Scale(v, 1f / Mathf.Sqrt(SqrMagnitude(v)));
            var x = v->x;
            var y = v->y;
            var z = v->z;
            var vSqrMagnitude = x * x + y * y + z * z;
            var vRoot = 1f / Mathf.Sqrt(vSqrMagnitude);
            v->x = x * vRoot;
            v->y = y * vRoot;
            v->z = z * vRoot;
        }

        /// <summary>Applies a normalized version of the Vector3 vector x by scaling it by 1 / length(x).</summary>
        /// <param name="v">Vector to normalize.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Normalize(Vector3* v)
        {
            // Scale(v, 1f / Mathf.Sqrt(SqrMagnitude(v)));
            var x = v->x;
            var y = v->y;
            var z = v->z;
            var vSqrMagnitude = x * x + y * y + z * z;
            var vRoot = 1f / Mathf.Sqrt(vSqrMagnitude);
            v->x = x * vRoot;
            v->y = y * vRoot;
            v->z = z * vRoot;
        }

        /// <summary>Checks whether the given Vector3 is zero.</summary>
        /// <returns>True when zero else false.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsZero(Vector3* x)
        {
            return x->x == 0.0f && x->y == 0.0f && x->z == 0.0f;
        }

        /// <summary>Checks whether the given Vector3 is not zero.</summary>
        /// <returns>True when not zero else false.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsNonZero(Vector3* x)
        {
            return x->x != 0.0f || x->y != 0.0f || x->z != 0.0f;
        }

        /// <summary>Applies the result of a cross-product operation on two Vector3 vectors.</summary>
        /// <param name="lhs">Left hand side Vector3 to use to compute and store the cross-product.</param>
        /// <param name="rhs">Right hand side Vector3 to use to compute the cross-product.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Cross(Vector3* lhs, Vector3* rhs)
        {
            float a = lhs->z * rhs->x - lhs->x * rhs->z;
            float b = lhs->x * rhs->y - lhs->y * rhs->x;
            lhs->x = lhs->y * rhs->z - lhs->z * rhs->y;
            lhs->y = a;
            lhs->z = b;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void GammaToLinearSpace(Vector3* sRGB)
        {
            // Approximate version from http://chilliant.blogspot.com.au/2012/08/srgb-approximations-for-hlsl.html?m=1
            // [unsafe] sRGB * (sRGB * (sRGB * 0.305306011f + 0.682171111f) + 0.012522878f);
            var x = sRGB->x;
            var y = sRGB->y;
            var z = sRGB->z;
            sRGB->x = x * (x * (x * 0.305306011f + 0.682171111f) + 0.012522878f);
            sRGB->y = y * (y * (y * 0.305306011f + 0.682171111f) + 0.012522878f);
            sRGB->z = z * (z * (z * 0.305306011f + 0.682171111f) + 0.012522878f);
        }

        /// <summary>Interprets the bit pattern of <paramref name="value"/> as an unsigned integer.</summary>
        /// <param name="value">The floating-point value.</param>
        /// <returns>The input interpreted as an unsigned integer.</returns>
        public static unsafe uint AsUInt32(this float value)
        {
            return *(uint*)&value;
        }
    }
}