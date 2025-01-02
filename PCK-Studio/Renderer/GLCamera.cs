using OpenTK;
using System;

namespace PckStudio.Renderer {
	internal class GLCamera {
		public Vector3 Position {
			get {
				return position;
			}
		}
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

		// TODO: find a better way to pan without gimbal locking (?)
		public void Pan(Vector2 newPos) {
			if(panning == true) {
				nowPoint = newPos;
				Vector2 delta = (nowPoint - lastPoint);
				Matrix4 pan =
					Matrix4.CreateRotationY(MathHelper.DegreesToRadians(-delta.X))
					*
					Matrix4.CreateRotationX(MathHelper.DegreesToRadians(-delta.Y));
				Vector4 newCamera = new Vector4(position - target);
				newCamera.W = 1.0f;
				newCamera *= pan;
				position = newCamera.Xyz + target;
				lastPoint = nowPoint;
			}
		}

		public void StopPanning() {
			panning = false;
		}

		public void Zoom(float by) {
			Vector3 direction = (position - target).Normalized();
			position -= direction * Math.Sign(by);
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
