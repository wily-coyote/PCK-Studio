using OpenTK;
using OpenTK.Graphics.OpenGL4;
using System;

namespace PckStudio.Renderer {
	internal class GLBox : IGLThing, IDisposable {
		private bool disposedValue;

		private int vao;
		private int vbo;
		private int ebo;
		private float[] vertices;
		private uint[] indices;

		/**
		 * <summary>Texture this is using</summary>
		 **/
		private GLTexture texture;

		/**
		 * <summary>The size of the GLBox (affects UVs).</summary>
		 **/
		public Vector3 Size {
			get {
				return size;
			}
			set {
				Resize(value, padding, mirror);
			}
		}
		private Vector3 size;

		/**
		 * <summary>Multiply this box by this color</summary>
		 **/
		public Vector4 Color {
			get {
				return color;
			}
			set {
				color = value;
			}
		}
		private Vector4 color;

		/**
		 * <summary>Adds this amount of pixels to all sides.</summary>
		 **/
		public float Padding {
			get {
				return padding;
			}
			set {
				Resize(size, value, mirror);
			}
		}
		private float padding;

		/**
		 * <summary>Flips the texture in the X axis.</summary>
		 **/
		public bool Mirror {
			get {
				return mirror;
			}
			set {
				Resize(size, padding, value);
			}
		}
		private bool mirror;

		/**
		 * <summary>The UV offset of the GLBox, based on the top left corner of the bounding box</summary>
		 **/
		public Vector2 Offset {
			get {
				return offset;
			}
			set {
				offset = value;
			}
		}
		private Vector2 offset;

		public GLTransform Transform;
		public GLBox Parent;

		public GLBox(GLTexture texture) {
			this.color = new Vector4(1.0f, 1.0f, 1.0f, 1.0f);
			this.texture = texture;
			this.Transform = new GLTransform();
			// Create OpenGL objects
			vao = GL.GenVertexArray();
			vbo = GL.GenBuffer();
			ebo = GL.GenBuffer();
		}

		public GLBox(GLTexture texture, Vector3 size) : this(texture) {
			Resize(size, 0.0f, false);
		}

