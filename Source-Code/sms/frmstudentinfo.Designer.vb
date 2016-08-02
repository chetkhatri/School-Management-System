<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmstudentinfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmstudentinfo))
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.grdstdinfo = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.gr_no = New DevExpress.XtraGrid.Columns.GridColumn
        Me.f_name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.l_name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.address = New DevExpress.XtraGrid.Columns.GridColumn
        Me.stdfrom = New DevExpress.XtraGrid.Columns.GridColumn
        Me.stddob = New DevExpress.XtraGrid.Columns.GridColumn
        Me.stdgender = New DevExpress.XtraGrid.Columns.GridColumn
        Me.category = New DevExpress.XtraGrid.Columns.GridColumn
        Me.handicap = New DevExpress.XtraGrid.Columns.GridColumn
        Me.stdcaste = New DevExpress.XtraGrid.Columns.GridColumn
        Me.m_name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.mo_name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.blood_grp = New DevExpress.XtraGrid.Columns.GridColumn
        Me.b_place = New DevExpress.XtraGrid.Columns.GridColumn
        Me.contactno = New DevExpress.XtraGrid.Columns.GridColumn
        Me.phno = New DevExpress.XtraGrid.Columns.GridColumn
        Me.mail = New DevExpress.XtraGrid.Columns.GridColumn
        Me.add_dte = New DevExpress.XtraGrid.Columns.GridColumn
        Me.add_std = New DevExpress.XtraGrid.Columns.GridColumn
        Me.skill = New DevExpress.XtraGrid.Columns.GridColumn
        Me.f_contact = New DevExpress.XtraGrid.Columns.GridColumn
        Me.f_business = New DevExpress.XtraGrid.Columns.GridColumn
        Me.f_income = New DevExpress.XtraGrid.Columns.GridColumn
        Me.income_certi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.caste_certi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lc_entry = New DevExpress.XtraGrid.Columns.GridColumn
        Me.result_entry = New DevExpress.XtraGrid.Columns.GridColumn
        Me.entrance = New DevExpress.XtraGrid.Columns.GridColumn
        Me.last_Scl = New DevExpress.XtraGrid.Columns.GridColumn
        Me.grpextrainfo = New DevExpress.XtraEditors.GroupControl
        Me.lblbsplace = New System.Windows.Forms.Label
        Me.txtbplace = New DevExpress.XtraEditors.TextEdit
        Me.lblregion = New System.Windows.Forms.Label
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl
        Me.lblhandicap = New System.Windows.Forms.Label
        Me.lblblood = New System.Windows.Forms.Label
        Me.txtcaste = New DevExpress.XtraEditors.TextEdit
        Me.lblcategory = New System.Windows.Forms.Label
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl
        Me.lblgender = New System.Windows.Forms.Label
        Me.dtpdob = New DevExpress.XtraEditors.DateEdit
        Me.lbldob = New System.Windows.Forms.Label
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl
        Me.rdhandino = New System.Windows.Forms.RadioButton
        Me.rdhandiyes = New System.Windows.Forms.RadioButton
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl
        Me.cmbbldgrp = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl
        Me.rdother = New System.Windows.Forms.RadioButton
        Me.rdfmale = New System.Windows.Forms.RadioButton
        Me.rdmale = New System.Windows.Forms.RadioButton
        Me.cmbcategory = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.grpcontact = New DevExpress.XtraEditors.GroupControl
        Me.lblemail = New System.Windows.Forms.Label
        Me.lblphone = New System.Windows.Forms.Label
        Me.lblcontact = New System.Windows.Forms.Label
        Me.txtemailid = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl
        Me.txtphoneno = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl
        Me.txtcontactno = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl
        Me.grpaccont = New DevExpress.XtraEditors.GroupControl
        Me.lblskills = New System.Windows.Forms.Label
        Me.lbladdstd = New System.Windows.Forms.Label
        Me.lbladdate = New System.Windows.Forms.Label
        Me.cmbaddstd = New DevExpress.XtraEditors.ComboBoxEdit
        Me.dtpadddate = New DevExpress.XtraEditors.DateEdit
        Me.txtskill = New DevExpress.XtraEditors.MemoEdit
        Me.LabelControl20 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl
        Me.grpparentdtl = New DevExpress.XtraEditors.GroupControl
        Me.lblcaste_certi = New System.Windows.Forms.Label
        Me.lblincome_certi = New System.Windows.Forms.Label
        Me.lbly_income = New System.Windows.Forms.Label
        Me.lblf_business = New System.Windows.Forms.Label
        Me.lblfatherno = New System.Windows.Forms.Label
        Me.GroupControl10 = New DevExpress.XtraEditors.GroupControl
        Me.rdcasteno = New System.Windows.Forms.RadioButton
        Me.rdcasteyes = New System.Windows.Forms.RadioButton
        Me.GroupControl9 = New DevExpress.XtraEditors.GroupControl
        Me.rdincno = New System.Windows.Forms.RadioButton
        Me.rdincyes = New System.Windows.Forms.RadioButton
        Me.LabelControl25 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl24 = New DevExpress.XtraEditors.LabelControl
        Me.txtfyearlyin = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl23 = New DevExpress.XtraEditors.LabelControl
        Me.txtfbusiness = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl22 = New DevExpress.XtraEditors.LabelControl
        Me.txtfcont = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl21 = New DevExpress.XtraEditors.LabelControl
        Me.grprelatedinfo = New DevExpress.XtraEditors.GroupControl
        Me.lbllastscl = New System.Windows.Forms.Label
        Me.lblentrance = New System.Windows.Forms.Label
        Me.lbl_result = New System.Windows.Forms.Label
        Me.lbllc = New System.Windows.Forms.Label
        Me.txtlaststudy = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl29 = New DevExpress.XtraEditors.LabelControl
        Me.GroupControl12 = New DevExpress.XtraEditors.GroupControl
        Me.rdresultno = New System.Windows.Forms.RadioButton
        Me.rdresultyes = New System.Windows.Forms.RadioButton
        Me.GroupControl13 = New DevExpress.XtraEditors.GroupControl
        Me.rdlcno = New System.Windows.Forms.RadioButton
        Me.rdlcyes = New System.Windows.Forms.RadioButton
        Me.cmbextrance = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl28 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl27 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl26 = New DevExpress.XtraEditors.LabelControl
        Me.grpphoto = New DevExpress.XtraEditors.GroupControl
        Me.btnpicbro = New DevExpress.XtraEditors.SimpleButton
        Me.picstd = New DevExpress.XtraEditors.PictureEdit
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.grpgeninfo = New DevExpress.XtraEditors.GroupControl
        Me.lblfrom = New System.Windows.Forms.Label
        Me.lbladd = New System.Windows.Forms.Label
        Me.lblmoname = New System.Windows.Forms.Label
        Me.lbllname = New System.Windows.Forms.Label
        Me.lblmname = New System.Windows.Forms.Label
        Me.lblfname = New System.Windows.Forms.Label
        Me.lblgrno = New System.Windows.Forms.Label
        Me.GroupControl16 = New DevExpress.XtraEditors.GroupControl
        Me.rdcity = New System.Windows.Forms.RadioButton
        Me.rdvillage = New System.Windows.Forms.RadioButton
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl
        Me.txtadd = New DevExpress.XtraEditors.MemoEdit
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.txtmothername = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.txtlname = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.txtmname = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.txtfname = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.txtgrno = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.grpsign = New DevExpress.XtraEditors.GroupControl
        Me.btnsignbro = New DevExpress.XtraEditors.SimpleButton
        Me.picsign = New DevExpress.XtraEditors.PictureEdit
        Me.GroupControl17 = New DevExpress.XtraEditors.GroupControl
        Me.GroupControl18 = New DevExpress.XtraEditors.GroupControl
        Me.btnsave = New DevExpress.XtraEditors.SimpleButton
        Me.btnedit = New DevExpress.XtraEditors.SimpleButton
        Me.btncancel = New DevExpress.XtraEditors.SimpleButton
        Me.dlg = New System.Windows.Forms.OpenFileDialog
        Me.btnreset = New DevExpress.XtraEditors.SimpleButton
        Me.btnadd = New DevExpress.XtraEditors.SimpleButton
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdstdinfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpextrainfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpextrainfo.SuspendLayout()
        CType(Me.txtbplace.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtcaste.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpdob.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpdob.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.cmbbldgrp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.cmbcategory.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpcontact, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpcontact.SuspendLayout()
        CType(Me.txtemailid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtphoneno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtcontactno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpaccont, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpaccont.SuspendLayout()
        CType(Me.cmbaddstd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpadddate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpadddate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtskill.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpparentdtl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpparentdtl.SuspendLayout()
        CType(Me.GroupControl10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl10.SuspendLayout()
        CType(Me.GroupControl9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl9.SuspendLayout()
        CType(Me.txtfyearlyin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtfbusiness.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtfcont.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grprelatedinfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grprelatedinfo.SuspendLayout()
        CType(Me.txtlaststudy.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl12, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl12.SuspendLayout()
        CType(Me.GroupControl13, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl13.SuspendLayout()
        CType(Me.cmbextrance.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpphoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpphoto.SuspendLayout()
        CType(Me.picstd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.grpgeninfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpgeninfo.SuspendLayout()
        CType(Me.GroupControl16, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl16.SuspendLayout()
        CType(Me.txtadd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtmothername.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtlname.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtmname.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtfname.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtgrno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpsign, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpsign.SuspendLayout()
        CType(Me.picsign.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl17, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl17.SuspendLayout()
        CType(Me.GroupControl18, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl18.SuspendLayout()
        Me.SuspendLayout()
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.grdstdinfo
        Me.GridView2.Name = "GridView2"
        '
        'grdstdinfo
        '
        GridLevelNode1.LevelTemplate = Me.GridView2
        GridLevelNode1.RelationName = "Level1"
        Me.grdstdinfo.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.grdstdinfo.Location = New System.Drawing.Point(1, 20)
        Me.grdstdinfo.MainView = Me.GridView1
        Me.grdstdinfo.Name = "grdstdinfo"
        Me.grdstdinfo.Size = New System.Drawing.Size(1361, 280)
        Me.grdstdinfo.TabIndex = 0
        Me.grdstdinfo.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1, Me.GridView2})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gr_no, Me.f_name, Me.l_name, Me.address, Me.stdfrom, Me.stddob, Me.stdgender, Me.category, Me.handicap, Me.stdcaste, Me.m_name, Me.mo_name, Me.blood_grp, Me.b_place, Me.contactno, Me.phno, Me.mail, Me.add_dte, Me.add_std, Me.skill, Me.f_contact, Me.f_business, Me.f_income, Me.income_certi, Me.caste_certi, Me.lc_entry, Me.result_entry, Me.entrance, Me.last_Scl})
        Me.GridView1.GridControl = Me.grdstdinfo
        Me.GridView1.Name = "GridView1"
        '
        'gr_no
        '
        Me.gr_no.Caption = "GR No"
        Me.gr_no.FieldName = "gr_no"
        Me.gr_no.Name = "gr_no"
        Me.gr_no.Visible = True
        Me.gr_no.VisibleIndex = 0
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
        'stdfrom
        '
        Me.stdfrom.Caption = "From"
        Me.stdfrom.FieldName = "stdfrom"
        Me.stdfrom.Name = "stdfrom"
        Me.stdfrom.Visible = True
        Me.stdfrom.VisibleIndex = 4
        '
        'stddob
        '
        Me.stddob.Caption = "DOB"
        Me.stddob.FieldName = "stddob"
        Me.stddob.Name = "stddob"
        Me.stddob.Visible = True
        Me.stddob.VisibleIndex = 5
        '
        'stdgender
        '
        Me.stdgender.Caption = "Gender"
        Me.stdgender.FieldName = "stdgender"
        Me.stdgender.Name = "stdgender"
        Me.stdgender.Visible = True
        Me.stdgender.VisibleIndex = 6
        '
        'category
        '
        Me.category.Caption = "Category"
        Me.category.FieldName = "category"
        Me.category.Name = "category"
        Me.category.Visible = True
        Me.category.VisibleIndex = 7
        '
        'handicap
        '
        Me.handicap.Caption = "Handicap"
        Me.handicap.FieldName = "handicap"
        Me.handicap.Name = "handicap"
        Me.handicap.Visible = True
        Me.handicap.VisibleIndex = 8
        '
        'stdcaste
        '
        Me.stdcaste.Caption = "Caste"
        Me.stdcaste.FieldName = "stdcaste"
        Me.stdcaste.Name = "stdcaste"
        Me.stdcaste.Visible = True
        Me.stdcaste.VisibleIndex = 9
        '
        'm_name
        '
        Me.m_name.Caption = "GridColumn2"
        Me.m_name.FieldName = "m_name"
        Me.m_name.Name = "m_name"
        '
        'mo_name
        '
        Me.mo_name.Caption = "GridColumn1"
        Me.mo_name.FieldName = "mo_name"
        Me.mo_name.Name = "mo_name"
        '
        'blood_grp
        '
        Me.blood_grp.Caption = "GridColumn1"
        Me.blood_grp.FieldName = "blood_grp"
        Me.blood_grp.Name = "blood_grp"
        '
        'b_place
        '
        Me.b_place.Caption = "GridColumn1"
        Me.b_place.FieldName = "b_place"
        Me.b_place.Name = "b_place"
        '
        'contactno
        '
        Me.contactno.Caption = "GridColumn1"
        Me.contactno.FieldName = "contactno"
        Me.contactno.Name = "contactno"
        '
        'phno
        '
        Me.phno.Caption = "GridColumn1"
        Me.phno.FieldName = "phno"
        Me.phno.Name = "phno"
        '
        'mail
        '
        Me.mail.Caption = "GridColumn1"
        Me.mail.FieldName = "mail"
        Me.mail.Name = "mail"
        '
        'add_dte
        '
        Me.add_dte.Caption = "GridColumn12"
        Me.add_dte.FieldName = "add_dte"
        Me.add_dte.Name = "add_dte"
        '
        'add_std
        '
        Me.add_std.Caption = "GridColumn11"
        Me.add_std.FieldName = "add_std"
        Me.add_std.Name = "add_std"
        '
        'skill
        '
        Me.skill.Caption = "GridColumn10"
        Me.skill.FieldName = "skill"
        Me.skill.Name = "skill"
        '
        'f_contact
        '
        Me.f_contact.Caption = "GridColumn9"
        Me.f_contact.FieldName = "f_contact"
        Me.f_contact.Name = "f_contact"
        '
        'f_business
        '
        Me.f_business.Caption = "GridColumn8"
        Me.f_business.FieldName = "f_business"
        Me.f_business.Name = "f_business"
        '
        'f_income
        '
        Me.f_income.Caption = "GridColumn7"
        Me.f_income.FieldName = "f_income"
        Me.f_income.Name = "f_income"
        '
        'income_certi
        '
        Me.income_certi.Caption = "GridColumn6"
        Me.income_certi.FieldName = "income_certi"
        Me.income_certi.Name = "income_certi"
        '
        'caste_certi
        '
        Me.caste_certi.Caption = "GridColumn5"
        Me.caste_certi.FieldName = "caste_certi"
        Me.caste_certi.Name = "caste_certi"
        '
        'lc_entry
        '
        Me.lc_entry.Caption = "GridColumn4"
        Me.lc_entry.FieldName = "lc_entry"
        Me.lc_entry.Name = "lc_entry"
        '
        'result_entry
        '
        Me.result_entry.Caption = "GridColumn3"
        Me.result_entry.FieldName = "result_entry"
        Me.result_entry.Name = "result_entry"
        '
        'entrance
        '
        Me.entrance.Caption = "GridColumn2"
        Me.entrance.FieldName = "entrance"
        Me.entrance.Name = "entrance"
        '
        'last_Scl
        '
        Me.last_Scl.Caption = "GridColumn1"
        Me.last_Scl.FieldName = "last_Scl"
        Me.last_Scl.Name = "last_Scl"
        '
        'grpextrainfo
        '
        Me.grpextrainfo.Controls.Add(Me.lblbsplace)
        Me.grpextrainfo.Controls.Add(Me.txtbplace)
        Me.grpextrainfo.Controls.Add(Me.lblregion)
        Me.grpextrainfo.Controls.Add(Me.LabelControl14)
        Me.grpextrainfo.Controls.Add(Me.lblhandicap)
        Me.grpextrainfo.Controls.Add(Me.lblblood)
        Me.grpextrainfo.Controls.Add(Me.txtcaste)
        Me.grpextrainfo.Controls.Add(Me.lblcategory)
        Me.grpextrainfo.Controls.Add(Me.LabelControl13)
        Me.grpextrainfo.Controls.Add(Me.lblgender)
        Me.grpextrainfo.Controls.Add(Me.dtpdob)
        Me.grpextrainfo.Controls.Add(Me.lbldob)
        Me.grpextrainfo.Controls.Add(Me.LabelControl12)
        Me.grpextrainfo.Controls.Add(Me.GroupControl4)
        Me.grpextrainfo.Controls.Add(Me.LabelControl10)
        Me.grpextrainfo.Controls.Add(Me.cmbbldgrp)
        Me.grpextrainfo.Controls.Add(Me.LabelControl9)
        Me.grpextrainfo.Controls.Add(Me.GroupControl3)
        Me.grpextrainfo.Controls.Add(Me.cmbcategory)
        Me.grpextrainfo.Controls.Add(Me.LabelControl8)
        Me.grpextrainfo.Controls.Add(Me.LabelControl7)
        Me.grpextrainfo.Location = New System.Drawing.Point(282, 1)
        Me.grpextrainfo.Name = "grpextrainfo"
        Me.grpextrainfo.Size = New System.Drawing.Size(268, 325)
        Me.grpextrainfo.TabIndex = 2
        Me.grpextrainfo.Text = "Student Extra Information"
        '
        'lblbsplace
        '
        Me.lblbsplace.AutoSize = True
        Me.lblbsplace.Location = New System.Drawing.Point(236, 300)
        Me.lblbsplace.Name = "lblbsplace"
        Me.lblbsplace.Size = New System.Drawing.Size(0, 13)
        Me.lblbsplace.TabIndex = 26
        '
        'txtbplace
        '
        Me.txtbplace.Location = New System.Drawing.Point(98, 296)
        Me.txtbplace.Name = "txtbplace"
        Me.txtbplace.Size = New System.Drawing.Size(131, 20)
        Me.txtbplace.TabIndex = 7
        '
        'lblregion
        '
        Me.lblregion.AutoSize = True
        Me.lblregion.Location = New System.Drawing.Point(237, 269)
        Me.lblregion.Name = "lblregion"
        Me.lblregion.Size = New System.Drawing.Size(0, 13)
        Me.lblregion.TabIndex = 25
        '
        'LabelControl14
        '
        Me.LabelControl14.Location = New System.Drawing.Point(16, 299)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl14.TabIndex = 15
        Me.LabelControl14.Text = "Birth Place"
        '
        'lblhandicap
        '
        Me.lblhandicap.AutoSize = True
        Me.lblhandicap.Location = New System.Drawing.Point(237, 225)
        Me.lblhandicap.Name = "lblhandicap"
        Me.lblhandicap.Size = New System.Drawing.Size(0, 13)
        Me.lblhandicap.TabIndex = 24
        '
        'lblblood
        '
        Me.lblblood.AutoSize = True
        Me.lblblood.Location = New System.Drawing.Point(238, 187)
        Me.lblblood.Name = "lblblood"
        Me.lblblood.Size = New System.Drawing.Size(0, 13)
        Me.lblblood.TabIndex = 23
        '
        'txtcaste
        '
        Me.txtcaste.Location = New System.Drawing.Point(98, 264)
        Me.txtcaste.Name = "txtcaste"
        Me.txtcaste.Size = New System.Drawing.Size(131, 20)
        Me.txtcaste.TabIndex = 6
        '
        'lblcategory
        '
        Me.lblcategory.AutoSize = True
        Me.lblcategory.Location = New System.Drawing.Point(238, 156)
        Me.lblcategory.Name = "lblcategory"
        Me.lblcategory.Size = New System.Drawing.Size(0, 13)
        Me.lblcategory.TabIndex = 22
        '
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(16, 268)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(75, 13)
        Me.LabelControl13.TabIndex = 13
        Me.LabelControl13.Text = "Religion / Caste"
        '
        'lblgender
        '
        Me.lblgender.AutoSize = True
        Me.lblgender.Location = New System.Drawing.Point(238, 69)
        Me.lblgender.Name = "lblgender"
        Me.lblgender.Size = New System.Drawing.Size(0, 13)
        Me.lblgender.TabIndex = 21
        '
        'dtpdob
        '
        Me.dtpdob.EditValue = Nothing
        Me.dtpdob.Location = New System.Drawing.Point(98, 29)
        Me.dtpdob.Name = "dtpdob"
        Me.dtpdob.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpdob.Properties.DisplayFormat.FormatString = "MM/dd/yyyy"
        Me.dtpdob.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtpdob.Properties.EditFormat.FormatString = "MM/dd/yyyy"
        Me.dtpdob.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtpdob.Properties.Mask.EditMask = "MM/dd/yyyy"
        Me.dtpdob.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dtpdob.Size = New System.Drawing.Size(131, 20)
        Me.dtpdob.TabIndex = 1
        '
        'lbldob
        '
        Me.lbldob.AutoSize = True
        Me.lbldob.Location = New System.Drawing.Point(238, 33)
        Me.lbldob.Name = "lbldob"
        Me.lbldob.Size = New System.Drawing.Size(0, 13)
        Me.lbldob.TabIndex = 20
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(16, 31)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(63, 13)
        Me.LabelControl12.TabIndex = 11
        Me.LabelControl12.Text = "Date Of Birth"
        '
        'GroupControl4
        '
        Me.GroupControl4.Controls.Add(Me.rdhandino)
        Me.GroupControl4.Controls.Add(Me.rdhandiyes)
        Me.GroupControl4.Location = New System.Drawing.Point(98, 218)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.ShowCaption = False
        Me.GroupControl4.Size = New System.Drawing.Size(131, 33)
        Me.GroupControl4.TabIndex = 5
        Me.GroupControl4.Text = "GroupControl4"
        '
        'rdhandino
        '
        Me.rdhandino.AutoSize = True
        Me.rdhandino.Location = New System.Drawing.Point(79, 8)
        Me.rdhandino.Name = "rdhandino"
        Me.rdhandino.Size = New System.Drawing.Size(38, 17)
        Me.rdhandino.TabIndex = 1
        Me.rdhandino.TabStop = True
        Me.rdhandino.Text = "No"
        Me.rdhandino.UseVisualStyleBackColor = True
        '
        'rdhandiyes
        '
        Me.rdhandiyes.AutoSize = True
        Me.rdhandiyes.Location = New System.Drawing.Point(12, 8)
        Me.rdhandiyes.Name = "rdhandiyes"
        Me.rdhandiyes.Size = New System.Drawing.Size(42, 17)
        Me.rdhandiyes.TabIndex = 0
        Me.rdhandiyes.TabStop = True
        Me.rdhandiyes.Text = "Yes"
        Me.rdhandiyes.UseVisualStyleBackColor = True
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(16, 226)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl10.TabIndex = 9
        Me.LabelControl10.Text = "Handicap"
        '
        'cmbbldgrp
        '
        Me.cmbbldgrp.Location = New System.Drawing.Point(98, 184)
        Me.cmbbldgrp.Name = "cmbbldgrp"
        Me.cmbbldgrp.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbbldgrp.Properties.Items.AddRange(New Object() {"O+", "A+", "B+", "AB+", "O-", "A-", "B-", "AB-"})
        Me.cmbbldgrp.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cmbbldgrp.Size = New System.Drawing.Size(131, 20)
        Me.cmbbldgrp.TabIndex = 4
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(16, 189)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(58, 13)
        Me.LabelControl9.TabIndex = 7
        Me.LabelControl9.Text = "Blood Group"
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.rdother)
        Me.GroupControl3.Controls.Add(Me.rdfmale)
        Me.GroupControl3.Controls.Add(Me.rdmale)
        Me.GroupControl3.Location = New System.Drawing.Point(98, 62)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.ShowCaption = False
        Me.GroupControl3.Size = New System.Drawing.Size(131, 75)
        Me.GroupControl3.TabIndex = 2
        Me.GroupControl3.Text = "GroupControl3"
        '
        'rdother
        '
        Me.rdother.AutoSize = True
        Me.rdother.Location = New System.Drawing.Point(25, 50)
        Me.rdother.Name = "rdother"
        Me.rdother.Size = New System.Drawing.Size(53, 17)
        Me.rdother.TabIndex = 6
        Me.rdother.TabStop = True
        Me.rdother.Text = "Other"
        Me.rdother.UseVisualStyleBackColor = True
        '
        'rdfmale
        '
        Me.rdfmale.AutoSize = True
        Me.rdfmale.Location = New System.Drawing.Point(25, 29)
        Me.rdfmale.Name = "rdfmale"
        Me.rdfmale.Size = New System.Drawing.Size(59, 17)
        Me.rdfmale.TabIndex = 5
        Me.rdfmale.TabStop = True
        Me.rdfmale.Text = "Female"
        Me.rdfmale.UseVisualStyleBackColor = True
        '
        'rdmale
        '
        Me.rdmale.AutoSize = True
        Me.rdmale.Location = New System.Drawing.Point(25, 9)
        Me.rdmale.Name = "rdmale"
        Me.rdmale.Size = New System.Drawing.Size(47, 17)
        Me.rdmale.TabIndex = 4
        Me.rdmale.TabStop = True
        Me.rdmale.Text = "Male"
        Me.rdmale.UseVisualStyleBackColor = True
        '
        'cmbcategory
        '
        Me.cmbcategory.Location = New System.Drawing.Point(98, 151)
        Me.cmbcategory.Name = "cmbcategory"
        Me.cmbcategory.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbcategory.Properties.Items.AddRange(New Object() {"S.T", "S.C", "S.E.B.C", "Other"})
        Me.cmbcategory.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cmbcategory.Size = New System.Drawing.Size(131, 20)
        Me.cmbcategory.TabIndex = 3
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(16, 154)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(45, 13)
        Me.LabelControl8.TabIndex = 4
        Me.LabelControl8.Text = "Category"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(16, 58)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(35, 13)
        Me.LabelControl7.TabIndex = 0
        Me.LabelControl7.Text = "Gender"
        '
        'grpcontact
        '
        Me.grpcontact.Controls.Add(Me.lblemail)
        Me.grpcontact.Controls.Add(Me.lblphone)
        Me.grpcontact.Controls.Add(Me.lblcontact)
        Me.grpcontact.Controls.Add(Me.txtemailid)
        Me.grpcontact.Controls.Add(Me.LabelControl17)
        Me.grpcontact.Controls.Add(Me.txtphoneno)
        Me.grpcontact.Controls.Add(Me.LabelControl16)
        Me.grpcontact.Controls.Add(Me.txtcontactno)
        Me.grpcontact.Controls.Add(Me.LabelControl15)
        Me.grpcontact.Location = New System.Drawing.Point(551, 1)
        Me.grpcontact.Name = "grpcontact"
        Me.grpcontact.Size = New System.Drawing.Size(252, 126)
        Me.grpcontact.TabIndex = 3
        Me.grpcontact.Text = "Student Contacts"
        '
        'lblemail
        '
        Me.lblemail.AutoSize = True
        Me.lblemail.Location = New System.Drawing.Point(235, 90)
        Me.lblemail.Name = "lblemail"
        Me.lblemail.Size = New System.Drawing.Size(0, 13)
        Me.lblemail.TabIndex = 7
        '
        'lblphone
        '
        Me.lblphone.AutoSize = True
        Me.lblphone.Location = New System.Drawing.Point(235, 63)
        Me.lblphone.Name = "lblphone"
        Me.lblphone.Size = New System.Drawing.Size(0, 13)
        Me.lblphone.TabIndex = 6
        '
        'lblcontact
        '
        Me.lblcontact.AutoSize = True
        Me.lblcontact.Location = New System.Drawing.Point(235, 36)
        Me.lblcontact.Name = "lblcontact"
        Me.lblcontact.Size = New System.Drawing.Size(0, 13)
        Me.lblcontact.TabIndex = 5
        '
        'txtemailid
        '
        Me.txtemailid.Location = New System.Drawing.Point(82, 90)
        Me.txtemailid.Name = "txtemailid"
        Me.txtemailid.Size = New System.Drawing.Size(149, 20)
        Me.txtemailid.TabIndex = 3
        '
        'LabelControl17
        '
        Me.LabelControl17.Location = New System.Drawing.Point(14, 92)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(42, 13)
        Me.LabelControl17.TabIndex = 4
        Me.LabelControl17.Text = "E-Mail ID"
        '
        'txtphoneno
        '
        Me.txtphoneno.Location = New System.Drawing.Point(82, 60)
        Me.txtphoneno.Name = "txtphoneno"
        Me.txtphoneno.Properties.MaxLength = 13
        Me.txtphoneno.Size = New System.Drawing.Size(149, 20)
        Me.txtphoneno.TabIndex = 2
        '
        'LabelControl16
        '
        Me.LabelControl16.Location = New System.Drawing.Point(13, 63)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl16.TabIndex = 2
        Me.LabelControl16.Text = "Phone No"
        '
        'txtcontactno
        '
        Me.txtcontactno.Location = New System.Drawing.Point(82, 31)
        Me.txtcontactno.Name = "txtcontactno"
        Me.txtcontactno.Properties.MaxLength = 13
        Me.txtcontactno.Size = New System.Drawing.Size(149, 20)
        Me.txtcontactno.TabIndex = 1
        '
        'LabelControl15
        '
        Me.LabelControl15.Location = New System.Drawing.Point(13, 34)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(58, 13)
        Me.LabelControl15.TabIndex = 0
        Me.LabelControl15.Text = "Contact No."
        '
        'grpaccont
        '
        Me.grpaccont.Controls.Add(Me.lblskills)
        Me.grpaccont.Controls.Add(Me.lbladdstd)
        Me.grpaccont.Controls.Add(Me.lbladdate)
        Me.grpaccont.Controls.Add(Me.cmbaddstd)
        Me.grpaccont.Controls.Add(Me.dtpadddate)
        Me.grpaccont.Controls.Add(Me.txtskill)
        Me.grpaccont.Controls.Add(Me.LabelControl20)
        Me.grpaccont.Controls.Add(Me.LabelControl19)
        Me.grpaccont.Controls.Add(Me.LabelControl18)
        Me.grpaccont.Location = New System.Drawing.Point(551, 128)
        Me.grpaccont.Name = "grpaccont"
        Me.grpaccont.Size = New System.Drawing.Size(252, 198)
        Me.grpaccont.TabIndex = 4
        Me.grpaccont.Text = "Academic Infomartion"
        '
        'lblskills
        '
        Me.lblskills.AutoSize = True
        Me.lblskills.Location = New System.Drawing.Point(235, 116)
        Me.lblskills.Name = "lblskills"
        Me.lblskills.Size = New System.Drawing.Size(0, 13)
        Me.lblskills.TabIndex = 10
        '
        'lbladdstd
        '
        Me.lbladdstd.AutoSize = True
        Me.lbladdstd.Location = New System.Drawing.Point(235, 62)
        Me.lbladdstd.Name = "lbladdstd"
        Me.lbladdstd.Size = New System.Drawing.Size(0, 13)
        Me.lbladdstd.TabIndex = 9
        '
        'lbladdate
        '
        Me.lbladdate.AutoSize = True
        Me.lbladdate.Location = New System.Drawing.Point(235, 31)
        Me.lbladdate.Name = "lbladdate"
        Me.lbladdate.Size = New System.Drawing.Size(0, 13)
        Me.lbladdate.TabIndex = 8
        '
        'cmbaddstd
        '
        Me.cmbaddstd.Location = New System.Drawing.Point(103, 60)
        Me.cmbaddstd.Name = "cmbaddstd"
        Me.cmbaddstd.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbaddstd.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cmbaddstd.Size = New System.Drawing.Size(128, 20)
        Me.cmbaddstd.TabIndex = 2
        '
        'dtpadddate
        '
        Me.dtpadddate.EditValue = Nothing
        Me.dtpadddate.Location = New System.Drawing.Point(103, 27)
        Me.dtpadddate.Name = "dtpadddate"
        Me.dtpadddate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpadddate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dtpadddate.Size = New System.Drawing.Size(128, 20)
        Me.dtpadddate.TabIndex = 1
        '
        'txtskill
        '
        Me.txtskill.Location = New System.Drawing.Point(14, 112)
        Me.txtskill.Name = "txtskill"
        Me.txtskill.Size = New System.Drawing.Size(217, 77)
        Me.txtskill.TabIndex = 3
        '
        'LabelControl20
        '
        Me.LabelControl20.Location = New System.Drawing.Point(14, 89)
        Me.LabelControl20.Name = "LabelControl20"
        Me.LabelControl20.Size = New System.Drawing.Size(133, 13)
        Me.LabelControl20.TabIndex = 4
        Me.LabelControl20.Text = "Additional Skills And Awards"
        '
        'LabelControl19
        '
        Me.LabelControl19.Location = New System.Drawing.Point(13, 61)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Size = New System.Drawing.Size(75, 13)
        Me.LabelControl19.TabIndex = 2
        Me.LabelControl19.Text = "Addmission STD"
        '
        'LabelControl18
        '
        Me.LabelControl18.Location = New System.Drawing.Point(13, 32)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(79, 13)
        Me.LabelControl18.TabIndex = 0
        Me.LabelControl18.Text = "Addmission Date"
        '
        'grpparentdtl
        '
        Me.grpparentdtl.Controls.Add(Me.lblcaste_certi)
        Me.grpparentdtl.Controls.Add(Me.lblincome_certi)
        Me.grpparentdtl.Controls.Add(Me.lbly_income)
        Me.grpparentdtl.Controls.Add(Me.lblf_business)
        Me.grpparentdtl.Controls.Add(Me.lblfatherno)
        Me.grpparentdtl.Controls.Add(Me.GroupControl10)
        Me.grpparentdtl.Controls.Add(Me.GroupControl9)
        Me.grpparentdtl.Controls.Add(Me.LabelControl25)
        Me.grpparentdtl.Controls.Add(Me.LabelControl24)
        Me.grpparentdtl.Controls.Add(Me.txtfyearlyin)
        Me.grpparentdtl.Controls.Add(Me.LabelControl23)
        Me.grpparentdtl.Controls.Add(Me.txtfbusiness)
        Me.grpparentdtl.Controls.Add(Me.LabelControl22)
        Me.grpparentdtl.Controls.Add(Me.txtfcont)
        Me.grpparentdtl.Controls.Add(Me.LabelControl21)
        Me.grpparentdtl.Location = New System.Drawing.Point(804, 1)
        Me.grpparentdtl.Name = "grpparentdtl"
        Me.grpparentdtl.Size = New System.Drawing.Size(322, 175)
        Me.grpparentdtl.TabIndex = 5
        Me.grpparentdtl.Text = "Parent's Details"
        '
        'lblcaste_certi
        '
        Me.lblcaste_certi.AutoSize = True
        Me.lblcaste_certi.Location = New System.Drawing.Point(293, 149)
        Me.lblcaste_certi.Name = "lblcaste_certi"
        Me.lblcaste_certi.Size = New System.Drawing.Size(0, 13)
        Me.lblcaste_certi.TabIndex = 13
        '
        'lblincome_certi
        '
        Me.lblincome_certi.AutoSize = True
        Me.lblincome_certi.Location = New System.Drawing.Point(293, 115)
        Me.lblincome_certi.Name = "lblincome_certi"
        Me.lblincome_certi.Size = New System.Drawing.Size(0, 13)
        Me.lblincome_certi.TabIndex = 12
        '
        'lbly_income
        '
        Me.lbly_income.AutoSize = True
        Me.lbly_income.Location = New System.Drawing.Point(293, 86)
        Me.lbly_income.Name = "lbly_income"
        Me.lbly_income.Size = New System.Drawing.Size(0, 13)
        Me.lbly_income.TabIndex = 11
        '
        'lblf_business
        '
        Me.lblf_business.AutoSize = True
        Me.lblf_business.Location = New System.Drawing.Point(293, 59)
        Me.lblf_business.Name = "lblf_business"
        Me.lblf_business.Size = New System.Drawing.Size(0, 13)
        Me.lblf_business.TabIndex = 10
        '
        'lblfatherno
        '
        Me.lblfatherno.AutoSize = True
        Me.lblfatherno.Location = New System.Drawing.Point(293, 31)
        Me.lblfatherno.Name = "lblfatherno"
        Me.lblfatherno.Size = New System.Drawing.Size(0, 13)
        Me.lblfatherno.TabIndex = 9
        '
        'GroupControl10
        '
        Me.GroupControl10.Controls.Add(Me.rdcasteno)
        Me.GroupControl10.Controls.Add(Me.rdcasteyes)
        Me.GroupControl10.Location = New System.Drawing.Point(136, 145)
        Me.GroupControl10.Name = "GroupControl10"
        Me.GroupControl10.ShowCaption = False
        Me.GroupControl10.Size = New System.Drawing.Size(149, 26)
        Me.GroupControl10.TabIndex = 5
        Me.GroupControl10.Text = "GroupControl10"
        '
        'rdcasteno
        '
        Me.rdcasteno.AutoSize = True
        Me.rdcasteno.Location = New System.Drawing.Point(87, 4)
        Me.rdcasteno.Name = "rdcasteno"
        Me.rdcasteno.Size = New System.Drawing.Size(38, 17)
        Me.rdcasteno.TabIndex = 1
        Me.rdcasteno.TabStop = True
        Me.rdcasteno.Text = "No"
        Me.rdcasteno.UseVisualStyleBackColor = True
        '
        'rdcasteyes
        '
        Me.rdcasteyes.AutoSize = True
        Me.rdcasteyes.Location = New System.Drawing.Point(20, 4)
        Me.rdcasteyes.Name = "rdcasteyes"
        Me.rdcasteyes.Size = New System.Drawing.Size(42, 17)
        Me.rdcasteyes.TabIndex = 0
        Me.rdcasteyes.TabStop = True
        Me.rdcasteyes.Text = "Yes"
        Me.rdcasteyes.UseVisualStyleBackColor = True
        '
        'GroupControl9
        '
        Me.GroupControl9.Controls.Add(Me.rdincno)
        Me.GroupControl9.Controls.Add(Me.rdincyes)
        Me.GroupControl9.Location = New System.Drawing.Point(135, 111)
        Me.GroupControl9.Name = "GroupControl9"
        Me.GroupControl9.ShowCaption = False
        Me.GroupControl9.Size = New System.Drawing.Size(149, 26)
        Me.GroupControl9.TabIndex = 4
        Me.GroupControl9.Text = "GroupControl9"
        '
        'rdincno
        '
        Me.rdincno.AutoSize = True
        Me.rdincno.Location = New System.Drawing.Point(87, 4)
        Me.rdincno.Name = "rdincno"
        Me.rdincno.Size = New System.Drawing.Size(38, 17)
        Me.rdincno.TabIndex = 1
        Me.rdincno.TabStop = True
        Me.rdincno.Text = "No"
        Me.rdincno.UseVisualStyleBackColor = True
        '
        'rdincyes
        '
        Me.rdincyes.AutoSize = True
        Me.rdincyes.Location = New System.Drawing.Point(20, 4)
        Me.rdincyes.Name = "rdincyes"
        Me.rdincyes.Size = New System.Drawing.Size(42, 17)
        Me.rdincyes.TabIndex = 0
        Me.rdincyes.TabStop = True
        Me.rdincyes.Text = "Yes"
        Me.rdincyes.UseVisualStyleBackColor = True
        '
        'LabelControl25
        '
        Me.LabelControl25.Location = New System.Drawing.Point(19, 151)
        Me.LabelControl25.Name = "LabelControl25"
        Me.LabelControl25.Size = New System.Drawing.Size(81, 13)
        Me.LabelControl25.TabIndex = 8
        Me.LabelControl25.Text = "Caste Certificate"
        '
        'LabelControl24
        '
        Me.LabelControl24.Location = New System.Drawing.Point(20, 120)
        Me.LabelControl24.Name = "LabelControl24"
        Me.LabelControl24.Size = New System.Drawing.Size(88, 13)
        Me.LabelControl24.TabIndex = 7
        Me.LabelControl24.Text = "Income Certificate"
        '
        'txtfyearlyin
        '
        Me.txtfyearlyin.Location = New System.Drawing.Point(135, 83)
        Me.txtfyearlyin.Name = "txtfyearlyin"
        Me.txtfyearlyin.Size = New System.Drawing.Size(149, 20)
        Me.txtfyearlyin.TabIndex = 3
        '
        'LabelControl23
        '
        Me.LabelControl23.Location = New System.Drawing.Point(18, 86)
        Me.LabelControl23.Name = "LabelControl23"
        Me.LabelControl23.Size = New System.Drawing.Size(103, 13)
        Me.LabelControl23.TabIndex = 5
        Me.LabelControl23.Text = "Father Yearly Income"
        '
        'txtfbusiness
        '
        Me.txtfbusiness.Location = New System.Drawing.Point(135, 54)
        Me.txtfbusiness.Name = "txtfbusiness"
        Me.txtfbusiness.Size = New System.Drawing.Size(149, 20)
        Me.txtfbusiness.TabIndex = 2
        '
        'LabelControl22
        '
        Me.LabelControl22.Location = New System.Drawing.Point(18, 59)
        Me.LabelControl22.Name = "LabelControl22"
        Me.LabelControl22.Size = New System.Drawing.Size(81, 13)
        Me.LabelControl22.TabIndex = 3
        Me.LabelControl22.Text = "Father Bussiness"
        '
        'txtfcont
        '
        Me.txtfcont.Location = New System.Drawing.Point(135, 25)
        Me.txtfcont.Name = "txtfcont"
        Me.txtfcont.Properties.MaxLength = 13
        Me.txtfcont.Size = New System.Drawing.Size(149, 20)
        Me.txtfcont.TabIndex = 1
        '
        'LabelControl21
        '
        Me.LabelControl21.Location = New System.Drawing.Point(18, 31)
        Me.LabelControl21.Name = "LabelControl21"
        Me.LabelControl21.Size = New System.Drawing.Size(93, 13)
        Me.LabelControl21.TabIndex = 0
        Me.LabelControl21.Text = "Father Contact No."
        '
        'grprelatedinfo
        '
        Me.grprelatedinfo.Controls.Add(Me.lbllastscl)
        Me.grprelatedinfo.Controls.Add(Me.lblentrance)
        Me.grprelatedinfo.Controls.Add(Me.lbl_result)
        Me.grprelatedinfo.Controls.Add(Me.lbllc)
        Me.grprelatedinfo.Controls.Add(Me.txtlaststudy)
        Me.grprelatedinfo.Controls.Add(Me.LabelControl29)
        Me.grprelatedinfo.Controls.Add(Me.GroupControl12)
        Me.grprelatedinfo.Controls.Add(Me.GroupControl13)
        Me.grprelatedinfo.Controls.Add(Me.cmbextrance)
        Me.grprelatedinfo.Controls.Add(Me.LabelControl28)
        Me.grprelatedinfo.Controls.Add(Me.LabelControl27)
        Me.grprelatedinfo.Controls.Add(Me.LabelControl26)
        Me.grprelatedinfo.Location = New System.Drawing.Point(804, 177)
        Me.grprelatedinfo.Name = "grprelatedinfo"
        Me.grprelatedinfo.Size = New System.Drawing.Size(323, 149)
        Me.grprelatedinfo.TabIndex = 6
        Me.grprelatedinfo.Text = "Related Information"
        '
        'lbllastscl
        '
        Me.lbllastscl.AutoSize = True
        Me.lbllastscl.Location = New System.Drawing.Point(293, 123)
        Me.lbllastscl.Name = "lbllastscl"
        Me.lbllastscl.Size = New System.Drawing.Size(0, 13)
        Me.lbllastscl.TabIndex = 22
        '
        'lblentrance
        '
        Me.lblentrance.AutoSize = True
        Me.lblentrance.Location = New System.Drawing.Point(293, 99)
        Me.lblentrance.Name = "lblentrance"
        Me.lblentrance.Size = New System.Drawing.Size(0, 13)
        Me.lblentrance.TabIndex = 21
        '
        'lbl_result
        '
        Me.lbl_result.AutoSize = True
        Me.lbl_result.Location = New System.Drawing.Point(293, 68)
        Me.lbl_result.Name = "lbl_result"
        Me.lbl_result.Size = New System.Drawing.Size(0, 13)
        Me.lbl_result.TabIndex = 20
        '
        'lbllc
        '
        Me.lbllc.AutoSize = True
        Me.lbllc.Location = New System.Drawing.Point(293, 34)
        Me.lbllc.Name = "lbllc"
        Me.lbllc.Size = New System.Drawing.Size(0, 13)
        Me.lbllc.TabIndex = 14
        '
        'txtlaststudy
        '
        Me.txtlaststudy.Location = New System.Drawing.Point(135, 120)
        Me.txtlaststudy.Name = "txtlaststudy"
        Me.txtlaststudy.Size = New System.Drawing.Size(149, 20)
        Me.txtlaststudy.TabIndex = 4
        '
        'LabelControl29
        '
        Me.LabelControl29.Location = New System.Drawing.Point(23, 123)
        Me.LabelControl29.Name = "LabelControl29"
        Me.LabelControl29.Size = New System.Drawing.Size(64, 13)
        Me.LabelControl29.TabIndex = 19
        Me.LabelControl29.Text = "Last Study @"
        '
        'GroupControl12
        '
        Me.GroupControl12.Controls.Add(Me.rdresultno)
        Me.GroupControl12.Controls.Add(Me.rdresultyes)
        Me.GroupControl12.Location = New System.Drawing.Point(136, 60)
        Me.GroupControl12.Name = "GroupControl12"
        Me.GroupControl12.ShowCaption = False
        Me.GroupControl12.Size = New System.Drawing.Size(149, 26)
        Me.GroupControl12.TabIndex = 2
        Me.GroupControl12.Text = "GroupControl12"
        '
        'rdresultno
        '
        Me.rdresultno.AutoSize = True
        Me.rdresultno.Location = New System.Drawing.Point(87, 4)
        Me.rdresultno.Name = "rdresultno"
        Me.rdresultno.Size = New System.Drawing.Size(38, 17)
        Me.rdresultno.TabIndex = 1
        Me.rdresultno.TabStop = True
        Me.rdresultno.Text = "No"
        Me.rdresultno.UseVisualStyleBackColor = True
        '
        'rdresultyes
        '
        Me.rdresultyes.AutoSize = True
        Me.rdresultyes.Location = New System.Drawing.Point(20, 4)
        Me.rdresultyes.Name = "rdresultyes"
        Me.rdresultyes.Size = New System.Drawing.Size(42, 17)
        Me.rdresultyes.TabIndex = 0
        Me.rdresultyes.TabStop = True
        Me.rdresultyes.Text = "Yes"
        Me.rdresultyes.UseVisualStyleBackColor = True
        '
        'GroupControl13
        '
        Me.GroupControl13.Controls.Add(Me.rdlcno)
        Me.GroupControl13.Controls.Add(Me.rdlcyes)
        Me.GroupControl13.Location = New System.Drawing.Point(135, 26)
        Me.GroupControl13.Name = "GroupControl13"
        Me.GroupControl13.ShowCaption = False
        Me.GroupControl13.Size = New System.Drawing.Size(149, 26)
        Me.GroupControl13.TabIndex = 1
        Me.GroupControl13.Text = "GroupControl13"
        '
        'rdlcno
        '
        Me.rdlcno.AutoSize = True
        Me.rdlcno.Location = New System.Drawing.Point(87, 4)
        Me.rdlcno.Name = "rdlcno"
        Me.rdlcno.Size = New System.Drawing.Size(38, 17)
        Me.rdlcno.TabIndex = 1
        Me.rdlcno.TabStop = True
        Me.rdlcno.Text = "No"
        Me.rdlcno.UseVisualStyleBackColor = True
        '
        'rdlcyes
        '
        Me.rdlcyes.AutoSize = True
        Me.rdlcyes.Location = New System.Drawing.Point(20, 4)
        Me.rdlcyes.Name = "rdlcyes"
        Me.rdlcyes.Size = New System.Drawing.Size(42, 17)
        Me.rdlcyes.TabIndex = 0
        Me.rdlcyes.TabStop = True
        Me.rdlcyes.Text = "Yes"
        Me.rdlcyes.UseVisualStyleBackColor = True
        '
        'cmbextrance
        '
        Me.cmbextrance.Location = New System.Drawing.Point(136, 94)
        Me.cmbextrance.Name = "cmbextrance"
        Me.cmbextrance.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbextrance.Properties.Items.AddRange(New Object() {"A+", "A", "B+", "B", "C"})
        Me.cmbextrance.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cmbextrance.Size = New System.Drawing.Size(149, 20)
        Me.cmbextrance.TabIndex = 3
        '
        'LabelControl28
        '
        Me.LabelControl28.Location = New System.Drawing.Point(24, 97)
        Me.LabelControl28.Name = "LabelControl28"
        Me.LabelControl28.Size = New System.Drawing.Size(76, 13)
        Me.LabelControl28.TabIndex = 15
        Me.LabelControl28.Text = "Entrance Result"
        '
        'LabelControl27
        '
        Me.LabelControl27.Location = New System.Drawing.Point(23, 66)
        Me.LabelControl27.Name = "LabelControl27"
        Me.LabelControl27.Size = New System.Drawing.Size(59, 13)
        Me.LabelControl27.TabIndex = 14
        Me.LabelControl27.Text = "Result Entry"
        '
        'LabelControl26
        '
        Me.LabelControl26.Location = New System.Drawing.Point(25, 35)
        Me.LabelControl26.Name = "LabelControl26"
        Me.LabelControl26.Size = New System.Drawing.Size(41, 13)
        Me.LabelControl26.TabIndex = 0
        Me.LabelControl26.Text = "LC Entry"
        '
        'grpphoto
        '
        Me.grpphoto.Controls.Add(Me.btnpicbro)
        Me.grpphoto.Controls.Add(Me.picstd)
        Me.grpphoto.Location = New System.Drawing.Point(1127, 1)
        Me.grpphoto.Name = "grpphoto"
        Me.grpphoto.Size = New System.Drawing.Size(238, 176)
        Me.grpphoto.TabIndex = 7
        Me.grpphoto.Text = "Photograph"
        '
        'btnpicbro
        '
        Me.btnpicbro.Location = New System.Drawing.Point(177, 82)
        Me.btnpicbro.Name = "btnpicbro"
        Me.btnpicbro.Size = New System.Drawing.Size(51, 28)
        Me.btnpicbro.TabIndex = 1
        Me.btnpicbro.Text = "..."
        '
        'picstd
        '
        Me.picstd.Location = New System.Drawing.Point(2, 21)
        Me.picstd.Name = "picstd"
        Me.picstd.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.picstd.Size = New System.Drawing.Size(167, 153)
        Me.picstd.TabIndex = 0
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.grpgeninfo)
        Me.GroupControl1.Location = New System.Drawing.Point(1, 1)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.ShowCaption = False
        Me.GroupControl1.Size = New System.Drawing.Size(280, 325)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "GroupControl1"
        '
        'grpgeninfo
        '
        Me.grpgeninfo.Controls.Add(Me.lblfrom)
        Me.grpgeninfo.Controls.Add(Me.lbladd)
        Me.grpgeninfo.Controls.Add(Me.lblmoname)
        Me.grpgeninfo.Controls.Add(Me.lbllname)
        Me.grpgeninfo.Controls.Add(Me.lblmname)
        Me.grpgeninfo.Controls.Add(Me.lblfname)
        Me.grpgeninfo.Controls.Add(Me.lblgrno)
        Me.grpgeninfo.Controls.Add(Me.GroupControl16)
        Me.grpgeninfo.Controls.Add(Me.LabelControl11)
        Me.grpgeninfo.Controls.Add(Me.txtadd)
        Me.grpgeninfo.Controls.Add(Me.LabelControl6)
        Me.grpgeninfo.Controls.Add(Me.txtmothername)
        Me.grpgeninfo.Controls.Add(Me.LabelControl5)
        Me.grpgeninfo.Controls.Add(Me.txtlname)
        Me.grpgeninfo.Controls.Add(Me.LabelControl4)
        Me.grpgeninfo.Controls.Add(Me.txtmname)
        Me.grpgeninfo.Controls.Add(Me.LabelControl3)
        Me.grpgeninfo.Controls.Add(Me.txtfname)
        Me.grpgeninfo.Controls.Add(Me.LabelControl2)
        Me.grpgeninfo.Controls.Add(Me.txtgrno)
        Me.grpgeninfo.Controls.Add(Me.LabelControl1)
        Me.grpgeninfo.Location = New System.Drawing.Point(1, 0)
        Me.grpgeninfo.Name = "grpgeninfo"
        Me.grpgeninfo.Size = New System.Drawing.Size(279, 325)
        Me.grpgeninfo.TabIndex = 1
        Me.grpgeninfo.Text = "Student General  Information"
        '
        'lblfrom
        '
        Me.lblfrom.AutoSize = True
        Me.lblfrom.Location = New System.Drawing.Point(245, 289)
        Me.lblfrom.Name = "lblfrom"
        Me.lblfrom.Size = New System.Drawing.Size(0, 13)
        Me.lblfrom.TabIndex = 19
        '
        'lbladd
        '
        Me.lbladd.AutoSize = True
        Me.lbladd.Location = New System.Drawing.Point(248, 194)
        Me.lbladd.Name = "lbladd"
        Me.lbladd.Size = New System.Drawing.Size(0, 13)
        Me.lbladd.TabIndex = 18
        '
        'lblmoname
        '
        Me.lblmoname.AutoSize = True
        Me.lblmoname.Location = New System.Drawing.Point(248, 155)
        Me.lblmoname.Name = "lblmoname"
        Me.lblmoname.Size = New System.Drawing.Size(0, 13)
        Me.lblmoname.TabIndex = 17
        '
        'lbllname
        '
        Me.lbllname.AutoSize = True
        Me.lbllname.Location = New System.Drawing.Point(248, 124)
        Me.lbllname.Name = "lbllname"
        Me.lbllname.Size = New System.Drawing.Size(0, 13)
        Me.lbllname.TabIndex = 16
        '
        'lblmname
        '
        Me.lblmname.AutoSize = True
        Me.lblmname.Location = New System.Drawing.Point(248, 96)
        Me.lblmname.Name = "lblmname"
        Me.lblmname.Size = New System.Drawing.Size(0, 13)
        Me.lblmname.TabIndex = 15
        '
        'lblfname
        '
        Me.lblfname.AutoSize = True
        Me.lblfname.Location = New System.Drawing.Point(248, 61)
        Me.lblfname.Name = "lblfname"
        Me.lblfname.Size = New System.Drawing.Size(0, 13)
        Me.lblfname.TabIndex = 14
        '
        'lblgrno
        '
        Me.lblgrno.AutoSize = True
        Me.lblgrno.Location = New System.Drawing.Point(248, 33)
        Me.lblgrno.Name = "lblgrno"
        Me.lblgrno.Size = New System.Drawing.Size(0, 13)
        Me.lblgrno.TabIndex = 13
        '
        'GroupControl16
        '
        Me.GroupControl16.Controls.Add(Me.rdcity)
        Me.GroupControl16.Controls.Add(Me.rdvillage)
        Me.GroupControl16.Location = New System.Drawing.Point(85, 278)
        Me.GroupControl16.Name = "GroupControl16"
        Me.GroupControl16.ShowCaption = False
        Me.GroupControl16.Size = New System.Drawing.Size(153, 39)
        Me.GroupControl16.TabIndex = 7
        Me.GroupControl16.Text = "GroupControl16"
        '
        'rdcity
        '
        Me.rdcity.AutoSize = True
        Me.rdcity.Location = New System.Drawing.Point(84, 12)
        Me.rdcity.Name = "rdcity"
        Me.rdcity.Size = New System.Drawing.Size(44, 17)
        Me.rdcity.TabIndex = 1
        Me.rdcity.TabStop = True
        Me.rdcity.Text = "City"
        Me.rdcity.UseVisualStyleBackColor = True
        '
        'rdvillage
        '
        Me.rdvillage.AutoSize = True
        Me.rdvillage.Location = New System.Drawing.Point(15, 12)
        Me.rdvillage.Name = "rdvillage"
        Me.rdvillage.Size = New System.Drawing.Size(55, 17)
        Me.rdvillage.TabIndex = 0
        Me.rdvillage.TabStop = True
        Me.rdvillage.Text = "Village"
        Me.rdvillage.UseVisualStyleBackColor = True
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(12, 278)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl11.TabIndex = 12
        Me.LabelControl11.Text = "From"
        '
        'txtadd
        '
        Me.txtadd.Location = New System.Drawing.Point(85, 187)
        Me.txtadd.Name = "txtadd"
        Me.txtadd.Size = New System.Drawing.Size(153, 80)
        Me.txtadd.TabIndex = 6
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(12, 187)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(39, 13)
        Me.LabelControl6.TabIndex = 10
        Me.LabelControl6.Text = "Address"
        '
        'txtmothername
        '
        Me.txtmothername.Location = New System.Drawing.Point(85, 153)
        Me.txtmothername.Name = "txtmothername"
        Me.txtmothername.Size = New System.Drawing.Size(153, 20)
        Me.txtmothername.TabIndex = 5
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(12, 155)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(64, 13)
        Me.LabelControl5.TabIndex = 8
        Me.LabelControl5.Text = "Mother Name"
        '
        'txtlname
        '
        Me.txtlname.Location = New System.Drawing.Point(85, 121)
        Me.txtlname.Name = "txtlname"
        Me.txtlname.Size = New System.Drawing.Size(153, 20)
        Me.txtlname.TabIndex = 4
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(12, 123)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl4.TabIndex = 6
        Me.LabelControl4.Text = "Last Name"
        '
        'txtmname
        '
        Me.txtmname.Location = New System.Drawing.Point(85, 89)
        Me.txtmname.Name = "txtmname"
        Me.txtmname.Size = New System.Drawing.Size(153, 20)
        Me.txtmname.TabIndex = 3
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(12, 92)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(60, 13)
        Me.LabelControl3.TabIndex = 4
        Me.LabelControl3.Text = "Middle Name"
        '
        'txtfname
        '
        Me.txtfname.Location = New System.Drawing.Point(85, 58)
        Me.txtfname.Name = "txtfname"
        Me.txtfname.Size = New System.Drawing.Size(153, 20)
        Me.txtfname.TabIndex = 2
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(12, 61)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(51, 13)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "First Name"
        '
        'txtgrno
        '
        Me.txtgrno.Location = New System.Drawing.Point(85, 27)
        Me.txtgrno.Name = "txtgrno"
        Me.txtgrno.Properties.ReadOnly = True
        Me.txtgrno.Size = New System.Drawing.Size(153, 20)
        Me.txtgrno.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 30)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(34, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "GR No."
        '
        'grpsign
        '
        Me.grpsign.Controls.Add(Me.btnsignbro)
        Me.grpsign.Controls.Add(Me.picsign)
        Me.grpsign.Location = New System.Drawing.Point(1128, 177)
        Me.grpsign.Name = "grpsign"
        Me.grpsign.Size = New System.Drawing.Size(237, 149)
        Me.grpsign.TabIndex = 8
        Me.grpsign.Text = "Signature"
        '
        'btnsignbro
        '
        Me.btnsignbro.Location = New System.Drawing.Point(176, 68)
        Me.btnsignbro.Name = "btnsignbro"
        Me.btnsignbro.Size = New System.Drawing.Size(51, 28)
        Me.btnsignbro.TabIndex = 1
        Me.btnsignbro.Text = "..."
        '
        'picsign
        '
        Me.picsign.Location = New System.Drawing.Point(2, 22)
        Me.picsign.Name = "picsign"
        Me.picsign.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.picsign.Size = New System.Drawing.Size(167, 124)
        Me.picsign.TabIndex = 0
        '
        'GroupControl17
        '
        Me.GroupControl17.Controls.Add(Me.GroupControl18)
        Me.GroupControl17.Location = New System.Drawing.Point(2, 327)
        Me.GroupControl17.Name = "GroupControl17"
        Me.GroupControl17.ShowCaption = False
        Me.GroupControl17.Size = New System.Drawing.Size(1363, 303)
        Me.GroupControl17.TabIndex = 14
        Me.GroupControl17.Text = "GroupControl17"
        '
        'GroupControl18
        '
        Me.GroupControl18.Controls.Add(Me.grdstdinfo)
        Me.GroupControl18.Location = New System.Drawing.Point(0, 1)
        Me.GroupControl18.Name = "GroupControl18"
        Me.GroupControl18.Size = New System.Drawing.Size(1362, 301)
        Me.GroupControl18.TabIndex = 16
        Me.GroupControl18.Text = "Student Information Management"
        '
        'btnsave
        '
        Me.btnsave.Image = Global.sms.My.Resources.Resources.Icon_Disk01_Blue
        Me.btnsave.Location = New System.Drawing.Point(473, 659)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(73, 31)
        Me.btnsave.TabIndex = 11
        Me.btnsave.Text = "Save"
        '
        'btnedit
        '
        Me.btnedit.Image = Global.sms.My.Resources.Resources.Edit
        Me.btnedit.Location = New System.Drawing.Point(637, 659)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(73, 31)
        Me.btnedit.TabIndex = 12
        Me.btnedit.Text = "Edit"
        '
        'btncancel
        '
        Me.btncancel.Image = Global.sms.My.Resources.Resources.Delete
        Me.btncancel.Location = New System.Drawing.Point(991, 659)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(73, 31)
        Me.btncancel.TabIndex = 14
        Me.btncancel.Text = "Cancel"
        '
        'btnreset
        '
        Me.btnreset.Image = Global.sms.My.Resources.Resources.reset
        Me.btnreset.Location = New System.Drawing.Point(823, 659)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(73, 31)
        Me.btnreset.TabIndex = 13
        Me.btnreset.Text = "Reset"
        '
        'btnadd
        '
        Me.btnadd.Image = Global.sms.My.Resources.Resources.plus_27
        Me.btnadd.Location = New System.Drawing.Point(316, 659)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(69, 31)
        Me.btnadd.TabIndex = 10
        Me.btnadd.Text = "Add"
        '
        'frmstudentinfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1366, 746)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.btnreset)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.GroupControl17)
        Me.Controls.Add(Me.grpsign)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.grpphoto)
        Me.Controls.Add(Me.grprelatedinfo)
        Me.Controls.Add(Me.grpparentdtl)
        Me.Controls.Add(Me.grpaccont)
        Me.Controls.Add(Me.grpcontact)
        Me.Controls.Add(Me.grpextrainfo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmstudentinfo"
        Me.Text = "Student Registration And Information"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdstdinfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpextrainfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpextrainfo.ResumeLayout(False)
        Me.grpextrainfo.PerformLayout()
        CType(Me.txtbplace.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtcaste.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpdob.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpdob.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        Me.GroupControl4.PerformLayout()
        CType(Me.cmbbldgrp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        CType(Me.cmbcategory.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpcontact, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpcontact.ResumeLayout(False)
        Me.grpcontact.PerformLayout()
        CType(Me.txtemailid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtphoneno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtcontactno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpaccont, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpaccont.ResumeLayout(False)
        Me.grpaccont.PerformLayout()
        CType(Me.cmbaddstd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpadddate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpadddate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtskill.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpparentdtl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpparentdtl.ResumeLayout(False)
        Me.grpparentdtl.PerformLayout()
        CType(Me.GroupControl10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl10.ResumeLayout(False)
        Me.GroupControl10.PerformLayout()
        CType(Me.GroupControl9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl9.ResumeLayout(False)
        Me.GroupControl9.PerformLayout()
        CType(Me.txtfyearlyin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtfbusiness.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtfcont.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grprelatedinfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grprelatedinfo.ResumeLayout(False)
        Me.grprelatedinfo.PerformLayout()
        CType(Me.txtlaststudy.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl12, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl12.ResumeLayout(False)
        Me.GroupControl12.PerformLayout()
        CType(Me.GroupControl13, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl13.ResumeLayout(False)
        Me.GroupControl13.PerformLayout()
        CType(Me.cmbextrance.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpphoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpphoto.ResumeLayout(False)
        CType(Me.picstd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.grpgeninfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpgeninfo.ResumeLayout(False)
        Me.grpgeninfo.PerformLayout()
        CType(Me.GroupControl16, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl16.ResumeLayout(False)
        Me.GroupControl16.PerformLayout()
        CType(Me.txtadd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtmothername.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtlname.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtmname.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtfname.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtgrno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpsign, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpsign.ResumeLayout(False)
        CType(Me.picsign.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl17, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl17.ResumeLayout(False)
        CType(Me.GroupControl18, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl18.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpextrainfo As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbbldgrp As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents rdother As System.Windows.Forms.RadioButton
    Friend WithEvents rdfmale As System.Windows.Forms.RadioButton
    Friend WithEvents rdmale As System.Windows.Forms.RadioButton
    Friend WithEvents cmbcategory As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents rdhandino As System.Windows.Forms.RadioButton
    Friend WithEvents rdhandiyes As System.Windows.Forms.RadioButton
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtpdob As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtbplace As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtcaste As DevExpress.XtraEditors.TextEdit
    Friend WithEvents grpcontact As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtphoneno As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtcontactno As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtemailid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grpaccont As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtskill As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl20 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grpparentdtl As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtfyearlyin As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl23 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtfbusiness As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl22 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtfcont As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl21 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl9 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents rdincno As System.Windows.Forms.RadioButton
    Friend WithEvents rdincyes As System.Windows.Forms.RadioButton
    Friend WithEvents LabelControl25 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl24 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grprelatedinfo As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cmbextrance As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl28 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl27 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl26 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl10 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents rdcasteno As System.Windows.Forms.RadioButton
    Friend WithEvents rdcasteyes As System.Windows.Forms.RadioButton
    Friend WithEvents GroupControl12 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents rdresultno As System.Windows.Forms.RadioButton
    Friend WithEvents rdresultyes As System.Windows.Forms.RadioButton
    Friend WithEvents GroupControl13 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents rdlcno As System.Windows.Forms.RadioButton
    Friend WithEvents rdlcyes As System.Windows.Forms.RadioButton
    Friend WithEvents txtlaststudy As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl29 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grpphoto As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grpgeninfo As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl16 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents rdcity As System.Windows.Forms.RadioButton
    Friend WithEvents rdvillage As System.Windows.Forms.RadioButton
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtadd As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtmothername As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtlname As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtmname As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtfname As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtgrno As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents picstd As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents grpsign As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnpicbro As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnsignbro As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents picsign As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents GroupControl17 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl18 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grdstdinfo As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnsave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnedit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btncancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dlg As System.Windows.Forms.OpenFileDialog
    Friend WithEvents dtpadddate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cmbaddstd As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents btnreset As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblgrno As System.Windows.Forms.Label
    Friend WithEvents lblfrom As System.Windows.Forms.Label
    Friend WithEvents lbladd As System.Windows.Forms.Label
    Friend WithEvents lblmoname As System.Windows.Forms.Label
    Friend WithEvents lbllname As System.Windows.Forms.Label
    Friend WithEvents lblmname As System.Windows.Forms.Label
    Friend WithEvents lblfname As System.Windows.Forms.Label
    Friend WithEvents lblbsplace As System.Windows.Forms.Label
    Friend WithEvents lblregion As System.Windows.Forms.Label
    Friend WithEvents lblhandicap As System.Windows.Forms.Label
    Friend WithEvents lblblood As System.Windows.Forms.Label
    Friend WithEvents lblcategory As System.Windows.Forms.Label
    Friend WithEvents lblgender As System.Windows.Forms.Label
    Friend WithEvents lbldob As System.Windows.Forms.Label
    Friend WithEvents lblcontact As System.Windows.Forms.Label
    Friend WithEvents lblemail As System.Windows.Forms.Label
    Friend WithEvents lblphone As System.Windows.Forms.Label
    Friend WithEvents lblskills As System.Windows.Forms.Label
    Friend WithEvents lbladdstd As System.Windows.Forms.Label
    Friend WithEvents lbladdate As System.Windows.Forms.Label
    Friend WithEvents lblcaste_certi As System.Windows.Forms.Label
    Friend WithEvents lblincome_certi As System.Windows.Forms.Label
    Friend WithEvents lbly_income As System.Windows.Forms.Label
    Friend WithEvents lblf_business As System.Windows.Forms.Label
    Friend WithEvents lblfatherno As System.Windows.Forms.Label
    Friend WithEvents lbllastscl As System.Windows.Forms.Label
    Friend WithEvents lblentrance As System.Windows.Forms.Label
    Friend WithEvents lbl_result As System.Windows.Forms.Label
    Friend WithEvents lbllc As System.Windows.Forms.Label
    Friend WithEvents btnadd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gr_no As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents f_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents l_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents address As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents stdfrom As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents stddob As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents stdgender As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents category As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents handicap As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents stdcaste As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents m_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents mo_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents blood_grp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents b_place As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents contactno As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents phno As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents mail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents add_dte As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents add_std As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents skill As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents f_contact As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents f_business As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents f_income As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents income_certi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents caste_certi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lc_entry As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents result_entry As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents entrance As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents last_Scl As DevExpress.XtraGrid.Columns.GridColumn
End Class
