/* Copyright (c) 2023-present miku-666, MattNL
 * This software is provided 'as-is', without any express or implied
 * warranty. In no event will the authors be held liable for any damages
 * arising from the use of this software.
 * 
 * Permission is granted to anyone to use this software for any purpose,
 * including commercial applications, and to alter it and redistribute it
 * freely, subject to the following restrictions:
 * 
 * 1.The origin of this software must not be misrepresented; you must not
 *    claim that you wrote the original software. If you use this software
 *    in a product, an acknowledgment in the product documentation would be
 *    appreciated but is not required.
 * 2. Altered source versions must be plainly marked as such, and must not be
 *    misrepresented as being the original software.
 * 3. This notice may not be removed or altered from any source distribution.
**/
using System;
using System.ComponentModel;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace PckStudio.Internal {
	/** <summary>Valid type values used in SkinBOX to define hierarchy.</summary> **/
	public enum BOXType {
		// Base 64x32 Parts
		HEAD,
		BODY,
		ARM0,
		ARM1,
		LEG0,
		LEG1,
		// 64x64 Overlay Parts
		HEADWEAR,
		JACKET,
		SLEEVE0,
		SLEEVE1,
		WAIST,
		PANTS0,
		PANTS1,
		// Armor Parts
		BODYARMOR,
		ARMARMOR0,
		ARMARMOR1,
		BELT,
		LEGGING0,
		LEGGING1,
		SOCK0,
		SOCK1,
		BOOT0,
		BOOT1
	}

	/** <summary>Defines 3D geometry for custom skins.</summary> **/
	public class SkinBOX : ICloneable, IEquatable<SkinBOX>, INotifyPropertyChanged {
		/** <summary>Default SkinBOX object that represents the head.</summary> **/
		public static readonly SkinBOX Empty = new SkinBOX(BOXType.HEAD, new Vector3(-4, -8, -4), new Vector3(8), Vector2.Zero);

		/** <summary>Fired whenever a property changes.</summary> **/
		public event PropertyChangedEventHandler PropertyChanged;
		
		private BOXType type;
		
		private float posX;
		private float posY;
		private float posZ;
		
		private float sizeX;
		private float sizeY;
		private float sizeZ;
		
		private float u;
		private float v;
		
		private bool armorFlag;
		private bool mirror;
		private float scale;

		/**
		 * <summary>The parent element that this SkinBOX is part of.</summary>
		 **/
		public BOXType Type {
			get { return type; }
			set { type = value; NotifyPropertyChanged(); }
		}

		/**
		 * <summary>The location of the SkinBOX relative to the parent <see cref="SkinBOX.Type"/>. In pixels.</summary>
		 **/
		[Browsable(false)]
		public Vector3 Pos {
			get { return new Vector3(PosX, PosY, PosZ); }
			set {
				PosX = value.X;
				PosY = value.Y;
				PosZ = value.Z;
			}
		}
		/** <summary>See <see cref="SkinBOX.Pos"/>.</summary> **/
		public float PosX {
			get { return posX; }
			set { posX = value; NotifyPropertyChanged(); }
		}
		/** <summary>See <see cref="SkinBOX.Pos"/>.</summary> **/
		public float PosY {
			get { return posY; }
			set { posY = value; NotifyPropertyChanged(); }
		}
		/** <summary>See <see cref="SkinBOX.Pos"/>.</summary> **/
		public float PosZ {
			get { return posZ; }
			set { posZ = value; NotifyPropertyChanged(); }
		}

		/**
		 * <summary>...of the SkinBOX in pixels.</summary>
		 **/
		[Browsable(false)]
		public Vector3 Size {
			get { return new Vector3(SizeX, SizeY, SizeZ); }
			set {
				SizeX = value.X;
				SizeY = value.Y;
				SizeZ = value.Z;
			}
		}
		/** <summary>See <see cref="SkinBOX.Size"/>.</summary> **/
		public float SizeX {
			get { return sizeX; }
			set { sizeX = value; NotifyPropertyChanged(); }
		}
		/** <summary>See <see cref="SkinBOX.Size"/>.</summary> **/
		public float SizeY {
			get { return sizeY; }
			set { sizeY = value; NotifyPropertyChanged(); }
		}
		/** <summary>See <see cref="SkinBOX.Size"/>.</summary> **/
		public float SizeZ {
			get { return sizeZ; }
			set { sizeZ = value; NotifyPropertyChanged(); }
		}

		/**
		 * <summary>
		 * The texture coordinate of the SkinBOX,
		 * located at the top left corner of the bounding box.
		 * </summary>
		 * 
		 * X    +----+----+
		 *      |    |    |    
		 *      |    |    |    
		 * +----+----+----+----+
		 * |    |    |    |    |
		 * |    |    |    |    |
		 * +----+----+----+----+
		 **/
		[Browsable(false)]
		public Vector2 UV {
			get { return new Vector2(U, V); }
			set {
				U = value.X;
				V = value.Y;
			}
		}
		/** <summary>See <see cref="SkinBOX.UV"/>.</summary> **/
		public float U {
			get { return u; }
			set { u = value; NotifyPropertyChanged(); }
		}
		/** <summary>See <see cref="SkinBOX.UV"/>.</summary> **/
		public float V {
			get { return v; }
			set { v = value; NotifyPropertyChanged(); }
		}

		/**
		 * <summary>Determines if this SkinBOX should hide itself if the player is wearing armor.</summary> 
		 **/
		public bool ArmorFlag {
			get { return armorFlag; }
			set { armorFlag = value; NotifyPropertyChanged(); }
		}

		/**
		 * <summary>Flips the texture coordinates of the SkinBOX.</summary> 
		 **/
		public bool Mirror {
			get { return mirror; }
			set { mirror = value; NotifyPropertyChanged(); }
		}

		/**
		 * <summary>
		 * Adds padding to the SkinBOX.
		 * 
		 * TODO: what units? what is this, actually?
		 * </summary>
		 **/
		public float Scale {
			get { return scale; }
			set { scale = value; NotifyPropertyChanged(); }
		}

		/** <summary>Constructs a SkinBOX using vector struct values.</summary> **/
		public SkinBOX(
			BOXType type,
			Vector3 pos,
			Vector3 size,
			Vector2 uv,
			bool armorFlag = false,
			bool mirror = false,
			float scale = 0.0f
		) {
			Type = type;
			PosX = pos.X;
			PosY = pos.Y;
			PosZ = pos.Z;
			SizeX = size.X;
			SizeY = size.Y;
			SizeZ = size.Z;
			U = uv.X;
			V = uv.Y;
			ArmorFlag = armorFlag;
			Mirror = mirror;
			Scale = scale;
		}

		/** <summary>Constructs a SkinBOX using raw values.</summary> **/
		public SkinBOX(
			BOXType type,
			float posX,
			float posY,
			float posZ,
			float sizeX,
			float sizeY,
			float sizeZ,
			float u,
			float v,
			bool armorFlag = false,
			bool mirror = false,
			float scale = 0.0f
		) {
			this.type = type;
			this.posX = posX;
			this.posY = posY;
			this.posZ = posZ;
			this.sizeX = sizeX;
			this.sizeY = sizeY;
			this.sizeZ = sizeZ;
			this.u = u;
			this.v = v;
			this.armorFlag = armorFlag;
			this.mirror = mirror;
			this.scale = scale;
		}

		/** <summary>Constructs a SkinBOX from a 4J-format property string.</summary> **/
		public static SkinBOX FromString(string value) {
			var arguments = value.Split(' ');
			if(arguments.Length < 9) {
				throw new ArgumentException("Arguments must have at least a length of 9");
			}
			BOXType type = (BOXType)Enum.Parse(typeof(BOXType), arguments[0], true);
			var skinBox = new SkinBOX(
				type,
				float.Parse(arguments[1]), // posX
				float.Parse(arguments[2]), // posY
				float.Parse(arguments[3]), // posZ
				float.Parse(arguments[4]), // sizeX
				float.Parse(arguments[5]), // sizeY
				float.Parse(arguments[6]), // sizeZ
				float.Parse(arguments[7]), // u
				float.Parse(arguments[8])  // v
			);
			if(arguments.Length >= 10)
				skinBox.ArmorFlag = arguments[9] == "1";
			if(arguments.Length >= 11)
				skinBox.Mirror = arguments[10] == "1";
			if(arguments.Length >= 12) {
				float scale;
				float.TryParse(arguments[11], out scale);
				skinBox.Scale = scale;
			}
			return skinBox;
		}

		/** <summary>TODO: what does this do?</summary> **/
		public ValueTuple<string, string> ToProperty() {
			return new ValueTuple<string, string>("BOX", ToString());
		}

		/** <summary>Converts this SkinBOX to 4J's string property format.</summary> **/
		public override string ToString() {
			return
				$"{Type} {PosX} {PosY} {PosZ} {SizeX} {SizeY} {SizeZ} {U} {V} {Convert.ToInt32(ArmorFlag)} {Convert.ToInt32(Mirror)} {Scale}"
				.Replace(',', '.');
		}

		/** <summary>Calculates a hash code based on this SkinBOX's values.</summary> **/
		public override int GetHashCode() {
			return
				24 * type.GetHashCode() +
				24 * posX.GetHashCode() +
				24 * posY.GetHashCode() +
				24 * posZ.GetHashCode() +
				24 * sizeX.GetHashCode() +
				24 * sizeY.GetHashCode() +
				24 * sizeZ.GetHashCode() +
				24 * u.GetHashCode() +
				24 * v.GetHashCode();
		}

		/** <summary>Checks if this SkinBOX is equivalent to another.</summary> **/
		public override bool Equals(object obj) {
			return obj is SkinBOX box && Equals(box);
		}

		/** <summary>Checks if this SkinBOX is equivalent to another.</summary> **/
		public bool Equals(SkinBOX other) {
			return
				type.Equals(other.Type) &&
				posX.Equals(other.PosX) &&
				posY.Equals(other.PosY) &&
				posZ.Equals(other.PosZ) &&
				sizeX.Equals(other.SizeX) &&
				sizeY.Equals(other.SizeY) &&
				sizeZ.Equals(other.SizeZ) &&
				u.Equals(other.U) &&
				v.Equals(other.V);
		}

		/** <summary>Creates a copy of this SkinBOX.</summary> **/
		public object Clone() {
			return new SkinBOX(
				type,
				posX,
				posY,
				posZ,
				sizeX,
				sizeY,
				sizeZ,
				u,
				v,
				armorFlag,
				mirror,
				scale
			);
		}

		/** <summary>Fired whenever a property changes.</summary> **/
		private void NotifyPropertyChanged([CallerMemberName] string propertyName = "") {
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
