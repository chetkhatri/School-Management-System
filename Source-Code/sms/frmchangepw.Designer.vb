<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmchangepw
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmchangepw))
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.lblnewpw = New System.Windows.Forms.Label
        Me.lblcupw = New System.Windows.Forms.Label
        Me.lblusertype = New System.Windows.Forms.Label
        Me.lblusername = New System.Windows.Forms.Label
        Me.cmbutype = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.txtnewpw = New DevExpress.XtraEditors.TextEdit
        Me.txtcupw = New DevExpress.XtraEditors.TextEdit
        Me.txtuname = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.btncancel = New DevExpress.XtraEditors.SimpleButton
        Me.btnsave = New DevExpress.XtraEditors.SimpleButton
        Me.btnreset = New DevExpress.XtraEditors.SimpleButton
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.cmbutype.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtnewpw.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtcupw.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtuname.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.lblnewpw)
        Me.GroupControl1.Controls.Add(Me.lblcupw)
        Me.GroupControl1.Controls.Add(Me.lblusertype)
        Me.GroupControl1.Controls.Add(Me.lblusername)
        Me.GroupControl1.Controls.Add(Me.cmbutype)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.txtnewpw)
        Me.GroupControl1.Controls.Add(Me.txtcupw)
        Me.GroupControl1.Controls.Add(Me.txtuname)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(360, 190)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Change Password Utility"
        '
        'lblnewpw
        '
        Me.lblnewpw.AutoSize = True
        Me.lblnewpw.Location = New System.Drawing.Point(300, 153)
        Me.lblnewpw.Name = "lblnewpw"
        Me.lblnewpw.Size = New System.Drawing.Size(0, 13)
        Me.lblnewpw.TabIndex = 11
        '
        'lblcupw
        '
        Me.lblcupw.AutoSize = True
        Me.lblcupw.Location = New System.Drawing.Point(300, 115)
        Me.lblcupw.Name = "lblcupw"
        Me.lblcupw.Size = New System.Drawing.Size(0, 13)
        Me.lblcupw.TabIndex = 10
        '
        'lblusertype
        '
        Me.lblusertype.AutoSize = True
        Me.lblusertype.Location = New System.Drawing.Point(300, 77)
        Me.lblusertype.Name = "lblusertype"
        Me.lblusertype.Size = New System.Drawing.Size(0, 13)
        Me.lblusertype.TabIndex = 9
        '
        'lblusername
        '
        Me.lblusername.AutoSize = True
        Me.lblusername.Location = New System.Drawing.Point(300, 39)
        Me.lblusername.Name = "lblusername"
        Me.lblusername.Size = New System.Drawing.Size(0, 13)
        Me.lblusername.TabIndex = 8
        '
        'cmbutype
        '
        Me.cmbutype.Location = New System.Drawing.Point(133, 74)
        Me.cmbutype.Name = "cmbutype"
        Me.cmbutype.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbutype.Properties.Items.AddRange(New Object() {"Admin", "Employee"})
        Me.cmbutype.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cmbutype.Size = New System.Drawing.Size(160, 20)
        Me.cmbutype.TabIndex = 2
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(23, 77)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(49, 13)
        Me.LabelControl4.TabIndex = 6
        Me.LabelControl4.Text = "User Type"
        '
        'txtnewpw
        '
        Me.txtnewpw.Location = New System.Drawing.Point(133, 150)
        Me.txtnewpw.Name = "txtnewpw"
        Me.txtnewpw.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtnewpw.Size = New System.Drawing.Size(160, 20)
        Me.txtnewpw.TabIndex = 4
        '
        'txtcupw
        '
        Me.txtcupw.Location = New System.Drawing.Point(133, 112)
        Me.txtcupw.Name = "txtcupw"
        Me.txtcupw.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtcupw.Size = New System.Drawing.Size(160, 20)
        Me.txtcupw.TabIndex = 3
        '
        'txtuname
        '
        Me.txtuname.Location = New System.Drawing.Point(133, 36)
        Me.txtuname.Name = "txtuname"
        Me.txtuname.Size = New System.Drawing.Size(160, 20)
        Me.txtuname.TabIndex = 1
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(23, 153)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(70, 13)
        Me.LabelControl3.TabIndex = 2
        Me.LabelControl3.Text = "New Password"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(23, 115)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(90, 13)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Current- Password"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(23, 39)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(49, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "UserName"
        '
        'btncancel
        '
        Me.btncancel.Image = Global.sms.My.Resources.Resources.Delete1
        Me.btncancel.Location = New System.Drawing.Point(238, 203)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(73, 31)
        Me.btncancel.TabIndex = 7
        Me.btncancel.Text = "Cancel"
        '
        'btnsave
        '
        Me.btnsave.Image = Global.sms.My.Resources.Resources.Icon_Disk01_Blue1
        Me.btnsave.Location = New System.Drawing.Point(44, 203)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(73, 31)
        Me.btnsave.TabIndex = 5
        Me.btnsave.Text = "Save"
        '
        'btnreset
        '
        Me.btnreset.Image = Global.sms.My.Resources.Resources.reset1
        Me.btnreset.Location = New System.Drawing.Point(142, 203)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(73, 31)
        Me.btnreset.TabIndex = 6
        Me.btnreset.Text = "Reset"
        '
        'frmchangepw
        '
        Me.AcceptButton = Me.btnsave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(359, 246)
        Me.Controls.Add(Me.btnreset)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.GroupControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmchangepw"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Password "
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.cmbutype.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtnewpw.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtcupw.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtuname.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtnewpw As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtcupw As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtuname As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbutype As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblnewpw As System.Windows.Forms.Label
    Friend WithEvents lblcupw As System.Windows.Forms.Label
    Friend WithEvents lblusertype As System.Windows.Forms.Label
    Friend WithEvents lblusername As System.Windows.Forms.Label
    Friend WithEvents btncancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnsave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnreset As DevExpress.XtraEditors.SimpleButton
End Class