		public void Resize(Vector3 newSize, float newPadding, bool newMirror) {
			padding = newPadding;
			size = newSize;
			mirror = newMirror;
			float xSize = size.X;
			float ySize = size.Y;
			float zSize = size.Z;
			float xSizePadded = (xSize+padding)/2.0f;
			float ySizePadded = (ySize+padding)/2.0f;
			float zSizePadded = (zSize+padding)/2.0f;
			float[] uvs;
			if(mirror) {
				uvs = new float[48] {
					// Front
					zSize+xSize,             zSize+ySize,
					zSize,                      zSize+ySize,
					zSize,                      zSize,
					zSize+xSize,                zSize,
					// Back
					zSize+xSize+zSize+xSize, zSize+ySize,
					zSize+xSize+zSize,          zSize+ySize,
					zSize+xSize+zSize,          zSize,
					zSize+xSize+zSize+xSize,    zSize,
					// Left (swapped with right)
					zSize+xSize+zSize,           zSize+ySize,
					zSize+xSize,                zSize+ySize,
					zSize+xSize,                zSize,
					zSize+xSize+zSize,          zSize,
					// Right (swapped with left)
					zSize,                       zSize+ySize,
					0.0f,                       zSize+ySize,
					0.0f,                       zSize,
					zSize,                      zSize,
					// Up
					zSize+xSize,             zSize,
					zSize,                      zSize,
					zSize,                      0.0f,
					zSize+xSize,                0.0f,
					// Down
					zSize+xSize+xSize,           0.0f,
					zSize+xSize,                0.0f,
					zSize+xSize,                zSize,
					zSize+xSize+xSize,          zSize,
				};
			} else {
				uvs = new float[48] {
					zSize,                      zSize+ySize,
					zSize+xSize,                zSize+ySize,
					zSize+xSize,                zSize,
					zSize,                      zSize,
					// Back
					zSize+xSize+zSize,          zSize+ySize,
					zSize+xSize+zSize+xSize,    zSize+ySize,
					zSize+xSize+zSize+xSize,    zSize,
					zSize+xSize+zSize,          zSize,
					// Left
					0.0f,                       zSize+ySize,
					zSize,                      zSize+ySize,
					zSize,                      zSize,
					0.0f,                       zSize,
					// Right
					zSize+xSize,                zSize+ySize,
					zSize+xSize+zSize,          zSize+ySize,
					zSize+xSize+zSize,          zSize,
					zSize+xSize,                zSize,
					// Up
					zSize,                      zSize,
					zSize+xSize,                zSize,
					zSize+xSize,                0.0f,
					zSize,                      0.0f,
					// Down
					zSize+xSize,                0.0f,
					zSize+xSize+xSize,          0.0f,
					zSize+xSize+xSize,          zSize,
					zSize+xSize,                zSize,
				};
			}
			vertices = new float[192] {
				// X Y Z U V Xn Yn Zn
				// Counterclockwise from bottom left
				// Front
				// EBO would be 0, 1, 2,	 0, 2, 3
				-xSizePadded,    -ySizePadded,   zSizePadded,    0.0f,   0.0f,   0.0f,   0.0f,   1.0f,
				xSizePadded,    -ySizePadded,   zSizePadded,    0.0f,   0.0f,   0.0f,   0.0f,   1.0f,
				xSizePadded,    ySizePadded,    zSizePadded,    0.0f,   0.0f,   0.0f,   0.0f,   1.0f,
				-xSizePadded,   ySizePadded,    zSizePadded,    0.0f,   0.0f,   0.0f,   0.0f,   1.0f,
				// Back
				xSizePadded,   -ySizePadded,   -zSizePadded,   0.0f,   0.0f,   0.0f,   0.0f,   -1.0f,
				-xSizePadded,   -ySizePadded,   -zSizePadded,   0.0f,   0.0f,   0.0f,   0.0f,   -1.0f,
				-xSizePadded,   ySizePadded,    -zSizePadded,   0.0f,   0.0f,   0.0f,   0.0f,   -1.0f,
				xSizePadded,    ySizePadded,    -zSizePadded,   0.0f,   0.0f,   0.0f,   0.0f,   -1.0f,
				// Left
				-xSizePadded,    -ySizePadded,   -zSizePadded,   0.0f,   0.0f,   -1.0f,  0.0f,   0.0f,
				-xSizePadded,   -ySizePadded,   zSizePadded,    0.0f,   0.0f,   -1.0f,  0.0f,   0.0f,
				-xSizePadded,   ySizePadded,    zSizePadded,    0.0f,   0.0f,   -1.0f,  0.0f,   0.0f,
				-xSizePadded,   ySizePadded,    -zSizePadded,   0.0f,   0.0f,   -1.0f,  0.0f,   0.0f,
				// Right
				xSizePadded,   -ySizePadded,   zSizePadded,    0.0f,   0.0f,   1.0f,   0.0f,   0.0f,
				xSizePadded,    -ySizePadded,   -zSizePadded,   0.0f,   0.0f,   1.0f,   0.0f,   0.0f,
				xSizePadded,    ySizePadded,    -zSizePadded,   0.0f,   0.0f,   1.0f,   0.0f,   0.0f,
				xSizePadded,    ySizePadded,    zSizePadded,    0.0f,   0.0f,   1.0f,   0.0f,   0.0f,
				// Up
				-xSizePadded,    ySizePadded,    zSizePadded,    0.0f,   0.0f,   0.0f,   1.0f,   0.0f,
				xSizePadded,    ySizePadded,    zSizePadded,    0.0f,   0.0f,   0.0f,   1.0f,   0.0f,
				xSizePadded,    ySizePadded,    -zSizePadded,   0.0f,   0.0f,   0.0f,   1.0f,   0.0f,
				-xSizePadded,   ySizePadded,    -zSizePadded,   0.0f,   0.0f,   0.0f,   1.0f,   0.0f,
				// Down
				-xSizePadded,    -ySizePadded,   zSizePadded,    0.0f,   0.0f,   0.0f,   -1.0f,  0.0f,
				xSizePadded,    -ySizePadded,   zSizePadded,    0.0f,   0.0f,   0.0f,   -1.0f,  0.0f,
				xSizePadded,    -ySizePadded,   -zSizePadded,   0.0f,   0.0f,   0.0f,   -1.0f,  0.0f,
				-xSizePadded,   -ySizePadded,   -zSizePadded,   0.0f,   0.0f,   0.0f,   -1.0f,  0.0f,
			};
			for(int i = 0; i < 24; i++) {
				vertices[3+(i*8)]   = uvs[i*2];
				vertices[3+(i*8)+1] = uvs[(i*2)+1];
			}
			indices = new uint[36] {
				// front
				0,   1,  2,
				0,  2,  3,
				// back
				4,   5,  6,
				4,  6,  7,
				// left
				8,   9,  10,
				8,  10, 11,
				// right
				12,   13, 14,
				12, 14, 15,
				// up
				16,   17, 18,
				16, 18, 19,
				// down
				20,   21, 22,
				20, 22, 23,
			};
			// Box is different from Plane
			// because it uses GL_TRIANGLES
			// instead of GL_TRIANGLE_STRIP
			// for its rendering data.
			GL.BindVertexArray(vao);
			// VBO
			GL.BindBuffer(BufferTarget.ArrayBuffer, vbo);
			GL.BufferData(BufferTarget.ArrayBuffer, vertices.Length * sizeof(float), vertices, BufferUsageHint.StreamDraw);
			// EBO
			GL.BindBuffer(BufferTarget.ElementArrayBuffer, ebo);
			GL.BufferData(BufferTarget.ElementArrayBuffer, indices.Length * sizeof(uint), indices, BufferUsageHint.StreamDraw);
			// VBO attributes
			GL.VertexAttribPointer(0, 3, VertexAttribPointerType.Float, false, 8 * sizeof(float), 0); // positions
			GL.EnableVertexAttribArray(0);
			GL.VertexAttribPointer(1, 2, VertexAttribPointerType.Float, false, 8 * sizeof(float), 3 * sizeof(float)); // uvs
			GL.EnableVertexAttribArray(1);
			GL.VertexAttribPointer(2, 3, VertexAttribPointerType.Float, false, 8 * sizeof(float), 5 * sizeof(float)); // normals
			GL.EnableVertexAttribArray(2);
			// Unbind everything
			GL.BindBuffer(BufferTarget.ArrayBuffer, 0);
			GL.BindBuffer(BufferTarget.ElementArrayBuffer, 0);
			GL.BindVertexArray(0);
			GL.BindTexture(TextureTarget.Texture2D, 0);
		}

