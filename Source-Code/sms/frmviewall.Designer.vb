<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmviewall
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmviewall))
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.txtyear = New DevExpress.XtraEditors.TextEdit
        Me.cmbempid = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.cmbmonth = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.txtempname = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.grdsal = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.emp_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.f_name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.dte = New DevExpress.XtraGrid.Columns.GridColumn
        Me.month = New DevExpress.XtraGrid.Columns.GridColumn
        Me.year = New DevExpress.XtraGrid.Columns.GridColumn
        Me.attend = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tax = New DevExpress.XtraGrid.Columns.GridColumn
        Me.basic = New DevExpress.XtraGrid.Columns.GridColumn
        Me.deduction = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gross = New DevExpress.XtraGrid.Columns.GridColumn
        Me.net_sal = New DevExpress.XtraGrid.Columns.GridColumn
        Me.btnpprev = New DevExpress.XtraEditors.SimpleButton
        Me.btnsearch = New DevExpress.XtraEditors.SimpleButton
        Me.btnprint = New DevExpress.XtraEditors.SimpleButton
        Me.btncancel = New DevExpress.XtraEditors.SimpleButton
        Me.btnreset = New DevExpress.XtraEditors.SimpleButton
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtyear.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbempid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbmonth.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtempname.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.grdsal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.txtyear)
        Me.GroupControl1.Controls.Add(Me.cmbempid)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.cmbmonth)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.txtempname)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(887, 114)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Employee HRM Advance LookUp"
        '
        'txtyear
        '
        Me.txtyear.Location = New System.Drawing.Point(567, 76)
        Me.txtyear.Name = "txtyear"
        Me.txtyear.Properties.MaxLength = 4
        Me.txtyear.Size = New System.Drawing.Size(100, 20)
        Me.txtyear.TabIndex = 4
        '
        'cmbempid
        '
        Me.cmbempid.Location = New System.Drawing.Point(289, 36)
        Me.cmbempid.Name = "cmbempid"
        Me.cmbempid.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbempid.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cmbempid.Size = New System.Drawing.Size(100, 20)
        Me.cmbempid.TabIndex = 1
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(523, 81)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(22, 13)
        Me.LabelControl4.TabIndex = 6
        Me.LabelControl4.Text = "Year"
        '
        'cmbmonth
        '
        Me.cmbmonth.Location = New System.Drawing.Point(567, 36)
        Me.cmbmonth.Name = "cmbmonth"
        Me.cmbmonth.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbmonth.Properties.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.cmbmonth.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cmbmonth.Size = New System.Drawing.Size(100, 20)
        Me.cmbmonth.TabIndex = 3
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(523, 39)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(30, 13)
        Me.LabelControl3.TabIndex = 4
        Me.LabelControl3.Text = "Month"
        '
        'txtempname
        '
        Me.txtempname.Location = New System.Drawing.Point(289, 75)
        Me.txtempname.Name = "txtempname"
        Me.txtempname.Size = New System.Drawing.Size(100, 20)
        Me.txtempname.TabIndex = 1
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(203, 78)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(76, 13)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "Employee Name"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(203, 40)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(60, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Employee ID"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.grdsal)
        Me.GroupControl2.Location = New System.Drawing.Point(2, 185)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(885, 329)
        Me.GroupControl2.TabIndex = 6
        Me.GroupControl2.Text = "Employee HRM Information"
        '
        'grdsal
        '
        Me.grdsal.Location = New System.Drawing.Point(0, 20)
        Me.grdsal.MainView = Me.GridView1
        Me.grdsal.Name = "grdsal"
        Me.grdsal.Size = New System.Drawing.Size(885, 309)
        Me.grdsal.TabIndex = 0
        Me.grdsal.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.emp_id, Me.f_name, Me.dte, Me.month, Me.year, Me.attend, Me.tax, Me.basic, Me.deduction, Me.gross, Me.net_sal})
        Me.GridView1.GridControl = Me.grdsal
        Me.GridView1.Name = "GridView1"
        '
        'emp_id
        '
        Me.emp_id.Caption = "Employee ID"
        Me.emp_id.FieldName = "emp_id"
        Me.emp_id.Name = "emp_id"
        Me.emp_id.Visible = True
        Me.emp_id.VisibleIndex = 0
        '
        'f_name
        '
        Me.f_name.Caption = "Name"
        Me.f_name.FieldName = "f_name"
        Me.f_name.Name = "f_name"
        Me.f_name.Visible = True
        Me.f_name.VisibleIndex = 1
        '
        'dte
        '
        Me.dte.Caption = "Date"
        Me.dte.FieldName = "dte"
        Me.dte.Name = "dte"
        Me.dte.Visible = True
        Me.dte.VisibleIndex = 2
        '
        'month
        '
        Me.month.Caption = "Month"
        Me.month.FieldName = "month"
        Me.month.Name = "month"
        Me.month.Visible = True
        Me.month.VisibleIndex = 3
        '
        'year
        '
        Me.year.Caption = "Year"
        Me.year.FieldName = "year"
        Me.year.Name = "year"
        Me.year.Visible = True
        Me.year.VisibleIndex = 4
        '
        'attend
        '
        Me.attend.Caption = "Attend"
        Me.attend.FieldName = "attend"
        Me.attend.Name = "attend"
        Me.attend.Visible = True
        Me.attend.VisibleIndex = 5
        '
        'tax
        '
        Me.tax.Caption = "Method"
        Me.tax.FieldName = "tax"
        Me.tax.Name = "tax"
        Me.tax.Visible = True
        Me.tax.VisibleIndex = 6
        '
        'basic
        '
        Me.basic.Caption = "Basic"
        Me.basic.FieldName = "basic"
        Me.basic.Name = "basic"
        Me.basic.Visible = True
        Me.basic.VisibleIndex = 7
        '
        'deduction
        '
        Me.deduction.Caption = "Deduction"
        Me.deduction.FieldName = "deduction"
        Me.deduction.Name = "deduction"
        Me.deduction.Visible = True
        Me.deduction.VisibleIndex = 8
        '
        'gross
        '
        Me.gross.Caption = "Gross"
        Me.gross.FieldName = "gross"
        Me.gross.Name = "gross"
        Me.gross.Visible = True
        Me.gross.VisibleIndex = 9
        '
        'net_sal
        '
        Me.net_sal.Caption = "Net"
        Me.net_sal.FieldName = "net_sal"
        Me.net_sal.Name = "net_sal"
        Me.net_sal.Visible = True
        Me.net_sal.VisibleIndex = 10
        '
        'btnpprev
        '
        Me.btnpprev.Image = Global.sms.My.Resources.Resources.document_print_preview
        Me.btnpprev.Location = New System.Drawing.Point(91, 134)
        Me.btnpprev.Name = "btnpprev"
        Me.btnpprev.Size = New System.Drawing.Size(106, 31)
        Me.btnpprev.TabIndex = 1
        Me.btnpprev.Text = "Print Preview"
        '
        'btnsearch
        '
        Me.btnsearch.Image = Global.sms.My.Resources.Resources.p_search_icon
        Me.btnsearch.Location = New System.Drawing.Point(423, 134)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(73, 31)
        Me.btnsearch.TabIndex = 3
        Me.btnsearch.Text = "Search"
        '
        'btnprint
        '
        Me.btnprint.Image = Global.sms.My.Resources.Resources.Printer_icon
        Me.btnprint.Location = New System.Drawing.Point(268, 134)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(73, 31)
        Me.btnprint.TabIndex = 2
        Me.btnprint.Text = "Print"
        '
        'btncancel
        '
        Me.btncancel.Image = Global.sms.My.Resources.Resources.Delete2
        Me.btncancel.Location = New System.Drawing.Point(726, 134)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(73, 31)
        Me.btncancel.TabIndex = 5
        Me.btncancel.Text = "Cancel"
        '
        'btnreset
        '
        Me.btnreset.Image = Global.sms.My.Resources.Resources.reset2
        Me.btnreset.Location = New System.Drawing.Point(572, 134)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(73, 31)
        Me.btnreset.TabIndex = 4
        Me.btnreset.Text = "Reset"
        '
        'frmviewall
        '
        Me.AcceptButton = Me.btnsearch
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(888, 515)
        Me.Controls.Add(Me.btnpprev)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.btnprint)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnreset)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmviewall"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee Salary LookUp"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txtyear.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbempid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbmonth.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtempname.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.grdsal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbmonth As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtempname As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grdsal As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnpprev As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnsearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnprint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btncancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnreset As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtyear As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmbempid As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents emp_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents f_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dte As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents month As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents year As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents attend As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tax As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents basic As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents deduction As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gross As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents net_sal As DevExpress.XtraGrid.Columns.GridColumn
End Class
