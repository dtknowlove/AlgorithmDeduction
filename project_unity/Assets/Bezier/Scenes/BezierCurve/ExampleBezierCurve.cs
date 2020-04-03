using System.Collections.Generic;
using UnityEngine;

namespace Algorithm.Example
{
	public class ExampleBezierCurve : MonoBehaviour
	{
		public Transform m_Start, m_Mid, m_End;

		public int Segment = 10;

		private List<Vector3> points = new List<Vector3>();

		void OnDrawGizmos()
		{
			points.Clear();
			points.AddRange(Bezier.Curve(m_Start.position, m_Mid.position, m_End.position, Segment));
			for (var i = 0; i < points.Count; i++)
			{
				Gizmos.color = Color.blue;
				var point = points[i];
				Gizmos.DrawSphere(point, 0.1f);
				Gizmos.color = Color.red;
				if (i > 0)
					Gizmos.DrawLine(points[i - 1], point);
			}
		}
	}
}
