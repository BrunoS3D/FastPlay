using System;
using UnityEngine;

namespace FastPlay.Runtime {
	[BuiltInNode]
	[Name("DelayedUpdate")]
	[Path("Events/Utilities/DelayedUpdate")]
	[Body("DelayedUpdate")]
	public class DelayedUpdateEvent : EventNode, IUpdate, IRegisterPorts {

		private float time;
		public InputValue<float> seconds;

		public void OnRegisterPorts() {
			seconds = RegisterInputValue<float>("Seconds", 3.0f);
		}

		public void Update() {
			time += Time.deltaTime;
			if (time >= seconds.value) {
				time = 0.0f;
				Call(output);
			}
		}
	}
}
