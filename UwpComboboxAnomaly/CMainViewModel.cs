namespace UwpComboboxAnomaly
{
    class CMainViewModel : CBindableBase
    {

        private int m_SelectedIndex = 0;

        public int SelectedIndex
        {
            get => m_SelectedIndex;
            set => SetProperty(ref m_SelectedIndex, value);
        }

        private string m_EventResult;

        public string EventResult
        {
            get => m_EventResult;
            set => SetProperty(ref m_EventResult, value);
        }


    }
}
