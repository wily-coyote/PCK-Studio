using OpenTK;
using OpenTK.Graphics.OpenGL4;
using System.Drawing;
using System.Drawing.Imaging;

namespace PckStudio.Renderer {
	internal class GLTexture {
		private int Handle;
		private int Width;
		private int Height;
		public Vector2 Size { get => new Vector2(Width, Height); }
		public GLTexture(Bitmap bitmap) {
			Width = bitmap.Width;
			Height = bitmap.Height;
			Handle = GL.GenTexture();
			// Skin texture
			GL.BindTexture(TextureTarget.Texture2D, Handle);
			BitmapData data = bitmap.LockBits(
				new Rectangle(0, 0, bitmap.Width, bitmap.Height),
				ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format32bppArgb
			);
			GL.TexImage2D(
				TextureTarget.Texture2D,
				0,
				PixelInternalFormat.Rgba,
				bitmap.Width,
				bitmap.Height,
				0,
				OpenTK.Graphics.OpenGL4.PixelFormat.Bgra,
				PixelType.UnsignedByte,
				data.Scan0
			);
			GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureWrapS, (int)TextureWrapMode.Repeat);
			GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureWrapT, (int)TextureWrapMode.Repeat);
			GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMinFilter, (int)TextureMinFilter.Nearest);
			GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMagFilter, (int)TextureMagFilter.Nearest);
			bitmap.UnlockBits(data);
			GL.BindTexture(TextureTarget.Texture2D, 0);
		}

		public void Use() {
			GL.BindTexture(TextureTarget.Texture2D, Handle);
		}
	}
}
