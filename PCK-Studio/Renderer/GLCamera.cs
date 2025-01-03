using OpenTK;
using System;

namespace PckStudio.Renderer {
	internal class GLCamera {
		public Vector3 Position {
			get {
				return position;
			}
		}

		private static readonly float zoomFactor = 4.0f;

		private Vector3 position;
		private Vector3 target;

		private Vector2 lastPoint;
		private Vector2 nowPoint;

		private bool panning;

		public GLCamera(Vector3 position, Vector3 target) {
			this.position = position;
			this.target = target;
		}

		public void StartPanning(Vector2 at) {
			panning = true;
			nowPoint = at;
			lastPoint = nowPoint;
		}

		// TODO: find a better way to pan
		public void Pan(Vector2 newPos) {
			if(panning == true) {
				nowPoint = newPos;
				Vector2 delta = (nowPoint - lastPoint);
				Vector3 normal = (position - target);
				float length = normal.Length;
				normal.Normalize();
				Vector3 right = Vector3.Cross(Vector3.UnitY, normal);
				Vector3 up = Vector3.Cross(normal, right);
				normal += ((right * -delta.X) + (up * delta.Y))/50.0f;
				normal.Normalize();
				normal *= length;
				position = target + normal;
				lastPoint = nowPoint;
			}
		}

		public void StopPanning() {
			panning = false;
		}

		public void Zoom(float by) {
			Vector3 direction = (position - target).Normalized();
			position -= direction * Math.Sign(by) * zoomFactor;
		}

		public Matrix4 GetMatrix() {
			return Matrix4.LookAt(
				position,
				target,
				Vector3.UnitY
			);
		}
	}
}
