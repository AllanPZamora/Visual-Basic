<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.title = New System.Windows.Forms.Label()
        Me.text1 = New System.Windows.Forms.Label()
        Me.text2 = New System.Windows.Forms.Label()
        Me.txtlrn = New System.Windows.Forms.TextBox()
        Me.txtaccnum = New System.Windows.Forms.TextBox()
        Me.txtaddress = New System.Windows.Forms.TextBox()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtamount = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtrate = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtyeartpay = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtyeartpayR = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtrateR = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtamountR = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtaddressR = New System.Windows.Forms.TextBox()
        Me.txtnameR = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtaccnumR = New System.Windows.Forms.TextBox()
        Me.txtlrnR = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtloanpay = New System.Windows.Forms.TextBox()
        Me.txttotalapay = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txttotalint = New System.Windows.Forms.TextBox()
        Me.txtmonthlypay = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'title
        '
        Me.title.AutoSize = True
        Me.title.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.title.Location = New System.Drawing.Point(267, 9)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(433, 33)
        Me.title.TabIndex = 0
        Me.title.Text = "LOAN MANAGEMENT SYSTEM"
        Me.title.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'text1
        '
        Me.text1.AutoSize = True
        Me.text1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text1.Location = New System.Drawing.Point(31, 75)
        Me.text1.Name = "text1"
        Me.text1.Size = New System.Drawing.Size(219, 22)
        Me.text1.TabIndex = 1
        Me.text1.Text = "Loan Reference Number"
        '
        'text2
        '
        Me.text2.AutoSize = True
        Me.text2.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.text2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.text2.Location = New System.Drawing.Point(31, 110)
        Me.text2.Name = "text2"
        Me.text2.Size = New System.Drawing.Size(151, 22)
        Me.text2.TabIndex = 2
        Me.text2.Text = "Account Number"
        '
        'txtlrn
        '
        Me.txtlrn.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlrn.Location = New System.Drawing.Point(256, 72)
        Me.txtlrn.Name = "txtlrn"
        Me.txtlrn.Size = New System.Drawing.Size(190, 29)
        Me.txtlrn.TabIndex = 3
        '
        'txtaccnum
        '
        Me.txtaccnum.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.txtaccnum.Location = New System.Drawing.Point(256, 107)
        Me.txtaccnum.Name = "txtaccnum"
        Me.txtaccnum.Size = New System.Drawing.Size(190, 29)
        Me.txtaccnum.TabIndex = 4
        '
        'txtaddress
        '
        Me.txtaddress.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.txtaddress.Location = New System.Drawing.Point(256, 177)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(190, 29)
        Me.txtaddress.TabIndex = 8
        '
        'txtname
        '
        Me.txtname.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.txtname.Location = New System.Drawing.Point(256, 142)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(190, 29)
        Me.txtname.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(31, 180)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 22)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Address"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(31, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 22)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Name"
        '
        'txtamount
        '
        Me.txtamount.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.txtamount.Location = New System.Drawing.Point(256, 212)
        Me.txtamount.Name = "txtamount"
        Me.txtamount.Size = New System.Drawing.Size(190, 29)
        Me.txtamount.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(31, 215)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 22)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Amount Loan"
        '
        'txtrate
        '
        Me.txtrate.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.txtrate.Location = New System.Drawing.Point(256, 247)
        Me.txtrate.Name = "txtrate"
        Me.txtrate.Size = New System.Drawing.Size(190, 29)
        Me.txtrate.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(31, 250)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 22)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Interest Rate"
        '
        'txtyeartpay
        '
        Me.txtyeartpay.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.txtyeartpay.Location = New System.Drawing.Point(256, 282)
        Me.txtyeartpay.Name = "txtyeartpay"
        Me.txtyeartpay.Size = New System.Drawing.Size(190, 29)
        Me.txtyeartpay.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(31, 285)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(127, 22)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Year(s) to Pay"
        '
        'txtyeartpayR
        '
        Me.txtyeartpayR.Enabled = False
        Me.txtyeartpayR.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.txtyeartpayR.Location = New System.Drawing.Point(716, 278)
        Me.txtyeartpayR.Name = "txtyeartpayR"
        Me.txtyeartpayR.Size = New System.Drawing.Size(190, 29)
        Me.txtyeartpayR.TabIndex = 28
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(491, 281)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(127, 22)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Year(s) to Pay"
        '
        'txtrateR
        '
        Me.txtrateR.Enabled = False
        Me.txtrateR.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.txtrateR.Location = New System.Drawing.Point(716, 243)
        Me.txtrateR.Name = "txtrateR"
        Me.txtrateR.Size = New System.Drawing.Size(190, 29)
        Me.txtrateR.TabIndex = 26
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(491, 246)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(119, 22)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Interest Rate"
        '
        'txtamountR
        '
        Me.txtamountR.Enabled = False
        Me.txtamountR.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.txtamountR.Location = New System.Drawing.Point(716, 208)
        Me.txtamountR.Name = "txtamountR"
        Me.txtamountR.Size = New System.Drawing.Size(190, 29)
        Me.txtamountR.TabIndex = 24
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(491, 211)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(122, 22)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Amount Loan"
        '
        'txtaddressR
        '
        Me.txtaddressR.Enabled = False
        Me.txtaddressR.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.txtaddressR.Location = New System.Drawing.Point(716, 173)
        Me.txtaddressR.Name = "txtaddressR"
        Me.txtaddressR.Size = New System.Drawing.Size(190, 29)
        Me.txtaddressR.TabIndex = 22
        '
        'txtnameR
        '
        Me.txtnameR.Enabled = False
        Me.txtnameR.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.txtnameR.Location = New System.Drawing.Point(716, 138)
        Me.txtnameR.Name = "txtnameR"
        Me.txtnameR.Size = New System.Drawing.Size(190, 29)
        Me.txtnameR.TabIndex = 21
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(491, 176)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 22)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Address"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(491, 141)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 22)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Name"
        '
        'txtaccnumR
        '
        Me.txtaccnumR.Enabled = False
        Me.txtaccnumR.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.txtaccnumR.Location = New System.Drawing.Point(716, 103)
        Me.txtaccnumR.Name = "txtaccnumR"
        Me.txtaccnumR.Size = New System.Drawing.Size(190, 29)
        Me.txtaccnumR.TabIndex = 18
        '
        'txtlrnR
        '
        Me.txtlrnR.Enabled = False
        Me.txtlrnR.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.txtlrnR.Location = New System.Drawing.Point(716, 68)
        Me.txtlrnR.Name = "txtlrnR"
        Me.txtlrnR.Size = New System.Drawing.Size(190, 29)
        Me.txtlrnR.TabIndex = 17
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.Label11.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label11.Location = New System.Drawing.Point(491, 106)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(151, 22)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Account Number"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.Label12.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label12.Location = New System.Drawing.Point(491, 71)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(219, 22)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Loan Reference Number"
        '
        'txtloanpay
        '
        Me.txtloanpay.Enabled = False
        Me.txtloanpay.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.txtloanpay.Location = New System.Drawing.Point(716, 445)
        Me.txtloanpay.Name = "txtloanpay"
        Me.txtloanpay.Size = New System.Drawing.Size(190, 29)
        Me.txtloanpay.TabIndex = 36
        '
        'txttotalapay
        '
        Me.txttotalapay.Enabled = False
        Me.txttotalapay.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.txttotalapay.Location = New System.Drawing.Point(716, 410)
        Me.txttotalapay.Name = "txttotalapay"
        Me.txttotalapay.Size = New System.Drawing.Size(190, 29)
        Me.txttotalapay.TabIndex = 35
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.Label14.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label14.Location = New System.Drawing.Point(491, 448)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(176, 22)
        Me.Label14.TabIndex = 34
        Me.Label14.Text = "Total Loan Payment"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.Label15.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label15.Location = New System.Drawing.Point(491, 413)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(190, 22)
        Me.Label15.TabIndex = 33
        Me.Label15.Text = "Total Annual Payment"
        '
        'txttotalint
        '
        Me.txttotalint.Enabled = False
        Me.txttotalint.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.txttotalint.Location = New System.Drawing.Point(716, 375)
        Me.txttotalint.Name = "txttotalint"
        Me.txttotalint.Size = New System.Drawing.Size(190, 29)
        Me.txttotalint.TabIndex = 32
        '
        'txtmonthlypay
        '
        Me.txtmonthlypay.Enabled = False
        Me.txtmonthlypay.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.txtmonthlypay.Location = New System.Drawing.Point(716, 340)
        Me.txtmonthlypay.Name = "txtmonthlypay"
        Me.txtmonthlypay.Size = New System.Drawing.Size(190, 29)
        Me.txtmonthlypay.TabIndex = 31
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.Label16.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label16.Location = New System.Drawing.Point(491, 378)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(119, 22)
        Me.Label16.TabIndex = 30
        Me.Label16.Text = "Total Interest"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.Label17.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label17.Location = New System.Drawing.Point(491, 343)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(153, 22)
        Me.Label17.TabIndex = 29
        Me.Label17.Text = "Monthly Payment"
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.Control
        Me.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnClear.FlatAppearance.BorderSize = 3
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold)
        Me.btnClear.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnClear.Location = New System.Drawing.Point(50, 378)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(163, 78)
        Me.btnClear.TabIndex = 40
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnCompute
        '
        Me.btnCompute.BackColor = System.Drawing.SystemColors.Control
        Me.btnCompute.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnCompute.FlatAppearance.BorderSize = 3
        Me.btnCompute.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCompute.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompute.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCompute.Location = New System.Drawing.Point(256, 378)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(163, 78)
        Me.btnCompute.TabIndex = 41
        Me.btnCompute.Text = "COMPUTE"
        Me.btnCompute.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSize = True
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.ClientSize = New System.Drawing.Size(939, 493)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtloanpay)
        Me.Controls.Add(Me.txttotalapay)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txttotalint)
        Me.Controls.Add(Me.txtmonthlypay)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtyeartpayR)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtrateR)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtamountR)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtaddressR)
        Me.Controls.Add(Me.txtnameR)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtaccnumR)
        Me.Controls.Add(Me.txtlrnR)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtyeartpay)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtrate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtamount)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtaddress)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtaccnum)
        Me.Controls.Add(Me.txtlrn)
        Me.Controls.Add(Me.text2)
        Me.Controls.Add(Me.text1)
        Me.Controls.Add(Me.title)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loan Management System"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents title As Label
    Friend WithEvents text1 As Label
    Friend WithEvents text2 As Label
    Friend WithEvents txtlrn As TextBox
    Friend WithEvents txtaccnum As TextBox
    Friend WithEvents txtaddress As TextBox
    Friend WithEvents txtname As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtamount As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtrate As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtyeartpay As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtyeartpayR As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtrateR As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtamountR As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtaddressR As TextBox
    Friend WithEvents txtnameR As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtaccnumR As TextBox
    Friend WithEvents txtlrnR As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtloanpay As TextBox
    Friend WithEvents txttotalapay As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txttotalint As TextBox
    Friend WithEvents txtmonthlypay As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnCompute As Button
End Class
