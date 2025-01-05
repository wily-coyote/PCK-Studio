using OpenTK;

namespace PckStudio.Renderer {
	internal class GLShaderSources {
		public static readonly string BoxVertShader = @"#version 330 core
layout (location = 0) in vec3 aPosition;
layout (location = 1) in vec2 aTexCoord;
layout (location = 2) in vec3 aNormal;

uniform mat4 model;
uniform mat4 view;
uniform mat4 projection;

uniform vec2 textureSize;
uniform vec2 uvOffset;

out vec2 TexCoord;
out vec3 Normal;

void main(){
	gl_Position = projection * view * model * vec4(aPosition, 1.0);
	TexCoord = (aTexCoord + uvOffset) / textureSize;
	Normal = ( ( model * vec4(aPosition + aNormal, 1.0) ) - ( model * vec4(aPosition, 1.0) ) ).xyz;
}";
		public static readonly string BoxFragShader = @"#version 330 core
out vec4 FragColor;
in vec2 TexCoord;
in vec3 Normal;
uniform vec4 mixColor;
uniform sampler2D skinTexture;
vec3 lightDir = normalize(vec3(1.0, 1.0, 1.0));
vec3 ambientColor = vec3(0.25, 0.25, 0.25);

void main(){
	vec4 color = texture(skinTexture, TexCoord);
	if(color.a <= 0.0)
		discard;
	FragColor = color * vec4(ambientColor * dot(normalize(Normal), lightDir) + (vec3(1.0)-ambientColor), 1.0);
}";
		
		public static readonly string WireVertShader = @"#version 330 core
layout (location = 0) in vec3 aPosition;
layout (location = 1) in vec2 aTexCoord;
layout (location = 2) in vec3 aNormal;

uniform mat4 model;
uniform mat4 view;
uniform mat4 projection;

uniform vec2 textureSize;
uniform vec2 uvOffset;

out vec2 TexCoord;
out vec3 Normal;

void main(){
	gl_Position = projection * view * model * vec4(aPosition, 1.0);
	TexCoord = vec2(0.0, 0.0);
	Normal = vec3(0.0, 0.0, 0.0);
}";
		public static readonly string WireFragShader = @"#version 330 core
out vec4 FragColor;
in vec2 TexCoord;
in vec3 Normal;
uniform vec4 mixColor;

void main(){
	FragColor = mixColor;
}";

		public static GLShader BoxShader(){
			return new GLShader(BoxVertShader, BoxFragShader);
		}
		
		public static GLShader WireShader(){
			return new GLShader(WireVertShader, WireFragShader);
		}
	}
}