		public Matrix4 GetMatrix() {
			// First, we apply the pivot.
			// Then, we apply the rotation.
			// Then, we un-apply the pivot.
			// Then, we apply the position.
			Matrix4 model = Matrix4.CreateTranslation(-Transform.Pivot);
			model *= Matrix4.CreateRotationX(Transform.Rotation.X);
			model *= Matrix4.CreateRotationY(Transform.Rotation.Y);
			model *= Matrix4.CreateRotationZ(Transform.Rotation.Z);
			model *= Matrix4.CreateTranslation(Transform.Pivot);
			model *= Matrix4.CreateTranslation(Transform.Position);
			return model;
		}

		public void SetShader(GLShader shader) {
			Matrix4 model = GetMatrix();
			if(Parent != null)
				model *= Parent.GetMatrix();
			// Use texture
			texture.Use();
			// Use shader
			shader.SetVec4("mixColor", color);
			shader.SetMat4("model", model);
			shader.SetVec2("textureSize", texture.Size);
			shader.SetVec2("uvOffset", offset); // where that plane is in the skin
		}

		public void Render() {
			if(Transform.Visible) {
				GL.BindVertexArray(vao);
				// not opentk nor learnopengl told me to do this.
				// stackoverflow told me to do this and it works.
				// i do not know why it works.
				GL.BindBuffer(BufferTarget.ElementArrayBuffer, ebo);
				GL.DrawElements(PrimitiveType.Triangles, indices.Length, DrawElementsType.UnsignedInt, 0);
				GL.BindVertexArray(0);
				GL.BindBuffer(BufferTarget.ElementArrayBuffer, 0);
			}
		}

		public float DistanceFromCamera(Vector3 camera) {
			Vector4 realpos = new Vector4(Transform.Position);
			realpos.W = 1.0f;
			realpos *= GetMatrix();
			if(Parent != null)
				realpos *= Parent.GetMatrix();
			return (realpos.Xyz - camera).Length;
		}

		public virtual void Dispose(bool disposing) {
			if(!disposedValue) {
				GL.BindBuffer(BufferTarget.ArrayBuffer, 0);
				GL.DeleteBuffer(vbo);
				GL.BindVertexArray(vao);
				GL.DeleteVertexArray(1);
				GL.BindVertexArray(0);
				disposedValue = true;
			}
		}

		~GLBox() {
			if(disposedValue == false) {
				Console.WriteLine("oops, vertex object leak. did you forget to Dispose()?");
			}
		}

		public void Dispose() {
			Dispose(true);
			GC.SuppressFinalize(this);
		}
	}
}
