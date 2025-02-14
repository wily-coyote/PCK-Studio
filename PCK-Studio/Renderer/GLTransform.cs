﻿using OpenTK;

namespace PckStudio.Renderer {
	internal class GLTransform {
		/**
		 * <summary>The location of the GLBox in the world</summary>
		 **/
		public Vector3 Position;

		/**
		 * <summary>The rotation of the GLbox based on the center + Pivot. In radians.</summary>
		 **/
		public Vector3 Rotation;

		/**
		 * <summary>The center of rotation</summary>
		 **/
		public Vector3 Pivot;

		public GLTransform() {
			Position = Vector3.Zero;
			Rotation = Vector3.Zero;
			Pivot = Vector3.Zero;
		}
	}
}
