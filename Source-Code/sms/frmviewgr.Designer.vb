<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmviewgr
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmviewgr))
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.grdgr = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GroupControl5 = New DevExpress.XtraEditors.GroupControl
        Me.btnprint = New DevExpress.XtraEditors.SimpleButton
        Me.btnpprev = New DevExpress.XtraEditors.SimpleButton
        Me.btncancel = New DevExpress.XtraEditors.SimpleButton
        Me.btnreset = New DevExpress.XtraEditors.SimpleButton
        Me.btnsearch = New DevExpress.XtraEditors.SimpleButton
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.txtlastname = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.cmbyear = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.txtfirstname = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.txtgrno = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdgr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl5.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.txtlastname.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbyear.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbyear.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtfirstname.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtgrno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.grdgr
        Me.GridView2.Name = "GridView2"
        '
        'grdgr
        '
        GridLevelNode1.LevelTemplate = Me.GridView2
        GridLevelNode1.RelationName = "Level1"
        Me.grdgr.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.grdgr.Location = New System.Drawing.Point(1, 20)
        Me.grdgr.MainView = Me.GridView1
        Me.grdgr.Name = "grdgr"
        Me.grdgr.Size = New System.Drawing.Size(1099, 371)
        Me.grdgr.TabIndex = 0
        Me.grdgr.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1, Me.GridView2})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.grdgr
        Me.GridView1.Name = "GridView1"
        '
        'GroupControl5
        '
        Me.GroupControl5.Controls.Add(Me.grdgr)
        Me.GroupControl5.Location = New System.Drawing.Point(1, 237)
        Me.GroupControl5.Name = "GroupControl5"
        Me.GroupControl5.Size = New System.Drawing.Size(1100, 391)
        Me.GroupControl5.TabIndex = 2
        Me.GroupControl5.Text = "Student General Register"
        '
        'btnprint
        '
        Me.btnprint.Image = Global.sms.My.Resources.Resources.Printer_icon
        Me.btnprint.Location = New System.Drawing.Point(308, 186)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(73, 31)
        Me.btnprint.TabIndex = 2
        Me.btnprint.Text = "Print"
        '
        'btnpprev
        '
        Me.btnpprev.Image = Global.sms.My.Resources.Resources.document_print_preview
        Me.btnpprev.Location = New System.Drawing.Point(117, 186)
        Me.btnpprev.Name = "btnpprev"
        Me.btnpprev.Size = New System.Drawing.Size(106, 31)
        Me.btnpprev.TabIndex = 1
        Me.btnpprev.Text = "Print Preview"
        '
        'btncancel
        '
        Me.btncancel.Image = Global.sms.My.Resources.Resources.Delete2
        Me.btncancel.Location = New System.Drawing.Point(895, 186)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(73, 31)
        Me.btncancel.TabIndex = 5
        Me.btncancel.Text = "Cancel"
        '
        'btnreset
        '
        Me.btnreset.Image = Global.sms.My.Resources.Resources.reset2
        Me.btnreset.Location = New System.Drawing.Point(705, 186)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(73, 31)
        Me.btnreset.TabIndex = 4
        Me.btnreset.Text = "Reset"
        '
        'btnsearch
        '
        Me.btnsearch.Image = Global.sms.My.Resources.Resources.p_search_icon
        Me.btnsearch.Location = New System.Drawing.Point(504, 186)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(73, 31)
        Me.btnsearch.TabIndex = 3
        Me.btnsearch.Text = "Search"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.txtlastname)
        Me.GroupControl2.Controls.Add(Me.LabelControl3)
        Me.GroupControl2.Controls.Add(Me.cmbyear)
        Me.GroupControl2.Controls.Add(Me.LabelControl4)
        Me.GroupControl2.Controls.Add(Me.txtfirstname)
        Me.GroupControl2.Controls.Add(Me.LabelControl2)
        Me.GroupControl2.Controls.Add(Me.txtgrno)
        Me.GroupControl2.Controls.Add(Me.LabelControl1)
        Me.GroupControl2.Location = New System.Drawing.Point(1, 1)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(1100, 162)
        Me.GroupControl2.TabIndex = 0
        Me.GroupControl2.Text = "Select Your Choice For Search By"
        '
        'txtlastname
        '
        Me.txtlastname.Location = New System.Drawing.Point(683, 96)
        Me.txtlastname.Name = "txtlastname"
        Me.txtlastname.Size = New System.Drawing.Size(130, 20)
        Me.txtlastname.TabIndex = 4
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(607, 100)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl3.TabIndex = 16
        Me.LabelControl3.Text = "Last Name"
        '
        'cmbyear
        '
        Me.cmbyear.EditValue = Nothing
        Me.cmbyear.Location = New System.Drawing.Point(354, 96)
        Me.cmbyear.Name = "cmbyear"
        Me.cmbyear.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbyear.Properties.DisplayFormat.FormatString = "yyyy"
        Me.cmbyear.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.cmbyear.Properties.EditFormat.FormatString = "yyyy"
        Me.cmbyear.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.cmbyear.Properties.Mask.EditMask = "yyyy"
        Me.cmbyear.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cmbyear.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.cmbyear.Size = New System.Drawing.Size(130, 20)
        Me.cmbyear.TabIndex = 2
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(278, 99)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(22, 13)
        Me.LabelControl4.TabIndex = 14
        Me.LabelControl4.Text = "Year"
        '
        'txtfirstname
        '
        Me.txtfirstname.Location = New System.Drawing.Point(683, 57)
        Me.txtfirstname.Name = "txtfirstname"
        Me.txtfirstname.Size = New System.Drawing.Size(130, 20)
        Me.txtfirstname.TabIndex = 3
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(607, 61)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(51, 13)
        Me.LabelControl2.TabIndex = 10
        Me.LabelControl2.Text = "First Name"
        '
        'txtgrno
        '
        Me.txtgrno.Location = New System.Drawing.Point(354, 56)
        Me.txtgrno.Name = "txtgrno"
        Me.txtgrno.Size = New System.Drawing.Size(130, 20)
        Me.txtgrno.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(278, 60)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(30, 13)
        Me.LabelControl1.TabIndex = 8
        Me.LabelControl1.Text = "GR No"
        '
        'frmviewgr
        '
        Me.AcceptButton = Me.btnsearch
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1102, 629)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.btnprint)
        Me.Controls.Add(Me.btnpprev)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnreset)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.GroupControl5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmviewgr"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student GR Advance View"
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdgr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl5.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.txtlastname.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbyear.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbyear.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtfirstname.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtgrno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl5 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grdgr As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnprint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnpprev As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btncancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnreset As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnsearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtfirstname As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtgrno As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbyear As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtlastname As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
End Class
