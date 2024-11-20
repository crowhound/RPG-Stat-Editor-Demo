using UnityEngine.UIElements;
using SF;

namespace SFEditor
{
    public abstract class DataView : BindableElement
    {
        protected Label _dataSectionHeader;
        protected const string DataSectionHeaderUSSClass = "data-section__header-label";
        protected DataView()
        {
            _dataSectionHeader = new Label();
            _dataSectionHeader.AddToClassList(DataSectionHeaderUSSClass);
        }
    }

    public abstract class DataView<TDataType> : BindableElement where TDataType : DTOBase
    {

        protected TDataType _value;
        public TDataType value
        {
            get => _value;
            set
            {
                if(value == this.value)
                    return;

                var previous = this.value;
                SetValueWithoutNotify(value);

                using(var evt = ChangeEvent<TDataType>.GetPooled(previous, value))
                {
                    evt.target = this;
                    SendEvent(evt);
                }
            }
        }

        protected Label _dataSectionHeader;
        protected const string DataSectionHeaderUSSClass = "data-section__header-label";
        protected DataView()
        {
            _dataSectionHeader = new Label();
            _dataSectionHeader.AddToClassList(DataSectionHeaderUSSClass);
        }

        public abstract void SetValueWithoutNotify(TDataType newValue);
    }
}
