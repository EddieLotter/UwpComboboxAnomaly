# UwpComboboxAnomaly
A demonstration of inconsistent behavior in the UWP Combobox.

This project reproduces an issue where the SelectionChanged event of the Combobox exhibits inconsistent behavior depending on how you interact with the control.

The bottom line of the form shows two values that are accessed in the SelectionChanged event. The combobox's SelectedIndex property and the data model's SelectIndex property, which is bound to the combobox's SelectedIndex property in XAML.
If you use *touch* or a *pointer* to change the combobox selection, these two values are the same in the event handler. However, if you use the *keyboard* to change the selection, these two values are **not** the same.

It shouldn't matter how you interact with the control. The two values in the event handler should be consistent. Either they should always be the same or never be the same.
