using UnityEngine;

namespace FastPlay.Runtime {
	[BuiltInNode]
	[Name("Divide")]
	[Path("Functions/Operation/Vector4/Divide")]
	[Body("Divide", "Vector4")]
	public class Vector4Divide : ValueNode<Vector4>, IRegisterPorts {

		public InputValue<Vector4> vector;

		public InputValue<float> factor;

		protected override string getDefaultName { get { return "Vector4 / Factor"; } }

		public void OnRegisterPorts() {
			vector = RegisterInputValue<Vector4>("Vector4");
			factor = RegisterInputValue<float>("Factor");
		}

		public override Vector4 OnGetValue() {
			return vector.value / factor.value;
		}
	}
}
