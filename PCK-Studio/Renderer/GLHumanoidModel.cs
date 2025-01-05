using OpenTK;
using System;
using System.Collections.Generic;

namespace PckStudio.Renderer {
	internal class GLHumanoidModel : IDisposable {

		public GLTexture Skin {
			get { return skin; }
		}
		private GLTexture skin;

		public GLBox Head {
			get { return head; }
		}
		private GLBox head;

		public GLBox Body {
			get { return body; }
		}
		private GLBox body;

		public GLBox LeftLeg {
			get { return leftLeg; }
		}
		private GLBox leftLeg;

		public GLBox RightLeg {
			get { return rightLeg; }
		}
		private GLBox rightLeg;

		public GLBox LeftArm {
			get { return leftArm; }
		}
		private GLBox leftArm;

		public GLBox RightArm {
			get { return rightArm; }
		}
		private GLBox rightArm;

		// outer layers

		public GLBox Hat {
			get { return hat; }
		}
		private GLBox hat;
		
		public GLBox Jacket {
			get { return jacket; }
		}
		private GLBox jacket;
		
		public GLBox LeftPant {
			get { return leftPant; }
		}
		private GLBox leftPant;
		
		public GLBox RightPant {
			get { return rightPant; }
		}
		private GLBox rightPant;
		
		public GLBox RightSleeve {
			get { return rightSleeve; }
		}
		private GLBox rightSleeve;
		
		public GLBox LeftSleeve {
			get { return leftSleeve; }
		}
		private GLBox leftSleeve;

		public List<GLBox> Boxes;

		private bool disposedValue;

		public bool Animate = true;

		/** <summary>Indicates if the model is for a 1.8 skin. Changing this recalculates UVs and toggles jacket layers. </summary> **/
		public bool LaterModel {
			get { return laterModel; }
			set { UpdateType(value); }
		}
		private bool laterModel;

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

			leftLeg = new GLBox(this.skin, new Vector3(4.0f, 12.0f, 4.0f));
			leftLeg.Offset = new Vector2(0.0f, 16.0f);
			leftLeg.Transform.Pivot = new Vector3(0.0f, 6.0f, 0.0f);
			leftLeg.Transform.Position = new Vector3(-2.0f, -12.0f, 0.0f);
			leftLeg.Parent = body;

			rightLeg = new GLBox(this.skin, new Vector3(4.0f, 12.0f, 4.0f));
			rightLeg.Mirror = true;
			rightLeg.Offset = new Vector2(0.0f, 16.0f);
			rightLeg.Transform.Pivot = new Vector3(0.0f, 6.0f, 0.0f);
			rightLeg.Transform.Position = new Vector3(2.0f, -12.0f, 0.0f);
			rightLeg.Parent = body;

			leftArm = new GLBox(this.skin, new Vector3(4.0f, 12.0f, 4.0f));
			leftArm.Offset = new Vector2(40.0f, 16.0f);
			leftArm.Transform.Pivot = new Vector3(0, 4.0f, 0.0f);
			leftArm.Transform.Position = new Vector3(-6.0f, 0.0f, 0.0f);
			leftArm.Parent = body;

			rightArm = new GLBox(this.skin, new Vector3(4.0f, 12.0f, 4.0f));
			rightArm.Mirror = true;
			rightArm.Offset = new Vector2(40.0f, 16.0f);
			rightArm.Transform.Pivot = new Vector3(0, 4.0f, 0.0f);
			rightArm.Transform.Position = new Vector3(6.0f, 0.0f, 0.0f);
			rightArm.Parent = body;

			// outer layers
			
			hat = new GLBox(this.skin, new Vector3(8.0f, 8.0f, 8.0f));
			hat.Padding = 0.5f;
			hat.Offset = new Vector2(32.0f, 0.0f);
			hat.Transform.Pivot = new Vector3(0.0f, -4.0f, 0.0f);
			hat.Transform.Position = new Vector3(0.0f, 0.0f, 0.0f);
			hat.Parent = head;
			
			jacket = new GLBox(this.skin, new Vector3(8.0f, 12.0f, 4.0f));
			jacket.Padding = 0.5f;
			jacket.Offset = new Vector2(16.0f, 32.0f);
			jacket.Transform.Pivot = new Vector3(0.0f, 0.0f, 0.0f);
			jacket.Transform.Position = new Vector3(0.0f, 0.0f, 0.0f);
			jacket.Parent = body;
			jacket.Visible = false;
			
			leftPant = new GLBox(this.skin, new Vector3(4.0f, 12.0f, 4.0f));
			leftPant.Padding = 0.5f;
			leftPant.Offset = new Vector2(0.0f, 32.0f);
			leftPant.Transform.Pivot = new Vector3(0.0f, 6.0f, 0.0f);
			leftPant.Transform.Position = new Vector3(0.0f, 0.0f, 0.0f);
			leftPant.Parent = leftLeg;
			leftPant.Visible = false;

