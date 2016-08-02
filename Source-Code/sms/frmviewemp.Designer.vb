<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmviewemp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmviewemp))
        Me.GroupControl5 = New DevExpress.XtraEditors.GroupControl
        Me.grdemp = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.emp_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.f_name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.address = New DevExpress.XtraGrid.Columns.GridColumn
        Me.co_no = New DevExpress.XtraGrid.Columns.GridColumn
        Me.email = New DevExpress.XtraGrid.Columns.GridColumn
        Me.dob = New DevExpress.XtraGrid.Columns.GridColumn
        Me.e_gender = New DevExpress.XtraGrid.Columns.GridColumn
        Me.class_no = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gov_no = New DevExpress.XtraGrid.Columns.GridColumn
        Me.dte_frm = New DevExpress.XtraGrid.Columns.GridColumn
        Me.dte_to = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.cmbpost = New DevExpress.XtraEditors.ComboBoxEdit
        Me.cmbempid = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.txtname = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.btnprint = New DevExpress.XtraEditors.SimpleButton
        Me.btncancel = New DevExpress.XtraEditors.SimpleButton
        Me.btnreset = New DevExpress.XtraEditors.SimpleButton
        Me.btnsearch = New DevExpress.XtraEditors.SimpleButton
        Me.btnpprev = New DevExpress.XtraEditors.SimpleButton
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl5.SuspendLayout()
        CType(Me.grdemp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.cmbpost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbempid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtname.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl5
        '
        Me.GroupControl5.Controls.Add(Me.grdemp)
        Me.GroupControl5.Location = New System.Drawing.Point(1, 238)
        Me.GroupControl5.Name = "GroupControl5"
        Me.GroupControl5.Size = New System.Drawing.Size(1101, 393)
        Me.GroupControl5.TabIndex = 6
        Me.GroupControl5.Text = "Employee Information Management"
        '
        'grdemp
        '
        Me.grdemp.Location = New System.Drawing.Point(1, 21)
        Me.grdemp.MainView = Me.GridView1
        Me.grdemp.Name = "grdemp"
        Me.grdemp.Size = New System.Drawing.Size(1100, 368)
        Me.grdemp.TabIndex = 0
        Me.grdemp.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.emp_id, Me.f_name, Me.address, Me.co_no, Me.email, Me.dob, Me.e_gender, Me.class_no, Me.gov_no, Me.dte_frm, Me.dte_to})
        Me.GridView1.GridControl = Me.grdemp
        Me.GridView1.Name = "GridView1"
        '
        'emp_id
        '
        Me.emp_id.Caption = "Emp ID"
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
        'address
        '
        Me.address.Caption = "Address"
        Me.address.FieldName = "address"
        Me.address.Name = "address"
        Me.address.Visible = True
        Me.address.VisibleIndex = 2
        '
        'co_no
        '
        Me.co_no.Caption = "Contact No"
        Me.co_no.FieldName = "co_no"
        Me.co_no.Name = "co_no"
        Me.co_no.Visible = True
        Me.co_no.VisibleIndex = 3
        '
        'email
        '
        Me.email.Caption = "Email"
        Me.email.FieldName = "email"
        Me.email.Name = "email"
        Me.email.Visible = True
        Me.email.VisibleIndex = 4
        '
        'dob
        '
        Me.dob.Caption = "DOB"
        Me.dob.FieldName = "dob"
        Me.dob.Name = "dob"
        Me.dob.Visible = True
        Me.dob.VisibleIndex = 5
        '
        'e_gender
        '
        Me.e_gender.Caption = "Gender"
        Me.e_gender.FieldName = "e_gender"
        Me.e_gender.Name = "e_gender"
        Me.e_gender.Visible = True
        Me.e_gender.VisibleIndex = 6
        '
        'class_no
        '
        Me.class_no.Caption = "Class"
        Me.class_no.FieldName = "class_no"
        Me.class_no.Name = "class_no"
        Me.class_no.Visible = True
        Me.class_no.VisibleIndex = 7
        '
        'gov_no
        '
        Me.gov_no.Caption = "Gov. No"
        Me.gov_no.FieldName = "gov_no"
        Me.gov_no.Name = "gov_no"
        Me.gov_no.Visible = True
        Me.gov_no.VisibleIndex = 8
        '
        'dte_frm
        '
        Me.dte_frm.Caption = "Date  From"
        Me.dte_frm.FieldName = "dte_frm"
        Me.dte_frm.Name = "dte_frm"
        Me.dte_frm.Visible = True
        Me.dte_frm.VisibleIndex = 9
        '
        'dte_to
        '
        Me.dte_to.Caption = "Date To"
        Me.dte_to.FieldName = "dte_to"
        Me.dte_to.Name = "dte_to"
        Me.dte_to.Visible = True
        Me.dte_to.VisibleIndex = 10
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.cmbpost)
        Me.GroupControl2.Controls.Add(Me.cmbempid)
        Me.GroupControl2.Controls.Add(Me.LabelControl3)
        Me.GroupControl2.Controls.Add(Me.LabelControl2)
        Me.GroupControl2.Controls.Add(Me.txtname)
        Me.GroupControl2.Controls.Add(Me.LabelControl1)
        Me.GroupControl2.Location = New System.Drawing.Point(0, 1)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(1102, 162)
        Me.GroupControl2.TabIndex = 0
        Me.GroupControl2.Text = "Select Your Choice For Search By"
        '
        'cmbpost
        '
        Me.cmbpost.Location = New System.Drawing.Point(495, 119)
        Me.cmbpost.Name = "cmbpost"
        Me.cmbpost.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbpost.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cmbpost.Size = New System.Drawing.Size(134, 20)
        Me.cmbpost.TabIndex = 11
        '
        'cmbempid
        '
        Me.cmbempid.Location = New System.Drawing.Point(495, 79)
        Me.cmbempid.Name = "cmbempid"
        Me.cmbempid.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbempid.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cmbempid.Size = New System.Drawing.Size(134, 20)
        Me.cmbempid.TabIndex = 10
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(447, 124)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(21, 13)
        Me.LabelControl3.TabIndex = 9
        Me.LabelControl3.Text = "Post"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(447, 84)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(11, 13)
        Me.LabelControl2.TabIndex = 8
        Me.LabelControl2.Text = "ID"
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(495, 38)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(134, 20)
        Me.txtname.TabIndex = 7
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(447, 43)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl1.TabIndex = 6
        Me.LabelControl1.Text = "Name"
        '
        'btnprint
        '
        Me.btnprint.Image = Global.sms.My.Resources.Resources.Printer_icon
        Me.btnprint.Location = New System.Drawing.Point(345, 186)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(73, 31)
        Me.btnprint.TabIndex = 2
        Me.btnprint.Text = "Print"
        '
        'btncancel
        '
        Me.btncancel.Image = Global.sms.My.Resources.Resources.Delete2
        Me.btncancel.Location = New System.Drawing.Point(888, 186)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(73, 31)
        Me.btncancel.TabIndex = 5
        Me.btncancel.Text = "Cancel"
        '
        'btnreset
        '
        Me.btnreset.Image = Global.sms.My.Resources.Resources.reset2
        Me.btnreset.Location = New System.Drawing.Point(701, 186)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(73, 31)
        Me.btnreset.TabIndex = 4
        Me.btnreset.Text = "Reset"
        '
        'btnsearch
        '
        Me.btnsearch.Image = Global.sms.My.Resources.Resources.p_search_icon
        Me.btnsearch.Location = New System.Drawing.Point(527, 186)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(73, 31)
        Me.btnsearch.TabIndex = 3
        Me.btnsearch.Text = "Search"
        '
        'btnpprev
        '
        Me.btnpprev.Image = Global.sms.My.Resources.Resources.document_print_preview
        Me.btnpprev.Location = New System.Drawing.Point(143, 186)
        Me.btnpprev.Name = "btnpprev"
        Me.btnpprev.Size = New System.Drawing.Size(106, 31)
        Me.btnpprev.TabIndex = 1
        Me.btnpprev.Text = "Print Preview"
        '
        'frmviewemp
        '
        Me.AcceptButton = Me.btnsearch
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1102, 629)
        Me.Controls.Add(Me.btnpprev)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.btnprint)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnreset)
        Me.Controls.Add(Me.GroupControl5)
        Me.Controls.Add(Me.GroupControl2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmviewemp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee Information Searching"
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl5.ResumeLayout(False)
        CType(Me.grdemp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.cmbpost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbempid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtname.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl5 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grdemp As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnprint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btncancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnreset As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnsearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnpprev As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmbpost As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cmbempid As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtname As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents emp_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents f_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents address As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents co_no As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents email As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dob As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents e_gender As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents class_no As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gov_no As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dte_to As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dte_frm As DevExpress.XtraGrid.Columns.GridColumn
End Class
