<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmfees
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub
    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Dim a As New validation
        a.GridPropery(GridView1)

    End Sub
    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmfees))
        Me.grpfees = New DevExpress.XtraEditors.GroupControl
        Me.btnprint = New DevExpress.XtraEditors.SimpleButton
        Me.btnpprev = New DevExpress.XtraEditors.SimpleButton
        Me.lblamt = New System.Windows.Forms.Label
        Me.lblfeetype = New System.Windows.Forms.Label
        Me.lblstdno = New System.Windows.Forms.Label
        Me.lblclassno = New System.Windows.Forms.Label
        Me.lbltotal = New System.Windows.Forms.Label
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.txtamt = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.cmbfees = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.cmbstdno = New DevExpress.XtraEditors.ComboBoxEdit
        Me.cmbclsno = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.grdfees = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.class_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.std_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.dte = New DevExpress.XtraGrid.Columns.GridColumn
        Me.fee_type = New DevExpress.XtraGrid.Columns.GridColumn
        Me.amt = New DevExpress.XtraGrid.Columns.GridColumn
        Me.fees_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.btncancel = New DevExpress.XtraEditors.SimpleButton
        Me.btnreset = New DevExpress.XtraEditors.SimpleButton
        Me.btnedit = New DevExpress.XtraEditors.SimpleButton
        Me.btnsave = New DevExpress.XtraEditors.SimpleButton
        Me.btnadd = New DevExpress.XtraEditors.SimpleButton
        CType(Me.grpfees, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpfees.SuspendLayout()
        CType(Me.txtamt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbfees.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbstdno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbclsno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.grdfees, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpfees
        '
        Me.grpfees.Controls.Add(Me.btnprint)
        Me.grpfees.Controls.Add(Me.btnpprev)
        Me.grpfees.Controls.Add(Me.lblamt)
        Me.grpfees.Controls.Add(Me.lblfeetype)
        Me.grpfees.Controls.Add(Me.lblstdno)
        Me.grpfees.Controls.Add(Me.lblclassno)
        Me.grpfees.Controls.Add(Me.lbltotal)
        Me.grpfees.Controls.Add(Me.LabelControl5)
        Me.grpfees.Controls.Add(Me.txtamt)
        Me.grpfees.Controls.Add(Me.LabelControl4)
        Me.grpfees.Controls.Add(Me.cmbfees)
        Me.grpfees.Controls.Add(Me.LabelControl3)
        Me.grpfees.Controls.Add(Me.cmbstdno)
        Me.grpfees.Controls.Add(Me.cmbclsno)
        Me.grpfees.Controls.Add(Me.LabelControl2)
        Me.grpfees.Controls.Add(Me.LabelControl1)
        Me.grpfees.Location = New System.Drawing.Point(1, 1)
        Me.grpfees.Name = "grpfees"
        Me.grpfees.Size = New System.Drawing.Size(651, 120)
        Me.grpfees.TabIndex = 0
        Me.grpfees.Text = "Student Fees Management"
        '
        'btnprint
        '
        Me.btnprint.Image = Global.sms.My.Resources.Resources.Printer_icon
        Me.btnprint.Location = New System.Drawing.Point(596, 33)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(32, 32)
        Me.btnprint.TabIndex = 26
        '
        'btnpprev
        '
        Me.btnpprev.Image = Global.sms.My.Resources.Resources.document_print_preview
        Me.btnpprev.Location = New System.Drawing.Point(542, 33)
        Me.btnpprev.Name = "btnpprev"
        Me.btnpprev.Size = New System.Drawing.Size(32, 32)
        Me.btnpprev.TabIndex = 25
        '
        'lblamt
        '
        Me.lblamt.AutoSize = True
        Me.lblamt.Location = New System.Drawing.Point(495, 81)
        Me.lblamt.Name = "lblamt"
        Me.lblamt.Size = New System.Drawing.Size(0, 13)
        Me.lblamt.TabIndex = 24
        '
        'lblfeetype
        '
        Me.lblfeetype.AutoSize = True
        Me.lblfeetype.Location = New System.Drawing.Point(495, 42)
        Me.lblfeetype.Name = "lblfeetype"
        Me.lblfeetype.Size = New System.Drawing.Size(0, 13)
        Me.lblfeetype.TabIndex = 23
        '
        'lblstdno
        '
        Me.lblstdno.AutoSize = True
        Me.lblstdno.Location = New System.Drawing.Point(252, 81)
        Me.lblstdno.Name = "lblstdno"
        Me.lblstdno.Size = New System.Drawing.Size(0, 13)
        Me.lblstdno.TabIndex = 22
        '
        'lblclassno
        '
        Me.lblclassno.AutoSize = True
        Me.lblclassno.Location = New System.Drawing.Point(252, 42)
        Me.lblclassno.Name = "lblclassno"
        Me.lblclassno.Size = New System.Drawing.Size(0, 13)
        Me.lblclassno.TabIndex = 21
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Location = New System.Drawing.Point(574, 84)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(0, 13)
        Me.lbltotal.TabIndex = 20
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(542, 84)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(31, 13)
        Me.LabelControl5.TabIndex = 19
        Me.LabelControl5.Text = "Total :"
        '
        'txtamt
        '
        Me.txtamt.Location = New System.Drawing.Point(377, 79)
        Me.txtamt.Name = "txtamt"
        Me.txtamt.Size = New System.Drawing.Size(112, 20)
        Me.txtamt.TabIndex = 4
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(310, 82)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl4.TabIndex = 17
        Me.LabelControl4.Text = "Amount"
        '
        'cmbfees
        '
        Me.cmbfees.Location = New System.Drawing.Point(377, 40)
        Me.cmbfees.Name = "cmbfees"
        Me.cmbfees.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbfees.Properties.Items.AddRange(New Object() {"Admission Fee", "Semester Fee", "Tution Fee", "Exam Fee", "All In One Fee"})
        Me.cmbfees.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cmbfees.Size = New System.Drawing.Size(112, 20)
        Me.cmbfees.TabIndex = 3
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(309, 43)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl3.TabIndex = 15
        Me.LabelControl3.Text = "Fees Type"
        '
        'cmbstdno
        '
        Me.cmbstdno.Location = New System.Drawing.Point(127, 78)
        Me.cmbstdno.Name = "cmbstdno"
        Me.cmbstdno.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbstdno.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cmbstdno.Size = New System.Drawing.Size(118, 20)
        Me.cmbstdno.TabIndex = 2
        '
        'cmbclsno
        '
        Me.cmbclsno.Location = New System.Drawing.Point(127, 39)
        Me.cmbclsno.Name = "cmbclsno"
        Me.cmbclsno.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbclsno.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cmbclsno.Size = New System.Drawing.Size(118, 20)
        Me.cmbclsno.TabIndex = 1
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(53, 81)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl2.TabIndex = 12
        Me.LabelControl2.Text = "Student No"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(53, 42)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(41, 13)
        Me.LabelControl1.TabIndex = 11
        Me.LabelControl1.Text = "Class No"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.grdfees)
        Me.GroupControl2.Location = New System.Drawing.Point(1, 193)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(651, 322)
        Me.GroupControl2.TabIndex = 6
        Me.GroupControl2.Text = "Student Fees Management"
        '
        'grdfees
        '
        Me.grdfees.Location = New System.Drawing.Point(1, 20)
        Me.grdfees.MainView = Me.GridView1
        Me.grdfees.Name = "grdfees"
        Me.grdfees.Size = New System.Drawing.Size(650, 301)
        Me.grdfees.TabIndex = 0
        Me.grdfees.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.class_id, Me.std_id, Me.dte, Me.fee_type, Me.amt, Me.fees_id})
        Me.GridView1.GridControl = Me.grdfees
        Me.GridView1.Name = "GridView1"
        '
        'class_id
        '
        Me.class_id.Caption = "Class No"
        Me.class_id.FieldName = "class_id"
        Me.class_id.Name = "class_id"
        Me.class_id.Visible = True
        Me.class_id.VisibleIndex = 0
        '
        'std_id
        '
        Me.std_id.Caption = "Student ID"
        Me.std_id.FieldName = "std_id"
        Me.std_id.Name = "std_id"
        Me.std_id.Visible = True
        Me.std_id.VisibleIndex = 1
        '
        'dte
        '
        Me.dte.Caption = "Date"
        Me.dte.FieldName = "dte"
        Me.dte.Name = "dte"
        Me.dte.Visible = True
        Me.dte.VisibleIndex = 2
        '
        'fee_type
        '
        Me.fee_type.Caption = "Fees Type"
        Me.fee_type.FieldName = "fee_type"
        Me.fee_type.Name = "fee_type"
        Me.fee_type.Visible = True
        Me.fee_type.VisibleIndex = 3
        '
        'amt
        '
        Me.amt.Caption = "Amount"
        Me.amt.FieldName = "amt"
        Me.amt.Name = "amt"
        Me.amt.Visible = True
        Me.amt.VisibleIndex = 4
        '
        'fees_id
        '
        Me.fees_id.Caption = "GridColumn1"
        Me.fees_id.FieldName = "fees_id"
        Me.fees_id.Name = "fees_id"
        '
        'btncancel
        '
        Me.btncancel.Image = Global.sms.My.Resources.Resources.Delete1
        Me.btncancel.Location = New System.Drawing.Point(528, 141)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(69, 31)
        Me.btncancel.TabIndex = 5
        Me.btncancel.Text = "Cancel"
        '
        'btnreset
        '
        Me.btnreset.Image = Global.sms.My.Resources.Resources.reset
        Me.btnreset.Location = New System.Drawing.Point(416, 141)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(69, 31)
        Me.btnreset.TabIndex = 4
        Me.btnreset.Text = "Reset"
        '
        'btnedit
        '
        Me.btnedit.Image = Global.sms.My.Resources.Resources.Edit1
        Me.btnedit.Location = New System.Drawing.Point(298, 141)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(69, 31)
        Me.btnedit.TabIndex = 3
        Me.btnedit.Text = "Edit"
        '
        'btnsave
        '
        Me.btnsave.Image = Global.sms.My.Resources.Resources.Icon_Disk01_Blue
        Me.btnsave.Location = New System.Drawing.Point(181, 141)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(69, 31)
        Me.btnsave.TabIndex = 2
        Me.btnsave.Text = "Save"
        '
        'btnadd
        '
        Me.btnadd.Image = Global.sms.My.Resources.Resources.plus_27
        Me.btnadd.Location = New System.Drawing.Point(63, 141)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(69, 31)
        Me.btnadd.TabIndex = 1
        Me.btnadd.Text = "Add"
        '
        'frmfees
        '
        Me.AcceptButton = Me.btnsave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(654, 516)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnreset)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.grpfees)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmfees"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student Fees Management"
        CType(Me.grpfees, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpfees.ResumeLayout(False)
        Me.grpfees.PerformLayout()
        CType(Me.txtamt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbfees.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbstdno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbclsno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.grdfees, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpfees As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtamt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbfees As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbstdno As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cmbclsno As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grdfees As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btncancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnreset As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnedit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnsave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnadd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lbltotal As System.Windows.Forms.Label
    Friend WithEvents lblamt As System.Windows.Forms.Label
    Friend WithEvents lblfeetype As System.Windows.Forms.Label
    Friend WithEvents lblstdno As System.Windows.Forms.Label
    Friend WithEvents lblclassno As System.Windows.Forms.Label
    Friend WithEvents std_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents class_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dte As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fee_type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents amt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fees_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnprint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnpprev As DevExpress.XtraEditors.SimpleButton
End Class
