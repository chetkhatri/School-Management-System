<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmemployee
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmemployee))
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl
        Me.grpempgvt = New DevExpress.XtraEditors.GroupControl
        Me.lblcpf = New System.Windows.Forms.Label
        Me.lblgpf = New System.Windows.Forms.Label
        Me.lblpranno = New System.Windows.Forms.Label
        Me.lblpanno = New System.Windows.Forms.Label
        Me.txtcpfno = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl
        Me.txtgpfno = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl
        Me.txtpranno = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl
        Me.txtpanno = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl
        Me.grpemppersonal = New DevExpress.XtraEditors.GroupControl
        Me.GroupControl7 = New DevExpress.XtraEditors.GroupControl
        Me.btnsign = New DevExpress.XtraEditors.SimpleButton
        Me.btnsignbro = New DevExpress.XtraEditors.SimpleButton
        Me.picsign = New DevExpress.XtraEditors.PictureEdit
        Me.GroupControl14 = New DevExpress.XtraEditors.GroupControl
        Me.btnphotobro = New DevExpress.XtraEditors.SimpleButton
        Me.picphoto = New DevExpress.XtraEditors.PictureEdit
        Me.grpempadv = New DevExpress.XtraEditors.GroupControl
        Me.lblclass = New System.Windows.Forms.Label
        Me.lblsubject = New System.Windows.Forms.Label
        Me.lbldteto = New System.Windows.Forms.Label
        Me.lbldtefrom = New System.Windows.Forms.Label
        Me.lblgender = New System.Windows.Forms.Label
        Me.lbldob = New System.Windows.Forms.Label
        Me.cmbclass = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl
        Me.cmbsubject = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl
        Me.dtpdteto = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl
        Me.dtpdtefrom = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl
        Me.GroupControl5 = New DevExpress.XtraEditors.GroupControl
        Me.rdother = New System.Windows.Forms.RadioButton
        Me.rdfmale = New System.Windows.Forms.RadioButton
        Me.rdmale = New System.Windows.Forms.RadioButton
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl
        Me.dtpdob = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.GroupControl8 = New DevExpress.XtraEditors.GroupControl
        Me.grdemp = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.emp_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.f_name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.l_name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.address = New DevExpress.XtraGrid.Columns.GridColumn
        Me.co_no = New DevExpress.XtraGrid.Columns.GridColumn
        Me.e_gender = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gov_no = New DevExpress.XtraGrid.Columns.GridColumn
        Me.dte_frm = New DevExpress.XtraGrid.Columns.GridColumn
        Me.dte_to = New DevExpress.XtraGrid.Columns.GridColumn
        Me.pan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.m_name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.email = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tax = New DevExpress.XtraGrid.Columns.GridColumn
        Me.dob = New DevExpress.XtraGrid.Columns.GridColumn
        Me.pran = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gpf = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cpf = New DevExpress.XtraGrid.Columns.GridColumn
        Me.post_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.sub_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.class_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.btncancel = New DevExpress.XtraEditors.SimpleButton
        Me.btnresign = New DevExpress.XtraEditors.SimpleButton
        Me.btnreset = New DevExpress.XtraEditors.SimpleButton
        Me.btnedit = New DevExpress.XtraEditors.SimpleButton
        Me.btnsave = New DevExpress.XtraEditors.SimpleButton
        Me.grpempgen = New DevExpress.XtraEditors.GroupControl
        Me.lblgovno = New System.Windows.Forms.Label
        Me.lbltaxmethod = New System.Windows.Forms.Label
        Me.lblemailid = New System.Windows.Forms.Label
        Me.lblcontactno = New System.Windows.Forms.Label
        Me.lbladd = New System.Windows.Forms.Label
        Me.lblpost = New System.Windows.Forms.Label
        Me.lbllname = New System.Windows.Forms.Label
        Me.lblmname = New System.Windows.Forms.Label
        Me.lblfname = New System.Windows.Forms.Label
        Me.lblempid = New System.Windows.Forms.Label
        Me.btnpost = New DevExpress.XtraEditors.SimpleButton
        Me.txtgovempno = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl20 = New DevExpress.XtraEditors.LabelControl
        Me.cmbtaxmethod = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl
        Me.txtemailid = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.txtcontactno = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.txtadd = New DevExpress.XtraEditors.MemoEdit
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.cmbpost = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.txtlname = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.txtmname = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.txtfname = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.txtempid = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.dlg = New System.Windows.Forms.OpenFileDialog
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.grpempgvt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpempgvt.SuspendLayout()
        CType(Me.txtcpfno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtgpfno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtpranno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtpanno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpemppersonal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpemppersonal.SuspendLayout()
        CType(Me.GroupControl7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl7.SuspendLayout()
        CType(Me.picsign.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl14, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl14.SuspendLayout()
        CType(Me.picphoto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpempadv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpempadv.SuspendLayout()
        CType(Me.cmbclass.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbsubject.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpdteto.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpdteto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpdtefrom.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpdtefrom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl5.SuspendLayout()
        CType(Me.dtpdob.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpdob.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl8.SuspendLayout()
        CType(Me.grdemp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpempgen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpempgen.SuspendLayout()
        CType(Me.txtgovempno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbtaxmethod.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtemailid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtcontactno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtadd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbpost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtlname.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtmname.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtfname.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtempid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.grpempgvt)
        Me.GroupControl3.Controls.Add(Me.grpemppersonal)
        Me.GroupControl3.Controls.Add(Me.grpempadv)
        Me.GroupControl3.Location = New System.Drawing.Point(358, 1)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.ShowCaption = False
        Me.GroupControl3.Size = New System.Drawing.Size(580, 360)
        Me.GroupControl3.TabIndex = 1
        Me.GroupControl3.Text = "GroupControl3"
        '
        'grpempgvt
        '
        Me.grpempgvt.Controls.Add(Me.lblcpf)
        Me.grpempgvt.Controls.Add(Me.lblgpf)
        Me.grpempgvt.Controls.Add(Me.lblpranno)
        Me.grpempgvt.Controls.Add(Me.lblpanno)
        Me.grpempgvt.Controls.Add(Me.txtcpfno)
        Me.grpempgvt.Controls.Add(Me.LabelControl19)
        Me.grpempgvt.Controls.Add(Me.txtgpfno)
        Me.grpempgvt.Controls.Add(Me.LabelControl18)
        Me.grpempgvt.Controls.Add(Me.txtpranno)
        Me.grpempgvt.Controls.Add(Me.LabelControl17)
        Me.grpempgvt.Controls.Add(Me.txtpanno)
        Me.grpempgvt.Controls.Add(Me.LabelControl16)
        Me.grpempgvt.Location = New System.Drawing.Point(1, 278)
        Me.grpempgvt.Name = "grpempgvt"
        Me.grpempgvt.Size = New System.Drawing.Size(335, 82)
        Me.grpempgvt.TabIndex = 1
        Me.grpempgvt.Text = "Employee Govt.Identification"
        '
        'lblcpf
        '
        Me.lblcpf.AutoSize = True
        Me.lblcpf.Location = New System.Drawing.Point(320, 57)
        Me.lblcpf.Name = "lblcpf"
        Me.lblcpf.Size = New System.Drawing.Size(0, 13)
        Me.lblcpf.TabIndex = 25
        '
        'lblgpf
        '
        Me.lblgpf.AutoSize = True
        Me.lblgpf.Location = New System.Drawing.Point(320, 28)
        Me.lblgpf.Name = "lblgpf"
        Me.lblgpf.Size = New System.Drawing.Size(0, 13)
        Me.lblgpf.TabIndex = 24
        '
        'lblpranno
        '
        Me.lblpranno.AutoSize = True
        Me.lblpranno.Location = New System.Drawing.Point(163, 57)
        Me.lblpranno.Name = "lblpranno"
        Me.lblpranno.Size = New System.Drawing.Size(0, 13)
        Me.lblpranno.TabIndex = 24
        '
        'lblpanno
        '
        Me.lblpanno.AutoSize = True
        Me.lblpanno.Location = New System.Drawing.Point(163, 27)
        Me.lblpanno.Name = "lblpanno"
        Me.lblpanno.Size = New System.Drawing.Size(0, 13)
        Me.lblpanno.TabIndex = 24
        '
        'txtcpfno
        '
        Me.txtcpfno.Location = New System.Drawing.Point(219, 53)
        Me.txtcpfno.Name = "txtcpfno"
        Me.txtcpfno.Size = New System.Drawing.Size(98, 20)
        Me.txtcpfno.TabIndex = 21
        '
        'LabelControl19
        '
        Me.LabelControl19.Location = New System.Drawing.Point(176, 56)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Size = New System.Drawing.Size(35, 13)
        Me.LabelControl19.TabIndex = 6
        Me.LabelControl19.Text = "CPF No"
        '
        'txtgpfno
        '
        Me.txtgpfno.Location = New System.Drawing.Point(219, 24)
        Me.txtgpfno.Name = "txtgpfno"
        Me.txtgpfno.Size = New System.Drawing.Size(98, 20)
        Me.txtgpfno.TabIndex = 20
        '
        'LabelControl18
        '
        Me.LabelControl18.Location = New System.Drawing.Point(176, 27)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(35, 13)
        Me.LabelControl18.TabIndex = 4
        Me.LabelControl18.Text = "GPF No"
        '
        'txtpranno
        '
        Me.txtpranno.Location = New System.Drawing.Point(62, 53)
        Me.txtpranno.Name = "txtpranno"
        Me.txtpranno.Size = New System.Drawing.Size(98, 20)
        Me.txtpranno.TabIndex = 19
        '
        'LabelControl17
        '
        Me.LabelControl17.Location = New System.Drawing.Point(10, 58)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl17.TabIndex = 2
        Me.LabelControl17.Text = "PRAN No."
        '
        'txtpanno
        '
        Me.txtpanno.Location = New System.Drawing.Point(62, 24)
        Me.txtpanno.Name = "txtpanno"
        Me.txtpanno.Size = New System.Drawing.Size(98, 20)
        Me.txtpanno.TabIndex = 18
        '
        'LabelControl16
        '
        Me.LabelControl16.Location = New System.Drawing.Point(10, 26)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(36, 13)
        Me.LabelControl16.TabIndex = 0
        Me.LabelControl16.Text = "PAN No"
        '
        'grpemppersonal
        '
        Me.grpemppersonal.Controls.Add(Me.GroupControl7)
        Me.grpemppersonal.Controls.Add(Me.GroupControl14)
        Me.grpemppersonal.Location = New System.Drawing.Point(337, 1)
        Me.grpemppersonal.Name = "grpemppersonal"
        Me.grpemppersonal.Size = New System.Drawing.Size(242, 359)
        Me.grpemppersonal.TabIndex = 2
        Me.grpemppersonal.Text = "Employee Personal LookUp"
        '
        'GroupControl7
        '
        Me.GroupControl7.Controls.Add(Me.btnsign)
        Me.GroupControl7.Controls.Add(Me.btnsignbro)
        Me.GroupControl7.Controls.Add(Me.picsign)
        Me.GroupControl7.Location = New System.Drawing.Point(2, 206)
        Me.GroupControl7.Name = "GroupControl7"
        Me.GroupControl7.Size = New System.Drawing.Size(238, 153)
        Me.GroupControl7.TabIndex = 10
        Me.GroupControl7.Text = "Signature"
        '
        'btnsign
        '
        Me.btnsign.Location = New System.Drawing.Point(178, 103)
        Me.btnsign.Name = "btnsign"
        Me.btnsign.Size = New System.Drawing.Size(51, 28)
        Me.btnsign.TabIndex = 29
        Me.btnsign.Text = "Sign"
        '
        'btnsignbro
        '
        Me.btnsignbro.Location = New System.Drawing.Point(178, 39)
        Me.btnsignbro.Name = "btnsignbro"
        Me.btnsignbro.Size = New System.Drawing.Size(51, 28)
        Me.btnsignbro.TabIndex = 27
        Me.btnsignbro.Text = "..."
        '
        'picsign
        '
        Me.picsign.Location = New System.Drawing.Point(3, 23)
        Me.picsign.Name = "picsign"
        Me.picsign.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.picsign.Size = New System.Drawing.Size(167, 125)
        Me.picsign.TabIndex = 26
        '
        'GroupControl14
        '
        Me.GroupControl14.Controls.Add(Me.btnphotobro)
        Me.GroupControl14.Controls.Add(Me.picphoto)
        Me.GroupControl14.Location = New System.Drawing.Point(2, 19)
        Me.GroupControl14.Name = "GroupControl14"
        Me.GroupControl14.Size = New System.Drawing.Size(238, 186)
        Me.GroupControl14.TabIndex = 9
        Me.GroupControl14.Text = "Photograph"
        '
        'btnphotobro
        '
        Me.btnphotobro.Location = New System.Drawing.Point(177, 84)
        Me.btnphotobro.Name = "btnphotobro"
        Me.btnphotobro.Size = New System.Drawing.Size(51, 28)
        Me.btnphotobro.TabIndex = 23
        Me.btnphotobro.Text = "..."
        '
        'picphoto
        '
        Me.picphoto.Location = New System.Drawing.Point(3, 22)
        Me.picphoto.Name = "picphoto"
        Me.picphoto.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.picphoto.Size = New System.Drawing.Size(167, 160)
        Me.picphoto.TabIndex = 22
        '
        'grpempadv
        '
        Me.grpempadv.Controls.Add(Me.lblclass)
        Me.grpempadv.Controls.Add(Me.lblsubject)
        Me.grpempadv.Controls.Add(Me.lbldteto)
        Me.grpempadv.Controls.Add(Me.lbldtefrom)
        Me.grpempadv.Controls.Add(Me.lblgender)
        Me.grpempadv.Controls.Add(Me.lbldob)
        Me.grpempadv.Controls.Add(Me.cmbclass)
        Me.grpempadv.Controls.Add(Me.LabelControl14)
        Me.grpempadv.Controls.Add(Me.cmbsubject)
        Me.grpempadv.Controls.Add(Me.LabelControl13)
        Me.grpempadv.Controls.Add(Me.dtpdteto)
        Me.grpempadv.Controls.Add(Me.LabelControl12)
        Me.grpempadv.Controls.Add(Me.dtpdtefrom)
        Me.grpempadv.Controls.Add(Me.LabelControl11)
        Me.grpempadv.Controls.Add(Me.GroupControl5)
        Me.grpempadv.Controls.Add(Me.LabelControl10)
        Me.grpempadv.Controls.Add(Me.dtpdob)
        Me.grpempadv.Controls.Add(Me.LabelControl9)
        Me.grpempadv.Location = New System.Drawing.Point(1, 1)
        Me.grpempadv.Name = "grpempadv"
        Me.grpempadv.Size = New System.Drawing.Size(335, 278)
        Me.grpempadv.TabIndex = 0
        Me.grpempadv.Text = "Employee Advanced LookUp"
        '
        'lblclass
        '
        Me.lblclass.AutoSize = True
        Me.lblclass.Location = New System.Drawing.Point(253, 249)
        Me.lblclass.Name = "lblclass"
        Me.lblclass.Size = New System.Drawing.Size(0, 13)
        Me.lblclass.TabIndex = 23
        '
        'lblsubject
        '
        Me.lblsubject.AutoSize = True
        Me.lblsubject.Location = New System.Drawing.Point(253, 217)
        Me.lblsubject.Name = "lblsubject"
        Me.lblsubject.Size = New System.Drawing.Size(0, 13)
        Me.lblsubject.TabIndex = 22
        '
        'lbldteto
        '
        Me.lbldteto.AutoSize = True
        Me.lbldteto.Location = New System.Drawing.Point(253, 185)
        Me.lbldteto.Name = "lbldteto"
        Me.lbldteto.Size = New System.Drawing.Size(0, 13)
        Me.lbldteto.TabIndex = 21
        '
        'lbldtefrom
        '
        Me.lbldtefrom.AutoSize = True
        Me.lbldtefrom.Location = New System.Drawing.Point(253, 153)
        Me.lbldtefrom.Name = "lbldtefrom"
        Me.lbldtefrom.Size = New System.Drawing.Size(0, 13)
        Me.lbldtefrom.TabIndex = 20
        '
        'lblgender
        '
        Me.lblgender.AutoSize = True
        Me.lblgender.Location = New System.Drawing.Point(253, 63)
        Me.lblgender.Name = "lblgender"
        Me.lblgender.Size = New System.Drawing.Size(0, 13)
        Me.lblgender.TabIndex = 19
        '
        'lbldob
        '
        Me.lbldob.AutoSize = True
        Me.lbldob.Location = New System.Drawing.Point(253, 32)
        Me.lbldob.Name = "lbldob"
        Me.lbldob.Size = New System.Drawing.Size(0, 13)
        Me.lbldob.TabIndex = 18
        '
        'cmbclass
        '
        Me.cmbclass.Location = New System.Drawing.Point(99, 247)
        Me.cmbclass.Name = "cmbclass"
        Me.cmbclass.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbclass.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cmbclass.Size = New System.Drawing.Size(148, 20)
        Me.cmbclass.TabIndex = 17
        '
        'LabelControl14
        '
        Me.LabelControl14.Location = New System.Drawing.Point(16, 249)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(25, 13)
        Me.LabelControl14.TabIndex = 10
        Me.LabelControl14.Text = "Class"
        '
        'cmbsubject
        '
        Me.cmbsubject.Location = New System.Drawing.Point(99, 214)
        Me.cmbsubject.Name = "cmbsubject"
        Me.cmbsubject.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbsubject.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cmbsubject.Size = New System.Drawing.Size(148, 20)
        Me.cmbsubject.TabIndex = 16
        '
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(16, 217)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(36, 13)
        Me.LabelControl13.TabIndex = 8
        Me.LabelControl13.Text = "Subject"
        '
        'dtpdteto
        '
        Me.dtpdteto.EditValue = Nothing
        Me.dtpdteto.Location = New System.Drawing.Point(99, 182)
        Me.dtpdteto.Name = "dtpdteto"
        Me.dtpdteto.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpdteto.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dtpdteto.Size = New System.Drawing.Size(148, 20)
        Me.dtpdteto.TabIndex = 15
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(16, 189)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl12.TabIndex = 6
        Me.LabelControl12.Text = "Date To"
        '
        'dtpdtefrom
        '
        Me.dtpdtefrom.EditValue = Nothing
        Me.dtpdtefrom.Location = New System.Drawing.Point(99, 150)
        Me.dtpdtefrom.Name = "dtpdtefrom"
        Me.dtpdtefrom.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpdtefrom.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dtpdtefrom.Size = New System.Drawing.Size(148, 20)
        Me.dtpdtefrom.TabIndex = 14
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(16, 157)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl11.TabIndex = 4
        Me.LabelControl11.Text = "Date From"
        '
        'GroupControl5
        '
        Me.GroupControl5.Controls.Add(Me.rdother)
        Me.GroupControl5.Controls.Add(Me.rdfmale)
        Me.GroupControl5.Controls.Add(Me.rdmale)
        Me.GroupControl5.Location = New System.Drawing.Point(99, 61)
        Me.GroupControl5.Name = "GroupControl5"
        Me.GroupControl5.ShowCaption = False
        Me.GroupControl5.Size = New System.Drawing.Size(148, 78)
        Me.GroupControl5.TabIndex = 13
        Me.GroupControl5.Text = "GroupControl5"
        '
        'rdother
        '
        Me.rdother.AutoSize = True
        Me.rdother.Location = New System.Drawing.Point(38, 53)
        Me.rdother.Name = "rdother"
        Me.rdother.Size = New System.Drawing.Size(53, 17)
        Me.rdother.TabIndex = 2
        Me.rdother.TabStop = True
        Me.rdother.Text = "Other"
        Me.rdother.UseVisualStyleBackColor = True
        '
        'rdfmale
        '
        Me.rdfmale.AutoSize = True
        Me.rdfmale.Location = New System.Drawing.Point(38, 30)
        Me.rdfmale.Name = "rdfmale"
        Me.rdfmale.Size = New System.Drawing.Size(59, 17)
        Me.rdfmale.TabIndex = 1
        Me.rdfmale.TabStop = True
        Me.rdfmale.Text = "Female"
        Me.rdfmale.UseVisualStyleBackColor = True
        '
        'rdmale
        '
        Me.rdmale.AutoSize = True
        Me.rdmale.Location = New System.Drawing.Point(38, 7)
        Me.rdmale.Name = "rdmale"
        Me.rdmale.Size = New System.Drawing.Size(47, 17)
        Me.rdmale.TabIndex = 0
        Me.rdmale.TabStop = True
        Me.rdmale.Text = "Male"
        Me.rdmale.UseVisualStyleBackColor = True
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(16, 61)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(35, 13)
        Me.LabelControl10.TabIndex = 2
        Me.LabelControl10.Text = "Gender"
        '
        'dtpdob
        '
        Me.dtpdob.EditValue = Nothing
        Me.dtpdob.Location = New System.Drawing.Point(99, 30)
        Me.dtpdob.Name = "dtpdob"
        Me.dtpdob.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpdob.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dtpdob.Size = New System.Drawing.Size(148, 20)
        Me.dtpdob.TabIndex = 12
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(16, 34)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(63, 13)
        Me.LabelControl9.TabIndex = 0
        Me.LabelControl9.Text = "Date Of Birth"
        '
        'GroupControl8
        '
        Me.GroupControl8.Controls.Add(Me.grdemp)
        Me.GroupControl8.Location = New System.Drawing.Point(1, 424)
        Me.GroupControl8.Name = "GroupControl8"
        Me.GroupControl8.Size = New System.Drawing.Size(937, 216)
        Me.GroupControl8.TabIndex = 8
        Me.GroupControl8.Text = "Employee Information Management"
        '
        'grdemp
        '
        Me.grdemp.Location = New System.Drawing.Point(2, 21)
        Me.grdemp.MainView = Me.GridView1
        Me.grdemp.Name = "grdemp"
        Me.grdemp.Size = New System.Drawing.Size(934, 192)
        Me.grdemp.TabIndex = 0
        Me.grdemp.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.emp_id, Me.f_name, Me.l_name, Me.address, Me.co_no, Me.e_gender, Me.gov_no, Me.dte_frm, Me.dte_to, Me.pan, Me.m_name, Me.email, Me.tax, Me.dob, Me.pran, Me.gpf, Me.cpf, Me.post_id, Me.sub_id, Me.class_id})
        Me.GridView1.GridControl = Me.grdemp
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
        Me.f_name.Caption = "First Name"
        Me.f_name.FieldName = "f_name"
        Me.f_name.Name = "f_name"
        Me.f_name.Visible = True
        Me.f_name.VisibleIndex = 1
        '
        'l_name
        '
        Me.l_name.Caption = "Last Name"
        Me.l_name.FieldName = "l_name"
        Me.l_name.Name = "l_name"
        Me.l_name.Visible = True
        Me.l_name.VisibleIndex = 2
        '
        'address
        '
        Me.address.Caption = "Address"
        Me.address.FieldName = "address"
        Me.address.Name = "address"
        Me.address.Visible = True
        Me.address.VisibleIndex = 3
        '
        'co_no
        '
        Me.co_no.Caption = "Contact No"
        Me.co_no.FieldName = "co_no"
        Me.co_no.Name = "co_no"
        Me.co_no.Visible = True
        Me.co_no.VisibleIndex = 4
        '
        'e_gender
        '
        Me.e_gender.Caption = "Gender"
        Me.e_gender.FieldName = "e_gender"
        Me.e_gender.Name = "e_gender"
        Me.e_gender.Visible = True
        Me.e_gender.VisibleIndex = 5
        '
        'gov_no
        '
        Me.gov_no.Caption = "Gov.Emp No"
        Me.gov_no.FieldName = "gov_no"
        Me.gov_no.Name = "gov_no"
        Me.gov_no.Visible = True
        Me.gov_no.VisibleIndex = 6
        '
        'dte_frm
        '
        Me.dte_frm.Caption = "Date From"
        Me.dte_frm.FieldName = "dte_frm"
        Me.dte_frm.Name = "dte_frm"
        Me.dte_frm.Visible = True
        Me.dte_frm.VisibleIndex = 7
        '
        'dte_to
        '
        Me.dte_to.Caption = "Date To"
        Me.dte_to.FieldName = "dte_to"
        Me.dte_to.Name = "dte_to"
        Me.dte_to.Visible = True
        Me.dte_to.VisibleIndex = 8
        '
        'pan
        '
        Me.pan.Caption = "PAN No"
        Me.pan.FieldName = "pan"
        Me.pan.Name = "pan"
        '
        'm_name
        '
        Me.m_name.Caption = "Mid name"
        Me.m_name.FieldName = "m_name"
        Me.m_name.Name = "m_name"
        '
        'email
        '
        Me.email.Caption = "email"
        Me.email.FieldName = "email"
        Me.email.Name = "email"
        '
        'tax
        '
        Me.tax.Caption = "Tax Method"
        Me.tax.FieldName = "tax"
        Me.tax.Name = "tax"
        Me.tax.Visible = True
        Me.tax.VisibleIndex = 9
        '
        'dob
        '
        Me.dob.Caption = "dob"
        Me.dob.FieldName = "dob"
        Me.dob.Name = "dob"
        '
        'pran
        '
        Me.pran.Caption = "pran"
        Me.pran.FieldName = "pran"
        Me.pran.Name = "pran"
        '
        'gpf
        '
        Me.gpf.Caption = "gpf"
        Me.gpf.FieldName = "gpf"
        Me.gpf.Name = "gpf"
        '
        'cpf
        '
        Me.cpf.Caption = "cpf"
        Me.cpf.FieldName = "cpf"
        Me.cpf.Name = "cpf"
        '
        'post_id
        '
        Me.post_id.Caption = "post_id"
        Me.post_id.FieldName = "post_id"
        Me.post_id.Name = "post_id"
        '
        'sub_id
        '
        Me.sub_id.Caption = "sub_id"
        Me.sub_id.FieldName = "sub_id"
        Me.sub_id.Name = "sub_id"
        '
        'class_id
        '
        Me.class_id.Caption = "class_id"
        Me.class_id.FieldName = "class_id"
        Me.class_id.Name = "class_id"
        '
        'btncancel
        '
        Me.btncancel.Image = Global.sms.My.Resources.Resources.Delete2
        Me.btncancel.Location = New System.Drawing.Point(658, 377)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(69, 31)
        Me.btncancel.TabIndex = 7
        Me.btncancel.Text = "Cancel"
        '
        'btnresign
        '
        Me.btnresign.Image = Global.sms.My.Resources.Resources.exit1
        Me.btnresign.Location = New System.Drawing.Point(537, 377)
        Me.btnresign.Name = "btnresign"
        Me.btnresign.Size = New System.Drawing.Size(69, 31)
        Me.btnresign.TabIndex = 6
        Me.btnresign.Text = "Resign"
        '
        'btnreset
        '
        Me.btnreset.Image = Global.sms.My.Resources.Resources.reset1
        Me.btnreset.Location = New System.Drawing.Point(414, 377)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(69, 31)
        Me.btnreset.TabIndex = 5
        Me.btnreset.Text = "Reset"
        '
        'btnedit
        '
        Me.btnedit.Image = Global.sms.My.Resources.Resources.Edit
        Me.btnedit.Location = New System.Drawing.Point(298, 377)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(69, 31)
        Me.btnedit.TabIndex = 4
        Me.btnedit.Text = "Edit"
        '
        'btnsave
        '
        Me.btnsave.Image = Global.sms.My.Resources.Resources.Icon_Disk01_Blue1
        Me.btnsave.Location = New System.Drawing.Point(181, 377)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(69, 31)
        Me.btnsave.TabIndex = 3
        Me.btnsave.Text = "Save"
        '
        'grpempgen
        '
        Me.grpempgen.Controls.Add(Me.lblgovno)
        Me.grpempgen.Controls.Add(Me.lbltaxmethod)
        Me.grpempgen.Controls.Add(Me.lblemailid)
        Me.grpempgen.Controls.Add(Me.lblcontactno)
        Me.grpempgen.Controls.Add(Me.lbladd)
        Me.grpempgen.Controls.Add(Me.lblpost)
        Me.grpempgen.Controls.Add(Me.lbllname)
        Me.grpempgen.Controls.Add(Me.lblmname)
        Me.grpempgen.Controls.Add(Me.lblfname)
        Me.grpempgen.Controls.Add(Me.lblempid)
        Me.grpempgen.Controls.Add(Me.btnpost)
        Me.grpempgen.Controls.Add(Me.txtgovempno)
        Me.grpempgen.Controls.Add(Me.LabelControl20)
        Me.grpempgen.Controls.Add(Me.cmbtaxmethod)
        Me.grpempgen.Controls.Add(Me.LabelControl15)
        Me.grpempgen.Controls.Add(Me.txtemailid)
        Me.grpempgen.Controls.Add(Me.LabelControl8)
        Me.grpempgen.Controls.Add(Me.txtcontactno)
        Me.grpempgen.Controls.Add(Me.LabelControl7)
        Me.grpempgen.Controls.Add(Me.txtadd)
        Me.grpempgen.Controls.Add(Me.LabelControl6)
        Me.grpempgen.Controls.Add(Me.cmbpost)
        Me.grpempgen.Controls.Add(Me.LabelControl5)
        Me.grpempgen.Controls.Add(Me.txtlname)
        Me.grpempgen.Controls.Add(Me.LabelControl4)
        Me.grpempgen.Controls.Add(Me.txtmname)
        Me.grpempgen.Controls.Add(Me.LabelControl3)
        Me.grpempgen.Controls.Add(Me.txtfname)
        Me.grpempgen.Controls.Add(Me.LabelControl2)
        Me.grpempgen.Controls.Add(Me.txtempid)
        Me.grpempgen.Controls.Add(Me.LabelControl1)
        Me.grpempgen.Location = New System.Drawing.Point(0, 0)
        Me.grpempgen.Name = "grpempgen"
        Me.grpempgen.Size = New System.Drawing.Size(356, 359)
        Me.grpempgen.TabIndex = 0
        Me.grpempgen.Text = "Employee General LookUp"
        '
        'lblgovno
        '
        Me.lblgovno.AutoSize = True
        Me.lblgovno.Location = New System.Drawing.Point(334, 333)
        Me.lblgovno.Name = "lblgovno"
        Me.lblgovno.Size = New System.Drawing.Size(0, 13)
        Me.lblgovno.TabIndex = 28
        '
        'lbltaxmethod
        '
        Me.lbltaxmethod.AutoSize = True
        Me.lbltaxmethod.Location = New System.Drawing.Point(165, 332)
        Me.lbltaxmethod.Name = "lbltaxmethod"
        Me.lbltaxmethod.Size = New System.Drawing.Size(0, 13)
        Me.lbltaxmethod.TabIndex = 27
        '
        'lblemailid
        '
        Me.lblemailid.AutoSize = True
        Me.lblemailid.Location = New System.Drawing.Point(304, 299)
        Me.lblemailid.Name = "lblemailid"
        Me.lblemailid.Size = New System.Drawing.Size(0, 13)
        Me.lblemailid.TabIndex = 26
        '
        'lblcontactno
        '
        Me.lblcontactno.AutoSize = True
        Me.lblcontactno.Location = New System.Drawing.Point(253, 266)
        Me.lblcontactno.Name = "lblcontactno"
        Me.lblcontactno.Size = New System.Drawing.Size(0, 13)
        Me.lblcontactno.TabIndex = 25
        '
        'lbladd
        '
        Me.lbladd.AutoSize = True
        Me.lbladd.Location = New System.Drawing.Point(253, 192)
        Me.lbladd.Name = "lbladd"
        Me.lbladd.Size = New System.Drawing.Size(0, 13)
        Me.lbladd.TabIndex = 24
        '
        'lblpost
        '
        Me.lblpost.AutoSize = True
        Me.lblpost.Location = New System.Drawing.Point(253, 159)
        Me.lblpost.Name = "lblpost"
        Me.lblpost.Size = New System.Drawing.Size(0, 13)
        Me.lblpost.TabIndex = 23
        '
        'lbllname
        '
        Me.lbllname.AutoSize = True
        Me.lbllname.Location = New System.Drawing.Point(253, 127)
        Me.lbllname.Name = "lbllname"
        Me.lbllname.Size = New System.Drawing.Size(0, 13)
        Me.lbllname.TabIndex = 22
        '
        'lblmname
        '
        Me.lblmname.AutoSize = True
        Me.lblmname.Location = New System.Drawing.Point(253, 95)
        Me.lblmname.Name = "lblmname"
        Me.lblmname.Size = New System.Drawing.Size(0, 13)
        Me.lblmname.TabIndex = 21
        '
        'lblfname
        '
        Me.lblfname.AutoSize = True
        Me.lblfname.Location = New System.Drawing.Point(253, 64)
        Me.lblfname.Name = "lblfname"
        Me.lblfname.Size = New System.Drawing.Size(0, 13)
        Me.lblfname.TabIndex = 20
        '
        'lblempid
        '
        Me.lblempid.AutoSize = True
        Me.lblempid.Location = New System.Drawing.Point(253, 34)
        Me.lblempid.Name = "lblempid"
        Me.lblempid.Size = New System.Drawing.Size(0, 13)
        Me.lblempid.TabIndex = 19
        '
        'btnpost
        '
        Me.btnpost.Image = Global.sms.My.Resources.Resources.plus_27
        Me.btnpost.Location = New System.Drawing.Point(271, 155)
        Me.btnpost.Name = "btnpost"
        Me.btnpost.Size = New System.Drawing.Size(27, 22)
        Me.btnpost.TabIndex = 6
        '
        'txtgovempno
        '
        Me.txtgovempno.Location = New System.Drawing.Point(254, 329)
        Me.txtgovempno.Name = "txtgovempno"
        Me.txtgovempno.Size = New System.Drawing.Size(74, 20)
        Me.txtgovempno.TabIndex = 11
        '
        'LabelControl20
        '
        Me.LabelControl20.Location = New System.Drawing.Point(188, 332)
        Me.LabelControl20.Name = "LabelControl20"
        Me.LabelControl20.Size = New System.Drawing.Size(60, 13)
        Me.LabelControl20.TabIndex = 18
        Me.LabelControl20.Text = "Gov.Emp.No"
        '
        'cmbtaxmethod
        '
        Me.cmbtaxmethod.Location = New System.Drawing.Point(88, 328)
        Me.cmbtaxmethod.Name = "cmbtaxmethod"
        Me.cmbtaxmethod.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbtaxmethod.Properties.Items.AddRange(New Object() {"CPF", "GPF"})
        Me.cmbtaxmethod.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cmbtaxmethod.Size = New System.Drawing.Size(71, 20)
        Me.cmbtaxmethod.TabIndex = 10
        '
        'LabelControl15
        '
        Me.LabelControl15.Location = New System.Drawing.Point(10, 329)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(57, 13)
        Me.LabelControl15.TabIndex = 16
        Me.LabelControl15.Text = "Tax Method"
        '
        'txtemailid
        '
        Me.txtemailid.Location = New System.Drawing.Point(88, 296)
        Me.txtemailid.Name = "txtemailid"
        Me.txtemailid.Size = New System.Drawing.Size(210, 20)
        Me.txtemailid.TabIndex = 9
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(10, 297)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(42, 13)
        Me.LabelControl8.TabIndex = 14
        Me.LabelControl8.Text = "E-Mail ID"
        '
        'txtcontactno
        '
        Me.txtcontactno.Location = New System.Drawing.Point(88, 263)
        Me.txtcontactno.Name = "txtcontactno"
        Me.txtcontactno.Properties.MaxLength = 13
        Me.txtcontactno.Size = New System.Drawing.Size(158, 20)
        Me.txtcontactno.TabIndex = 8
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(10, 266)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl7.TabIndex = 12
        Me.LabelControl7.Text = "Contact No"
        '
        'txtadd
        '
        Me.txtadd.Location = New System.Drawing.Point(88, 189)
        Me.txtadd.Name = "txtadd"
        Me.txtadd.Size = New System.Drawing.Size(158, 58)
        Me.txtadd.TabIndex = 7
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(10, 189)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(39, 13)
        Me.LabelControl6.TabIndex = 10
        Me.LabelControl6.Text = "Address"
        '
        'cmbpost
        '
        Me.cmbpost.Location = New System.Drawing.Point(88, 156)
        Me.cmbpost.Name = "cmbpost"
        Me.cmbpost.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbpost.Properties.Items.AddRange(New Object() {"Principal", "Teacher", "Clerk", "Poen"})
        Me.cmbpost.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cmbpost.Size = New System.Drawing.Size(158, 20)
        Me.cmbpost.TabIndex = 5
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(10, 156)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(21, 13)
        Me.LabelControl5.TabIndex = 8
        Me.LabelControl5.Text = "Post"
        '
        'txtlname
        '
        Me.txtlname.Location = New System.Drawing.Point(88, 124)
        Me.txtlname.Name = "txtlname"
        Me.txtlname.Size = New System.Drawing.Size(158, 20)
        Me.txtlname.TabIndex = 4
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(10, 127)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl4.TabIndex = 6
        Me.LabelControl4.Text = "Last Name"
        '
        'txtmname
        '
        Me.txtmname.Location = New System.Drawing.Point(88, 92)
        Me.txtmname.Name = "txtmname"
        Me.txtmname.Size = New System.Drawing.Size(158, 20)
        Me.txtmname.TabIndex = 3
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(10, 95)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(60, 13)
        Me.LabelControl3.TabIndex = 4
        Me.LabelControl3.Text = "Middle Name"
        '
        'txtfname
        '
        Me.txtfname.Location = New System.Drawing.Point(88, 61)
        Me.txtfname.Name = "txtfname"
        Me.txtfname.Size = New System.Drawing.Size(158, 20)
        Me.txtfname.TabIndex = 2
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(10, 64)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(51, 13)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "First Name"
        '
        'txtempid
        '
        Me.txtempid.Location = New System.Drawing.Point(88, 30)
        Me.txtempid.Name = "txtempid"
        Me.txtempid.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtempid.Properties.Appearance.Options.UseFont = True
        Me.txtempid.Properties.ReadOnly = True
        Me.txtempid.Size = New System.Drawing.Size(158, 20)
        Me.txtempid.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(10, 30)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(60, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Employee ID"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.grpempgen)
        Me.GroupControl1.Location = New System.Drawing.Point(1, 1)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.ShowCaption = False
        Me.GroupControl1.Size = New System.Drawing.Size(356, 360)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "GroupControl1"
        '
        'frmemployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(939, 639)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnresign)
        Me.Controls.Add(Me.btnreset)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.GroupControl8)
        Me.Controls.Add(Me.GroupControl3)
        Me.Controls.Add(Me.GroupControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmemployee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee Registration"
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.grpempgvt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpempgvt.ResumeLayout(False)
        Me.grpempgvt.PerformLayout()
        CType(Me.txtcpfno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtgpfno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtpranno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtpanno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpemppersonal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpemppersonal.ResumeLayout(False)
        CType(Me.GroupControl7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl7.ResumeLayout(False)
        CType(Me.picsign.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl14, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl14.ResumeLayout(False)
        CType(Me.picphoto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpempadv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpempadv.ResumeLayout(False)
        Me.grpempadv.PerformLayout()
        CType(Me.cmbclass.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbsubject.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpdteto.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpdteto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpdtefrom.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpdtefrom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl5.ResumeLayout(False)
        Me.GroupControl5.PerformLayout()
        CType(Me.dtpdob.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpdob.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl8.ResumeLayout(False)
        CType(Me.grdemp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpempgen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpempgen.ResumeLayout(False)
        Me.grpempgen.PerformLayout()
        CType(Me.txtgovempno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbtaxmethod.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtemailid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtcontactno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtadd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbpost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtlname.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtmname.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtfname.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtempid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grpempadv As DevExpress.XtraEditors.GroupControl
    Friend WithEvents dtpdob As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbclass As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbsubject As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtpdteto As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtpdtefrom As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl5 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents rdother As System.Windows.Forms.RadioButton
    Friend WithEvents rdfmale As System.Windows.Forms.RadioButton
    Friend WithEvents rdmale As System.Windows.Forms.RadioButton
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grpemppersonal As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl7 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnsign As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnsignbro As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents picsign As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents GroupControl14 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnphotobro As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents picphoto As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents GroupControl8 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grdemp As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents grpempgvt As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtpanno As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtcpfno As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtgpfno As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtpranno As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btncancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnresign As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnreset As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnedit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnsave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grpempgen As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnpost As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtgovempno As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl20 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbtaxmethod As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtemailid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtcontactno As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtadd As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbpost As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtlname As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtmname As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtfname As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtempid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblemailid As System.Windows.Forms.Label
    Friend WithEvents lblcontactno As System.Windows.Forms.Label
    Friend WithEvents lbladd As System.Windows.Forms.Label
    Friend WithEvents lblpost As System.Windows.Forms.Label
    Friend WithEvents lbllname As System.Windows.Forms.Label
    Friend WithEvents lblmname As System.Windows.Forms.Label
    Friend WithEvents lblfname As System.Windows.Forms.Label
    Friend WithEvents lblempid As System.Windows.Forms.Label
    Friend WithEvents lblgovno As System.Windows.Forms.Label
    Friend WithEvents lbltaxmethod As System.Windows.Forms.Label
    Friend WithEvents lblclass As System.Windows.Forms.Label
    Friend WithEvents lblsubject As System.Windows.Forms.Label
    Friend WithEvents lbldteto As System.Windows.Forms.Label
    Friend WithEvents lbldtefrom As System.Windows.Forms.Label
    Friend WithEvents lblgender As System.Windows.Forms.Label
    Friend WithEvents lbldob As System.Windows.Forms.Label
    Friend WithEvents lblpanno As System.Windows.Forms.Label
    Friend WithEvents lblcpf As System.Windows.Forms.Label
    Friend WithEvents lblgpf As System.Windows.Forms.Label
    Friend WithEvents lblpranno As System.Windows.Forms.Label
    Friend WithEvents f_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents l_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents address As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents co_no As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents e_gender As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gov_no As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dte_frm As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dte_to As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents pan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents m_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents email As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tax As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dob As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents pran As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gpf As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cpf As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents post_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sub_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents class_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dlg As System.Windows.Forms.OpenFileDialog
    Friend WithEvents emp_id As DevExpress.XtraGrid.Columns.GridColumn
End Class
