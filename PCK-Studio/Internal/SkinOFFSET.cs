using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PckStudio.Internal {
	/** <summary>Valid offset type values used in SkinOFFSET.</summary> **/
	public enum OFFSETType {
		// Body Offsets
		HEAD,
		BODY,
		ARM0,
		ARM1,
		LEG0,
		LEG1,
		// Armor Offsets
		HELMET,
		CHEST, BODYARMOR,
		SHOULDER0, ARMARMOR0,
		SHOULDER1, ARMARMOR1,
		BELT,
		LEGGING0,
		LEGGING1,
		SOCK0, BOOT0,
		SOCK1, BOOT1,
		TOOL0,
		TOOL1,
	};

	/** <summary>Defines Y offsets for custom skins.</summary> **/
	public class SkinOFFSET {
		public OFFSETType Name;
		public float YOffset;

		public SkinOFFSET(OFFSETType name, float yOffset) {
			Name = name;
			YOffset = yOffset;
		}

		public (string, string) ToProperty() {
			string value = $"{Name} Y {YOffset}";
			return ("OFFSET", value.Replace(',', '.'));
		}
	}
}