			rightPant = new GLBox(this.skin, new Vector3(4.0f, 12.0f, 4.0f));
			rightPant.Padding = 0.5f;
			rightPant.Offset = new Vector2(0.0f, 48.0f);
			rightPant.Transform.Pivot = new Vector3(0.0f, 6.0f, 0.0f);
			rightPant.Transform.Position = new Vector3(0.0f, 0.0f, 0.0f);
			rightPant.Parent = rightLeg;
			rightPant.Visible = false;

			leftSleeve = new GLBox(this.skin, new Vector3(4.0f, 12.0f, 4.0f));
			leftSleeve.Padding = 0.5f;
			leftSleeve.Offset = new Vector2(40.0f, 32.0f);
			leftSleeve.Transform.Pivot = new Vector3(0, 4.0f, 0.0f);
			leftSleeve.Transform.Position = new Vector3(0.0f, 0.0f, 0.0f);
			leftSleeve.Parent = leftArm;
			leftSleeve.Visible = false;

			rightSleeve = new GLBox(this.skin, new Vector3(4.0f, 12.0f, 4.0f));
			rightSleeve.Padding = 0.5f;
			rightSleeve.Offset = new Vector2(48.0f, 48.0f);
			rightSleeve.Transform.Pivot = new Vector3(0, 4.0f, 0.0f);
			rightSleeve.Transform.Position = new Vector3(0.0f, 0.0f, 0.0f);
			rightSleeve.Parent = rightArm;
			rightSleeve.Visible = false;

			laterModel = false;
		}

		private void UpdateType(bool type){
			laterModel = type;
			if(LaterModel){
				jacket.Visible = true;
				leftPant.Visible = true;
				rightPant.Visible = true;
				leftSleeve.Visible = true;
				rightSleeve.Visible = true;
				rightLeg.Mirror = false;
				rightLeg.Offset = new Vector2(16.0f, 48.0f);
				rightArm.Mirror = false;
				rightArm.Offset = new Vector2(32.0f, 48.0f);
			} else {
				jacket.Visible = false;
				leftPant.Visible = false;
				rightPant.Visible = false;
				leftSleeve.Visible = false;
				rightSleeve.Visible = false;
				rightLeg.Mirror = true;
				rightLeg.Offset = new Vector2(0.0f, 16.0f);
				rightArm.Mirror = true;
				rightArm.Offset = new Vector2(40.0f, 16.0f);
			}
		}

		public void Tick(double _time) {
			if(Animate) {
				double time = _time * 10.0f;
				// anda anda anda pica pica pica
				body.Transform.Position.Y		= (float)Math.Abs(Math.Sin(time * 0.6662f)) * 5.0f - 24.0f + 20.0f;
				head.Transform.Rotation.X		= (float)Math.Sin(time*0.23f) * 1.0f;
				head.Transform.Rotation.Y		= (float)Math.Sin(time*0.1f) * 0.8f;
				leftLeg.Transform.Rotation.X	= (float)Math.Sin(time*0.6662f)*1.4f;
				rightLeg.Transform.Rotation.X	= (float)Math.Sin(time*0.6662f+Math.PI)*1.4f;
				rightArm.Transform.Rotation.X	= (float)Math.Sin(time*0.6662f)*2.0f;
				rightArm.Transform.Rotation.Z	= -((float)Math.Sin(time*0.2819f) - 1.0f) * 1.0f;
				leftArm.Transform.Rotation.X	= (float)Math.Sin(time*0.6662f+Math.PI)*2.0f;
				leftArm.Transform.Rotation.Z	= -((float)Math.Sin(time*0.2312f) + 1.0f) * 1.0f;
			} else {
				body.Transform.Position = Vector3.Zero;
				head.Transform.Rotation = Vector3.Zero;
				rightLeg.Transform.Rotation = Vector3.Zero;
				leftLeg.Transform.Rotation = Vector3.Zero;
				rightArm.Transform.Rotation = Vector3.Zero;
				leftArm.Transform.Rotation = Vector3.Zero;
			}
		}

		public void Render(GLShader shader, Vector3 camera) {
			List<GLBox> objects = [
				body,
				head,
				leftLeg,
				rightLeg,
				leftArm,
				rightArm,
				hat,
				jacket,
				leftPant,
				rightPant,
				leftSleeve,
				rightSleeve,
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
				rightLeg.Dispose();
				leftLeg.Dispose();
				rightArm.Dispose();
				leftArm.Dispose();
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
