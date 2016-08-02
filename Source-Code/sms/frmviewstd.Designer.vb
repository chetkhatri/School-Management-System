<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmviewstd
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
        a.GridPropery(GridView2)
    End Sub
    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmviewstd))
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.grdstdview = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.cmbclassno = New DevExpress.XtraEditors.ComboBoxEdit
        Me.cmbstdid = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.txtname = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.btnprint = New DevExpress.XtraEditors.SimpleButton
        Me.btnpprev = New DevExpress.XtraEditors.SimpleButton
        Me.btncancel = New DevExpress.XtraEditors.SimpleButton
        Me.btnreset = New DevExpress.XtraEditors.SimpleButton
        Me.btnviewall = New DevExpress.XtraEditors.SimpleButton
        Me.GroupControl5 = New DevExpress.XtraEditors.GroupControl
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdstdview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.cmbclassno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbstdid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtname.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.grdstdview
        Me.GridView2.Name = "GridView2"
        '
        'grdstdview
        '
        GridLevelNode1.LevelTemplate = Me.GridView2
        GridLevelNode1.RelationName = "Level1"
        Me.grdstdview.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.grdstdview.Location = New System.Drawing.Point(1, 20)
        Me.grdstdview.MainView = Me.GridView1
        Me.grdstdview.Name = "grdstdview"
        Me.grdstdview.Size = New System.Drawing.Size(1098, 369)
        Me.grdstdview.TabIndex = 0
        Me.grdstdview.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1, Me.GridView2})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.grdstdview
        Me.GridView1.Name = "GridView1"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.GroupControl2)
        Me.GroupControl1.Controls.Add(Me.btnprint)
        Me.GroupControl1.Controls.Add(Me.btnpprev)
        Me.GroupControl1.Controls.Add(Me.btncancel)
        Me.GroupControl1.Controls.Add(Me.btnreset)
        Me.GroupControl1.Controls.Add(Me.btnviewall)
        Me.GroupControl1.Controls.Add(Me.GroupControl5)
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.ShowCaption = False
        Me.GroupControl1.Size = New System.Drawing.Size(1365, 628)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "GroupControl1"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.cmbclassno)
        Me.GroupControl2.Controls.Add(Me.cmbstdid)
        Me.GroupControl2.Controls.Add(Me.LabelControl3)
        Me.GroupControl2.Controls.Add(Me.LabelControl2)
        Me.GroupControl2.Controls.Add(Me.txtname)
        Me.GroupControl2.Controls.Add(Me.LabelControl1)
        Me.GroupControl2.Location = New System.Drawing.Point(2, 2)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(1099, 162)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "Select Your Choice For Search By"
        '
        'cmbclassno
        '
        Me.cmbclassno.Location = New System.Drawing.Point(515, 80)
        Me.cmbclassno.Name = "cmbclassno"
        Me.cmbclassno.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbclassno.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cmbclassno.Size = New System.Drawing.Size(134, 20)
        Me.cmbclassno.TabIndex = 2
        '
        'cmbstdid
        '
        Me.cmbstdid.Location = New System.Drawing.Point(515, 121)
        Me.cmbstdid.Name = "cmbstdid"
        Me.cmbstdid.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbstdid.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cmbstdid.Size = New System.Drawing.Size(134, 20)
        Me.cmbstdid.TabIndex = 3
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(437, 83)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(41, 13)
        Me.LabelControl3.TabIndex = 9
        Me.LabelControl3.Text = "Class No"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(437, 124)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(52, 13)
        Me.LabelControl2.TabIndex = 6
        Me.LabelControl2.Text = "Student ID"
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(515, 39)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(134, 20)
        Me.txtname.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(437, 42)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(51, 13)
        Me.LabelControl1.TabIndex = 4
        Me.LabelControl1.Text = "First Name"
        '
        'btnprint
        '
        Me.btnprint.Image = Global.sms.My.Resources.Resources.Printer_icon
        Me.btnprint.Location = New System.Drawing.Point(318, 188)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(73, 31)
        Me.btnprint.TabIndex = 3
        Me.btnprint.Text = "Print"
        '
        'btnpprev
        '
        Me.btnpprev.Image = Global.sms.My.Resources.Resources.document_print_preview
        Me.btnpprev.Location = New System.Drawing.Point(127, 188)
        Me.btnpprev.Name = "btnpprev"
        Me.btnpprev.Size = New System.Drawing.Size(106, 31)
        Me.btnpprev.TabIndex = 2
        Me.btnpprev.Text = "Print Preview"
        '
        'btncancel
        '
        Me.btncancel.Image = Global.sms.My.Resources.Resources.Delete2
        Me.btncancel.Location = New System.Drawing.Point(905, 188)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(73, 31)
        Me.btncancel.TabIndex = 6
        Me.btncancel.Text = "Cancel"
        '
        'btnreset
        '
        Me.btnreset.Image = Global.sms.My.Resources.Resources.reset2
        Me.btnreset.Location = New System.Drawing.Point(715, 188)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(73, 31)
        Me.btnreset.TabIndex = 5
        Me.btnreset.Text = "Reset"
        '
        'btnviewall
        '
        Me.btnviewall.Image = Global.sms.My.Resources.Resources.p_search_icon
        Me.btnviewall.Location = New System.Drawing.Point(514, 188)
        Me.btnviewall.Name = "btnviewall"
        Me.btnviewall.Size = New System.Drawing.Size(73, 31)
        Me.btnviewall.TabIndex = 4
        Me.btnviewall.Text = "Search"
        '
        'GroupControl5
        '
        Me.GroupControl5.Controls.Add(Me.grdstdview)
        Me.GroupControl5.Location = New System.Drawing.Point(3, 239)
        Me.GroupControl5.Name = "GroupControl5"
        Me.GroupControl5.Size = New System.Drawing.Size(1099, 389)
        Me.GroupControl5.TabIndex = 7
        Me.GroupControl5.Text = "Student Administration"
        '
        'frmviewstd
        '
        Me.AcceptButton = Me.btnviewall
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1102, 629)
        Me.Controls.Add(Me.GroupControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmviewstd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student Information Advance View"
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdstdview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.cmbclassno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbstdid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtname.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl5 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grdstdview As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnprint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnpprev As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btncancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnreset As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnviewall As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cmbclassno As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cmbstdid As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtname As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
End Class
