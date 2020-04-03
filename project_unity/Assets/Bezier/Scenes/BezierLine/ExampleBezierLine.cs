using UnityEngine;

namespace Algorithm.Example
{
	public class ExampleBezierLine : MonoBehaviour
	{
		public Transform m_Start, m_End;

		public int Segment = 10;
		
		private Vector3[] points;

		void OnDrawGizmos()
		{
			Gizmos.color=Color.red;
			points = Bezier.Line(m_Start.position, m_End.position, Segment);
			for (var i = 0; i < points.Length; i++)
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
