using OpenTK;
using OpenTK.Graphics.OpenGL4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PckStudio.Renderer {
    public enum PlaneOrientation {
        Forwards,
        Rightwards,
        Upwards,
        Downwards,
        Leftwards,
        Backwards
    }
    internal class GLPlane : IGLThing, IDisposable {
        /**
         * <summary>The texture associated with this GLPlane.</summary>
         **/
        private GLTexture texture;

        /**
         * <summary>Location in the world in GL units.</summary>
         **/
        public Vector3 Position {
            get { return position; }
            set { position = value; }
        }
        private Vector3 position;
        
        /**
         * <summary>Center of rotation.</summary>
         **/
        public Vector3 Pivot {
            get { return pivot; }
            set { pivot = value; }
        }
        private Vector3 pivot;

        /**
         * <summary>Rotation in the world in radians.</summary>
         **/
        public Vector3 Rotation {
            get { return rotation; }
            set { rotation = value; }
        }
        private Vector3 rotation;

        /**
         * <summary>UV size of the plane in pixels.</summary>
         **/
        public Vector2 Size {
            get { return size; }
            set { Resize(value); }
        }
        private Vector2 size;

        /**
         * <summary>UV position of the plane in pixels.</summary>
         **/
        public Vector2 Offset {
            get { return offset; }
            set { offset = value; }
        }
        private Vector2 offset;

        /**
         * <summary>Multiply the texture by this color.</summary>
         **/
        public Vector4 Color {
            get { return color; }
            set { color = value; }
        }
        private Vector4 color;

        /**
         * <summary>Which direction this GLPlane is facing.</summary>
         **/
        public PlaneOrientation Orientation {
            get { return orientation; }
            set { orientation = value; }
        }
        private PlaneOrientation orientation;

        /**
         * <summary>Raw vertex data</summary>
         **/
        private float[] vertices;

        /**
         * <summary>OpenGL vertex array object</summary>
         **/
        private int vao;

        /**
         * <summary>OpenGL vertex buffer object</summary>
         **/
        private int vbo;

        private bool disposedValue;

        public GLPlane(GLTexture texture) {
            this.texture = texture;
            // Create OpenGL objects
            vao = GL.GenVertexArray();
            vbo = GL.GenBuffer();
        }

        public GLPlane(GLTexture texture, Vector2 size) : this(texture) {
            Resize(size);
        }

        private void Resize(Vector2 newsize) {
            size = newsize;
            float XCoord = newsize.X / 2.0f;
            float YCoord = newsize.Y / 2.0f;
            vertices = new float[]{
                // X Y Z U V
                -XCoord, -YCoord, 0.0f, 0.0f, 1.0f,
                -XCoord,  YCoord, 0.0f, 0.0f, 0.0f,
                 XCoord, -YCoord, 0.0f, 1.0f, 1.0f,
                 XCoord,  YCoord, 0.0f, 1.0f, 0.0f,
            };
            GL.BindVertexArray(vao);
            // VBO
            GL.BindBuffer(BufferTarget.ArrayBuffer, vbo);
            GL.BufferData(BufferTarget.ArrayBuffer, vertices.Length * sizeof(float), vertices, BufferUsageHint.StreamDraw);
            // VAO
            GL.VertexAttribPointer(0, 3, VertexAttribPointerType.Float, false, 5 * sizeof(float), 0);
            GL.EnableVertexAttribArray(0);
            GL.VertexAttribPointer(1, 2, VertexAttribPointerType.Float, false, 5 * sizeof(float), 3 * sizeof(float));
            GL.EnableVertexAttribArray(1);
            // Unbind everything
            GL.BindBuffer(BufferTarget.ArrayBuffer, 0);
            GL.BindVertexArray(0);
            GL.BindTexture(TextureTarget.Texture2D, 0);
        }

        public void SetShader(GLShader shader) {
            // By default, the plane goes from X to Y, pointing towards Z.
            // We rotate it to put it to the correct orientation.
            Matrix4 model = Matrix4.Identity;
            switch(Orientation) {
                case PlaneOrientation.Upwards:
                    model *= Matrix4.CreateRotationX(MathHelper.DegreesToRadians(90.0f));
                    break;
                case PlaneOrientation.Downwards:
                    model *= Matrix4.CreateRotationX(MathHelper.DegreesToRadians(-90.0f));
                    break;
                case PlaneOrientation.Rightwards:
                    model *= Matrix4.CreateRotationY(MathHelper.DegreesToRadians(90.0f));
                    break;
                case PlaneOrientation.Leftwards:
                    model *= Matrix4.CreateRotationY(MathHelper.DegreesToRadians(-90.0f));
                    break;
                case PlaneOrientation.Backwards:
                    model *= Matrix4.CreateRotationY(MathHelper.DegreesToRadians(180.0f));
                    break;
                case PlaneOrientation.Forwards:
                    // Do nothing
                    break;
            }
            // We're at the center of the universe right now, immediately after
            // the orientation bit.
            // First, we apply the pivot.
            // Then, we apply the rotation.
            // Then, we un-apply the pivot.
            // Then, we apply the position.
            model *= Matrix4.CreateTranslation(-pivot);
            model *= Matrix4.CreateRotationX(rotation.X);
            model *= Matrix4.CreateRotationY(rotation.Y);
            model *= Matrix4.CreateRotationZ(rotation.Z);
            model *= Matrix4.CreateTranslation(pivot);
            model *= Matrix4.CreateTranslation(position);
            // Use texture
            texture.Use();
            // Use shader
            shader.SetVec4("mixColor", Color);
            shader.SetMat4("model", model);
            shader.SetVec2("skinSize", texture.Size);
            shader.SetVec2("planeSize", size); // size of the plane texture
            shader.SetVec2("planePosition", Offset); // where that plane is in the skin
        }

        public void Render() {
            GL.BindVertexArray(vbo);
            GL.DrawArrays(PrimitiveType.TriangleStrip, 0, 4);
            GL.BindVertexArray(0);
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

        ~GLPlane() {
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
