using OpenTK;
using OpenTK.Graphics.OpenGL4;
using PckStudio.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PckStudio.Renderer {
	internal class GLWireBox : GLBox {
		public GLWireBox() : base(null) {
			indices = new uint[48] {
				// front
				0,	1,	1,	2,	2,	3,	3,	0,
				// back
				4,	5,	5,	6,	6,	7,	7,	4,
				// left
				8,	9,	9,	10,	10,	11,	11,	8,
				// right
				12,	13,	13,	14,	14,	15,	15,	12,
				// up
				16,	17,	17,	18,	18,	19,	19,	16,
				// down
				20,	21,	21,	22,	22,	23,	23,	20
			};
		}

		public GLWireBox(Vector3 size) : this() {
			Resize(size, 0.0f, false);
		}

		public new void SetShader(GLShader shader) {
			if(visible == true) {
				Matrix4 model = GetMatrix();
				// Use shader
				shader.SetVec4("mixColor", color);
				shader.SetMat4("model", model);
			}
		}
		
		public void UpdateFromGLBox(GLBox glBox) {
			Resize(glBox.Size, glBox.Padding, glBox.Mirror);
		}

		public new void Render() {
			if(visible == true) {
				GL.BindVertexArray(vao);
				// not opentk nor learnopengl told me to do this.
				// stackoverflow told me to do this and it works.
				// i do not know why it works.
				GL.BindBuffer(BufferTarget.ElementArrayBuffer, ebo);
				GL.DrawElements(PrimitiveType.Lines, indices.Length, DrawElementsType.UnsignedInt, 0);
				GL.BindVertexArray(0);
				GL.BindBuffer(BufferTarget.ElementArrayBuffer, 0);
			}
		}
	}
}
