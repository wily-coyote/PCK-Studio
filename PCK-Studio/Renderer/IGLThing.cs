using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PckStudio.Renderer {
	internal interface IGLThing {
		void Render();
		void SetShader(GLShader shader);
	}
}
