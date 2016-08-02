<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmarksedit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmmarksedit))
        Me.grpfinal = New DevExpress.XtraEditors.GroupControl
        Me.GroupControl9 = New DevExpress.XtraEditors.GroupControl
        Me.txtstatus = New DevExpress.XtraEditors.TextEdit
        Me.txtnet = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl
        Me.grpkrupa = New DevExpress.XtraEditors.GroupControl
        Me.GroupControl7 = New DevExpress.XtraEditors.GroupControl
        Me.txtkrupa = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl
        Me.txtsiddhi = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl
        Me.grptotal = New DevExpress.XtraEditors.GroupControl
        Me.txttotal = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl
        Me.grpmarks = New DevExpress.XtraEditors.GroupControl
        Me.lblsa1 = New System.Windows.Forms.Label
        Me.lblfa2 = New System.Windows.Forms.Label
        Me.lblfa1 = New System.Windows.Forms.Label
        Me.txtsa1 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.txtfa2 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.txtfa1 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.grpgeninfo = New DevExpress.XtraEditors.GroupControl
        Me.lblsubname = New System.Windows.Forms.Label
        Me.lblsubcode = New System.Windows.Forms.Label
        Me.txtsubname = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.cmbsubcode = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.lblsem = New System.Windows.Forms.Label
        Me.lblstdid = New System.Windows.Forms.Label
        Me.lblclassid = New System.Windows.Forms.Label
        Me.cmbsem = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl
        Me.cmbstdno = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.cmbclsno = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.btncancel = New DevExpress.XtraEditors.SimpleButton
        Me.btnedit = New DevExpress.XtraEditors.SimpleButton
        Me.btnsave = New DevExpress.XtraEditors.SimpleButton
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.grdmarking = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        CType(Me.grpfinal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpfinal.SuspendLayout()
        CType(Me.GroupControl9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl9.SuspendLayout()
        CType(Me.txtstatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtnet.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpkrupa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpkrupa.SuspendLayout()
        CType(Me.GroupControl7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl7.SuspendLayout()
        CType(Me.txtkrupa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtsiddhi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.grptotal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grptotal.SuspendLayout()
        CType(Me.txttotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpmarks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpmarks.SuspendLayout()
        CType(Me.txtsa1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtfa2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtfa1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.grpgeninfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpgeninfo.SuspendLayout()
        CType(Me.txtsubname.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbsubcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbsem.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbstdno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbclsno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.grdmarking, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpfinal
        '
        Me.grpfinal.Controls.Add(Me.GroupControl9)
        Me.grpfinal.Location = New System.Drawing.Point(540, 133)
        Me.grpfinal.Name = "grpfinal"
        Me.grpfinal.Size = New System.Drawing.Size(233, 119)
        Me.grpfinal.TabIndex = 27
        Me.grpfinal.Text = "Final Result"
        '
        'GroupControl9
        '
        Me.GroupControl9.Controls.Add(Me.txtstatus)
        Me.GroupControl9.Controls.Add(Me.txtnet)
        Me.GroupControl9.Controls.Add(Me.LabelControl15)
        Me.GroupControl9.Controls.Add(Me.LabelControl14)
        Me.GroupControl9.Location = New System.Drawing.Point(1, 19)
        Me.GroupControl9.Name = "GroupControl9"
        Me.GroupControl9.ShowCaption = False
        Me.GroupControl9.Size = New System.Drawing.Size(231, 100)
        Me.GroupControl9.TabIndex = 0
        Me.GroupControl9.Text = "GroupControl9"
        '
        'txtstatus
        '
        Me.txtstatus.Location = New System.Drawing.Point(96, 48)
        Me.txtstatus.Name = "txtstatus"
        Me.txtstatus.Properties.ReadOnly = True
        Me.txtstatus.Size = New System.Drawing.Size(97, 20)
        Me.txtstatus.TabIndex = 2
        '
        'txtnet
        '
        Me.txtnet.Location = New System.Drawing.Point(96, 16)
        Me.txtnet.Name = "txtnet"
        Me.txtnet.Properties.ReadOnly = True
        Me.txtnet.Size = New System.Drawing.Size(97, 20)
        Me.txtnet.TabIndex = 1
        '
        'LabelControl15
        '
        Me.LabelControl15.Location = New System.Drawing.Point(18, 51)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(31, 13)
        Me.LabelControl15.TabIndex = 1
        Me.LabelControl15.Text = "Status"
        '
        'LabelControl14
        '
        Me.LabelControl14.Location = New System.Drawing.Point(18, 19)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl14.TabIndex = 0
        Me.LabelControl14.Text = "Net Total"
        '
        'grpkrupa
        '
        Me.grpkrupa.Controls.Add(Me.GroupControl7)
        Me.grpkrupa.Location = New System.Drawing.Point(540, 1)
        Me.grpkrupa.Name = "grpkrupa"
        Me.grpkrupa.Size = New System.Drawing.Size(233, 131)
        Me.grpkrupa.TabIndex = 26
        Me.grpkrupa.Text = "Advanced Stream Marking"
        '
        'GroupControl7
        '
        Me.GroupControl7.Controls.Add(Me.txtkrupa)
        Me.GroupControl7.Controls.Add(Me.LabelControl13)
        Me.GroupControl7.Controls.Add(Me.txtsiddhi)
        Me.GroupControl7.Controls.Add(Me.LabelControl12)
        Me.GroupControl7.Location = New System.Drawing.Point(1, 20)
        Me.GroupControl7.Name = "GroupControl7"
        Me.GroupControl7.ShowCaption = False
        Me.GroupControl7.Size = New System.Drawing.Size(232, 110)
        Me.GroupControl7.TabIndex = 0
        Me.GroupControl7.Text = "GroupControl7"
        '
        'txtkrupa
        '
        Me.txtkrupa.Location = New System.Drawing.Point(92, 58)
        Me.txtkrupa.Name = "txtkrupa"
        Me.txtkrupa.Properties.MaxLength = 1
        Me.txtkrupa.Size = New System.Drawing.Size(97, 20)
        Me.txtkrupa.TabIndex = 2
        '
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(14, 61)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(59, 13)
        Me.LabelControl13.TabIndex = 21
        Me.LabelControl13.Text = "Krupa Marks"
        '
        'txtsiddhi
        '
        Me.txtsiddhi.Location = New System.Drawing.Point(92, 26)
        Me.txtsiddhi.Name = "txtsiddhi"
        Me.txtsiddhi.Properties.MaxLength = 1
        Me.txtsiddhi.Size = New System.Drawing.Size(97, 20)
        Me.txtsiddhi.TabIndex = 1
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(14, 29)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(59, 13)
        Me.LabelControl12.TabIndex = 0
        Me.LabelControl12.Text = "Siddhi Marks"
        '
        'GroupControl4
        '
        Me.GroupControl4.Controls.Add(Me.grptotal)
        Me.GroupControl4.Location = New System.Drawing.Point(298, 201)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.ShowCaption = False
        Me.GroupControl4.Size = New System.Drawing.Size(241, 51)
        Me.GroupControl4.TabIndex = 25
        Me.GroupControl4.Text = "GroupControl4"
        '
        'grptotal
        '
        Me.grptotal.Controls.Add(Me.txttotal)
        Me.grptotal.Controls.Add(Me.LabelControl11)
        Me.grptotal.Location = New System.Drawing.Point(0, 0)
        Me.grptotal.Name = "grptotal"
        Me.grptotal.ShowCaption = False
        Me.grptotal.Size = New System.Drawing.Size(241, 51)
        Me.grptotal.TabIndex = 2
        Me.grptotal.Text = "GroupControl5"
        '
        'txttotal
        '
        Me.txttotal.Location = New System.Drawing.Point(83, 13)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Properties.ReadOnly = True
        Me.txttotal.Size = New System.Drawing.Size(97, 20)
        Me.txttotal.TabIndex = 1
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(18, 16)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(48, 13)
        Me.LabelControl11.TabIndex = 0
        Me.LabelControl11.Text = "Row Total"
        '
        'grpmarks
        '
        Me.grpmarks.Controls.Add(Me.lblsa1)
        Me.grpmarks.Controls.Add(Me.lblfa2)
        Me.grpmarks.Controls.Add(Me.lblfa1)
        Me.grpmarks.Controls.Add(Me.txtsa1)
        Me.grpmarks.Controls.Add(Me.LabelControl8)
        Me.grpmarks.Controls.Add(Me.txtfa2)
        Me.grpmarks.Controls.Add(Me.LabelControl7)
        Me.grpmarks.Controls.Add(Me.txtfa1)
        Me.grpmarks.Controls.Add(Me.LabelControl6)
        Me.grpmarks.Location = New System.Drawing.Point(298, 1)
        Me.grpmarks.Name = "grpmarks"
        Me.grpmarks.Size = New System.Drawing.Size(241, 199)
        Me.grpmarks.TabIndex = 24
        Me.grpmarks.Text = "Stream Wise Marking"
        '
        'lblsa1
        '
        Me.lblsa1.AutoSize = True
        Me.lblsa1.Location = New System.Drawing.Point(180, 109)
        Me.lblsa1.Name = "lblsa1"
        Me.lblsa1.Size = New System.Drawing.Size(0, 13)
        Me.lblsa1.TabIndex = 17
        '
        'lblfa2
        '
        Me.lblfa2.AutoSize = True
        Me.lblfa2.Location = New System.Drawing.Point(180, 76)
        Me.lblfa2.Name = "lblfa2"
        Me.lblfa2.Size = New System.Drawing.Size(0, 13)
        Me.lblfa2.TabIndex = 16
        '
        'lblfa1
        '
        Me.lblfa1.AutoSize = True
        Me.lblfa1.Location = New System.Drawing.Point(180, 37)
        Me.lblfa1.Name = "lblfa1"
        Me.lblfa1.Size = New System.Drawing.Size(0, 13)
        Me.lblfa1.TabIndex = 15
        '
        'txtsa1
        '
        Me.txtsa1.Location = New System.Drawing.Point(76, 106)
        Me.txtsa1.Name = "txtsa1"
        Me.txtsa1.Properties.MaxLength = 2
        Me.txtsa1.Size = New System.Drawing.Size(97, 20)
        Me.txtsa1.TabIndex = 3
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(18, 109)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(23, 13)
        Me.LabelControl8.TabIndex = 13
        Me.LabelControl8.Text = "SA-1"
        '
        'txtfa2
        '
        Me.txtfa2.Location = New System.Drawing.Point(76, 72)
        Me.txtfa2.Name = "txtfa2"
        Me.txtfa2.Properties.MaxLength = 2
        Me.txtfa2.Size = New System.Drawing.Size(97, 20)
        Me.txtfa2.TabIndex = 2
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(18, 75)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(23, 13)
        Me.LabelControl7.TabIndex = 11
        Me.LabelControl7.Text = "FA-2"
        '
        'txtfa1
        '
        Me.txtfa1.Location = New System.Drawing.Point(76, 37)
        Me.txtfa1.Name = "txtfa1"
        Me.txtfa1.Properties.MaxLength = 2
        Me.txtfa1.Size = New System.Drawing.Size(97, 20)
        Me.txtfa1.TabIndex = 1
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(18, 40)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(23, 13)
        Me.LabelControl6.TabIndex = 0
        Me.LabelControl6.Text = "FA-1"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.grpgeninfo)
        Me.GroupControl1.Location = New System.Drawing.Point(1, 1)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.ShowCaption = False
        Me.GroupControl1.Size = New System.Drawing.Size(296, 252)
        Me.GroupControl1.TabIndex = 23
        Me.GroupControl1.Text = "GroupControl1"
        '
        'grpgeninfo
        '
        Me.grpgeninfo.Controls.Add(Me.lblsubname)
        Me.grpgeninfo.Controls.Add(Me.lblsubcode)
        Me.grpgeninfo.Controls.Add(Me.txtsubname)
        Me.grpgeninfo.Controls.Add(Me.LabelControl5)
        Me.grpgeninfo.Controls.Add(Me.cmbsubcode)
        Me.grpgeninfo.Controls.Add(Me.LabelControl4)
        Me.grpgeninfo.Controls.Add(Me.lblsem)
        Me.grpgeninfo.Controls.Add(Me.lblstdid)
        Me.grpgeninfo.Controls.Add(Me.lblclassid)
        Me.grpgeninfo.Controls.Add(Me.cmbsem)
        Me.grpgeninfo.Controls.Add(Me.LabelControl16)
        Me.grpgeninfo.Controls.Add(Me.cmbstdno)
        Me.grpgeninfo.Controls.Add(Me.LabelControl2)
        Me.grpgeninfo.Controls.Add(Me.cmbclsno)
        Me.grpgeninfo.Controls.Add(Me.LabelControl1)
        Me.grpgeninfo.Location = New System.Drawing.Point(0, 0)
        Me.grpgeninfo.Name = "grpgeninfo"
        Me.grpgeninfo.Size = New System.Drawing.Size(296, 251)
        Me.grpgeninfo.TabIndex = 0
        Me.grpgeninfo.Text = "General Identification"
        '
        'lblsubname
        '
        Me.lblsubname.AutoSize = True
        Me.lblsubname.Location = New System.Drawing.Point(245, 193)
        Me.lblsubname.Name = "lblsubname"
        Me.lblsubname.Size = New System.Drawing.Size(0, 13)
        Me.lblsubname.TabIndex = 22
        '
        'lblsubcode
        '
        Me.lblsubcode.AutoSize = True
        Me.lblsubcode.Location = New System.Drawing.Point(248, 154)
        Me.lblsubcode.Name = "lblsubcode"
        Me.lblsubcode.Size = New System.Drawing.Size(0, 13)
        Me.lblsubcode.TabIndex = 21
        '
        'txtsubname
        '
        Me.txtsubname.Location = New System.Drawing.Point(117, 189)
        Me.txtsubname.Name = "txtsubname"
        Me.txtsubname.Properties.ReadOnly = True
        Me.txtsubname.Size = New System.Drawing.Size(125, 20)
        Me.txtsubname.TabIndex = 5
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(21, 191)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(66, 13)
        Me.LabelControl5.TabIndex = 19
        Me.LabelControl5.Text = "Subject Name"
        '
        'cmbsubcode
        '
        Me.cmbsubcode.Location = New System.Drawing.Point(117, 150)
        Me.cmbsubcode.Name = "cmbsubcode"
        Me.cmbsubcode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbsubcode.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cmbsubcode.Size = New System.Drawing.Size(125, 20)
        Me.cmbsubcode.TabIndex = 4
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(21, 153)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(64, 13)
        Me.LabelControl4.TabIndex = 17
        Me.LabelControl4.Text = "Subject Code"
        '
        'lblsem
        '
        Me.lblsem.AutoSize = True
        Me.lblsem.Location = New System.Drawing.Point(244, 115)
        Me.lblsem.Name = "lblsem"
        Me.lblsem.Size = New System.Drawing.Size(0, 13)
        Me.lblsem.TabIndex = 16
        '
        'lblstdid
        '
        Me.lblstdid.AutoSize = True
        Me.lblstdid.Location = New System.Drawing.Point(244, 77)
        Me.lblstdid.Name = "lblstdid"
        Me.lblstdid.Size = New System.Drawing.Size(0, 13)
        Me.lblstdid.TabIndex = 13
        '
        'lblclassid
        '
        Me.lblclassid.AutoSize = True
        Me.lblclassid.Location = New System.Drawing.Point(244, 38)
        Me.lblclassid.Name = "lblclassid"
        Me.lblclassid.Size = New System.Drawing.Size(0, 13)
        Me.lblclassid.TabIndex = 12
        '
        'cmbsem
        '
        Me.cmbsem.Location = New System.Drawing.Point(116, 111)
        Me.cmbsem.Name = "cmbsem"
        Me.cmbsem.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbsem.Properties.Items.AddRange(New Object() {"1", "2"})
        Me.cmbsem.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cmbsem.Size = New System.Drawing.Size(125, 20)
        Me.cmbsem.TabIndex = 3
        '
        'LabelControl16
        '
        Me.LabelControl16.Location = New System.Drawing.Point(21, 114)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(45, 13)
        Me.LabelControl16.TabIndex = 10
        Me.LabelControl16.Text = "Semester"
        '
        'cmbstdno
        '
        Me.cmbstdno.Location = New System.Drawing.Point(116, 73)
        Me.cmbstdno.Name = "cmbstdno"
        Me.cmbstdno.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbstdno.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cmbstdno.Size = New System.Drawing.Size(125, 20)
        Me.cmbstdno.TabIndex = 2
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(19, 76)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(75, 13)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "Student ID / No"
        '
        'cmbclsno
        '
        Me.cmbclsno.Location = New System.Drawing.Point(116, 35)
        Me.cmbclsno.Name = "cmbclsno"
        Me.cmbclsno.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbclsno.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cmbclsno.Size = New System.Drawing.Size(125, 20)
        Me.cmbclsno.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(19, 38)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(62, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Class ID / No"
        '
        'btncancel
        '
        Me.btncancel.Image = Global.sms.My.Resources.Resources.Delete1
        Me.btncancel.Location = New System.Drawing.Point(457, 273)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(69, 31)
        Me.btncancel.TabIndex = 31
        Me.btncancel.Text = "Cancel"
        '
        'btnedit
        '
        Me.btnedit.Image = Global.sms.My.Resources.Resources.Edit1
        Me.btnedit.Location = New System.Drawing.Point(339, 273)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(69, 31)
        Me.btnedit.TabIndex = 29
        Me.btnedit.Text = "Edit"
        '
        'btnsave
        '
        Me.btnsave.Image = Global.sms.My.Resources.Resources.Icon_Disk01_Blue
        Me.btnsave.Location = New System.Drawing.Point(222, 273)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(69, 31)
        Me.btnsave.TabIndex = 28
        Me.btnsave.Text = "Save"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.grdmarking)
        Me.GroupControl2.Location = New System.Drawing.Point(1, 325)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(772, 225)
        Me.GroupControl2.TabIndex = 32
        Me.GroupControl2.Text = "Exam Marks LookUp"
        '
        'grdmarking
        '
        Me.grdmarking.Location = New System.Drawing.Point(1, 20)
        Me.grdmarking.MainView = Me.GridView1
        Me.grdmarking.Name = "grdmarking"
        Me.grdmarking.Size = New System.Drawing.Size(770, 205)
        Me.grdmarking.TabIndex = 0
        Me.grdmarking.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.grdmarking
        Me.GridView1.Name = "GridView1"
        '
        'frmmarksedit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(774, 551)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.grpfinal)
        Me.Controls.Add(Me.grpkrupa)
        Me.Controls.Add(Me.GroupControl4)
        Me.Controls.Add(Me.grpmarks)
        Me.Controls.Add(Me.GroupControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmmarksedit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student Exam Marking"
        CType(Me.grpfinal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpfinal.ResumeLayout(False)
        CType(Me.GroupControl9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl9.ResumeLayout(False)
        Me.GroupControl9.PerformLayout()
        CType(Me.txtstatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtnet.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpkrupa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpkrupa.ResumeLayout(False)
        CType(Me.GroupControl7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl7.ResumeLayout(False)
        Me.GroupControl7.PerformLayout()
        CType(Me.txtkrupa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtsiddhi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        CType(Me.grptotal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grptotal.ResumeLayout(False)
        Me.grptotal.PerformLayout()
        CType(Me.txttotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpmarks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpmarks.ResumeLayout(False)
        Me.grpmarks.PerformLayout()
        CType(Me.txtsa1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtfa2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtfa1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.grpgeninfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpgeninfo.ResumeLayout(False)
        Me.grpgeninfo.PerformLayout()
        CType(Me.txtsubname.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbsubcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbsem.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbstdno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbclsno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.grdmarking, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpfinal As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl9 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtstatus As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtnet As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grpkrupa As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl7 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtkrupa As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtsiddhi As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grptotal As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txttotal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grpmarks As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblsa1 As System.Windows.Forms.Label
    Friend WithEvents lblfa2 As System.Windows.Forms.Label
    Friend WithEvents lblfa1 As System.Windows.Forms.Label
    Friend WithEvents txtsa1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtfa2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtfa1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grpgeninfo As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblsubname As System.Windows.Forms.Label
    Friend WithEvents lblsubcode As System.Windows.Forms.Label
    Friend WithEvents txtsubname As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbsubcode As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblsem As System.Windows.Forms.Label
    Friend WithEvents lblstdid As System.Windows.Forms.Label
    Friend WithEvents lblclassid As System.Windows.Forms.Label
    Friend WithEvents cmbsem As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbstdno As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbclsno As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btncancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnedit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnsave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grdmarking As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
End Class
