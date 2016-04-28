﻿using SmartReactives.Postsharp.NotifyPropertyChanged;
using SmartReactives.Test.Reactive.Postsharp;

namespace SmartReactives.Test.Reactive
{
	class EfficientMode : HasNotifyPropertyChanged
	{
		[SmartNotifyPropertyChangedVariable]
		public bool DependentWithSetter
		{
			get { return Source; }
			set { Source = value; }
		}

		[SmartNotifyPropertyChangedExpression]
		public bool Dependent => Source;

		[SmartNotifyPropertyChangedVariable]
		public bool Source { get; set; }
	}
}