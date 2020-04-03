using UnityEngine;

namespace Algorithm
{
	public class Bezier
	{
		/// <summary>
		/// 一维 公式:B(t)=P₀+(P₁-P₀)t=(1-t)P₀+tP₁,t∈[0,1]
		/// </summary>
		/// <param name="start">起点</param>
		/// <param name="end">终点</param>
		/// <param name="segment">段数</param>
		/// <returns></returns>
		public static Vector3[] Line(Vector3 start, Vector3 end, int segment)
		{
			var d = 1.0f / segment;
			var points = new Vector3[segment + 1];

			for (var i = 0; i < points.Length; i++)
			{
				var t = d * i;
				points[i] = (1 - t) * start + t * end;
			}

			return points;
		}

		/// <summary>
		/// 二维 公式:B(t)=(1-t)²P₀+2t(1-t)P₁+t²P₂,t∈[0,1]
		/// </summary>
		/// <param name="start">起点</param>
		/// <param name="mid">中点</param>
		/// <param name="end">终点</param>
		/// <param name="segment">段数</param>
		/// <returns></returns>
		public static Vector3[] Curve(Vector3 start, Vector3 mid, Vector3 end, int segment)
		{
			var d = 1.0f / segment;

			var points = new Vector3[segment + 1];

			for (var i = 0; i < points.Length; i++)
			{
				var t = d * i;
				points[i] = Mathf.Pow(1 - t, 2) * start + 2 * t * (1 - t) * mid + Mathf.Pow(t, 2) * end;
			}

			return points;
		}
	}
}
