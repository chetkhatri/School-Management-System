<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptallowance
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptallowance))
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine
        Me.XrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTable2 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow
        Me.xrdte = New DevExpress.XtraReports.UI.XRTableCell
        Me.xrgpay = New DevExpress.XtraReports.UI.XRTableCell
        Me.xrda = New DevExpress.XtraReports.UI.XRTableCell
        Me.xrhra = New DevExpress.XtraReports.UI.XRTableCell
        Me.xrmedall = New DevExpress.XtraReports.UI.XRTableCell
        Me.xrfpi = New DevExpress.XtraReports.UI.XRTableCell
        Me.xrcashall = New DevExpress.XtraReports.UI.XRTableCell
        Me.xrwasall = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo
        Me.XrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel
        Me.xruser = New DevExpress.XtraReports.UI.XRLabel
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable1})
        Me.PageHeader.Height = 25
        Me.PageHeader.Name = "PageHeader"
        Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageHeader.StylePriority.UseTextAlignment = False
        Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xruser, Me.XrLabel2, Me.XrPageInfo2, Me.XrPageInfo1})
        Me.PageFooter.Height = 42
        Me.PageFooter.Name = "PageFooter"
        Me.PageFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine1, Me.XrLabel1, Me.XrLabel9, Me.XrPictureBox1})
        Me.ReportHeader.Height = 161
        Me.ReportHeader.Name = "ReportHeader"
        '
        'XrLabel9
        '
        Me.XrLabel9.Font = New System.Drawing.Font("Times New Roman", 20.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel9.ForeColor = System.Drawing.Color.Maroon
        Me.XrLabel9.Location = New System.Drawing.Point(300, 17)
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
        'XrLabel1
        '
        Me.XrLabel1.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel1.ForeColor = System.Drawing.Color.Maroon
        Me.XrLabel1.Location = New System.Drawing.Point(300, 83)
        Me.XrLabel1.Multiline = True
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.Size = New System.Drawing.Size(400, 33)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseForeColor = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "Allowance Rules Update Report"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLine1
        '
        Me.XrLine1.Location = New System.Drawing.Point(8, 150)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.Size = New System.Drawing.Size(950, 2)
        '
        'XrPictureBox1
        '
        Me.XrPictureBox1.Image = CType(resources.GetObject("XrPictureBox1.Image"), System.Drawing.Image)
        Me.XrPictureBox1.ImageUrl = "D:\SMS\sms\sms\Resources\sms.png"
        Me.XrPictureBox1.Location = New System.Drawing.Point(8, 8)
        Me.XrPictureBox1.Name = "XrPictureBox1"
        Me.XrPictureBox1.Size = New System.Drawing.Size(167, 135)
        Me.XrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        '
        'XrTable1
        '
        Me.XrTable1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTable1.Location = New System.Drawing.Point(58, 0)
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1})
        Me.XrTable1.Size = New System.Drawing.Size(650, 25)
        Me.XrTable1.StylePriority.UseBorders = False
        Me.XrTable1.StylePriority.UseFont = False
        Me.XrTable1.StylePriority.UseTextAlignment = False
        Me.XrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell1, Me.XrTableCell2, Me.XrTableCell4, Me.XrTableCell5, Me.XrTableCell7, Me.XrTableCell8, Me.XrTableCell9, Me.XrTableCell10})
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Size = New System.Drawing.Size(650, 25)
        '
        'XrTableCell1
        '
        Me.XrTableCell1.Location = New System.Drawing.Point(0, 0)
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.Size = New System.Drawing.Size(158, 25)
        Me.XrTableCell1.Text = "Date"
        '
        'XrTableCell2
        '
        Me.XrTableCell2.Location = New System.Drawing.Point(158, 0)
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.Size = New System.Drawing.Size(59, 25)
        Me.XrTableCell2.Text = "G.Pay"
        '
        'XrTableCell4
        '
        Me.XrTableCell4.Location = New System.Drawing.Point(217, 0)
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.Size = New System.Drawing.Size(50, 25)
        Me.XrTableCell4.Text = "D.A"
        '
        'XrTableCell5
        '
        Me.XrTableCell5.Location = New System.Drawing.Point(267, 0)
        Me.XrTableCell5.Name = "XrTableCell5"
        Me.XrTableCell5.Size = New System.Drawing.Size(58, 25)
        Me.XrTableCell5.Text = "H.R.A"
        '
        'XrTableCell7
        '
        Me.XrTableCell7.Location = New System.Drawing.Point(325, 0)
        Me.XrTableCell7.Name = "XrTableCell7"
        Me.XrTableCell7.Size = New System.Drawing.Size(83, 25)
        Me.XrTableCell7.Text = "Med.All"
        '
        'XrTableCell8
        '
        Me.XrTableCell8.Location = New System.Drawing.Point(408, 0)
        Me.XrTableCell8.Name = "XrTableCell8"
        Me.XrTableCell8.Size = New System.Drawing.Size(59, 25)
        Me.XrTableCell8.Text = "F.P.I"
        '
        'XrTableCell9
        '
        Me.XrTableCell9.Location = New System.Drawing.Point(467, 0)
        Me.XrTableCell9.Name = "XrTableCell9"
        Me.XrTableCell9.Size = New System.Drawing.Size(83, 25)
        Me.XrTableCell9.Text = "Cash.All"
        '
        'XrTableCell10
        '
        Me.XrTableCell10.Location = New System.Drawing.Point(550, 0)
        Me.XrTableCell10.Name = "XrTableCell10"
        Me.XrTableCell10.Size = New System.Drawing.Size(100, 25)
        Me.XrTableCell10.Text = "Was.All"
        '
        'XrTable2
        '
        Me.XrTable2.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable2.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.XrTable2.Location = New System.Drawing.Point(58, 0)
        Me.XrTable2.Name = "XrTable2"
        Me.XrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow2})
        Me.XrTable2.Size = New System.Drawing.Size(650, 25)
        Me.XrTable2.StylePriority.UseBorders = False
        Me.XrTable2.StylePriority.UseFont = False
        Me.XrTable2.StylePriority.UseTextAlignment = False
        Me.XrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow2
        '
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrdte, Me.xrgpay, Me.xrda, Me.xrhra, Me.xrmedall, Me.xrfpi, Me.xrcashall, Me.xrwasall})
        Me.XrTableRow2.Name = "XrTableRow2"
        Me.XrTableRow2.Size = New System.Drawing.Size(650, 25)
        '
        'xrdte
        '
        Me.xrdte.Location = New System.Drawing.Point(0, 0)
        Me.xrdte.Name = "xrdte"
        Me.xrdte.Size = New System.Drawing.Size(158, 25)
        Me.xrdte.Text = "xrdte"
        '
        'xrgpay
        '
        Me.xrgpay.Location = New System.Drawing.Point(158, 0)
        Me.xrgpay.Name = "xrgpay"
        Me.xrgpay.Size = New System.Drawing.Size(59, 25)
        Me.xrgpay.Text = "xrgpay"
        '
        'xrda
        '
        Me.xrda.Location = New System.Drawing.Point(217, 0)
        Me.xrda.Name = "xrda"
        Me.xrda.Size = New System.Drawing.Size(50, 25)
        Me.xrda.Text = "xrda"
        '
        'xrhra
        '
        Me.xrhra.Location = New System.Drawing.Point(267, 0)
        Me.xrhra.Name = "xrhra"
        Me.xrhra.Size = New System.Drawing.Size(58, 25)
        Me.xrhra.Text = "xrhra"
        '
        'xrmedall
        '
        Me.xrmedall.Location = New System.Drawing.Point(325, 0)
        Me.xrmedall.Name = "xrmedall"
        Me.xrmedall.Size = New System.Drawing.Size(83, 25)
        Me.xrmedall.Text = "xrmedall"
        '
        'xrfpi
        '
        Me.xrfpi.Location = New System.Drawing.Point(408, 0)
        Me.xrfpi.Name = "xrfpi"
        Me.xrfpi.Size = New System.Drawing.Size(59, 25)
        Me.xrfpi.Text = "xrfpi"
        '
        'xrcashall
        '
        Me.xrcashall.Location = New System.Drawing.Point(467, 0)
        Me.xrcashall.Name = "xrcashall"
        Me.xrcashall.Size = New System.Drawing.Size(83, 25)
        Me.xrcashall.Text = "xrcashall"
        '
        'xrwasall
        '
        Me.xrwasall.Location = New System.Drawing.Point(550, 0)
        Me.xrwasall.Name = "xrwasall"
        Me.xrwasall.Size = New System.Drawing.Size(100, 25)
        Me.xrwasall.Text = "xrwasall"
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.XrPageInfo1.Location = New System.Drawing.Point(17, 8)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.XrPageInfo1.Size = New System.Drawing.Size(100, 25)
        Me.XrPageInfo1.StylePriority.UseFont = False
        '
        'XrPageInfo2
        '
        Me.XrPageInfo2.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.XrPageInfo2.Format = "Page {0} of {1}"
        Me.XrPageInfo2.Location = New System.Drawing.Point(850, 8)
        Me.XrPageInfo2.Name = "XrPageInfo2"
        Me.XrPageInfo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo2.Size = New System.Drawing.Size(100, 25)
        Me.XrPageInfo2.StylePriority.UseFont = False
        '
        'XrLabel2
        '
        Me.XrLabel2.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.XrLabel2.Location = New System.Drawing.Point(333, 8)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.Size = New System.Drawing.Size(175, 25)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "Report Generated By :-"
        '
        'xruser
        '
        Me.xruser.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.xruser.Location = New System.Drawing.Point(508, 8)
        Me.xruser.Name = "xruser"
        Me.xruser.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xruser.Size = New System.Drawing.Size(100, 25)
        Me.xruser.StylePriority.UseFont = False
        Me.xruser.StylePriority.UseTextAlignment = False
        Me.xruser.Text = "xruser"
        '
        'rptallowance
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeader, Me.PageFooter, Me.ReportHeader})
        Me.Landscape = True
        Me.Margins = New System.Drawing.Printing.Margins(100, 40, 100, 100)
        Me.PageHeight = 850
        Me.PageWidth = 1100
        Me.Version = "8.3"
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell10 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents xrdte As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrgpay As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrda As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrhra As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrmedall As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrfpi As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrcashall As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrwasall As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xruser As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
End Class
