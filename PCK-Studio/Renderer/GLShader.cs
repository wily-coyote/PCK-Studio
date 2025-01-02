using OpenTK;
using OpenTK.Graphics.OpenGL4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PckStudio.Renderer
{
    internal class GLShader : IDisposable
    {
        private int Handle;
        private int VertShader;
        private int FragShader;
        private bool disposedValue;

        public GLShader(string vert, string frag)
        {
            VertShader = GL.CreateShader(ShaderType.VertexShader);
            FragShader = GL.CreateShader(ShaderType.FragmentShader);
            GL.ShaderSource(VertShader, vert);
            GL.ShaderSource(FragShader, frag);
            {
                GL.CompileShader(VertShader);
                GL.GetShader(VertShader, ShaderParameter.CompileStatus, out int success);
                if (success == 0)
                {
                    string infoLog = GL.GetShaderInfoLog(VertShader);
                    Console.WriteLine(infoLog);
                    throw new ArgumentNullException(infoLog);
                }
            } {
                GL.CompileShader(FragShader);
                GL.CompileShader(FragShader);
                GL.GetShader(FragShader, ShaderParameter.CompileStatus, out int success);
                if (success == 0)
                {
                    string infoLog = GL.GetShaderInfoLog(FragShader);
                    Console.WriteLine(infoLog);
                    throw new ArgumentNullException(infoLog);
                }
            }
            Handle = GL.CreateProgram();
            GL.AttachShader(Handle, VertShader);
            GL.AttachShader(Handle, FragShader);
            GL.LinkProgram(Handle);
            {
                GL.GetProgram(Handle, GetProgramParameterName.LinkStatus, out int success);
                if (success == 0)
                {
                    string infoLog = GL.GetProgramInfoLog(Handle);
                    Console.WriteLine(infoLog);
                    throw new ArgumentNullException(infoLog);
                }
            }
            GL.DetachShader(Handle, VertShader);
            GL.DetachShader(Handle, FragShader);
            GL.DeleteShader(FragShader);
            GL.DeleteShader(VertShader);
        }

        public void Use()
        {
            GL.UseProgram(Handle);
        }
        
        public void SetFloat(string name, float value)
        {
            int loc = GL.GetUniformLocation(Handle, name);
            GL.Uniform1(loc, value);
        }
        
        public void SetVec2(string name, Vector2 vec2)
        {
            int loc = GL.GetUniformLocation(Handle, name);
            GL.Uniform2(loc, vec2);
        }
        
        public void SetVec3(string name, Vector3 vec3)
        {
            int loc = GL.GetUniformLocation(Handle, name);
            GL.Uniform3(loc, vec3);
        }

        public void SetVec4(string name, Vector4 vec4)
        {
            int loc = GL.GetUniformLocation(Handle, name);
            GL.Uniform4(loc, vec4);
        }
        
        public void SetMat4(string name, Matrix4 mat4)
        {
            int loc = GL.GetUniformLocation(Handle, name);
            GL.UniformMatrix4(loc, false, ref mat4);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                GL.DeleteProgram(Handle);
                disposedValue = true;
            }
        }

        ~GLShader()
        {
            if(disposedValue == false)
            {
                Console.WriteLine("oops, shader leak. did you forget to Dispose()?");
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
