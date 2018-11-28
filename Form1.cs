#region Copyright Syncfusion Inc. 2001-2018.
// Copyright Syncfusion Inc. 2001-2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.WinForms.Controls;
using Syncfusion.WinForms.DataGrid.Styles;
using System.Windows.Forms;
using Syncfusion.WinForms.DataGrid.Enums;
using Syncfusion.WinForms.DataGrid.Events;

namespace GettingStarted
{
    public partial class Form1 : Form
    {
        #region Constructor
        public Form1()
        {
            InitializeComponent();
            var data = new OrderInfoCollection();
            sfDataGrid.DataSource = data.OrdersListDetails;

            this.sfDataGrid.CurrentCellBeginEdit += sfDataGrid1_CurrentCellBeginEdit;
            this.sfDataGrid.CurrentCellEndEdit += sfDataGrid1_CurrentCellEndEdit;

        }


        System.Diagnostics.Process process;
        void sfDataGrid1_CurrentCellEndEdit(object sender, CurrentCellEndEditEventArgs e)
        {
            if (!process.HasExited)
                process.Kill();
        }

        void sfDataGrid1_CurrentCellBeginEdit(object sender, CurrentCellBeginEditEventArgs e)
        {
            process = System.Diagnostics.Process.Start("Osk.exe");
        }

        #endregion
    }
}
