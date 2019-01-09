using UnityEngine;

namespace FastPlay.Runtime {
	[BuiltInNode]
	[Name("Subtract")]
	[Path("Functions/Operation/Float/Subtract")]
	[Body("Subtract", "Float")]
	public class FloatSubtract : ValueNode<float>, IRegisterPorts {

		public InputValue<float> a, b;

		protected override string getDefaultName { get { return "A - B"; } }

		public void OnRegisterPorts() {
			a = RegisterInputValue<float>("A");
			b = RegisterInputValue<float>("B");
		}

		public override float OnGetValue() {
			return a.value - b.value;
		}
	}
}
