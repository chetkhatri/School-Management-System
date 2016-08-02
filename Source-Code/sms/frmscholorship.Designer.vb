<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmscholorship
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmscholorship))
        Me.grpscholor = New DevExpress.XtraEditors.GroupControl
        Me.lblamt = New System.Windows.Forms.Label
        Me.lblscholortype = New System.Windows.Forms.Label
        Me.lblstdno = New System.Windows.Forms.Label
        Me.lblclsno = New System.Windows.Forms.Label
        Me.lbltotal = New System.Windows.Forms.Label
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.txtamt = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.cmbscholor = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.cmbstdno = New DevExpress.XtraEditors.ComboBoxEdit
        Me.cmbclsno = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.grdscholor = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.class_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.std_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.sch_type = New DevExpress.XtraGrid.Columns.GridColumn
        Me.amt = New DevExpress.XtraGrid.Columns.GridColumn
        Me.dte = New DevExpress.XtraGrid.Columns.GridColumn
        Me.sch_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.btncancel = New DevExpress.XtraEditors.SimpleButton
        Me.btnreset = New DevExpress.XtraEditors.SimpleButton
        Me.btnedit = New DevExpress.XtraEditors.SimpleButton
        Me.btnsave = New DevExpress.XtraEditors.SimpleButton
        Me.btnadd = New DevExpress.XtraEditors.SimpleButton
        CType(Me.grpscholor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpscholor.SuspendLayout()
        CType(Me.txtamt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbscholor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbstdno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbclsno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.grdscholor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpscholor
        '
        Me.grpscholor.Controls.Add(Me.lblamt)
        Me.grpscholor.Controls.Add(Me.lblscholortype)
        Me.grpscholor.Controls.Add(Me.lblstdno)
        Me.grpscholor.Controls.Add(Me.lblclsno)
        Me.grpscholor.Controls.Add(Me.lbltotal)
        Me.grpscholor.Controls.Add(Me.LabelControl5)
        Me.grpscholor.Controls.Add(Me.txtamt)
        Me.grpscholor.Controls.Add(Me.LabelControl9)
        Me.grpscholor.Controls.Add(Me.cmbscholor)
        Me.grpscholor.Controls.Add(Me.LabelControl8)
        Me.grpscholor.Controls.Add(Me.cmbstdno)
        Me.grpscholor.Controls.Add(Me.cmbclsno)
        Me.grpscholor.Controls.Add(Me.LabelControl6)
        Me.grpscholor.Controls.Add(Me.LabelControl7)
        Me.grpscholor.Location = New System.Drawing.Point(1, 1)
        Me.grpscholor.Name = "grpscholor"
        Me.grpscholor.Size = New System.Drawing.Size(653, 125)
        Me.grpscholor.TabIndex = 0
        Me.grpscholor.Text = "Student Scholorship Management"
        '
        'lblamt
        '
        Me.lblamt.AutoSize = True
        Me.lblamt.Location = New System.Drawing.Point(523, 87)
        Me.lblamt.Name = "lblamt"
        Me.lblamt.Size = New System.Drawing.Size(0, 13)
        Me.lblamt.TabIndex = 37
        '
        'lblscholortype
        '
        Me.lblscholortype.AutoSize = True
        Me.lblscholortype.Location = New System.Drawing.Point(523, 46)
        Me.lblscholortype.Name = "lblscholortype"
        Me.lblscholortype.Size = New System.Drawing.Size(0, 13)
        Me.lblscholortype.TabIndex = 36
        '
        'lblstdno
        '
        Me.lblstdno.AutoSize = True
        Me.lblstdno.Location = New System.Drawing.Point(240, 84)
        Me.lblstdno.Name = "lblstdno"
        Me.lblstdno.Size = New System.Drawing.Size(0, 13)
        Me.lblstdno.TabIndex = 35
        '
        'lblclsno
        '
        Me.lblclsno.AutoSize = True
        Me.lblclsno.Location = New System.Drawing.Point(240, 47)
        Me.lblclsno.Name = "lblclsno"
        Me.lblclsno.Size = New System.Drawing.Size(0, 13)
        Me.lblclsno.TabIndex = 34
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Location = New System.Drawing.Point(598, 65)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(0, 13)
        Me.lbltotal.TabIndex = 33
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(557, 64)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(31, 13)
        Me.LabelControl5.TabIndex = 32
        Me.LabelControl5.Text = "Total :"
        '
        'txtamt
        '
        Me.txtamt.Location = New System.Drawing.Point(397, 80)
        Me.txtamt.Name = "txtamt"
        Me.txtamt.Size = New System.Drawing.Size(120, 20)
        Me.txtamt.TabIndex = 4
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(300, 83)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl9.TabIndex = 31
        Me.LabelControl9.Text = "Amount"
        '
        'cmbscholor
        '
        Me.cmbscholor.Location = New System.Drawing.Point(397, 43)
        Me.cmbscholor.Name = "cmbscholor"
        Me.cmbscholor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbscholor.Properties.Items.AddRange(New Object() {"S.T", "S.C", "S.E.B.C", "Other"})
        Me.cmbscholor.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cmbscholor.Size = New System.Drawing.Size(120, 20)
        Me.cmbscholor.TabIndex = 3
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(300, 46)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(81, 13)
        Me.LabelControl8.TabIndex = 29
        Me.LabelControl8.Text = "Scholorship Type"
        '
        'cmbstdno
        '
        Me.cmbstdno.Location = New System.Drawing.Point(119, 80)
        Me.cmbstdno.Name = "cmbstdno"
        Me.cmbstdno.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbstdno.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cmbstdno.Size = New System.Drawing.Size(115, 20)
        Me.cmbstdno.TabIndex = 2
        '
        'cmbclsno
        '
        Me.cmbclsno.Location = New System.Drawing.Point(119, 43)
        Me.cmbclsno.Name = "cmbclsno"
        Me.cmbclsno.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbclsno.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cmbclsno.Size = New System.Drawing.Size(115, 20)
        Me.cmbclsno.TabIndex = 1
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(50, 83)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl6.TabIndex = 26
        Me.LabelControl6.Text = "Student No"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(50, 46)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(41, 13)
        Me.LabelControl7.TabIndex = 25
        Me.LabelControl7.Text = "Class No"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.grdscholor)
        Me.GroupControl2.Location = New System.Drawing.Point(1, 194)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(653, 322)
        Me.GroupControl2.TabIndex = 7
        Me.GroupControl2.Text = "Student Scholorship Management"
        '
        'grdscholor
        '
        Me.grdscholor.Location = New System.Drawing.Point(1, 20)
        Me.grdscholor.MainView = Me.GridView1
        Me.grdscholor.Name = "grdscholor"
        Me.grdscholor.Size = New System.Drawing.Size(650, 301)
        Me.grdscholor.TabIndex = 0
        Me.grdscholor.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.class_id, Me.std_id, Me.sch_type, Me.amt, Me.dte, Me.sch_id})
        Me.GridView1.GridControl = Me.grdscholor
        Me.GridView1.Name = "GridView1"
        '
        'class_id
        '
        Me.class_id.Caption = "Class ID"
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
        'sch_type
        '
        Me.sch_type.Caption = "Scholorship Type"
        Me.sch_type.FieldName = "sch_type"
        Me.sch_type.Name = "sch_type"
        Me.sch_type.Visible = True
        Me.sch_type.VisibleIndex = 2
        '
        'amt
        '
        Me.amt.Caption = "Amount"
        Me.amt.FieldName = "amt"
        Me.amt.Name = "amt"
        Me.amt.Visible = True
        Me.amt.VisibleIndex = 3
        '
        'dte
        '
        Me.dte.Caption = "Date"
        Me.dte.FieldName = "dte"
        Me.dte.Name = "dte"
        Me.dte.Visible = True
        Me.dte.VisibleIndex = 4
        '
        'sch_id
        '
        Me.sch_id.Caption = "GridColumn6"
        Me.sch_id.FieldName = "sch_id"
        Me.sch_id.Name = "sch_id"
        '
        'btncancel
        '
        Me.btncancel.Image = Global.sms.My.Resources.Resources.Delete1
        Me.btncancel.Location = New System.Drawing.Point(524, 145)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(69, 31)
        Me.btncancel.TabIndex = 6
        Me.btncancel.Text = "Cancel"
        '
        'btnreset
        '
        Me.btnreset.Image = Global.sms.My.Resources.Resources.reset
        Me.btnreset.Location = New System.Drawing.Point(412, 145)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(69, 31)
        Me.btnreset.TabIndex = 5
        Me.btnreset.Text = "Reset"
        '
        'btnedit
        '
        Me.btnedit.Image = Global.sms.My.Resources.Resources.Edit1
        Me.btnedit.Location = New System.Drawing.Point(294, 145)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(69, 31)
        Me.btnedit.TabIndex = 4
        Me.btnedit.Text = "Edit"
        '
        'btnsave
        '
        Me.btnsave.Image = Global.sms.My.Resources.Resources.Icon_Disk01_Blue
        Me.btnsave.Location = New System.Drawing.Point(177, 145)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(69, 31)
        Me.btnsave.TabIndex = 3
        Me.btnsave.Text = "Save"
        '
        'btnadd
        '
        Me.btnadd.Image = Global.sms.My.Resources.Resources.plus_27
        Me.btnadd.Location = New System.Drawing.Point(59, 145)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(69, 31)
        Me.btnadd.TabIndex = 2
        Me.btnadd.Text = "Add"
        '
        'frmscholorship
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(654, 516)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnreset)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.grpscholor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmscholorship"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student Scholorship Management"
        CType(Me.grpscholor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpscholor.ResumeLayout(False)
        Me.grpscholor.PerformLayout()
        CType(Me.txtamt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbscholor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbstdno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbclsno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.grdscholor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpscholor As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtamt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbscholor As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbstdno As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cmbclsno As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grdscholor As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btncancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnreset As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnedit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnsave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnadd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lbltotal As System.Windows.Forms.Label
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblscholortype As System.Windows.Forms.Label
    Friend WithEvents lblstdno As System.Windows.Forms.Label
    Friend WithEvents lblclsno As System.Windows.Forms.Label
    Friend WithEvents lblamt As System.Windows.Forms.Label
    Friend WithEvents std_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents class_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sch_type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents amt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dte As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sch_id As DevExpress.XtraGrid.Columns.GridColumn
End Class
