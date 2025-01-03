﻿using OpenTK;
using System;
using System.Collections.Generic;

namespace PckStudio.Renderer {
	internal class GLHumanoidModel : IDisposable {

		public GLTexture Skin {
			get { return skin; }
		}
		private GLTexture skin;

		public GLBox Hat {
			get { return hat; }
		}
		private GLBox hat;

		public GLBox Head {
			get { return head; }
		}
		private GLBox head;

		public GLBox Body {
			get { return body; }
		}
		private GLBox body;

		public GLBox LeftLeg {
			get { return leftleg; }
		}
		private GLBox leftleg;

		public GLBox RightLeg {
			get { return rightleg; }
		}
		private GLBox rightleg;

		public GLBox LeftArm {
			get { return leftarm; }
		}
		private GLBox leftarm;

		public GLBox RightArm {
			get { return rightarm; }
		}
		private GLBox rightarm;

		public List<GLBox> Boxes;

		private bool disposedValue;

		public bool Animate = true;

		public GLHumanoidModel(GLTexture skin) {
			Boxes = new List<GLBox>();
			this.skin = skin;
			body = new GLBox(this.skin, new Vector3(8.0f, 12.0f, 4.0f));
			body.Offset = new Vector2(16.0f, 16.0f);
			body.Transform.Pivot = new Vector3(0.0f, 0.0f, 0.0f);
			body.Transform.Position = new Vector3(0.0f, 0.0f, 0.0f);

			head = new GLBox(this.skin, new Vector3(8.0f, 8.0f, 8.0f));
			head.Offset = new Vector2(0.0f, 0.0f);
			head.Transform.Pivot = new Vector3(0.0f, -4.0f, 0.0f);
			head.Transform.Position = new Vector3(0.0f, 10.0f, 0.0f);
			head.Parent = body;

			hat = new GLBox(this.skin, new Vector3(8.0f, 8.0f, 8.0f));
			hat.Padding = 1.0f;
			hat.Offset = new Vector2(32.0f, 0.0f);
			hat.Transform.Pivot = new Vector3(0.0f, -4.0f, 0.0f);
			hat.Transform.Position = new Vector3(0.0f, 0.0f, 0.0f);
			hat.Parent = head;

			leftleg = new GLBox(this.skin, new Vector3(4.0f, 12.0f, 4.0f));
			leftleg.Offset = new Vector2(0.0f, 16.0f);
			leftleg.Transform.Pivot = new Vector3(0.0f, 6.0f, 0.0f);
			leftleg.Transform.Position = new Vector3(-2.0f, -12.0f, 0.0f);
			leftleg.Parent = body;

			rightleg = new GLBox(this.skin, new Vector3(4.0f, 12.0f, 4.0f));
			rightleg.Mirror = true;
			rightleg.Offset = new Vector2(0.0f, 16.0f);
			rightleg.Transform.Pivot = new Vector3(0.0f, 6.0f, 0.0f);
			rightleg.Transform.Position = new Vector3(2.0f, -12.0f, 0.0f);
			rightleg.Parent = body;

			leftarm = new GLBox(this.skin, new Vector3(4.0f, 12.0f, 4.0f));
			leftarm.Offset = new Vector2(40.0f, 16.0f);
			leftarm.Transform.Pivot = new Vector3(0, 4.0f, 0.0f);
			leftarm.Transform.Position = new Vector3(-6.0f, 0.0f, 0.0f);
			leftarm.Parent = body;

			rightarm = new GLBox(this.skin, new Vector3(4.0f, 12.0f, 4.0f));
			rightarm.Mirror = true;
			rightarm.Offset = new Vector2(40.0f, 16.0f);
			rightarm.Transform.Pivot = new Vector3(0, 4.0f, 0.0f);
			rightarm.Transform.Position = new Vector3(6.0f, 0.0f, 0.0f);
			rightarm.Parent = body;
		}

		public void Tick(double _time) {
			if(Animate) {
				double time = _time * 10.0f;
				// anda anda anda pica pica pica
				body.Transform.Position.Y		= (float)Math.Abs(Math.Sin(time * 0.6662f)) * 5.0f - 24.0f + 20.0f;
				head.Transform.Rotation.X		= (float)Math.Sin(time*0.23f) * 1.0f;
				head.Transform.Rotation.Y		= (float)Math.Sin(time*0.1f) * 0.8f;
				leftleg.Transform.Rotation.X	= (float)Math.Sin(time*0.6662f)*1.4f;
				rightleg.Transform.Rotation.X	= (float)Math.Sin(time*0.6662f+Math.PI)*1.4f;
				rightarm.Transform.Rotation.X	= (float)Math.Sin(time*0.6662f)*2.0f;
				rightarm.Transform.Rotation.Z	= -((float)Math.Sin(time*0.2819f) - 1.0f) * 1.0f;
				leftarm.Transform.Rotation.X	= (float)Math.Sin(time*0.6662f+Math.PI)*2.0f;
				leftarm.Transform.Rotation.Z	= -((float)Math.Sin(time*0.2312f) + 1.0f) * 1.0f;
			} else {
				body.Transform.Position = Vector3.Zero;
				head.Transform.Rotation = Vector3.Zero;
				rightleg.Transform.Rotation = Vector3.Zero;
				leftleg.Transform.Rotation = Vector3.Zero;
				rightarm.Transform.Rotation = Vector3.Zero;
				leftarm.Transform.Rotation = Vector3.Zero;
			}
		}

		public void Render(GLShader shader, Vector3 camera) {
			List<GLBox> objects = [
				body,
				head,
				leftleg,
				rightleg,
				leftarm,
				rightarm,
				hat,
				..Boxes,
			];
			objects.Sort((a, b) => {
				return (int)(b.DistanceFromCamera(camera) - a.DistanceFromCamera(camera));
			});
			//objects.Reverse();
			foreach(var obj in objects) {
				obj.SetShader(shader);
				obj.Render();
			}
		}

		public virtual void Dispose(bool disposing) {
			if(!disposedValue) {
				for(int i = Boxes.Count-1; i >= 0; i--) {
					Boxes[i].Dispose();
				}
				head.Dispose();
				rightleg.Dispose();
				leftleg.Dispose();
				rightarm.Dispose();
				leftarm.Dispose();
				body.Dispose();
				disposedValue = true;
			}
		}

		~GLHumanoidModel() {
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
