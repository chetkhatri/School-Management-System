<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptfeesreceipt
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptfeesreceipt))
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell
        Me.xrfname = New DevExpress.XtraReports.UI.XRTableCell
        Me.xrmname = New DevExpress.XtraReports.UI.XRTableCell
        Me.xrlname = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell
        Me.xrclass = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell
        Me.xrstdid = New DevExpress.XtraReports.UI.XRTableCell
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand
        Me.XrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo
        Me.xruser = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox
        Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrtotal = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrTable3 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow10 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTable2 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow4 = New DevExpress.XtraReports.UI.XRTableRow
        Me.xrfeetype = New DevExpress.XtraReports.UI.XRTableCell
        Me.xrfamt = New DevExpress.XtraReports.UI.XRTableCell
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable2})
        Me.Detail.Height = 25
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable3, Me.XrTable1})
        Me.PageHeader.Height = 150
        Me.PageHeader.Name = "PageHeader"
        Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrTable1
        '
        Me.XrTable1.Location = New System.Drawing.Point(183, 17)
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1, Me.XrTableRow2, Me.XrTableRow3})
        Me.XrTable1.Size = New System.Drawing.Size(325, 75)
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell1, Me.xrfname, Me.xrmname, Me.xrlname})
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Size = New System.Drawing.Size(325, 25)
        '
        'XrTableCell1
        '
        Me.XrTableCell1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell1.Location = New System.Drawing.Point(0, 0)
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.Size = New System.Drawing.Size(108, 25)
        Me.XrTableCell1.StylePriority.UseFont = False
        Me.XrTableCell1.Text = "Name :-"
        '
        'xrfname
        '
        Me.xrfname.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.xrfname.Location = New System.Drawing.Point(108, 0)
        Me.xrfname.Name = "xrfname"
        Me.xrfname.Size = New System.Drawing.Size(93, 25)
        Me.xrfname.StylePriority.UseFont = False
        Me.xrfname.Text = "xrfname"
        '
        'xrmname
        '
        Me.xrmname.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.xrmname.Location = New System.Drawing.Point(201, 0)
        Me.xrmname.Name = "xrmname"
        Me.xrmname.Size = New System.Drawing.Size(41, 25)
        Me.xrmname.StylePriority.UseFont = False
        Me.xrmname.Text = "xrmname"
        '
        'xrlname
        '
        Me.xrlname.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.xrlname.Location = New System.Drawing.Point(242, 0)
        Me.xrlname.Name = "xrlname"
        Me.xrlname.Size = New System.Drawing.Size(83, 25)
        Me.xrlname.StylePriority.UseFont = False
        Me.xrlname.Text = "xrlname"
        '
        'XrTableRow2
        '
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell3, Me.xrclass})
        Me.XrTableRow2.Name = "XrTableRow2"
        Me.XrTableRow2.Size = New System.Drawing.Size(325, 25)
        '
        'XrTableCell3
        '
        Me.XrTableCell3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell3.Location = New System.Drawing.Point(0, 0)
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.Size = New System.Drawing.Size(108, 25)
        Me.XrTableCell3.StylePriority.UseFont = False
        Me.XrTableCell3.Text = "Class :-"
        '
        'xrclass
        '
        Me.xrclass.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.xrclass.Location = New System.Drawing.Point(108, 0)
        Me.xrclass.Name = "xrclass"
        Me.xrclass.Size = New System.Drawing.Size(217, 25)
        Me.xrclass.StylePriority.UseFont = False
        Me.xrclass.Text = "xrclass"
        '
        'XrTableRow3
        '
        Me.XrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell5, Me.xrstdid})
        Me.XrTableRow3.Name = "XrTableRow3"
        Me.XrTableRow3.Size = New System.Drawing.Size(325, 25)
        '
        'XrTableCell5
        '
        Me.XrTableCell5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell5.Location = New System.Drawing.Point(0, 0)
        Me.XrTableCell5.Name = "XrTableCell5"
        Me.XrTableCell5.Size = New System.Drawing.Size(108, 25)
        Me.XrTableCell5.StylePriority.UseFont = False
        Me.XrTableCell5.Text = "Student ID :-"
        '
        'xrstdid
        '
        Me.xrstdid.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.xrstdid.Location = New System.Drawing.Point(108, 0)
        Me.xrstdid.Name = "xrstdid"
        Me.xrstdid.Size = New System.Drawing.Size(217, 25)
        Me.xrstdid.StylePriority.UseFont = False
        Me.xrstdid.Text = "xrstdid"
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPageInfo2, Me.xruser, Me.XrLabel2, Me.XrPageInfo1})
        Me.PageFooter.Height = 41
        Me.PageFooter.Name = "PageFooter"
        Me.PageFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrPageInfo2
        '
        Me.XrPageInfo2.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.XrPageInfo2.Format = "Page {0} of {1}"
        Me.XrPageInfo2.Location = New System.Drawing.Point(608, 8)
        Me.XrPageInfo2.Name = "XrPageInfo2"
        Me.XrPageInfo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo2.Size = New System.Drawing.Size(100, 25)
        Me.XrPageInfo2.StylePriority.UseFont = False
        '
        'xruser
        '
        Me.xruser.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.xruser.Location = New System.Drawing.Point(383, 8)
        Me.xruser.Name = "xruser"
        Me.xruser.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xruser.Size = New System.Drawing.Size(100, 25)
        Me.xruser.StylePriority.UseFont = False
        Me.xruser.StylePriority.UseTextAlignment = False
        Me.xruser.Text = "xruser"
        '
        'XrLabel2
        '
        Me.XrLabel2.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.XrLabel2.Location = New System.Drawing.Point(200, 8)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.Size = New System.Drawing.Size(175, 25)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "Report Generated By :-"
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.XrPageInfo1.Location = New System.Drawing.Point(8, 8)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.XrPageInfo1.Size = New System.Drawing.Size(100, 25)
        Me.XrPageInfo1.StylePriority.UseFont = False
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine1, Me.XrLabel1, Me.XrLabel9, Me.XrPictureBox1})
        Me.ReportHeader.Height = 161
        Me.ReportHeader.Name = "ReportHeader"
        '
        'XrLine1
        '
        Me.XrLine1.Location = New System.Drawing.Point(0, 150)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.Size = New System.Drawing.Size(708, 2)
        '
        'XrLabel1
        '
        Me.XrLabel1.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel1.ForeColor = System.Drawing.Color.Maroon
        Me.XrLabel1.Location = New System.Drawing.Point(192, 83)
        Me.XrLabel1.Multiline = True
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.Size = New System.Drawing.Size(400, 33)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseForeColor = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "Student Fees Receipt"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel9
        '
        Me.XrLabel9.Font = New System.Drawing.Font("Times New Roman", 20.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel9.ForeColor = System.Drawing.Color.Maroon
        Me.XrLabel9.Location = New System.Drawing.Point(192, 17)
        Me.XrLabel9.Multiline = True
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.Size = New System.Drawing.Size(400, 33)
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.StylePriority.UseForeColor = False
        Me.XrLabel9.StylePriority.UseTextAlignment = False
        Me.XrLabel9.Text = "School Management System" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrPictureBox1
        '
        Me.XrPictureBox1.Image = CType(resources.GetObject("XrPictureBox1.Image"), System.Drawing.Image)
        Me.XrPictureBox1.ImageUrl = "D:\SMS\sms\sms\Resources\sms.png"
        Me.XrPictureBox1.Location = New System.Drawing.Point(0, 8)
        Me.XrPictureBox1.Name = "XrPictureBox1"
        Me.XrPictureBox1.Size = New System.Drawing.Size(167, 135)
        Me.XrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel3, Me.xrtotal, Me.XrLabel4})
        Me.GroupFooter1.Height = 118
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'XrLabel3
        '
        Me.XrLabel3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel3.Location = New System.Drawing.Point(492, 92)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.Size = New System.Drawing.Size(158, 25)
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.Text = "(Receiving Cashier)"
        '
        'xrtotal
        '
        Me.xrtotal.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.xrtotal.Location = New System.Drawing.Point(325, 8)
        Me.xrtotal.Name = "xrtotal"
        Me.xrtotal.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrtotal.Size = New System.Drawing.Size(100, 25)
        Me.xrtotal.StylePriority.UseFont = False
        Me.xrtotal.StylePriority.UseTextAlignment = False
        Me.xrtotal.Text = "xrtotal"
        Me.xrtotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel4
        '
        Me.XrLabel4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel4.Location = New System.Drawing.Point(183, 8)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.Size = New System.Drawing.Size(167, 25)
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.Text = "Total Amount :-  Rs."
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTable3
        '
        Me.XrTable3.Location = New System.Drawing.Point(183, 125)
        Me.XrTable3.Name = "XrTable3"
        Me.XrTable3.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow10})
        Me.XrTable3.Size = New System.Drawing.Size(325, 25)
        '
        'XrTableRow10
        '
        Me.XrTableRow10.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell7})
        Me.XrTableRow10.Name = "XrTableRow10"
        Me.XrTableRow10.Size = New System.Drawing.Size(325, 25)
        '
        'XrTableCell7
        '
        Me.XrTableCell7.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell7.Location = New System.Drawing.Point(0, 0)
        Me.XrTableCell7.Name = "XrTableCell7"
        Me.XrTableCell7.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 0, 0, 0, 100.0!)
        Me.XrTableCell7.Size = New System.Drawing.Size(325, 25)
        Me.XrTableCell7.StylePriority.UseBorders = False
        Me.XrTableCell7.StylePriority.UseFont = False
        Me.XrTableCell7.StylePriority.UsePadding = False
        Me.XrTableCell7.StylePriority.UseTextAlignment = False
        Me.XrTableCell7.Text = "Fees Descriptions"
        Me.XrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrTable2
        '
        Me.XrTable2.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable2.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.XrTable2.Location = New System.Drawing.Point(183, 0)
        Me.XrTable2.Name = "XrTable2"
        Me.XrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow4})
        Me.XrTable2.Size = New System.Drawing.Size(325, 25)
        Me.XrTable2.StylePriority.UseBorders = False
        Me.XrTable2.StylePriority.UseFont = False
        Me.XrTable2.StylePriority.UseTextAlignment = False
        '
        'XrTableRow4
        '
        Me.XrTableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrfeetype, Me.xrfamt})
        Me.XrTableRow4.Name = "XrTableRow4"
        Me.XrTableRow4.Size = New System.Drawing.Size(325, 25)
        '
        'xrfeetype
        '
        Me.xrfeetype.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold)
        Me.xrfeetype.Location = New System.Drawing.Point(0, 0)
        Me.xrfeetype.Name = "xrfeetype"
        Me.xrfeetype.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 0, 0, 0, 100.0!)
        Me.xrfeetype.Size = New System.Drawing.Size(158, 25)
        Me.xrfeetype.StylePriority.UseFont = False
        Me.xrfeetype.StylePriority.UsePadding = False
        Me.xrfeetype.StylePriority.UseTextAlignment = False
        Me.xrfeetype.Text = "xrfeetype"
        Me.xrfeetype.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'xrfamt
        '
        Me.xrfamt.Location = New System.Drawing.Point(158, 0)
        Me.xrfamt.Name = "xrfamt"
        Me.xrfamt.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
        Me.xrfamt.Size = New System.Drawing.Size(167, 25)
        Me.xrfamt.StylePriority.UsePadding = False
        Me.xrfamt.StylePriority.UseTextAlignment = False
        Me.xrfamt.Text = "xrfamt"
        Me.xrfamt.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'rptfeesreceipt
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeader, Me.PageFooter, Me.ReportHeader, Me.GroupFooter1})
        Me.Margins = New System.Drawing.Printing.Margins(100, 40, 100, 100)
        Me.Version = "8.3"
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrlname As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrclass As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow3 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrstdid As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents xrtotal As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents xruser As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrfname As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrmname As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow4 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents xrfeetype As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrfamt As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable3 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow10 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
End Class
