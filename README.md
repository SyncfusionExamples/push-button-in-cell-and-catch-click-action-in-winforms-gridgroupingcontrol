 # How to use a PushButton in a cell and catch the user clicking it in WinForms GridGroupingControl?

 Use the **CellType** property to set a **PushButton** in a cell, and use the **TableControlPushButtonClick** event to get the button click action.

### C#
```csharp
//To set PushButton.
this.gridGroupingControl1.TableDescriptor.Columns["Description"].Appearance.AddNewRecordFieldCell.CellType = GridCellTypeName.PushButton;
this.gridGroupingControl1.TableDescriptor.Columns["Description"].Appearance.AddNewRecordFieldCell.Description = "PushButton";

//Event Subscription
this.gridGroupingControl1.TableControlPushButtonClick += new GridTableControlCellPushButtonClickEventHandler(gridGroupingControl1_TableControlPushButtonClick);

//Event Customization
void gridGroupingControl1_TableControlPushButtonClick(object sender, GridTableControlCellPushButtonClickEventArgs e)
{
    string s = string.Format("You clicked ({0},{1}).", e.Inner.RowIndex, e.Inner.ColIndex);
    MessageBox.Show(s);
}
```

### VB
```vb
'To set PushButton.
Me.gridGroupingControl1.TableDescriptor.Columns(2).Appearance.AddNewRecordFieldCell.CellType = GridCellTypeName.PushButton
Me.gridGroupingControl1.TableDescriptor.Columns(2).Appearance.AddNewRecordFieldCell.Description = "PushButton"

 'Event subscription
AddHandler gridGroupingControl1.TableControlPushButtonClick, AddressOf gridGroupingControl1_TableControlPushButtonClick
 
'Event Customization
Private Sub gridGroupingControl1_TableControlPushButtonClick(ByVal sender As Object, ByVal e As GridTableControlCellPushButtonClickEventArgs)
 Dim s As String = String.Format("You clicked ({0},{1}).", e.Inner.RowIndex, e.Inner.ColIndex)
 MessageBox.Show(s)
End Sub
```