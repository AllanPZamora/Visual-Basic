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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtdept = New System.Windows.Forms.TextBox()
        Me.txtworkhours = New System.Windows.Forms.TextBox()
        Me.txtovertimerate = New System.Windows.Forms.TextBox()
        Me.txtovertime = New System.Windows.Forms.TextBox()
        Me.txtrate = New System.Windows.Forms.TextBox()
        Me.txtovertimerateR = New System.Windows.Forms.TextBox()
        Me.txtovertimeR = New System.Windows.Forms.TextBox()
        Me.txtrateR = New System.Windows.Forms.TextBox()
        Me.txtworkhoursR = New System.Windows.Forms.TextBox()
        Me.txtdeptR = New System.Windows.Forms.TextBox()
        Me.txtnameR = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtNetpay = New System.Windows.Forms.TextBox()
        Me.txtDeduc = New System.Windows.Forms.TextBox()
        Me.txtincometax = New System.Windows.Forms.TextBox()
        Me.txtPI = New System.Windows.Forms.TextBox()
        Me.txtPH = New System.Windows.Forms.TextBox()
        Me.txtSSS = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Com = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtgross = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(474, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(423, 43)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Salary Computation System"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 22)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Department"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(25, 181)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(147, 22)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Working Hour(s)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(25, 220)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 22)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Regular Rate"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(25, 259)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 22)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Overtime"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(25, 296)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(132, 22)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Overtime Rate"
        '
        'txtname
        '
        Me.txtname.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.Location = New System.Drawing.Point(222, 94)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(192, 29)
        Me.txtname.TabIndex = 7
        '
        'txtdept
        '
        Me.txtdept.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdept.Location = New System.Drawing.Point(222, 133)
        Me.txtdept.Name = "txtdept"
        Me.txtdept.Size = New System.Drawing.Size(192, 29)
        Me.txtdept.TabIndex = 8
        '
        'txtworkhours
        '
        Me.txtworkhours.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtworkhours.Location = New System.Drawing.Point(222, 174)
        Me.txtworkhours.Name = "txtworkhours"
        Me.txtworkhours.Size = New System.Drawing.Size(192, 29)
        Me.txtworkhours.TabIndex = 9
        Me.txtworkhours.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtovertimerate
        '
        Me.txtovertimerate.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtovertimerate.Location = New System.Drawing.Point(222, 289)
        Me.txtovertimerate.Name = "txtovertimerate"
        Me.txtovertimerate.Size = New System.Drawing.Size(192, 29)
        Me.txtovertimerate.TabIndex = 12
        Me.txtovertimerate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtovertime
        '
        Me.txtovertime.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtovertime.Location = New System.Drawing.Point(222, 252)
        Me.txtovertime.Name = "txtovertime"
        Me.txtovertime.Size = New System.Drawing.Size(192, 29)
        Me.txtovertime.TabIndex = 11
        Me.txtovertime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtrate
        '
        Me.txtrate.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrate.Location = New System.Drawing.Point(222, 213)
        Me.txtrate.Name = "txtrate"
        Me.txtrate.Size = New System.Drawing.Size(192, 29)
        Me.txtrate.TabIndex = 10
        Me.txtrate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtovertimerateR
        '
        Me.txtovertimerateR.Enabled = False
        Me.txtovertimerateR.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtovertimerateR.Location = New System.Drawing.Point(649, 293)
        Me.txtovertimerateR.Name = "txtovertimerateR"
        Me.txtovertimerateR.Size = New System.Drawing.Size(192, 29)
        Me.txtovertimerateR.TabIndex = 24
        Me.txtovertimerateR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtovertimeR
        '
        Me.txtovertimeR.Enabled = False
        Me.txtovertimeR.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtovertimeR.Location = New System.Drawing.Point(649, 256)
        Me.txtovertimeR.Name = "txtovertimeR"
        Me.txtovertimeR.Size = New System.Drawing.Size(192, 29)
        Me.txtovertimeR.TabIndex = 23
        Me.txtovertimeR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtrateR
        '
        Me.txtrateR.Enabled = False
        Me.txtrateR.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrateR.Location = New System.Drawing.Point(649, 217)
        Me.txtrateR.Name = "txtrateR"
        Me.txtrateR.Size = New System.Drawing.Size(192, 29)
        Me.txtrateR.TabIndex = 22
        Me.txtrateR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtworkhoursR
        '
        Me.txtworkhoursR.Enabled = False
        Me.txtworkhoursR.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtworkhoursR.Location = New System.Drawing.Point(649, 178)
        Me.txtworkhoursR.Name = "txtworkhoursR"
        Me.txtworkhoursR.Size = New System.Drawing.Size(192, 29)
        Me.txtworkhoursR.TabIndex = 21
        Me.txtworkhoursR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtdeptR
        '
        Me.txtdeptR.Enabled = False
        Me.txtdeptR.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdeptR.Location = New System.Drawing.Point(649, 137)
        Me.txtdeptR.Name = "txtdeptR"
        Me.txtdeptR.Size = New System.Drawing.Size(192, 29)
        Me.txtdeptR.TabIndex = 20
        '
        'txtnameR
        '
        Me.txtnameR.Enabled = False
        Me.txtnameR.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnameR.Location = New System.Drawing.Point(649, 98)
        Me.txtnameR.Name = "txtnameR"
        Me.txtnameR.Size = New System.Drawing.Size(192, 29)
        Me.txtnameR.TabIndex = 19
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(452, 259)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 22)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Overtime"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(452, 296)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(132, 22)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Overtime Rate"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(452, 181)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(147, 22)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Working Hour(s)"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(452, 220)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(121, 22)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Regular Rate"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(452, 140)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(109, 22)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Department"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(452, 101)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(60, 22)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "Name"
        '
        'txtNetpay
        '
        Me.txtNetpay.Enabled = False
        Me.txtNetpay.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNetpay.Location = New System.Drawing.Point(1073, 293)
        Me.txtNetpay.Name = "txtNetpay"
        Me.txtNetpay.Size = New System.Drawing.Size(192, 29)
        Me.txtNetpay.TabIndex = 36
        Me.txtNetpay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDeduc
        '
        Me.txtDeduc.Enabled = False
        Me.txtDeduc.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDeduc.Location = New System.Drawing.Point(1073, 256)
        Me.txtDeduc.Name = "txtDeduc"
        Me.txtDeduc.Size = New System.Drawing.Size(192, 29)
        Me.txtDeduc.TabIndex = 35
        Me.txtDeduc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtincometax
        '
        Me.txtincometax.Enabled = False
        Me.txtincometax.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtincometax.Location = New System.Drawing.Point(1073, 217)
        Me.txtincometax.Name = "txtincometax"
        Me.txtincometax.Size = New System.Drawing.Size(192, 29)
        Me.txtincometax.TabIndex = 34
        Me.txtincometax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPI
        '
        Me.txtPI.Enabled = False
        Me.txtPI.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPI.Location = New System.Drawing.Point(1073, 178)
        Me.txtPI.Name = "txtPI"
        Me.txtPI.Size = New System.Drawing.Size(192, 29)
        Me.txtPI.TabIndex = 33
        Me.txtPI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPH
        '
        Me.txtPH.Enabled = False
        Me.txtPH.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPH.Location = New System.Drawing.Point(1073, 137)
        Me.txtPH.Name = "txtPH"
        Me.txtPH.Size = New System.Drawing.Size(192, 29)
        Me.txtPH.TabIndex = 32
        Me.txtPH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSSS
        '
        Me.txtSSS.Enabled = False
        Me.txtSSS.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSSS.Location = New System.Drawing.Point(1073, 98)
        Me.txtSSS.Name = "txtSSS"
        Me.txtSSS.Size = New System.Drawing.Size(192, 29)
        Me.txtSSS.TabIndex = 31
        Me.txtSSS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(876, 263)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(141, 22)
        Me.Label14.TabIndex = 30
        Me.Label14.Text = "Total Deduction"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(876, 300)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(76, 22)
        Me.Label15.TabIndex = 29
        Me.Label15.Text = "Net Pay"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(876, 185)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(96, 22)
        Me.Label16.TabIndex = 28
        Me.Label16.Text = "PAG-IBIG"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(876, 224)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(108, 22)
        Me.Label17.TabIndex = 27
        Me.Label17.Text = "Income Tax"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(876, 144)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(94, 22)
        Me.Label18.TabIndex = 26
        Me.Label18.Text = "PhilHealth"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(876, 105)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(49, 22)
        Me.Label19.TabIndex = 25
        Me.Label19.Text = "SSS"
        '
        'Com
        '
        Me.Com.FlatAppearance.BorderSize = 4
        Me.Com.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Com.Font = New System.Drawing.Font("Arial Narrow", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Com.Location = New System.Drawing.Point(241, 371)
        Me.Com.Name = "Com"
        Me.Com.Size = New System.Drawing.Size(173, 67)
        Me.Com.TabIndex = 37
        Me.Com.Text = "COMPUTE"
        Me.Com.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderSize = 4
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Arial Narrow", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(29, 371)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(173, 67)
        Me.Button2.TabIndex = 38
        Me.Button2.Text = "CLEAR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtgross
        '
        Me.txtgross.Enabled = False
        Me.txtgross.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtgross.Location = New System.Drawing.Point(649, 335)
        Me.txtgross.Name = "txtgross"
        Me.txtgross.Size = New System.Drawing.Size(192, 29)
        Me.txtgross.TabIndex = 40
        Me.txtgross.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(452, 338)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(119, 22)
        Me.Label20.TabIndex = 39
        Me.Label20.Text = "Gross Salary"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1277, 457)
        Me.Controls.Add(Me.txtgross)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Com)
        Me.Controls.Add(Me.txtNetpay)
        Me.Controls.Add(Me.txtDeduc)
        Me.Controls.Add(Me.txtincometax)
        Me.Controls.Add(Me.txtPI)
        Me.Controls.Add(Me.txtPH)
        Me.Controls.Add(Me.txtSSS)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txtovertimerateR)
        Me.Controls.Add(Me.txtovertimeR)
        Me.Controls.Add(Me.txtrateR)
        Me.Controls.Add(Me.txtworkhoursR)
        Me.Controls.Add(Me.txtdeptR)
        Me.Controls.Add(Me.txtnameR)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtovertimerate)
        Me.Controls.Add(Me.txtovertime)
        Me.Controls.Add(Me.txtrate)
        Me.Controls.Add(Me.txtworkhours)
        Me.Controls.Add(Me.txtdept)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.Text = "Salary Computation System"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtname As TextBox
    Friend WithEvents txtdept As TextBox
    Friend WithEvents txtworkhours As TextBox
    Friend WithEvents txtovertimerate As TextBox
    Friend WithEvents txtovertime As TextBox
    Friend WithEvents txtrate As TextBox
    Friend WithEvents txtovertimerateR As TextBox
    Friend WithEvents txtovertimeR As TextBox
    Friend WithEvents txtrateR As TextBox
    Friend WithEvents txtworkhoursR As TextBox
    Friend WithEvents txtdeptR As TextBox
    Friend WithEvents txtnameR As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtNetpay As TextBox
    Friend WithEvents txtDeduc As TextBox
    Friend WithEvents txtincometax As TextBox
    Friend WithEvents txtPI As TextBox
    Friend WithEvents txtPH As TextBox
    Friend WithEvents txtSSS As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Com As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents txtgross As TextBox
    Friend WithEvents Label20 As Label
End Class
