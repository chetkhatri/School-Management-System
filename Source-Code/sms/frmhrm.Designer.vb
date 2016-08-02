<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmhrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmhrm))
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.grpemp = New DevExpress.XtraEditors.GroupControl
        Me.lblbasic = New System.Windows.Forms.Label
        Me.lbltax = New System.Windows.Forms.Label
        Me.lblattend = New System.Windows.Forms.Label
        Me.lbldte = New System.Windows.Forms.Label
        Me.lblempid = New System.Windows.Forms.Label
        Me.dtpdte = New DevExpress.XtraEditors.DateEdit
        Me.txtyear = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.txtmonth = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl23 = New DevExpress.XtraEditors.LabelControl
        Me.cmbempid = New DevExpress.XtraEditors.ComboBoxEdit
        Me.cmbtaxmethod = New DevExpress.XtraEditors.ComboBoxEdit
        Me.txtsalary = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl22 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.txtattned = New DevExpress.XtraEditors.TextEdit
        Me.SimpleButton12 = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.txtname = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.grpallowance = New DevExpress.XtraEditors.GroupControl
        Me.txtwasall = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl
        Me.txtcashall = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl
        Me.txtfpi = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl
        Me.txtmedall = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl
        Me.txthra = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.txtda = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.txtgpay = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.grptax = New DevExpress.XtraEditors.GroupControl
        Me.txtgi = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl21 = New DevExpress.XtraEditors.LabelControl
        Me.txtcpf = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl20 = New DevExpress.XtraEditors.LabelControl
        Me.txtdeduc = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl
        Me.txtit = New DevExpress.XtraEditors.TextEdit
        Me.txtpf = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl
        Me.txtgpf = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl
        Me.GroupControl5 = New DevExpress.XtraEditors.GroupControl
        Me.grpnet = New DevExpress.XtraEditors.GroupControl
        Me.txtnet = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl
        Me.txtgross = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl
        Me.GroupControl7 = New DevExpress.XtraEditors.GroupControl
        Me.grdhrm = New DevExpress.XtraGrid.GridControl
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
        Me.sal_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.btncancel = New DevExpress.XtraEditors.SimpleButton
        Me.btnedit = New DevExpress.XtraEditors.SimpleButton
        Me.btnsave = New DevExpress.XtraEditors.SimpleButton
        Me.btnadd = New DevExpress.XtraEditors.SimpleButton
        Me.btnreset = New DevExpress.XtraEditors.SimpleButton
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.grpemp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpemp.SuspendLayout()
        CType(Me.dtpdte.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpdte.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtyear.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtmonth.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbempid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbtaxmethod.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtsalary.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtattned.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtname.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpallowance, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpallowance.SuspendLayout()
        CType(Me.txtwasall.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtcashall.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtfpi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtmedall.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txthra.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtgpay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grptax, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grptax.SuspendLayout()
        CType(Me.txtgi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtcpf.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdeduc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtpf.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtgpf.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl5.SuspendLayout()
        CType(Me.grpnet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpnet.SuspendLayout()
        CType(Me.txtnet.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtgross.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl7.SuspendLayout()
        CType(Me.grdhrm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.grpemp)
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.ShowCaption = False
        Me.GroupControl1.Size = New System.Drawing.Size(351, 334)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "GroupControl1"
        '
        'grpemp
        '
        Me.grpemp.Controls.Add(Me.lblbasic)
        Me.grpemp.Controls.Add(Me.lbltax)
        Me.grpemp.Controls.Add(Me.lblattend)
        Me.grpemp.Controls.Add(Me.lbldte)
        Me.grpemp.Controls.Add(Me.lblempid)
        Me.grpemp.Controls.Add(Me.dtpdte)
        Me.grpemp.Controls.Add(Me.txtyear)
        Me.grpemp.Controls.Add(Me.LabelControl4)
        Me.grpemp.Controls.Add(Me.txtmonth)
        Me.grpemp.Controls.Add(Me.LabelControl23)
        Me.grpemp.Controls.Add(Me.cmbempid)
        Me.grpemp.Controls.Add(Me.cmbtaxmethod)
        Me.grpemp.Controls.Add(Me.txtsalary)
        Me.grpemp.Controls.Add(Me.LabelControl22)
        Me.grpemp.Controls.Add(Me.LabelControl6)
        Me.grpemp.Controls.Add(Me.txtattned)
        Me.grpemp.Controls.Add(Me.SimpleButton12)
        Me.grpemp.Controls.Add(Me.LabelControl5)
        Me.grpemp.Controls.Add(Me.LabelControl3)
        Me.grpemp.Controls.Add(Me.txtname)
        Me.grpemp.Controls.Add(Me.LabelControl2)
        Me.grpemp.Controls.Add(Me.LabelControl1)
        Me.grpemp.Location = New System.Drawing.Point(2, 2)
        Me.grpemp.Name = "grpemp"
        Me.grpemp.Size = New System.Drawing.Size(349, 330)
        Me.grpemp.TabIndex = 0
        Me.grpemp.Text = "Employee LookUp"
        '
        'lblbasic
        '
        Me.lblbasic.AutoSize = True
        Me.lblbasic.Location = New System.Drawing.Point(228, 299)
        Me.lblbasic.Name = "lblbasic"
        Me.lblbasic.Size = New System.Drawing.Size(0, 13)
        Me.lblbasic.TabIndex = 30
        '
        'lbltax
        '
        Me.lbltax.AutoSize = True
        Me.lbltax.Location = New System.Drawing.Point(229, 262)
        Me.lbltax.Name = "lbltax"
        Me.lbltax.Size = New System.Drawing.Size(0, 13)
        Me.lbltax.TabIndex = 29
        '
        'lblattend
        '
        Me.lblattend.AutoSize = True
        Me.lblattend.Location = New System.Drawing.Point(229, 226)
        Me.lblattend.Name = "lblattend"
        Me.lblattend.Size = New System.Drawing.Size(0, 13)
        Me.lblattend.TabIndex = 28
        '
        'lbldte
        '
        Me.lbldte.AutoSize = True
        Me.lbldte.Location = New System.Drawing.Point(228, 113)
        Me.lbldte.Name = "lbldte"
        Me.lbldte.Size = New System.Drawing.Size(0, 13)
        Me.lbldte.TabIndex = 27
        '
        'lblempid
        '
        Me.lblempid.AutoSize = True
        Me.lblempid.Location = New System.Drawing.Point(229, 37)
        Me.lblempid.Name = "lblempid"
        Me.lblempid.Size = New System.Drawing.Size(0, 13)
        Me.lblempid.TabIndex = 26
        '
        'dtpdte
        '
        Me.dtpdte.EditValue = Nothing
        Me.dtpdte.Location = New System.Drawing.Point(85, 108)
        Me.dtpdte.Name = "dtpdte"
        Me.dtpdte.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpdte.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.dtpdte.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtpdte.Properties.EditFormat.FormatString = "MM/dd/yyyy"
        Me.dtpdte.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtpdte.Properties.Mask.EditMask = "MM/dd/yyyy"
        Me.dtpdte.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.dtpdte.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dtpdte.Size = New System.Drawing.Size(138, 20)
        Me.dtpdte.TabIndex = 3
        '
        'txtyear
        '
        Me.txtyear.Location = New System.Drawing.Point(85, 183)
        Me.txtyear.Name = "txtyear"
        Me.txtyear.Properties.ReadOnly = True
        Me.txtyear.Size = New System.Drawing.Size(138, 20)
        Me.txtyear.TabIndex = 5
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(9, 187)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(22, 13)
        Me.LabelControl4.TabIndex = 25
        Me.LabelControl4.Text = "Year"
        '
        'txtmonth
        '
        Me.txtmonth.Location = New System.Drawing.Point(85, 146)
        Me.txtmonth.Name = "txtmonth"
        Me.txtmonth.Properties.ReadOnly = True
        Me.txtmonth.Size = New System.Drawing.Size(138, 20)
        Me.txtmonth.TabIndex = 4
        '
        'LabelControl23
        '
        Me.LabelControl23.Location = New System.Drawing.Point(9, 150)
        Me.LabelControl23.Name = "LabelControl23"
        Me.LabelControl23.Size = New System.Drawing.Size(30, 13)
        Me.LabelControl23.TabIndex = 23
        Me.LabelControl23.Text = "Month"
        '
        'cmbempid
        '
        Me.cmbempid.Location = New System.Drawing.Point(85, 31)
        Me.cmbempid.Name = "cmbempid"
        Me.cmbempid.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbempid.Properties.Items.AddRange(New Object() {"C.P.F", "G.P.F"})
        Me.cmbempid.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cmbempid.Size = New System.Drawing.Size(138, 20)
        Me.cmbempid.TabIndex = 1
        '
        'cmbtaxmethod
        '
        Me.cmbtaxmethod.Location = New System.Drawing.Point(85, 258)
        Me.cmbtaxmethod.Name = "cmbtaxmethod"
        Me.cmbtaxmethod.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbtaxmethod.Properties.Items.AddRange(New Object() {"C.P.F", "G.P.F"})
        Me.cmbtaxmethod.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cmbtaxmethod.Size = New System.Drawing.Size(138, 20)
        Me.cmbtaxmethod.TabIndex = 7
        '
        'txtsalary
        '
        Me.txtsalary.Location = New System.Drawing.Point(85, 295)
        Me.txtsalary.Name = "txtsalary"
        Me.txtsalary.Size = New System.Drawing.Size(138, 20)
        Me.txtsalary.TabIndex = 8
        '
        'LabelControl22
        '
        Me.LabelControl22.Location = New System.Drawing.Point(9, 298)
        Me.LabelControl22.Name = "LabelControl22"
        Me.LabelControl22.Size = New System.Drawing.Size(57, 13)
        Me.LabelControl22.TabIndex = 21
        Me.LabelControl22.Text = "Basic Salary"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(9, 261)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(57, 13)
        Me.LabelControl6.TabIndex = 19
        Me.LabelControl6.Text = "Tax Method"
        '
        'txtattned
        '
        Me.txtattned.Location = New System.Drawing.Point(85, 221)
        Me.txtattned.Name = "txtattned"
        Me.txtattned.Properties.MaxLength = 2
        Me.txtattned.Size = New System.Drawing.Size(138, 20)
        Me.txtattned.TabIndex = 6
        '
        'SimpleButton12
        '
        Me.SimpleButton12.Image = Global.sms.My.Resources.Resources.p_search_icon
        Me.SimpleButton12.Location = New System.Drawing.Point(260, 57)
        Me.SimpleButton12.Name = "SimpleButton12"
        Me.SimpleButton12.Size = New System.Drawing.Size(73, 31)
        Me.SimpleButton12.TabIndex = 9
        Me.SimpleButton12.Text = "View All"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(9, 225)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(56, 13)
        Me.LabelControl5.TabIndex = 12
        Me.LabelControl5.Text = "Attendance"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(9, 110)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(23, 13)
        Me.LabelControl3.TabIndex = 8
        Me.LabelControl3.Text = "Date"
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(85, 70)
        Me.txtname.Name = "txtname"
        Me.txtname.Properties.ReadOnly = True
        Me.txtname.Size = New System.Drawing.Size(138, 20)
        Me.txtname.TabIndex = 2
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(9, 74)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl2.TabIndex = 6
        Me.LabelControl2.Text = "Name"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(9, 36)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(60, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Employee ID"
        '
        'grpallowance
        '
        Me.grpallowance.Controls.Add(Me.txtwasall)
        Me.grpallowance.Controls.Add(Me.LabelControl13)
        Me.grpallowance.Controls.Add(Me.txtcashall)
        Me.grpallowance.Controls.Add(Me.LabelControl12)
        Me.grpallowance.Controls.Add(Me.txtfpi)
        Me.grpallowance.Controls.Add(Me.LabelControl11)
        Me.grpallowance.Controls.Add(Me.txtmedall)
        Me.grpallowance.Controls.Add(Me.LabelControl10)
        Me.grpallowance.Controls.Add(Me.txthra)
        Me.grpallowance.Controls.Add(Me.LabelControl9)
        Me.grpallowance.Controls.Add(Me.txtda)
        Me.grpallowance.Controls.Add(Me.LabelControl8)
        Me.grpallowance.Controls.Add(Me.txtgpay)
        Me.grpallowance.Controls.Add(Me.LabelControl7)
        Me.grpallowance.Location = New System.Drawing.Point(352, 1)
        Me.grpallowance.Name = "grpallowance"
        Me.grpallowance.Size = New System.Drawing.Size(314, 283)
        Me.grpallowance.TabIndex = 1
        Me.grpallowance.Text = "Employee Allowances"
        '
        'txtwasall
        '
        Me.txtwasall.Location = New System.Drawing.Point(121, 248)
        Me.txtwasall.Name = "txtwasall"
        Me.txtwasall.Size = New System.Drawing.Size(132, 20)
        Me.txtwasall.TabIndex = 14
        '
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(14, 251)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(76, 13)
        Me.LabelControl13.TabIndex = 12
        Me.LabelControl13.Text = "Was. Allowance"
        '
        'txtcashall
        '
        Me.txtcashall.Location = New System.Drawing.Point(121, 212)
        Me.txtcashall.Name = "txtcashall"
        Me.txtcashall.Size = New System.Drawing.Size(132, 20)
        Me.txtcashall.TabIndex = 13
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(13, 219)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(76, 13)
        Me.LabelControl12.TabIndex = 10
        Me.LabelControl12.Text = "Cash.Allowance"
        '
        'txtfpi
        '
        Me.txtfpi.Location = New System.Drawing.Point(121, 177)
        Me.txtfpi.Name = "txtfpi"
        Me.txtfpi.Size = New System.Drawing.Size(132, 20)
        Me.txtfpi.TabIndex = 12
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(13, 179)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl11.TabIndex = 8
        Me.LabelControl11.Text = "F.P.I"
        '
        'txtmedall
        '
        Me.txtmedall.Location = New System.Drawing.Point(121, 141)
        Me.txtmedall.Name = "txtmedall"
        Me.txtmedall.Size = New System.Drawing.Size(132, 20)
        Me.txtmedall.TabIndex = 11
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(13, 143)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(72, 13)
        Me.LabelControl10.TabIndex = 6
        Me.LabelControl10.Text = "Med.Allowance"
        '
        'txthra
        '
        Me.txthra.Location = New System.Drawing.Point(121, 104)
        Me.txthra.Name = "txthra"
        Me.txthra.Size = New System.Drawing.Size(132, 20)
        Me.txthra.TabIndex = 10
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(13, 108)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(29, 13)
        Me.LabelControl9.TabIndex = 4
        Me.LabelControl9.Text = "H.R.A"
        '
        'txtda
        '
        Me.txtda.Location = New System.Drawing.Point(121, 68)
        Me.txtda.Name = "txtda"
        Me.txtda.Size = New System.Drawing.Size(132, 20)
        Me.txtda.TabIndex = 9
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(14, 73)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(18, 13)
        Me.LabelControl8.TabIndex = 2
        Me.LabelControl8.Text = "D.A"
        '
        'txtgpay
        '
        Me.txtgpay.Location = New System.Drawing.Point(121, 32)
        Me.txtgpay.Name = "txtgpay"
        Me.txtgpay.Size = New System.Drawing.Size(132, 20)
        Me.txtgpay.TabIndex = 8
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(14, 36)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(29, 13)
        Me.LabelControl7.TabIndex = 0
        Me.LabelControl7.Text = "G.Pay"
        '
        'grptax
        '
        Me.grptax.Controls.Add(Me.txtgi)
        Me.grptax.Controls.Add(Me.LabelControl21)
        Me.grptax.Controls.Add(Me.txtcpf)
        Me.grptax.Controls.Add(Me.LabelControl20)
        Me.grptax.Controls.Add(Me.txtdeduc)
        Me.grptax.Controls.Add(Me.LabelControl17)
        Me.grptax.Controls.Add(Me.txtit)
        Me.grptax.Controls.Add(Me.txtpf)
        Me.grptax.Controls.Add(Me.LabelControl16)
        Me.grptax.Controls.Add(Me.LabelControl15)
        Me.grptax.Controls.Add(Me.txtgpf)
        Me.grptax.Controls.Add(Me.LabelControl14)
        Me.grptax.Location = New System.Drawing.Point(667, 1)
        Me.grptax.Name = "grptax"
        Me.grptax.Size = New System.Drawing.Size(228, 283)
        Me.grptax.TabIndex = 2
        Me.grptax.Text = "Employee Tax Deductions"
        '
        'txtgi
        '
        Me.txtgi.Location = New System.Drawing.Point(61, 176)
        Me.txtgi.Name = "txtgi"
        Me.txtgi.Size = New System.Drawing.Size(132, 20)
        Me.txtgi.TabIndex = 19
        '
        'LabelControl21
        '
        Me.LabelControl21.Location = New System.Drawing.Point(22, 179)
        Me.LabelControl21.Name = "LabelControl21"
        Me.LabelControl21.Size = New System.Drawing.Size(19, 13)
        Me.LabelControl21.TabIndex = 23
        Me.LabelControl21.Text = "G.I."
        '
        'txtcpf
        '
        Me.txtcpf.Location = New System.Drawing.Point(61, 68)
        Me.txtcpf.Name = "txtcpf"
        Me.txtcpf.Size = New System.Drawing.Size(132, 20)
        Me.txtcpf.TabIndex = 16
        '
        'LabelControl20
        '
        Me.LabelControl20.Location = New System.Drawing.Point(19, 73)
        Me.LabelControl20.Name = "LabelControl20"
        Me.LabelControl20.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl20.TabIndex = 21
        Me.LabelControl20.Text = "C.P.F"
        '
        'txtdeduc
        '
        Me.txtdeduc.Location = New System.Drawing.Point(61, 248)
        Me.txtdeduc.Name = "txtdeduc"
        Me.txtdeduc.Size = New System.Drawing.Size(132, 20)
        Me.txtdeduc.TabIndex = 20
        '
        'LabelControl17
        '
        Me.LabelControl17.Location = New System.Drawing.Point(19, 221)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(80, 13)
        Me.LabelControl17.TabIndex = 19
        Me.LabelControl17.Text = "Total Deductions"
        '
        'txtit
        '
        Me.txtit.Location = New System.Drawing.Point(61, 141)
        Me.txtit.Name = "txtit"
        Me.txtit.Size = New System.Drawing.Size(132, 20)
        Me.txtit.TabIndex = 18
        '
        'txtpf
        '
        Me.txtpf.Location = New System.Drawing.Point(61, 105)
        Me.txtpf.Name = "txtpf"
        Me.txtpf.Size = New System.Drawing.Size(132, 20)
        Me.txtpf.TabIndex = 17
        '
        'LabelControl16
        '
        Me.LabelControl16.Location = New System.Drawing.Point(21, 106)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(16, 13)
        Me.LabelControl16.TabIndex = 16
        Me.LabelControl16.Text = "P.F"
        '
        'LabelControl15
        '
        Me.LabelControl15.Location = New System.Drawing.Point(22, 144)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(18, 13)
        Me.LabelControl15.TabIndex = 15
        Me.LabelControl15.Text = "I.T."
        '
        'txtgpf
        '
        Me.txtgpf.Location = New System.Drawing.Point(61, 32)
        Me.txtgpf.Name = "txtgpf"
        Me.txtgpf.Size = New System.Drawing.Size(132, 20)
        Me.txtgpf.TabIndex = 15
        '
        'LabelControl14
        '
        Me.LabelControl14.Location = New System.Drawing.Point(19, 37)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl14.TabIndex = 0
        Me.LabelControl14.Text = "G.P.F"
        '
        'GroupControl5
        '
        Me.GroupControl5.Controls.Add(Me.grpnet)
        Me.GroupControl5.Location = New System.Drawing.Point(351, 283)
        Me.GroupControl5.Name = "GroupControl5"
        Me.GroupControl5.ShowCaption = False
        Me.GroupControl5.Size = New System.Drawing.Size(544, 51)
        Me.GroupControl5.TabIndex = 3
        Me.GroupControl5.Text = "GroupControl5"
        '
        'grpnet
        '
        Me.grpnet.Controls.Add(Me.txtnet)
        Me.grpnet.Controls.Add(Me.LabelControl19)
        Me.grpnet.Controls.Add(Me.txtgross)
        Me.grpnet.Controls.Add(Me.LabelControl18)
        Me.grpnet.Location = New System.Drawing.Point(1, 2)
        Me.grpnet.Name = "grpnet"
        Me.grpnet.ShowCaption = False
        Me.grpnet.Size = New System.Drawing.Size(543, 47)
        Me.grpnet.TabIndex = 3
        Me.grpnet.Text = "GroupControl6"
        '
        'txtnet
        '
        Me.txtnet.Location = New System.Drawing.Point(378, 14)
        Me.txtnet.Name = "txtnet"
        Me.txtnet.Size = New System.Drawing.Size(132, 20)
        Me.txtnet.TabIndex = 22
        '
        'LabelControl19
        '
        Me.LabelControl19.Location = New System.Drawing.Point(288, 17)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl19.TabIndex = 15
        Me.LabelControl19.Text = "Net Salary"
        '
        'txtgross
        '
        Me.txtgross.Location = New System.Drawing.Point(120, 14)
        Me.txtgross.Name = "txtgross"
        Me.txtgross.Size = New System.Drawing.Size(132, 20)
        Me.txtgross.TabIndex = 21
        '
        'LabelControl18
        '
        Me.LabelControl18.Location = New System.Drawing.Point(13, 17)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(60, 13)
        Me.LabelControl18.TabIndex = 0
        Me.LabelControl18.Text = "Gross Salary"
        '
        'GroupControl7
        '
        Me.GroupControl7.Controls.Add(Me.grdhrm)
        Me.GroupControl7.Location = New System.Drawing.Point(0, 409)
        Me.GroupControl7.Name = "GroupControl7"
        Me.GroupControl7.Size = New System.Drawing.Size(894, 275)
        Me.GroupControl7.TabIndex = 10
        Me.GroupControl7.Text = "Employee Yearly Salary LookUp"
        '
        'grdhrm
        '
        Me.grdhrm.Location = New System.Drawing.Point(2, 18)
        Me.grdhrm.MainView = Me.GridView1
        Me.grdhrm.Name = "grdhrm"
        Me.grdhrm.Size = New System.Drawing.Size(892, 255)
        Me.grdhrm.TabIndex = 0
        Me.grdhrm.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.emp_id, Me.f_name, Me.dte, Me.month, Me.year, Me.attend, Me.tax, Me.basic, Me.deduction, Me.gross, Me.net_sal, Me.sal_id})
        Me.GridView1.GridControl = Me.grdhrm
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
        'sal_id
        '
        Me.sal_id.Caption = "sal_id"
        Me.sal_id.FieldName = "sal_id"
        Me.sal_id.Name = "sal_id"
        '
        'btncancel
        '
        Me.btncancel.Image = Global.sms.My.Resources.Resources.Delete
        Me.btncancel.Location = New System.Drawing.Point(671, 356)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(73, 31)
        Me.btncancel.TabIndex = 8
        Me.btncancel.Text = "Cancel"
        '
        'btnedit
        '
        Me.btnedit.Image = Global.sms.My.Resources.Resources.Edit
        Me.btnedit.Location = New System.Drawing.Point(400, 356)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(73, 31)
        Me.btnedit.TabIndex = 6
        Me.btnedit.Text = "Edit"
        '
        'btnsave
        '
        Me.btnsave.Image = Global.sms.My.Resources.Resources.Icon_Disk01_Blue
        Me.btnsave.Location = New System.Drawing.Point(271, 356)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(73, 31)
        Me.btnsave.TabIndex = 5
        Me.btnsave.Text = "Save"
        '
        'btnadd
        '
        Me.btnadd.Image = Global.sms.My.Resources.Resources.plus_27
        Me.btnadd.Location = New System.Drawing.Point(145, 356)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(73, 31)
        Me.btnadd.TabIndex = 4
        Me.btnadd.Text = "Add"
        '
        'btnreset
        '
        Me.btnreset.Image = Global.sms.My.Resources.Resources.reset
        Me.btnreset.Location = New System.Drawing.Point(537, 356)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(73, 31)
        Me.btnreset.TabIndex = 7
        Me.btnreset.Text = "Reset"
        '
        'frmhrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(894, 685)
        Me.Controls.Add(Me.btnreset)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.GroupControl7)
        Me.Controls.Add(Me.GroupControl5)
        Me.Controls.Add(Me.grptax)
        Me.Controls.Add(Me.grpallowance)
        Me.Controls.Add(Me.GroupControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmhrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee Salary Management"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.grpemp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpemp.ResumeLayout(False)
        Me.grpemp.PerformLayout()
        CType(Me.dtpdte.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpdte.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtyear.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtmonth.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbempid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbtaxmethod.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtsalary.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtattned.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtname.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpallowance, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpallowance.ResumeLayout(False)
        Me.grpallowance.PerformLayout()
        CType(Me.txtwasall.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtcashall.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtfpi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtmedall.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txthra.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtgpay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grptax, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grptax.ResumeLayout(False)
        Me.grptax.PerformLayout()
        CType(Me.txtgi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtcpf.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdeduc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtpf.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtgpf.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl5.ResumeLayout(False)
        CType(Me.grpnet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpnet.ResumeLayout(False)
        Me.grpnet.PerformLayout()
        CType(Me.txtnet.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtgross.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl7.ResumeLayout(False)
        CType(Me.grdhrm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grpemp As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtname As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtattned As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SimpleButton12 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grpallowance As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txthra As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtda As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtgpay As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtwasall As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtcashall As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtfpi As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtmedall As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grptax As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtdeduc As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtpf As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtgpf As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl5 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grpnet As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtnet As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtgross As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl7 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grdhrm As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtgi As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl21 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtcpf As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl20 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtsalary As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl22 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbtaxmethod As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cmbempid As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents btncancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnedit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnsave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnadd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnreset As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtyear As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtmonth As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl23 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtpdte As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lblbasic As System.Windows.Forms.Label
    Friend WithEvents lbltax As System.Windows.Forms.Label
    Friend WithEvents lblattend As System.Windows.Forms.Label
    Friend WithEvents lbldte As System.Windows.Forms.Label
    Friend WithEvents lblempid As System.Windows.Forms.Label
    Friend WithEvents emp_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dte As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents month As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents year As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents attend As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tax As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents basic As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gross As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents net_sal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents deduction As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents f_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sal_id As DevExpress.XtraGrid.Columns.GridColumn
End Class
