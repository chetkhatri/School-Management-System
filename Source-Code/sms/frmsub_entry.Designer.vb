<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmsub_entry
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmsub_entry))
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.btnadd = New DevExpress.XtraEditors.SimpleButton
        Me.btncancel = New DevExpress.XtraEditors.SimpleButton
        Me.btnedit = New DevExpress.XtraEditors.SimpleButton
        Me.btnsave = New DevExpress.XtraEditors.SimpleButton
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl
        Me.grdsub = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.s_name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.s_code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.sub_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.sem_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.lblsem = New System.Windows.Forms.Label
        Me.cmbsem = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.lblsubcode = New System.Windows.Forms.Label
        Me.lblsubname = New System.Windows.Forms.Label
        Me.txtsubcode = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.txtsubname = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.grdsub, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.cmbsem.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtsubcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtsubname.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.btnadd)
        Me.GroupControl1.Controls.Add(Me.btncancel)
        Me.GroupControl1.Controls.Add(Me.btnedit)
        Me.GroupControl1.Controls.Add(Me.btnsave)
        Me.GroupControl1.Controls.Add(Me.GroupControl3)
        Me.GroupControl1.Controls.Add(Me.GroupControl2)
        Me.GroupControl1.Location = New System.Drawing.Point(1, 1)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(355, 310)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Subject LookUp"
        '
        'btnadd
        '
        Me.btnadd.Image = Global.sms.My.Resources.Resources.plus_27
        Me.btnadd.Location = New System.Drawing.Point(11, 124)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(69, 31)
        Me.btnadd.TabIndex = 3
        Me.btnadd.Text = "Add"
        '
        'btncancel
        '
        Me.btncancel.Image = Global.sms.My.Resources.Resources.Delete
        Me.btncancel.Location = New System.Drawing.Point(274, 124)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(69, 31)
        Me.btncancel.TabIndex = 6
        Me.btncancel.Text = "Cancel"
        '
        'btnedit
        '
        Me.btnedit.Image = Global.sms.My.Resources.Resources.Edit
        Me.btnedit.Location = New System.Drawing.Point(190, 124)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(69, 31)
        Me.btnedit.TabIndex = 5
        Me.btnedit.Text = "Edit"
        '
        'btnsave
        '
        Me.btnsave.Image = Global.sms.My.Resources.Resources.Icon_Disk01_Blue
        Me.btnsave.Location = New System.Drawing.Point(101, 124)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(69, 31)
        Me.btnsave.TabIndex = 4
        Me.btnsave.Text = "Save"
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.grdsub)
        Me.GroupControl3.Location = New System.Drawing.Point(1, 168)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(354, 142)
        Me.GroupControl3.TabIndex = 3
        Me.GroupControl3.Text = "Subject Information"
        '
        'grdsub
        '
        Me.grdsub.Location = New System.Drawing.Point(2, 20)
        Me.grdsub.MainView = Me.GridView1
        Me.grdsub.Name = "grdsub"
        Me.grdsub.Size = New System.Drawing.Size(350, 120)
        Me.grdsub.TabIndex = 0
        Me.grdsub.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.s_name, Me.s_code, Me.sub_id, Me.sem_id})
        Me.GridView1.GridControl = Me.grdsub
        Me.GridView1.Name = "GridView1"
        '
        's_name
        '
        Me.s_name.Caption = "Subject Name"
        Me.s_name.FieldName = "s_name"
        Me.s_name.Name = "s_name"
        Me.s_name.Visible = True
        Me.s_name.VisibleIndex = 0
        '
        's_code
        '
        Me.s_code.Caption = "Subject Code"
        Me.s_code.FieldName = "s_code"
        Me.s_code.Name = "s_code"
        Me.s_code.Visible = True
        Me.s_code.VisibleIndex = 1
        '
        'sub_id
        '
        Me.sub_id.Caption = "s_id"
        Me.sub_id.FieldName = "sub_id"
        Me.sub_id.Name = "sub_id"
        Me.sub_id.Visible = True
        Me.sub_id.VisibleIndex = 2
        '
        'sem_id
        '
        Me.sem_id.Caption = "Semester"
        Me.sem_id.FieldName = "sem_id"
        Me.sem_id.Name = "sem_id"
        Me.sem_id.Visible = True
        Me.sem_id.VisibleIndex = 3
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.lblsem)
        Me.GroupControl2.Controls.Add(Me.cmbsem)
        Me.GroupControl2.Controls.Add(Me.LabelControl3)
        Me.GroupControl2.Controls.Add(Me.lblsubcode)
        Me.GroupControl2.Controls.Add(Me.lblsubname)
        Me.GroupControl2.Controls.Add(Me.txtsubcode)
        Me.GroupControl2.Controls.Add(Me.LabelControl2)
        Me.GroupControl2.Controls.Add(Me.txtsubname)
        Me.GroupControl2.Controls.Add(Me.LabelControl1)
        Me.GroupControl2.Location = New System.Drawing.Point(1, 19)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.ShowCaption = False
        Me.GroupControl2.Size = New System.Drawing.Size(354, 90)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "GroupControl2"
        '
        'lblsem
        '
        Me.lblsem.AutoSize = True
        Me.lblsem.Location = New System.Drawing.Point(336, 20)
        Me.lblsem.Name = "lblsem"
        Me.lblsem.Size = New System.Drawing.Size(0, 13)
        Me.lblsem.TabIndex = 8
        '
        'cmbsem
        '
        Me.cmbsem.Location = New System.Drawing.Point(267, 15)
        Me.cmbsem.Name = "cmbsem"
        Me.cmbsem.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbsem.Properties.Items.AddRange(New Object() {"1", "2"})
        Me.cmbsem.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cmbsem.Size = New System.Drawing.Size(63, 20)
        Me.cmbsem.TabIndex = 3
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(211, 18)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(45, 13)
        Me.LabelControl3.TabIndex = 6
        Me.LabelControl3.Text = "Semester"
        '
        'lblsubcode
        '
        Me.lblsubcode.AutoSize = True
        Me.lblsubcode.Location = New System.Drawing.Point(191, 56)
        Me.lblsubcode.Name = "lblsubcode"
        Me.lblsubcode.Size = New System.Drawing.Size(0, 13)
        Me.lblsubcode.TabIndex = 5
        '
        'lblsubname
        '
        Me.lblsubname.AutoSize = True
        Me.lblsubname.Location = New System.Drawing.Point(191, 20)
        Me.lblsubname.Name = "lblsubname"
        Me.lblsubname.Size = New System.Drawing.Size(0, 13)
        Me.lblsubname.TabIndex = 4
        '
        'txtsubcode
        '
        Me.txtsubcode.Location = New System.Drawing.Point(86, 52)
        Me.txtsubcode.Name = "txtsubcode"
        Me.txtsubcode.Size = New System.Drawing.Size(100, 20)
        Me.txtsubcode.TabIndex = 2
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(9, 56)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(64, 13)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "Subject Code"
        '
        'txtsubname
        '
        Me.txtsubname.Location = New System.Drawing.Point(86, 15)
        Me.txtsubname.Name = "txtsubname"
        Me.txtsubname.Size = New System.Drawing.Size(100, 20)
        Me.txtsubname.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(9, 19)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(66, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Subject Name"
        '
        'frmsub_entry
        '
        Me.AcceptButton = Me.btnsave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(356, 311)
        Me.Controls.Add(Me.GroupControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmsub_entry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Subject Inforamtion"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.grdsub, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.cmbsem.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtsubcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtsubname.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnadd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btncancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnedit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnsave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grdsub As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents s_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents s_code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblsubcode As System.Windows.Forms.Label
    Friend WithEvents lblsubname As System.Windows.Forms.Label
    Friend WithEvents txtsubcode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtsubname As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sub_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblsem As System.Windows.Forms.Label
    Friend WithEvents cmbsem As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents sem_id As DevExpress.XtraGrid.Columns.GridColumn
End Class
