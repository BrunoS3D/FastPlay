using System;
using UnityEngine;

namespace FastPlay.Runtime {
	[BuiltInNode]
	[Icon("update_event_icon")]
	[Title("FixedUpdate")]
	[Path("Events/Lifecycle/FixedUpdate")]
	[Summary("Frame-rate independent MonoBehaviour.FixedUpdate message for physics calculations.")]
	public class FixedUpdateEvent : EventNode, IRegisterEvents {

		public void OnRegisterEvents() {
			Current.controller.DoFixedUpdate += FixedUpdate;
		}

		public void OnRemoveEvents() {
			Current.controller.DoFixedUpdate -= FixedUpdate;
		}

		public void FixedUpdate() {
			Call(output);
		}
	}
}
