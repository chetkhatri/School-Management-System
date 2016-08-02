<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmclass_entry
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmclass_entry))
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.btnadd = New DevExpress.XtraEditors.SimpleButton
        Me.btncancel = New DevExpress.XtraEditors.SimpleButton
        Me.btnedit = New DevExpress.XtraEditors.SimpleButton
        Me.btnsave = New DevExpress.XtraEditors.SimpleButton
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl
        Me.grdclass = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.class_no = New DevExpress.XtraGrid.Columns.GridColumn
        Me.class_dsc = New DevExpress.XtraGrid.Columns.GridColumn
        Me.class_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.lblclsname = New System.Windows.Forms.Label
        Me.lblclsno = New System.Windows.Forms.Label
        Me.txtclsname = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.txtclsno = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.grdclass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.txtclsname.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtclsno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GroupControl1.Text = "Class LookUp"
        '
        'btnadd
        '
        Me.btnadd.Image = Global.sms.My.Resources.Resources.plus_27
        Me.btnadd.Location = New System.Drawing.Point(11, 124)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(69, 31)
        Me.btnadd.TabIndex = 1
        Me.btnadd.Text = "Add"
        '
        'btncancel
        '
        Me.btncancel.Image = Global.sms.My.Resources.Resources.Delete2
        Me.btncancel.Location = New System.Drawing.Point(274, 124)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(69, 31)
        Me.btncancel.TabIndex = 4
        Me.btncancel.Text = "Cancel"
        '
        'btnedit
        '
        Me.btnedit.Image = Global.sms.My.Resources.Resources.Edit1
        Me.btnedit.Location = New System.Drawing.Point(186, 124)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(69, 31)
        Me.btnedit.TabIndex = 3
        Me.btnedit.Text = "Edit"
        '
        'btnsave
        '
        Me.btnsave.Image = Global.sms.My.Resources.Resources.Icon_Disk01_Blue1
        Me.btnsave.Location = New System.Drawing.Point(98, 124)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(69, 31)
        Me.btnsave.TabIndex = 2
        Me.btnsave.Text = "Save"
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.grdclass)
        Me.GroupControl3.Location = New System.Drawing.Point(1, 168)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(354, 142)
        Me.GroupControl3.TabIndex = 1
        Me.GroupControl3.Text = "Class Information"
        '
        'grdclass
        '
        Me.grdclass.Location = New System.Drawing.Point(2, 20)
        Me.grdclass.MainView = Me.GridView1
        Me.grdclass.Name = "grdclass"
        Me.grdclass.Size = New System.Drawing.Size(350, 120)
        Me.grdclass.TabIndex = 5
        Me.grdclass.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.class_no, Me.class_dsc, Me.class_id})
        Me.GridView1.GridControl = Me.grdclass
        Me.GridView1.Name = "GridView1"
        '
        'class_no
        '
        Me.class_no.Caption = "Class No"
        Me.class_no.FieldName = "class_no"
        Me.class_no.Name = "class_no"
        Me.class_no.Visible = True
        Me.class_no.VisibleIndex = 0
        '
        'class_dsc
        '
        Me.class_dsc.Caption = "Class Name"
        Me.class_dsc.FieldName = "class_dsc"
        Me.class_dsc.Name = "class_dsc"
        Me.class_dsc.Visible = True
        Me.class_dsc.VisibleIndex = 1
        '
        'class_id
        '
        Me.class_id.Caption = "class id"
        Me.class_id.FieldName = "class_id"
        Me.class_id.Name = "class_id"
        Me.class_id.Visible = True
        Me.class_id.VisibleIndex = 2
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.lblclsname)
        Me.GroupControl2.Controls.Add(Me.lblclsno)
        Me.GroupControl2.Controls.Add(Me.txtclsname)
        Me.GroupControl2.Controls.Add(Me.LabelControl2)
        Me.GroupControl2.Controls.Add(Me.txtclsno)
        Me.GroupControl2.Controls.Add(Me.LabelControl1)
        Me.GroupControl2.Location = New System.Drawing.Point(1, 19)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.ShowCaption = False
        Me.GroupControl2.Size = New System.Drawing.Size(354, 90)
        Me.GroupControl2.TabIndex = 0
        Me.GroupControl2.Text = "GroupControl2"
        '
        'lblclsname
        '
        Me.lblclsname.AutoSize = True
        Me.lblclsname.Location = New System.Drawing.Point(196, 56)
        Me.lblclsname.Name = "lblclsname"
        Me.lblclsname.Size = New System.Drawing.Size(0, 13)
        Me.lblclsname.TabIndex = 5
        '
        'lblclsno
        '
        Me.lblclsno.AutoSize = True
        Me.lblclsno.Location = New System.Drawing.Point(196, 20)
        Me.lblclsno.Name = "lblclsno"
        Me.lblclsno.Size = New System.Drawing.Size(0, 13)
        Me.lblclsno.TabIndex = 4
        '
        'txtclsname
        '
        Me.txtclsname.Location = New System.Drawing.Point(84, 52)
        Me.txtclsname.Name = "txtclsname"
        Me.txtclsname.Size = New System.Drawing.Size(100, 20)
        Me.txtclsname.TabIndex = 2
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(15, 56)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(55, 13)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "Class Name"
        '
        'txtclsno
        '
        Me.txtclsno.Location = New System.Drawing.Point(84, 15)
        Me.txtclsno.Name = "txtclsno"
        Me.txtclsno.Size = New System.Drawing.Size(100, 20)
        Me.txtclsno.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(15, 19)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(41, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Class No"
        '
        'frmclass_entry
        '
        Me.AcceptButton = Me.btnsave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(356, 311)
        Me.Controls.Add(Me.GroupControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmclass_entry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Class Information"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.grdclass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.txtclsname.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtclsno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btncancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnedit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnsave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtclsno As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtclsname As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblclsname As System.Windows.Forms.Label
    Friend WithEvents lblclsno As System.Windows.Forms.Label
    Friend WithEvents btnadd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grdclass As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents class_no As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents class_dsc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents class_id As DevExpress.XtraGrid.Columns.GridColumn
End Class
