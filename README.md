# How to show onscreen keyboard while editing a cell in WinForms DataGrid?

## About the example

This example illustrates how to show onscreen keyboard while editing a cell in WinForms DataGrid.

In [WinForms DataGrid](https://www.syncfusion.com/winforms-ui-controls/datagrid) (SfDataGrid), the on-screen keyboard can be launched programmatically through the [CurrentCellBeginEdit](https://help.syncfusion.com/cr/windowsforms/Syncfusion.WinForms.DataGrid.SfDataGrid.html?_gl=1*1325pyh*_ga*ODQzMzc0ODE1LjE3NDcyMzc2Mjg.*_ga_41J4HFMX1J*czE3NTQ5MDQ2ODckbzIzNyRnMSR0MTc1NDkxMzgyNiRqNjAkbDAkaDA.#Syncfusion_WinForms_DataGrid_SfDataGrid_CurrentCellBeginEdit) event while editing a cell.

### C#
```c#
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
### VB
```vb
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
