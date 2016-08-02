<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmgrmaster
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmgrmaster))
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.grdgrmaster = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.gr_no = New DevExpress.XtraGrid.Columns.GridColumn
        Me.year = New DevExpress.XtraGrid.Columns.GridColumn
        Me.f_name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.l_name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.address = New DevExpress.XtraGrid.Columns.GridColumn
        Me.stdfrom = New DevExpress.XtraGrid.Columns.GridColumn
        Me.stddob = New DevExpress.XtraGrid.Columns.GridColumn
        Me.stdgender = New DevExpress.XtraGrid.Columns.GridColumn
        Me.category = New DevExpress.XtraGrid.Columns.GridColumn
        Me.handicap = New DevExpress.XtraGrid.Columns.GridColumn
        Me.stdcaste = New DevExpress.XtraGrid.Columns.GridColumn
        Me.std_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.b_place = New DevExpress.XtraGrid.Columns.GridColumn
        Me.remarks = New DevExpress.XtraGrid.Columns.GridColumn
        Me.add_dte = New DevExpress.XtraGrid.Columns.GridColumn
        Me.add_std = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lc_entry = New DevExpress.XtraGrid.Columns.GridColumn
        Me.result_entry = New DevExpress.XtraGrid.Columns.GridColumn
        Me.last_Scl = New DevExpress.XtraGrid.Columns.GridColumn
        Me.leave_dte = New DevExpress.XtraGrid.Columns.GridColumn
        Me.leave_rsn = New DevExpress.XtraGrid.Columns.GridColumn
        Me.progress = New DevExpress.XtraGrid.Columns.GridColumn
        Me.conduct = New DevExpress.XtraGrid.Columns.GridColumn
        Me.try_pass = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.grpgeninfo = New DevExpress.XtraEditors.GroupControl
        Me.cmbyear = New DevExpress.XtraEditors.DateEdit
        Me.lblremark = New System.Windows.Forms.Label
        Me.lblyear = New System.Windows.Forms.Label
        Me.lblbplace = New System.Windows.Forms.Label
        Me.lbldob = New System.Windows.Forms.Label
        Me.lblstdid = New System.Windows.Forms.Label
        Me.lblgrno = New System.Windows.Forms.Label
        Me.txtremarks = New DevExpress.XtraEditors.MemoEdit
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.txtbplace = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.dtpdob = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.txtstdid = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.txtgrno = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.grpacadinfo = New DevExpress.XtraEditors.GroupControl
        Me.lblleavestd = New System.Windows.Forms.Label
        Me.lblreason = New System.Windows.Forms.Label
        Me.lblscleavedt = New System.Windows.Forms.Label
        Me.lblcategory = New System.Windows.Forms.Label
        Me.lblgender = New System.Windows.Forms.Label
        Me.lblcaste = New System.Windows.Forms.Label
        Me.lbllastschool = New System.Windows.Forms.Label
        Me.lblresultentry = New System.Windows.Forms.Label
        Me.lbllcentery = New System.Windows.Forms.Label
        Me.lbladstd = New System.Windows.Forms.Label
        Me.lbladdate = New System.Windows.Forms.Label
        Me.cmbleavestd = New DevExpress.XtraEditors.ComboBoxEdit
        Me.cmbadstd = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl
        Me.txtleavereson = New DevExpress.XtraEditors.MemoEdit
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl
        Me.dtpleavedate = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl
        Me.cmbcategory = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl
        Me.GroupControl6 = New DevExpress.XtraEditors.GroupControl
        Me.rdother = New System.Windows.Forms.RadioButton
        Me.rdfemale = New System.Windows.Forms.RadioButton
        Me.rdmale = New System.Windows.Forms.RadioButton
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl
        Me.txtcaste = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl
        Me.txtlastscl = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl
        Me.GroupControl5 = New DevExpress.XtraEditors.GroupControl
        Me.rdresultno = New System.Windows.Forms.RadioButton
        Me.rdresultyes = New System.Windows.Forms.RadioButton
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl
        Me.rdlcno = New System.Windows.Forms.RadioButton
        Me.rdlcyes = New System.Windows.Forms.RadioButton
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.dtpaddte = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.GroupControl7 = New DevExpress.XtraEditors.GroupControl
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.cmbtry = New DevExpress.XtraEditors.ComboBoxEdit
        Me.gctry = New DevExpress.XtraGauges.Win.GaugeControl
        Me.DigitalGauge1 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge
        Me.DigitalBackgroundLayerComponent2 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent
        Me.LabelControl20 = New DevExpress.XtraEditors.LabelControl
        Me.grpcapbility = New DevExpress.XtraEditors.GroupControl
        Me.lbltry = New System.Windows.Forms.Label
        Me.lblconduct = New System.Windows.Forms.Label
        Me.lblprogress = New System.Windows.Forms.Label
        Me.cmbconduct = New DevExpress.XtraEditors.ComboBoxEdit
        Me.cmbprogress = New DevExpress.XtraEditors.ComboBoxEdit
        Me.GaugeControl2 = New DevExpress.XtraGauges.Win.GaugeControl
        Me.CircularGauge2 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge
        Me.ArcScaleBackgroundLayerComponent6 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent
        Me.ArcScaleComponent5 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
        Me.ArcScaleBackgroundLayerComponent7 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent
        Me.ArcScaleNeedleComponent4 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
        Me.GaugeControl1 = New DevExpress.XtraGauges.Win.GaugeControl
        Me.CircularGauge1 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge
        Me.ArcScaleBackgroundLayerComponent4 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent
        Me.ArcScaleComponent3 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
        Me.ArcScaleBackgroundLayerComponent5 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent
        Me.ArcScaleNeedleComponent3 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
        Me.ArcScaleComponent4 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl
        Me.ArcScaleComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
        Me.ArcScaleBackgroundLayerComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent
        Me.ArcScaleNeedleComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
        Me.ArcScaleSpindleCapComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent
        Me.ArcScaleComponent2 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
        Me.ArcScaleBackgroundLayerComponent3 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent
        Me.ArcScaleNeedleComponent2 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
        Me.ArcScaleEffectLayerComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent
        Me.ArcScaleBackgroundLayerComponent2 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent
        Me.DigitalBackgroundLayerComponent1 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent
        Me.GroupControl9 = New DevExpress.XtraEditors.GroupControl
        Me.GroupControl10 = New DevExpress.XtraEditors.GroupControl
        Me.btnreset = New DevExpress.XtraEditors.SimpleButton
        Me.btncancel = New DevExpress.XtraEditors.SimpleButton
        Me.btnedit = New DevExpress.XtraEditors.SimpleButton
        Me.btnsave = New DevExpress.XtraEditors.SimpleButton
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdgrmaster, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.grpgeninfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpgeninfo.SuspendLayout()
        CType(Me.cmbyear.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbyear.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtremarks.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtbplace.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpdob.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpdob.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtstdid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtgrno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpacadinfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpacadinfo.SuspendLayout()
        CType(Me.cmbleavestd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbadstd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtleavereson.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpleavedate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpleavedate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbcategory.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl6.SuspendLayout()
        CType(Me.txtcaste.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtlastscl.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl5.SuspendLayout()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.dtpaddte.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpaddte.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl7.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.cmbtry.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DigitalGauge1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DigitalBackgroundLayerComponent2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpcapbility, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpcapbility.SuspendLayout()
        CType(Me.cmbconduct.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbprogress.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CircularGauge2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArcScaleBackgroundLayerComponent6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArcScaleComponent5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArcScaleBackgroundLayerComponent7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArcScaleNeedleComponent4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CircularGauge1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArcScaleBackgroundLayerComponent4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArcScaleComponent3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArcScaleBackgroundLayerComponent5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArcScaleNeedleComponent3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArcScaleComponent4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArcScaleComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArcScaleBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArcScaleNeedleComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArcScaleSpindleCapComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArcScaleComponent2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArcScaleBackgroundLayerComponent3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArcScaleNeedleComponent2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArcScaleEffectLayerComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArcScaleBackgroundLayerComponent2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DigitalBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl9.SuspendLayout()
        CType(Me.GroupControl10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl10.SuspendLayout()
        Me.SuspendLayout()
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.grdgrmaster
        Me.GridView2.Name = "GridView2"
        '
        'grdgrmaster
        '
        GridLevelNode1.LevelTemplate = Me.GridView2
        GridLevelNode1.RelationName = "Level1"
        Me.grdgrmaster.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.grdgrmaster.Location = New System.Drawing.Point(1, 19)
        Me.grdgrmaster.MainView = Me.GridView1
        Me.grdgrmaster.Name = "grdgrmaster"
        Me.grdgrmaster.Size = New System.Drawing.Size(1361, 318)
        Me.grdgrmaster.TabIndex = 12
        Me.grdgrmaster.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1, Me.GridView2})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gr_no, Me.year, Me.f_name, Me.l_name, Me.address, Me.stdfrom, Me.stddob, Me.stdgender, Me.category, Me.handicap, Me.stdcaste, Me.std_id, Me.b_place, Me.remarks, Me.add_dte, Me.add_std, Me.lc_entry, Me.result_entry, Me.last_Scl, Me.leave_dte, Me.leave_rsn, Me.progress, Me.conduct, Me.try_pass})
        Me.GridView1.GridControl = Me.grdgrmaster
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
        'year
        '
        Me.year.Caption = "Admission Year"
        Me.year.FieldName = "year"
        Me.year.Name = "year"
        Me.year.Visible = True
        Me.year.VisibleIndex = 1
        '
        'f_name
        '
        Me.f_name.Caption = "First Name"
        Me.f_name.FieldName = "f_name"
        Me.f_name.Name = "f_name"
        Me.f_name.Visible = True
        Me.f_name.VisibleIndex = 2
        '
        'l_name
        '
        Me.l_name.Caption = "Last Name"
        Me.l_name.FieldName = "l_name"
        Me.l_name.Name = "l_name"
        Me.l_name.Visible = True
        Me.l_name.VisibleIndex = 3
        '
        'address
        '
        Me.address.Caption = "Address"
        Me.address.FieldName = "address"
        Me.address.Name = "address"
        Me.address.Visible = True
        Me.address.VisibleIndex = 4
        '
        'stdfrom
        '
        Me.stdfrom.Caption = "From"
        Me.stdfrom.FieldName = "stdfrom"
        Me.stdfrom.Name = "stdfrom"
        Me.stdfrom.Visible = True
        Me.stdfrom.VisibleIndex = 5
        '
        'stddob
        '
        Me.stddob.Caption = "DOB"
        Me.stddob.FieldName = "stddob"
        Me.stddob.Name = "stddob"
        Me.stddob.Visible = True
        Me.stddob.VisibleIndex = 6
        '
        'stdgender
        '
        Me.stdgender.Caption = "Gender"
        Me.stdgender.FieldName = "stdgender"
        Me.stdgender.Name = "stdgender"
        Me.stdgender.Visible = True
        Me.stdgender.VisibleIndex = 7
        '
        'category
        '
        Me.category.Caption = "Category"
        Me.category.FieldName = "category"
        Me.category.Name = "category"
        Me.category.Visible = True
        Me.category.VisibleIndex = 8
        '
        'handicap
        '
        Me.handicap.Caption = "Handicap"
        Me.handicap.FieldName = "handicap"
        Me.handicap.Name = "handicap"
        Me.handicap.Visible = True
        Me.handicap.VisibleIndex = 9
        '
        'stdcaste
        '
        Me.stdcaste.Caption = "Caste"
        Me.stdcaste.FieldName = "stdcaste"
        Me.stdcaste.Name = "stdcaste"
        Me.stdcaste.Visible = True
        Me.stdcaste.VisibleIndex = 10
        '
        'std_id
        '
        Me.std_id.FieldName = "std_id"
        Me.std_id.Name = "std_id"
        '
        'b_place
        '
        Me.b_place.FieldName = "b_place"
        Me.b_place.Name = "b_place"
        '
        'remarks
        '
        Me.remarks.FieldName = "remarks"
        Me.remarks.Name = "remarks"
        '
        'add_dte
        '
        Me.add_dte.FieldName = "add_dte"
        Me.add_dte.Name = "add_dte"
        '
        'add_std
        '
        Me.add_std.Caption = "add_std"
        Me.add_std.FieldName = "add_std"
        Me.add_std.Name = "add_std"
        '
        'lc_entry
        '
        Me.lc_entry.FieldName = "lc_entry"
        Me.lc_entry.Name = "lc_entry"
        '
        'result_entry
        '
        Me.result_entry.FieldName = "result_entry"
        Me.result_entry.Name = "result_entry"
        '
        'last_Scl
        '
        Me.last_Scl.FieldName = "last_Scl"
        Me.last_Scl.Name = "last_Scl"
        '
        'leave_dte
        '
        Me.leave_dte.FieldName = "leave_dte"
        Me.leave_dte.Name = "leave_dte"
        '
        'leave_rsn
        '
        Me.leave_rsn.FieldName = "leave_rsn"
        Me.leave_rsn.Name = "leave_rsn"
        '
        'progress
        '
        Me.progress.FieldName = "progress"
        Me.progress.Name = "progress"
        '
        'conduct
        '
        Me.conduct.FieldName = "conduct"
        Me.conduct.Name = "conduct"
        '
        'try_pass
        '
        Me.try_pass.FieldName = "try_pass"
        Me.try_pass.Name = "try_pass"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.grpgeninfo)
        Me.GroupControl1.Location = New System.Drawing.Point(1, 1)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.ShowCaption = False
        Me.GroupControl1.Size = New System.Drawing.Size(348, 300)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "GroupControl1"
        '
        'grpgeninfo
        '
        Me.grpgeninfo.Controls.Add(Me.cmbyear)
        Me.grpgeninfo.Controls.Add(Me.lblremark)
        Me.grpgeninfo.Controls.Add(Me.lblyear)
        Me.grpgeninfo.Controls.Add(Me.lblbplace)
        Me.grpgeninfo.Controls.Add(Me.lbldob)
        Me.grpgeninfo.Controls.Add(Me.lblstdid)
        Me.grpgeninfo.Controls.Add(Me.lblgrno)
        Me.grpgeninfo.Controls.Add(Me.txtremarks)
        Me.grpgeninfo.Controls.Add(Me.LabelControl6)
        Me.grpgeninfo.Controls.Add(Me.LabelControl5)
        Me.grpgeninfo.Controls.Add(Me.txtbplace)
        Me.grpgeninfo.Controls.Add(Me.LabelControl4)
        Me.grpgeninfo.Controls.Add(Me.dtpdob)
        Me.grpgeninfo.Controls.Add(Me.LabelControl3)
        Me.grpgeninfo.Controls.Add(Me.txtstdid)
        Me.grpgeninfo.Controls.Add(Me.LabelControl2)
        Me.grpgeninfo.Controls.Add(Me.txtgrno)
        Me.grpgeninfo.Controls.Add(Me.LabelControl1)
        Me.grpgeninfo.Location = New System.Drawing.Point(1, 0)
        Me.grpgeninfo.Name = "grpgeninfo"
        Me.grpgeninfo.Size = New System.Drawing.Size(347, 299)
        Me.grpgeninfo.TabIndex = 0
        Me.grpgeninfo.Text = "Student General Information"
        '
        'cmbyear
        '
        Me.cmbyear.EditValue = Nothing
        Me.cmbyear.Location = New System.Drawing.Point(96, 180)
        Me.cmbyear.Name = "cmbyear"
        Me.cmbyear.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbyear.Properties.DisplayFormat.FormatString = "yyyy"
        Me.cmbyear.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.cmbyear.Properties.EditFormat.FormatString = "yyyy"
        Me.cmbyear.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.cmbyear.Properties.Mask.EditMask = "yyyy"
        Me.cmbyear.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.cmbyear.Size = New System.Drawing.Size(163, 20)
        Me.cmbyear.TabIndex = 9
        '
        'lblremark
        '
        Me.lblremark.AutoSize = True
        Me.lblremark.Location = New System.Drawing.Point(274, 217)
        Me.lblremark.Name = "lblremark"
        Me.lblremark.Size = New System.Drawing.Size(0, 13)
        Me.lblremark.TabIndex = 17
        '
        'lblyear
        '
        Me.lblyear.AutoSize = True
        Me.lblyear.Location = New System.Drawing.Point(274, 179)
        Me.lblyear.Name = "lblyear"
        Me.lblyear.Size = New System.Drawing.Size(0, 13)
        Me.lblyear.TabIndex = 16
        '
        'lblbplace
        '
        Me.lblbplace.AutoSize = True
        Me.lblbplace.Location = New System.Drawing.Point(274, 141)
        Me.lblbplace.Name = "lblbplace"
        Me.lblbplace.Size = New System.Drawing.Size(0, 13)
        Me.lblbplace.TabIndex = 15
        '
        'lbldob
        '
        Me.lbldob.AutoSize = True
        Me.lbldob.Location = New System.Drawing.Point(274, 110)
        Me.lbldob.Name = "lbldob"
        Me.lbldob.Size = New System.Drawing.Size(0, 13)
        Me.lbldob.TabIndex = 14
        '
        'lblstdid
        '
        Me.lblstdid.AutoSize = True
        Me.lblstdid.Location = New System.Drawing.Point(274, 71)
        Me.lblstdid.Name = "lblstdid"
        Me.lblstdid.Size = New System.Drawing.Size(0, 13)
        Me.lblstdid.TabIndex = 13
        '
        'lblgrno
        '
        Me.lblgrno.AutoSize = True
        Me.lblgrno.Location = New System.Drawing.Point(274, 33)
        Me.lblgrno.Name = "lblgrno"
        Me.lblgrno.Size = New System.Drawing.Size(0, 13)
        Me.lblgrno.TabIndex = 12
        '
        'txtremarks
        '
        Me.txtremarks.Location = New System.Drawing.Point(96, 218)
        Me.txtremarks.Name = "txtremarks"
        Me.txtremarks.Size = New System.Drawing.Size(163, 68)
        Me.txtremarks.TabIndex = 11
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(9, 218)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(41, 13)
        Me.LabelControl6.TabIndex = 10
        Me.LabelControl6.Text = "Remarks"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(9, 183)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(22, 13)
        Me.LabelControl5.TabIndex = 8
        Me.LabelControl5.Text = "Year"
        '
        'txtbplace
        '
        Me.txtbplace.Location = New System.Drawing.Point(96, 142)
        Me.txtbplace.Name = "txtbplace"
        Me.txtbplace.Size = New System.Drawing.Size(163, 20)
        Me.txtbplace.TabIndex = 7
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(9, 145)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl4.TabIndex = 6
        Me.LabelControl4.Text = "Birth Place"
        '
        'dtpdob
        '
        Me.dtpdob.EditValue = Nothing
        Me.dtpdob.Location = New System.Drawing.Point(96, 104)
        Me.dtpdob.Name = "dtpdob"
        Me.dtpdob.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpdob.Properties.DisplayFormat.FormatString = "MM/dd/yyyy"
        Me.dtpdob.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtpdob.Properties.EditFormat.FormatString = "MM/dd/yyyy"
        Me.dtpdob.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtpdob.Properties.Mask.EditMask = "MM/dd/yyyy"
        Me.dtpdob.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dtpdob.Size = New System.Drawing.Size(163, 20)
        Me.dtpdob.TabIndex = 5
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(9, 104)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(61, 13)
        Me.LabelControl3.TabIndex = 4
        Me.LabelControl3.Text = "Date of Birth"
        '
        'txtstdid
        '
        Me.txtstdid.Location = New System.Drawing.Point(96, 67)
        Me.txtstdid.Name = "txtstdid"
        Me.txtstdid.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtstdid.Properties.Appearance.Options.UseFont = True
        Me.txtstdid.Properties.ReadOnly = True
        Me.txtstdid.Size = New System.Drawing.Size(163, 20)
        Me.txtstdid.TabIndex = 3
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(9, 70)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(52, 13)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "Student ID"
        '
        'txtgrno
        '
        Me.txtgrno.Location = New System.Drawing.Point(96, 30)
        Me.txtgrno.Name = "txtgrno"
        Me.txtgrno.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtgrno.Properties.Appearance.Options.UseFont = True
        Me.txtgrno.Properties.ReadOnly = True
        Me.txtgrno.Size = New System.Drawing.Size(163, 20)
        Me.txtgrno.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(9, 33)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(34, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "GR No."
        '
        'grpacadinfo
        '
        Me.grpacadinfo.Controls.Add(Me.lblleavestd)
        Me.grpacadinfo.Controls.Add(Me.lblreason)
        Me.grpacadinfo.Controls.Add(Me.lblscleavedt)
        Me.grpacadinfo.Controls.Add(Me.lblcategory)
        Me.grpacadinfo.Controls.Add(Me.lblgender)
        Me.grpacadinfo.Controls.Add(Me.lblcaste)
        Me.grpacadinfo.Controls.Add(Me.lbllastschool)
        Me.grpacadinfo.Controls.Add(Me.lblresultentry)
        Me.grpacadinfo.Controls.Add(Me.lbllcentery)
        Me.grpacadinfo.Controls.Add(Me.lbladstd)
        Me.grpacadinfo.Controls.Add(Me.lbladdate)
        Me.grpacadinfo.Controls.Add(Me.cmbleavestd)
        Me.grpacadinfo.Controls.Add(Me.cmbadstd)
        Me.grpacadinfo.Controls.Add(Me.LabelControl17)
        Me.grpacadinfo.Controls.Add(Me.txtleavereson)
        Me.grpacadinfo.Controls.Add(Me.LabelControl16)
        Me.grpacadinfo.Controls.Add(Me.dtpleavedate)
        Me.grpacadinfo.Controls.Add(Me.LabelControl15)
        Me.grpacadinfo.Controls.Add(Me.cmbcategory)
        Me.grpacadinfo.Controls.Add(Me.LabelControl14)
        Me.grpacadinfo.Controls.Add(Me.GroupControl6)
        Me.grpacadinfo.Controls.Add(Me.LabelControl13)
        Me.grpacadinfo.Controls.Add(Me.txtcaste)
        Me.grpacadinfo.Controls.Add(Me.LabelControl12)
        Me.grpacadinfo.Controls.Add(Me.txtlastscl)
        Me.grpacadinfo.Controls.Add(Me.LabelControl11)
        Me.grpacadinfo.Controls.Add(Me.GroupControl5)
        Me.grpacadinfo.Controls.Add(Me.LabelControl10)
        Me.grpacadinfo.Controls.Add(Me.GroupControl4)
        Me.grpacadinfo.Controls.Add(Me.LabelControl9)
        Me.grpacadinfo.Controls.Add(Me.LabelControl8)
        Me.grpacadinfo.Controls.Add(Me.dtpaddte)
        Me.grpacadinfo.Controls.Add(Me.LabelControl7)
        Me.grpacadinfo.Location = New System.Drawing.Point(350, 1)
        Me.grpacadinfo.Name = "grpacadinfo"
        Me.grpacadinfo.Size = New System.Drawing.Size(609, 300)
        Me.grpacadinfo.TabIndex = 1
        Me.grpacadinfo.Text = "Student Academic Information"
        '
        'lblleavestd
        '
        Me.lblleavestd.AutoSize = True
        Me.lblleavestd.Location = New System.Drawing.Point(570, 253)
        Me.lblleavestd.Name = "lblleavestd"
        Me.lblleavestd.Size = New System.Drawing.Size(0, 13)
        Me.lblleavestd.TabIndex = 31
        '
        'lblreason
        '
        Me.lblreason.AutoSize = True
        Me.lblreason.Location = New System.Drawing.Point(570, 187)
        Me.lblreason.Name = "lblreason"
        Me.lblreason.Size = New System.Drawing.Size(0, 13)
        Me.lblreason.TabIndex = 30
        '
        'lblscleavedt
        '
        Me.lblscleavedt.AutoSize = True
        Me.lblscleavedt.Location = New System.Drawing.Point(570, 154)
        Me.lblscleavedt.Name = "lblscleavedt"
        Me.lblscleavedt.Size = New System.Drawing.Size(0, 13)
        Me.lblscleavedt.TabIndex = 29
        '
        'lblcategory
        '
        Me.lblcategory.AutoSize = True
        Me.lblcategory.Location = New System.Drawing.Point(570, 118)
        Me.lblcategory.Name = "lblcategory"
        Me.lblcategory.Size = New System.Drawing.Size(0, 13)
        Me.lblcategory.TabIndex = 28
        '
        'lblgender
        '
        Me.lblgender.AutoSize = True
        Me.lblgender.Location = New System.Drawing.Point(570, 37)
        Me.lblgender.Name = "lblgender"
        Me.lblgender.Size = New System.Drawing.Size(0, 13)
        Me.lblgender.TabIndex = 27
        '
        'lblcaste
        '
        Me.lblcaste.AutoSize = True
        Me.lblcaste.Location = New System.Drawing.Point(279, 250)
        Me.lblcaste.Name = "lblcaste"
        Me.lblcaste.Size = New System.Drawing.Size(0, 13)
        Me.lblcaste.TabIndex = 26
        '
        'lbllastschool
        '
        Me.lbllastschool.AutoSize = True
        Me.lbllastschool.Location = New System.Drawing.Point(279, 213)
        Me.lbllastschool.Name = "lbllastschool"
        Me.lbllastschool.Size = New System.Drawing.Size(0, 13)
        Me.lbllastschool.TabIndex = 25
        '
        'lblresultentry
        '
        Me.lblresultentry.AutoSize = True
        Me.lblresultentry.Location = New System.Drawing.Point(279, 166)
        Me.lblresultentry.Name = "lblresultentry"
        Me.lblresultentry.Size = New System.Drawing.Size(0, 13)
        Me.lblresultentry.TabIndex = 24
        '
        'lbllcentery
        '
        Me.lbllcentery.AutoSize = True
        Me.lbllcentery.Location = New System.Drawing.Point(279, 117)
        Me.lbllcentery.Name = "lbllcentery"
        Me.lbllcentery.Size = New System.Drawing.Size(0, 13)
        Me.lbllcentery.TabIndex = 23
        '
        'lbladstd
        '
        Me.lbladstd.AutoSize = True
        Me.lbladstd.Location = New System.Drawing.Point(279, 74)
        Me.lbladstd.Name = "lbladstd"
        Me.lbladstd.Size = New System.Drawing.Size(0, 13)
        Me.lbladstd.TabIndex = 22
        '
        'lbladdate
        '
        Me.lbladdate.AutoSize = True
        Me.lbladdate.Location = New System.Drawing.Point(279, 37)
        Me.lbladdate.Name = "lbladdate"
        Me.lbladdate.Size = New System.Drawing.Size(0, 13)
        Me.lbladdate.TabIndex = 21
        '
        'cmbleavestd
        '
        Me.cmbleavestd.Location = New System.Drawing.Point(427, 250)
        Me.cmbleavestd.Name = "cmbleavestd"
        Me.cmbleavestd.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbleavestd.Properties.Items.AddRange(New Object() {"8", "9"})
        Me.cmbleavestd.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cmbleavestd.Size = New System.Drawing.Size(130, 20)
        Me.cmbleavestd.TabIndex = 20
        '
        'cmbadstd
        '
        Me.cmbadstd.Location = New System.Drawing.Point(130, 71)
        Me.cmbadstd.Name = "cmbadstd"
        Me.cmbadstd.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbadstd.Properties.Items.AddRange(New Object() {"8", "9"})
        Me.cmbadstd.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cmbadstd.Size = New System.Drawing.Size(136, 20)
        Me.cmbadstd.TabIndex = 3
        '
        'LabelControl17
        '
        Me.LabelControl17.Location = New System.Drawing.Point(322, 253)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(76, 13)
        Me.LabelControl17.TabIndex = 19
        Me.LabelControl17.Text = "Leave Standard"
        '
        'txtleavereson
        '
        Me.txtleavereson.Location = New System.Drawing.Point(427, 187)
        Me.txtleavereson.Name = "txtleavereson"
        Me.txtleavereson.Size = New System.Drawing.Size(130, 47)
        Me.txtleavereson.TabIndex = 18
        '
        'LabelControl16
        '
        Me.LabelControl16.Location = New System.Drawing.Point(323, 191)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(36, 13)
        Me.LabelControl16.TabIndex = 17
        Me.LabelControl16.Text = "Reason"
        '
        'dtpleavedate
        '
        Me.dtpleavedate.EditValue = Nothing
        Me.dtpleavedate.Location = New System.Drawing.Point(427, 151)
        Me.dtpleavedate.Name = "dtpleavedate"
        Me.dtpleavedate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpleavedate.Properties.DisplayFormat.FormatString = "MM/dd/yyyy"
        Me.dtpleavedate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtpleavedate.Properties.EditFormat.FormatString = "MM/dd/yyyy"
        Me.dtpleavedate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtpleavedate.Properties.Mask.EditMask = "MM/dd/yyyy"
        Me.dtpleavedate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dtpleavedate.Size = New System.Drawing.Size(130, 20)
        Me.dtpleavedate.TabIndex = 16
        '
        'LabelControl15
        '
        Me.LabelControl15.Location = New System.Drawing.Point(322, 152)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(89, 13)
        Me.LabelControl15.TabIndex = 15
        Me.LabelControl15.Text = "School Leave Date"
        '
        'cmbcategory
        '
        Me.cmbcategory.Location = New System.Drawing.Point(427, 115)
        Me.cmbcategory.Name = "cmbcategory"
        Me.cmbcategory.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbcategory.Properties.Items.AddRange(New Object() {"S.T", "S.C", "S.E.B.C", "Other"})
        Me.cmbcategory.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cmbcategory.Size = New System.Drawing.Size(130, 20)
        Me.cmbcategory.TabIndex = 14
        '
        'LabelControl14
        '
        Me.LabelControl14.Location = New System.Drawing.Point(322, 114)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(45, 13)
        Me.LabelControl14.TabIndex = 13
        Me.LabelControl14.Text = "Category"
        '
        'GroupControl6
        '
        Me.GroupControl6.Controls.Add(Me.rdother)
        Me.GroupControl6.Controls.Add(Me.rdfemale)
        Me.GroupControl6.Controls.Add(Me.rdmale)
        Me.GroupControl6.Location = New System.Drawing.Point(426, 31)
        Me.GroupControl6.Name = "GroupControl6"
        Me.GroupControl6.ShowCaption = False
        Me.GroupControl6.Size = New System.Drawing.Size(131, 69)
        Me.GroupControl6.TabIndex = 12
        Me.GroupControl6.Text = "GroupControl6"
        '
        'rdother
        '
        Me.rdother.AutoSize = True
        Me.rdother.Location = New System.Drawing.Point(25, 47)
        Me.rdother.Name = "rdother"
        Me.rdother.Size = New System.Drawing.Size(53, 17)
        Me.rdother.TabIndex = 6
        Me.rdother.TabStop = True
        Me.rdother.Text = "Other"
        Me.rdother.UseVisualStyleBackColor = True
        '
        'rdfemale
        '
        Me.rdfemale.AutoSize = True
        Me.rdfemale.Location = New System.Drawing.Point(25, 26)
        Me.rdfemale.Name = "rdfemale"
        Me.rdfemale.Size = New System.Drawing.Size(59, 17)
        Me.rdfemale.TabIndex = 5
        Me.rdfemale.TabStop = True
        Me.rdfemale.Text = "Female"
        Me.rdfemale.UseVisualStyleBackColor = True
        '
        'rdmale
        '
        Me.rdmale.AutoSize = True
        Me.rdmale.Location = New System.Drawing.Point(25, 6)
        Me.rdmale.Name = "rdmale"
        Me.rdmale.Size = New System.Drawing.Size(47, 17)
        Me.rdmale.TabIndex = 4
        Me.rdmale.TabStop = True
        Me.rdmale.Text = "Male"
        Me.rdmale.UseVisualStyleBackColor = True
        '
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(322, 37)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(35, 13)
        Me.LabelControl13.TabIndex = 11
        Me.LabelControl13.Text = "Gender"
        '
        'txtcaste
        '
        Me.txtcaste.Location = New System.Drawing.Point(130, 246)
        Me.txtcaste.Name = "txtcaste"
        Me.txtcaste.Size = New System.Drawing.Size(136, 20)
        Me.txtcaste.TabIndex = 10
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(15, 249)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(90, 13)
        Me.LabelControl12.TabIndex = 9
        Me.LabelControl12.Text = "Religion And Caste"
        '
        'txtlastscl
        '
        Me.txtlastscl.Location = New System.Drawing.Point(130, 210)
        Me.txtlastscl.Name = "txtlastscl"
        Me.txtlastscl.Size = New System.Drawing.Size(136, 20)
        Me.txtlastscl.TabIndex = 8
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(15, 211)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(67, 13)
        Me.LabelControl11.TabIndex = 7
        Me.LabelControl11.Text = "Last School @"
        '
        'GroupControl5
        '
        Me.GroupControl5.Controls.Add(Me.rdresultno)
        Me.GroupControl5.Controls.Add(Me.rdresultyes)
        Me.GroupControl5.Location = New System.Drawing.Point(130, 160)
        Me.GroupControl5.Name = "GroupControl5"
        Me.GroupControl5.ShowCaption = False
        Me.GroupControl5.Size = New System.Drawing.Size(136, 29)
        Me.GroupControl5.TabIndex = 6
        Me.GroupControl5.Text = "GroupControl5"
        '
        'rdresultno
        '
        Me.rdresultno.AutoSize = True
        Me.rdresultno.Location = New System.Drawing.Point(84, 7)
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
        Me.rdresultyes.Location = New System.Drawing.Point(16, 6)
        Me.rdresultyes.Name = "rdresultyes"
        Me.rdresultyes.Size = New System.Drawing.Size(42, 17)
        Me.rdresultyes.TabIndex = 0
        Me.rdresultyes.TabStop = True
        Me.rdresultyes.Text = "Yes"
        Me.rdresultyes.UseVisualStyleBackColor = True
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(15, 164)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(59, 13)
        Me.LabelControl10.TabIndex = 6
        Me.LabelControl10.Text = "Result Entry"
        '
        'GroupControl4
        '
        Me.GroupControl4.Controls.Add(Me.rdlcno)
        Me.GroupControl4.Controls.Add(Me.rdlcyes)
        Me.GroupControl4.Location = New System.Drawing.Point(130, 111)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.ShowCaption = False
        Me.GroupControl4.Size = New System.Drawing.Size(136, 29)
        Me.GroupControl4.TabIndex = 5
        Me.GroupControl4.Text = "GroupControl4"
        '
        'rdlcno
        '
        Me.rdlcno.AutoSize = True
        Me.rdlcno.Location = New System.Drawing.Point(84, 7)
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
        Me.rdlcyes.Location = New System.Drawing.Point(16, 6)
        Me.rdlcyes.Name = "rdlcyes"
        Me.rdlcyes.Size = New System.Drawing.Size(42, 17)
        Me.rdlcyes.TabIndex = 0
        Me.rdlcyes.TabStop = True
        Me.rdlcyes.Text = "Yes"
        Me.rdlcyes.UseVisualStyleBackColor = True
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(15, 119)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(41, 13)
        Me.LabelControl9.TabIndex = 4
        Me.LabelControl9.Text = "LC Entry"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(15, 73)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(100, 13)
        Me.LabelControl8.TabIndex = 2
        Me.LabelControl8.Text = "Addmission Standard"
        '
        'dtpaddte
        '
        Me.dtpaddte.EditValue = Nothing
        Me.dtpaddte.Location = New System.Drawing.Point(130, 33)
        Me.dtpaddte.Name = "dtpaddte"
        Me.dtpaddte.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpaddte.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.dtpaddte.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dtpaddte.Size = New System.Drawing.Size(136, 20)
        Me.dtpaddte.TabIndex = 1
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(15, 36)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(79, 13)
        Me.LabelControl7.TabIndex = 0
        Me.LabelControl7.Text = "Addmission Date"
        '
        'GroupControl7
        '
        Me.GroupControl7.Controls.Add(Me.GroupControl2)
        Me.GroupControl7.Controls.Add(Me.grpcapbility)
        Me.GroupControl7.Location = New System.Drawing.Point(960, 1)
        Me.GroupControl7.Name = "GroupControl7"
        Me.GroupControl7.ShowCaption = False
        Me.GroupControl7.Size = New System.Drawing.Size(404, 300)
        Me.GroupControl7.TabIndex = 3
        Me.GroupControl7.Text = "GroupControl7"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.cmbtry)
        Me.GroupControl2.Controls.Add(Me.gctry)
        Me.GroupControl2.Controls.Add(Me.LabelControl20)
        Me.GroupControl2.Location = New System.Drawing.Point(1, 231)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.ShowCaption = False
        Me.GroupControl2.Size = New System.Drawing.Size(402, 69)
        Me.GroupControl2.TabIndex = 4
        Me.GroupControl2.Text = "GroupControl2"
        '
        'cmbtry
        '
        Me.cmbtry.Location = New System.Drawing.Point(114, 23)
        Me.cmbtry.Name = "cmbtry"
        Me.cmbtry.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbtry.Properties.Items.AddRange(New Object() {"1", "2", "3"})
        Me.cmbtry.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cmbtry.Size = New System.Drawing.Size(73, 20)
        Me.cmbtry.TabIndex = 12
        '
        'gctry
        '
        Me.gctry.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.DigitalGauge1})
        Me.gctry.Location = New System.Drawing.Point(205, 2)
        Me.gctry.Name = "gctry"
        Me.gctry.Size = New System.Drawing.Size(82, 64)
        Me.gctry.TabIndex = 13
        '
        'DigitalGauge1
        '
        Me.DigitalGauge1.AppearanceOff.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#0FFF5000")
        Me.DigitalGauge1.AppearanceOn.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#FF5000")
        Me.DigitalGauge1.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent() {Me.DigitalBackgroundLayerComponent2})
        Me.DigitalGauge1.Bounds = New System.Drawing.Rectangle(6, 6, 70, 52)
        Me.DigitalGauge1.DigitCount = 2
        Me.DigitalGauge1.Name = "dGauge1"
        Me.DigitalGauge1.Text = "00,000"
        '
        'DigitalBackgroundLayerComponent2
        '
        Me.DigitalBackgroundLayerComponent2.BottomRight = New DevExpress.XtraGauges.Core.Base.PointF2D(115.925!, 99.9625!)
        Me.DigitalBackgroundLayerComponent2.Name = "bg1"
        Me.DigitalBackgroundLayerComponent2.ShapeType = DevExpress.XtraGauges.Core.Model.DigitalBackgroundShapeSetType.Style3
        Me.DigitalBackgroundLayerComponent2.TopLeft = New DevExpress.XtraGauges.Core.Base.PointF2D(20.0!, 0.0!)
        Me.DigitalBackgroundLayerComponent2.ZOrder = 1000
        '
        'LabelControl20
        '
        Me.LabelControl20.Location = New System.Drawing.Point(26, 26)
        Me.LabelControl20.Name = "LabelControl20"
        Me.LabelControl20.Size = New System.Drawing.Size(68, 13)
        Me.LabelControl20.TabIndex = 11
        Me.LabelControl20.Text = "Try of Passing"
        '
        'grpcapbility
        '
        Me.grpcapbility.Controls.Add(Me.lbltry)
        Me.grpcapbility.Controls.Add(Me.lblconduct)
        Me.grpcapbility.Controls.Add(Me.lblprogress)
        Me.grpcapbility.Controls.Add(Me.cmbconduct)
        Me.grpcapbility.Controls.Add(Me.cmbprogress)
        Me.grpcapbility.Controls.Add(Me.GaugeControl2)
        Me.grpcapbility.Controls.Add(Me.GaugeControl1)
        Me.grpcapbility.Controls.Add(Me.LabelControl19)
        Me.grpcapbility.Controls.Add(Me.LabelControl18)
        Me.grpcapbility.Location = New System.Drawing.Point(0, 0)
        Me.grpcapbility.Name = "grpcapbility"
        Me.grpcapbility.Size = New System.Drawing.Size(404, 231)
        Me.grpcapbility.TabIndex = 3
        Me.grpcapbility.Text = "Student Capability LookUp"
        '
        'lbltry
        '
        Me.lbltry.AutoSize = True
        Me.lbltry.Location = New System.Drawing.Point(186, 235)
        Me.lbltry.Name = "lbltry"
        Me.lbltry.Size = New System.Drawing.Size(0, 13)
        Me.lbltry.TabIndex = 34
        '
        'lblconduct
        '
        Me.lblconduct.AutoSize = True
        Me.lblconduct.Location = New System.Drawing.Point(381, 28)
        Me.lblconduct.Name = "lblconduct"
        Me.lblconduct.Size = New System.Drawing.Size(0, 13)
        Me.lblconduct.TabIndex = 33
        '
        'lblprogress
        '
        Me.lblprogress.AutoSize = True
        Me.lblprogress.Location = New System.Drawing.Point(181, 28)
        Me.lblprogress.Name = "lblprogress"
        Me.lblprogress.Size = New System.Drawing.Size(0, 13)
        Me.lblprogress.TabIndex = 32
        '
        'cmbconduct
        '
        Me.cmbconduct.Location = New System.Drawing.Point(276, 25)
        Me.cmbconduct.Name = "cmbconduct"
        Me.cmbconduct.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbconduct.Properties.Items.AddRange(New Object() {"Excellent", "Good", "Bad"})
        Me.cmbconduct.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cmbconduct.Size = New System.Drawing.Size(100, 20)
        Me.cmbconduct.TabIndex = 2
        '
        'cmbprogress
        '
        Me.cmbprogress.Location = New System.Drawing.Point(75, 25)
        Me.cmbprogress.Name = "cmbprogress"
        Me.cmbprogress.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbprogress.Properties.Items.AddRange(New Object() {"Excellent", "Good", "Bad"})
        Me.cmbprogress.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cmbprogress.Size = New System.Drawing.Size(100, 20)
        Me.cmbprogress.TabIndex = 1
        '
        'GaugeControl2
        '
        Me.GaugeControl2.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.CircularGauge2})
        Me.GaugeControl2.Location = New System.Drawing.Point(205, 50)
        Me.GaugeControl2.Name = "GaugeControl2"
        Me.GaugeControl2.Size = New System.Drawing.Size(193, 178)
        Me.GaugeControl2.TabIndex = 4
        '
        'CircularGauge2
        '
        Me.CircularGauge2.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() {Me.ArcScaleBackgroundLayerComponent6, Me.ArcScaleBackgroundLayerComponent7})
        Me.CircularGauge2.Bounds = New System.Drawing.Rectangle(6, 6, 181, 166)
        Me.CircularGauge2.Name = "cGauge1"
        Me.CircularGauge2.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() {Me.ArcScaleNeedleComponent4})
        Me.CircularGauge2.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.ArcScaleComponent5})
        '
        'ArcScaleBackgroundLayerComponent6
        '
        Me.ArcScaleBackgroundLayerComponent6.ArcScale = Me.ArcScaleComponent5
        Me.ArcScaleBackgroundLayerComponent6.Name = "bg1"
        Me.ArcScaleBackgroundLayerComponent6.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5!, 1.95!)
        Me.ArcScaleBackgroundLayerComponent6.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularWide_Style3
        Me.ArcScaleBackgroundLayerComponent6.Size = New System.Drawing.SizeF(250.0!, 123.0!)
        Me.ArcScaleBackgroundLayerComponent6.ZOrder = 1000
        '
        'ArcScaleComponent5
        '
        Me.ArcScaleComponent5.AppearanceTickmarkText.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.ArcScaleComponent5.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#FF8000")
        Me.ArcScaleComponent5.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125.0!, 295.0!)
        Me.ArcScaleComponent5.EndAngle = -68.0!
        Me.ArcScaleComponent5.MajorTickCount = 7
        Me.ArcScaleComponent5.MajorTickmark.FormatString = "{0:F0}"
        Me.ArcScaleComponent5.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style3_3
        Me.ArcScaleComponent5.MajorTickmark.TextOffset = -20.0!
        Me.ArcScaleComponent5.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
        Me.ArcScaleComponent5.MaxValue = 80.0!
        Me.ArcScaleComponent5.MinorTickCount = 4
        Me.ArcScaleComponent5.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style3_2
        Me.ArcScaleComponent5.MinValue = 20.0!
        Me.ArcScaleComponent5.Name = "scale1"
        Me.ArcScaleComponent5.RadiusX = 250.0!
        Me.ArcScaleComponent5.RadiusY = 200.0!
        Me.ArcScaleComponent5.StartAngle = -112.0!
        Me.ArcScaleComponent5.Value = 50.0!
        '
        'ArcScaleBackgroundLayerComponent7
        '
        Me.ArcScaleBackgroundLayerComponent7.ArcScale = Me.ArcScaleComponent5
        Me.ArcScaleBackgroundLayerComponent7.Name = "bg2"
        Me.ArcScaleBackgroundLayerComponent7.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5!, 1.95!)
        Me.ArcScaleBackgroundLayerComponent7.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularWide_Style3_1
        Me.ArcScaleBackgroundLayerComponent7.Size = New System.Drawing.SizeF(250.0!, 123.0!)
        Me.ArcScaleBackgroundLayerComponent7.ZOrder = -500
        '
        'ArcScaleNeedleComponent4
        '
        Me.ArcScaleNeedleComponent4.ArcScale = Me.ArcScaleComponent5
        Me.ArcScaleNeedleComponent4.Name = "needle1"
        Me.ArcScaleNeedleComponent4.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularWide_Style3
        Me.ArcScaleNeedleComponent4.StartOffset = 161.0!
        Me.ArcScaleNeedleComponent4.ZOrder = -50
        '
        'GaugeControl1
        '
        Me.GaugeControl1.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.CircularGauge1})
        Me.GaugeControl1.Location = New System.Drawing.Point(4, 51)
        Me.GaugeControl1.Name = "GaugeControl1"
        Me.GaugeControl1.Size = New System.Drawing.Size(198, 178)
        Me.GaugeControl1.TabIndex = 3
        '
        'CircularGauge1
        '
        Me.CircularGauge1.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() {Me.ArcScaleBackgroundLayerComponent4, Me.ArcScaleBackgroundLayerComponent5})
        Me.CircularGauge1.Bounds = New System.Drawing.Rectangle(6, 6, 186, 166)
        Me.CircularGauge1.Name = ""
        Me.CircularGauge1.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() {Me.ArcScaleNeedleComponent3})
        Me.CircularGauge1.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.ArcScaleComponent3, Me.ArcScaleComponent4})
        '
        'ArcScaleBackgroundLayerComponent4
        '
        Me.ArcScaleBackgroundLayerComponent4.ArcScale = Me.ArcScaleComponent3
        Me.ArcScaleBackgroundLayerComponent4.Name = "arcScaleBackgroundLayerComponent7"
        Me.ArcScaleBackgroundLayerComponent4.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_Style5
        Me.ArcScaleBackgroundLayerComponent4.ZOrder = 1000
        '
        'ArcScaleComponent3
        '
        Me.ArcScaleComponent3.AppearanceTickmarkText.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.ArcScaleComponent3.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:LightGrey")
        Me.ArcScaleComponent3.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125.0!, 125.0!)
        Me.ArcScaleComponent3.EndAngle = 60.0!
        Me.ArcScaleComponent3.MajorTickmark.FormatString = "{0:F0}"
        Me.ArcScaleComponent3.MajorTickmark.ShapeOffset = -11.0!
        Me.ArcScaleComponent3.MajorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(0.5!, 1.0!)
        Me.ArcScaleComponent3.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style5_1
        Me.ArcScaleComponent3.MajorTickmark.TextOffset = -28.0!
        Me.ArcScaleComponent3.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
        Me.ArcScaleComponent3.MaxValue = 100.0!
        Me.ArcScaleComponent3.MinorTickCount = 4
        Me.ArcScaleComponent3.MinorTickmark.ShapeOffset = -5.0!
        Me.ArcScaleComponent3.MinorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(0.5!, 1.0!)
        Me.ArcScaleComponent3.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style5_2
        Me.ArcScaleComponent3.Name = "arcScaleComponent7"
        Me.ArcScaleComponent3.RadiusX = 122.0!
        Me.ArcScaleComponent3.RadiusY = 122.0!
        Me.ArcScaleComponent3.StartAngle = -240.0!
        '
        'ArcScaleBackgroundLayerComponent5
        '
        Me.ArcScaleBackgroundLayerComponent5.ArcScale = Me.ArcScaleComponent3
        Me.ArcScaleBackgroundLayerComponent5.Name = "arcScaleBackgroundLayerComponent10"
        Me.ArcScaleBackgroundLayerComponent5.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_Style5_1
        Me.ArcScaleBackgroundLayerComponent5.Size = New System.Drawing.SizeF(216.0!, 216.0!)
        Me.ArcScaleBackgroundLayerComponent5.ZOrder = 999
        '
        'ArcScaleNeedleComponent3
        '
        Me.ArcScaleNeedleComponent3.ArcScale = Me.ArcScaleComponent3
        Me.ArcScaleNeedleComponent3.Name = "arcScaleNeedleComponent7"
        Me.ArcScaleNeedleComponent3.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style5
        Me.ArcScaleNeedleComponent3.StartOffset = -23.5!
        Me.ArcScaleNeedleComponent3.ZOrder = -50
        '
        'ArcScaleComponent4
        '
        Me.ArcScaleComponent4.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Silver")
        Me.ArcScaleComponent4.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125.0!, 125.0!)
        Me.ArcScaleComponent4.EndAngle = -30.0!
        Me.ArcScaleComponent4.MajorTickCount = 8
        Me.ArcScaleComponent4.MajorTickmark.FormatString = "{0:F0}"
        Me.ArcScaleComponent4.MajorTickmark.ShapeOffset = -4.0!
        Me.ArcScaleComponent4.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style5_4
        Me.ArcScaleComponent4.MajorTickmark.TextOffset = -15.0!
        Me.ArcScaleComponent4.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
        Me.ArcScaleComponent4.MaxValue = 700.0!
        Me.ArcScaleComponent4.MinorTickCount = 4
        Me.ArcScaleComponent4.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style5_5
        Me.ArcScaleComponent4.Name = "arcScaleComponent11"
        Me.ArcScaleComponent4.RadiusX = 65.0!
        Me.ArcScaleComponent4.RadiusY = 65.0!
        Me.ArcScaleComponent4.StartAngle = -240.0!
        Me.ArcScaleComponent4.ZOrder = -1
        '
        'LabelControl19
        '
        Me.LabelControl19.Location = New System.Drawing.Point(220, 31)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl19.TabIndex = 1
        Me.LabelControl19.Text = "Conduct"
        '
        'LabelControl18
        '
        Me.LabelControl18.Location = New System.Drawing.Point(26, 29)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(42, 13)
        Me.LabelControl18.TabIndex = 0
        Me.LabelControl18.Text = "Progress"
        '
        'ArcScaleComponent1
        '
        Me.ArcScaleComponent1.AppearanceTickmarkText.Font = New System.Drawing.Font("Arial Narrow", 11.0!, System.Drawing.FontStyle.Bold)
        Me.ArcScaleComponent1.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#C0C0FF")
        Me.ArcScaleComponent1.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125.0!, 165.0!)
        Me.ArcScaleComponent1.EndAngle = 0.0!
        Me.ArcScaleComponent1.MajorTickCount = 7
        Me.ArcScaleComponent1.MajorTickmark.AllowTickOverlap = True
        Me.ArcScaleComponent1.MajorTickmark.FormatString = "{0:F0}"
        Me.ArcScaleComponent1.MajorTickmark.ShapeOffset = -9.0!
        Me.ArcScaleComponent1.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style2_2
        Me.ArcScaleComponent1.MajorTickmark.TextOffset = -22.0!
        Me.ArcScaleComponent1.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
        Me.ArcScaleComponent1.MaxValue = 100.0!
        Me.ArcScaleComponent1.MinorTickCount = 4
        Me.ArcScaleComponent1.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style2_1
        Me.ArcScaleComponent1.MinValue = 40.0!
        Me.ArcScaleComponent1.Name = "scale1"
        Me.ArcScaleComponent1.RadiusX = 91.0!
        Me.ArcScaleComponent1.RadiusY = 91.0!
        Me.ArcScaleComponent1.StartAngle = -180.0!
        Me.ArcScaleComponent1.Value = 40.0!
        '
        'ArcScaleBackgroundLayerComponent1
        '
        Me.ArcScaleBackgroundLayerComponent1.ArcScale = Me.ArcScaleComponent1
        Me.ArcScaleBackgroundLayerComponent1.Name = "bg1"
        Me.ArcScaleBackgroundLayerComponent1.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5!, 0.72!)
        Me.ArcScaleBackgroundLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularHalf_Style2
        Me.ArcScaleBackgroundLayerComponent1.Size = New System.Drawing.SizeF(244.0!, 170.0!)
        Me.ArcScaleBackgroundLayerComponent1.ZOrder = 1000
        '
        'ArcScaleNeedleComponent1
        '
        Me.ArcScaleNeedleComponent1.ArcScale = Me.ArcScaleComponent1
        Me.ArcScaleNeedleComponent1.EndOffset = -6.0!
        Me.ArcScaleNeedleComponent1.Name = "needle1"
        Me.ArcScaleNeedleComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style2
        Me.ArcScaleNeedleComponent1.StartOffset = 9.0!
        Me.ArcScaleNeedleComponent1.ZOrder = -50
        '
        'ArcScaleSpindleCapComponent1
        '
        Me.ArcScaleSpindleCapComponent1.ArcScale = Me.ArcScaleComponent1
        Me.ArcScaleSpindleCapComponent1.Name = "cap1"
        Me.ArcScaleSpindleCapComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.SpindleCapShapeType.CircularFull_Style2
        Me.ArcScaleSpindleCapComponent1.Size = New System.Drawing.SizeF(24.0!, 24.0!)
        Me.ArcScaleSpindleCapComponent1.ZOrder = -100
        '
        'ArcScaleComponent2
        '
        Me.ArcScaleComponent2.AppearanceTickmarkText.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.ArcScaleComponent2.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125.0!, 250.0!)
        Me.ArcScaleComponent2.EndAngle = -49.0!
        Me.ArcScaleComponent2.MajorTickCount = 7
        Me.ArcScaleComponent2.MajorTickmark.FormatString = "{0:F0}"
        Me.ArcScaleComponent2.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style7_2
        Me.ArcScaleComponent2.MajorTickmark.TextOffset = 23.0!
        Me.ArcScaleComponent2.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
        Me.ArcScaleComponent2.MaxValue = 80.0!
        Me.ArcScaleComponent2.MinorTickCount = 4
        Me.ArcScaleComponent2.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style7_1
        Me.ArcScaleComponent2.MinValue = 20.0!
        Me.ArcScaleComponent2.Name = "scale1"
        Me.ArcScaleComponent2.RadiusX = 140.0!
        Me.ArcScaleComponent2.RadiusY = 140.0!
        Me.ArcScaleComponent2.StartAngle = -131.0!
        Me.ArcScaleComponent2.Value = 50.0!
        '
        'ArcScaleBackgroundLayerComponent3
        '
        Me.ArcScaleBackgroundLayerComponent3.ArcScale = Me.ArcScaleComponent2
        Me.ArcScaleBackgroundLayerComponent3.Name = "bg2"
        Me.ArcScaleBackgroundLayerComponent3.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5!, 1.76!)
        Me.ArcScaleBackgroundLayerComponent3.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularWide_Style7_1
        Me.ArcScaleBackgroundLayerComponent3.Size = New System.Drawing.SizeF(250.0!, 106.0!)
        Me.ArcScaleBackgroundLayerComponent3.ZOrder = -500
        '
        'ArcScaleNeedleComponent2
        '
        Me.ArcScaleNeedleComponent2.ArcScale = Me.ArcScaleComponent2
        Me.ArcScaleNeedleComponent2.EndOffset = -10.0!
        Me.ArcScaleNeedleComponent2.Name = "needle1"
        Me.ArcScaleNeedleComponent2.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularWide_Style7
        Me.ArcScaleNeedleComponent2.StartOffset = 110.0!
        Me.ArcScaleNeedleComponent2.ZOrder = -50
        '
        'ArcScaleEffectLayerComponent1
        '
        Me.ArcScaleEffectLayerComponent1.ArcScale = Me.ArcScaleComponent2
        Me.ArcScaleEffectLayerComponent1.Name = "effect1"
        Me.ArcScaleEffectLayerComponent1.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5!, 2.6!)
        Me.ArcScaleEffectLayerComponent1.Shader = New DevExpress.XtraGauges.Core.Drawing.OpacityShader("Opacity[0.5]")
        Me.ArcScaleEffectLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.EffectLayerShapeType.CircularWide_Style7
        Me.ArcScaleEffectLayerComponent1.Size = New System.Drawing.SizeF(236.0!, 70.0!)
        Me.ArcScaleEffectLayerComponent1.ZOrder = -1000
        '
        'ArcScaleBackgroundLayerComponent2
        '
        Me.ArcScaleBackgroundLayerComponent2.ArcScale = Me.ArcScaleComponent2
        Me.ArcScaleBackgroundLayerComponent2.Name = "bg1"
        Me.ArcScaleBackgroundLayerComponent2.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5!, 1.85!)
        Me.ArcScaleBackgroundLayerComponent2.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularWide_Style7
        Me.ArcScaleBackgroundLayerComponent2.Size = New System.Drawing.SizeF(240.0!, 98.0!)
        Me.ArcScaleBackgroundLayerComponent2.ZOrder = 1000
        '
        'DigitalBackgroundLayerComponent1
        '
        Me.DigitalBackgroundLayerComponent1.BottomRight = New DevExpress.XtraGauges.Core.Base.PointF2D(259.8125!, 99.9625!)
        Me.DigitalBackgroundLayerComponent1.Name = "bg1"
        Me.DigitalBackgroundLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.DigitalBackgroundShapeSetType.Style3
        Me.DigitalBackgroundLayerComponent1.TopLeft = New DevExpress.XtraGauges.Core.Base.PointF2D(20.0!, 0.0!)
        Me.DigitalBackgroundLayerComponent1.ZOrder = 1000
        '
        'GroupControl9
        '
        Me.GroupControl9.Controls.Add(Me.GroupControl10)
        Me.GroupControl9.Location = New System.Drawing.Point(1, 302)
        Me.GroupControl9.Name = "GroupControl9"
        Me.GroupControl9.ShowCaption = False
        Me.GroupControl9.Size = New System.Drawing.Size(1363, 338)
        Me.GroupControl9.TabIndex = 10
        Me.GroupControl9.Text = "GroupControl9"
        '
        'GroupControl10
        '
        Me.GroupControl10.Controls.Add(Me.grdgrmaster)
        Me.GroupControl10.Location = New System.Drawing.Point(1, 0)
        Me.GroupControl10.Name = "GroupControl10"
        Me.GroupControl10.Size = New System.Drawing.Size(1362, 338)
        Me.GroupControl10.TabIndex = 11
        Me.GroupControl10.Text = "General Register Management"
        '
        'btnreset
        '
        Me.btnreset.Image = Global.sms.My.Resources.Resources.reset
        Me.btnreset.Location = New System.Drawing.Point(741, 664)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(73, 31)
        Me.btnreset.TabIndex = 8
        Me.btnreset.Text = "Reset"
        '
        'btncancel
        '
        Me.btncancel.Image = Global.sms.My.Resources.Resources.Delete
        Me.btncancel.Location = New System.Drawing.Point(909, 664)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(73, 31)
        Me.btncancel.TabIndex = 9
        Me.btncancel.Text = "Cancel"
        '
        'btnedit
        '
        Me.btnedit.Image = Global.sms.My.Resources.Resources.Edit
        Me.btnedit.Location = New System.Drawing.Point(555, 664)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(73, 31)
        Me.btnedit.TabIndex = 7
        Me.btnedit.Text = "Edit"
        '
        'btnsave
        '
        Me.btnsave.Image = Global.sms.My.Resources.Resources.Icon_Disk01_Blue
        Me.btnsave.Location = New System.Drawing.Point(391, 664)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(73, 31)
        Me.btnsave.TabIndex = 6
        Me.btnsave.Text = "Save"
        '
        'frmgrmaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1366, 746)
        Me.Controls.Add(Me.GroupControl9)
        Me.Controls.Add(Me.GroupControl7)
        Me.Controls.Add(Me.btnreset)
        Me.Controls.Add(Me.grpacadinfo)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.btnsave)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Name = "frmgrmaster"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student General Register"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdgrmaster, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.grpgeninfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpgeninfo.ResumeLayout(False)
        Me.grpgeninfo.PerformLayout()
        CType(Me.cmbyear.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbyear.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtremarks.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtbplace.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpdob.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpdob.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtstdid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtgrno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpacadinfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpacadinfo.ResumeLayout(False)
        Me.grpacadinfo.PerformLayout()
        CType(Me.cmbleavestd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbadstd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtleavereson.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpleavedate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpleavedate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbcategory.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl6.ResumeLayout(False)
        Me.GroupControl6.PerformLayout()
        CType(Me.txtcaste.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtlastscl.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl5.ResumeLayout(False)
        Me.GroupControl5.PerformLayout()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        Me.GroupControl4.PerformLayout()
        CType(Me.dtpaddte.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpaddte.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl7.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.cmbtry.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DigitalGauge1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DigitalBackgroundLayerComponent2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpcapbility, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpcapbility.ResumeLayout(False)
        Me.grpcapbility.PerformLayout()
        CType(Me.cmbconduct.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbprogress.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CircularGauge2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArcScaleBackgroundLayerComponent6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArcScaleComponent5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArcScaleBackgroundLayerComponent7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArcScaleNeedleComponent4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CircularGauge1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArcScaleBackgroundLayerComponent4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArcScaleComponent3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArcScaleBackgroundLayerComponent5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArcScaleNeedleComponent3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArcScaleComponent4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArcScaleComponent1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArcScaleBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArcScaleNeedleComponent1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArcScaleSpindleCapComponent1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArcScaleComponent2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArcScaleBackgroundLayerComponent3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArcScaleNeedleComponent2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArcScaleEffectLayerComponent1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArcScaleBackgroundLayerComponent2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DigitalBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl9.ResumeLayout(False)
        CType(Me.GroupControl10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl10.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grpgeninfo As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtpdob As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtstdid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtgrno As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtremarks As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtbplace As DevExpress.XtraEditors.TextEdit
    Friend WithEvents grpacadinfo As DevExpress.XtraEditors.GroupControl
    Friend WithEvents dtpaddte As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl5 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents rdresultno As System.Windows.Forms.RadioButton
    Friend WithEvents rdresultyes As System.Windows.Forms.RadioButton
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents rdlcno As System.Windows.Forms.RadioButton
    Friend WithEvents rdlcyes As System.Windows.Forms.RadioButton
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtcaste As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtlastscl As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl6 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents rdother As System.Windows.Forms.RadioButton
    Friend WithEvents rdfemale As System.Windows.Forms.RadioButton
    Friend WithEvents rdmale As System.Windows.Forms.RadioButton
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtleavereson As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtpleavedate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbcategory As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl7 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grpcapbility As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Private WithEvents ArcScaleComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
    Private WithEvents ArcScaleBackgroundLayerComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent
    Private WithEvents ArcScaleNeedleComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
    Private WithEvents ArcScaleSpindleCapComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent
    Friend WithEvents GaugeControl2 As DevExpress.XtraGauges.Win.GaugeControl
    Friend WithEvents CircularGauge2 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge
    Private WithEvents ArcScaleBackgroundLayerComponent6 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent
    Private WithEvents ArcScaleComponent5 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
    Private WithEvents ArcScaleBackgroundLayerComponent7 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent
    Private WithEvents ArcScaleNeedleComponent4 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
    Friend WithEvents GaugeControl1 As DevExpress.XtraGauges.Win.GaugeControl
    Friend WithEvents CircularGauge1 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge
    Private WithEvents ArcScaleBackgroundLayerComponent4 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent
    Private WithEvents ArcScaleComponent3 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
    Private WithEvents ArcScaleBackgroundLayerComponent5 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent
    Private WithEvents ArcScaleNeedleComponent3 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
    Private WithEvents ArcScaleComponent4 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
    Private WithEvents ArcScaleComponent2 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
    Private WithEvents ArcScaleBackgroundLayerComponent3 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent
    Private WithEvents ArcScaleNeedleComponent2 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
    Private WithEvents ArcScaleEffectLayerComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent
    Private WithEvents ArcScaleBackgroundLayerComponent2 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent
    Private WithEvents DigitalBackgroundLayerComponent1 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent
    Friend WithEvents GroupControl9 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cmbconduct As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cmbprogress As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents GroupControl10 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cmbadstd As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cmbleavestd As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents lblremark As System.Windows.Forms.Label
    Friend WithEvents lblyear As System.Windows.Forms.Label
    Friend WithEvents lblbplace As System.Windows.Forms.Label
    Friend WithEvents lbldob As System.Windows.Forms.Label
    Friend WithEvents lblstdid As System.Windows.Forms.Label
    Friend WithEvents lblgrno As System.Windows.Forms.Label
    Friend WithEvents lblleavestd As System.Windows.Forms.Label
    Friend WithEvents lblreason As System.Windows.Forms.Label
    Friend WithEvents lblscleavedt As System.Windows.Forms.Label
    Friend WithEvents lblcategory As System.Windows.Forms.Label
    Friend WithEvents lblgender As System.Windows.Forms.Label
    Friend WithEvents lblcaste As System.Windows.Forms.Label
    Friend WithEvents lbllastschool As System.Windows.Forms.Label
    Friend WithEvents lblresultentry As System.Windows.Forms.Label
    Friend WithEvents lbllcentery As System.Windows.Forms.Label
    Friend WithEvents lbladstd As System.Windows.Forms.Label
    Friend WithEvents lbladdate As System.Windows.Forms.Label
    Friend WithEvents lbltry As System.Windows.Forms.Label
    Friend WithEvents lblconduct As System.Windows.Forms.Label
    Friend WithEvents lblprogress As System.Windows.Forms.Label
    Friend WithEvents btnreset As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btncancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnedit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnsave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grdgrmaster As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
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
    Friend WithEvents std_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents b_place As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents year As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents remarks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents add_dte As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents add_std As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lc_entry As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents result_entry As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents last_Scl As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents leave_dte As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents leave_rsn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents progress As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents conduct As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents try_pass As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmbyear As DevExpress.XtraEditors.DateEdit
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cmbtry As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents gctry As DevExpress.XtraGauges.Win.GaugeControl
    Friend WithEvents DigitalGauge1 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge
    Private WithEvents DigitalBackgroundLayerComponent2 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent
    Friend WithEvents LabelControl20 As DevExpress.XtraEditors.LabelControl
End Class
