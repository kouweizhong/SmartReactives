using SmartReactives.Common;

namespace SmartReactives.Test
{
    public class Source //: HasNotifyPropertyChanged
    {
        readonly ReactiveVariable<bool> woop = new ReactiveVariable<bool>();

        public bool Woop
        {
            get { return woop.Value; }
            set { woop.SetValueIfChanged(value); } //TODO sure about this?
        }

        public void FlipWoop()
        {
            Woop = !Woop;
        }
    }
}