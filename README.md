# How to show onscreen keyboard in tablet device while editing a cell in WinForms DataGrid (SfDataGrid)
 
## Show onscreen keyboard
Programmatically launch the on-screen keyboard to open it through [SfDataGrid.CurrentCellBeginEdit](https://help.syncfusion.com/cr/windowsforms/Syncfusion.WinForms.DataGrid.SfDataGrid.html) event when you begin editing in a cell.

## C#

```C#
this.sfDataGrid.CurrentCellBeginEdit += sfDataGrid1_CurrentCellBeginEdit;
this.sfDataGrid.CurrentCellEndEdit += sfDataGrid1_CurrentCellEndEdit;
 
System.Diagnostics.Process process;
void sfDataGrid1_CurrentCellBeginEdit(object sender, CurrentCellBeginEditEventArgs e)
{
    process = System.Diagnostics.Process.Start("Osk.exe");
}
 
void sfDataGrid1_CurrentCellEndEdit(object sender, CurrentCellEndEditEventArgs e)
{
    if (!process.HasExited)
        process.Kill();
}
```

## VB

```VB
AddHandler Me.sfDataGrid.CurrentCellBeginEdit, AddressOf sfDataGrid1_CurrentCellBeginEdit
AddHandler Me.sfDataGrid.CurrentCellEndEdit, AddressOf sfDataGrid1_CurrentCellEndEdit
 
Private process As System.Diagnostics.Process
Private Sub sfDataGrid1_CurrentCellBeginEdit(ByVal sender As Object, ByVal e As CurrentCellBeginEditEventArgs)
    process = System.Diagnostics.Process.Start("Osk.exe")
End Sub
 
Private Sub sfDataGrid1_CurrentCellEndEdit(ByVal sender As Object, ByVal e As CurrentCellEndEditEventArgs)
    If Not process.HasExited Then
       process.Kill()
    End If
End Sub
```