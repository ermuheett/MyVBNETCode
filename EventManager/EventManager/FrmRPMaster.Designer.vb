<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRPMaster
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
        Me.LblRPID = New System.Windows.Forms.Label()
        Me.TxtRPName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtRPSpecialization = New System.Windows.Forms.TextBox()
        Me.TxtAddress = New System.Windows.Forms.TextBox()
        Me.TxtRPDesig = New System.Windows.Forms.TextBox()
        Me.TxtMobile = New System.Windows.Forms.TextBox()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.ButnCancel = New System.Windows.Forms.Button()
        Me.butnOK = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblRPID
        '
        Me.LblRPID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblRPID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRPID.Location = New System.Drawing.Point(298, 34)
        Me.LblRPID.Name = "LblRPID"
        Me.LblRPID.Size = New System.Drawing.Size(261, 37)
        Me.LblRPID.TabIndex = 13
        Me.LblRPID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtRPName
        '
        Me.TxtRPName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRPName.Location = New System.Drawing.Point(298, 96)
        Me.TxtRPName.Name = "TxtRPName"
        Me.TxtRPName.Size = New System.Drawing.Size(572, 30)
        Me.TxtRPName.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(223, 37)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Resource Person ID"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(31, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(242, 37)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Resource Person Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(31, 220)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(201, 37)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Designation"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(31, 289)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(201, 37)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Address"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(31, 419)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(201, 37)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Mobile"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(31, 483)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(201, 37)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Email"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(31, 151)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(201, 37)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Specialization"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtRPSpecialization
        '
        Me.TxtRPSpecialization.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRPSpecialization.Location = New System.Drawing.Point(298, 151)
        Me.TxtRPSpecialization.Name = "TxtRPSpecialization"
        Me.TxtRPSpecialization.Size = New System.Drawing.Size(428, 30)
        Me.TxtRPSpecialization.TabIndex = 20
        '
        'TxtAddress
        '
        Me.TxtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAddress.Location = New System.Drawing.Point(298, 289)
        Me.TxtAddress.Multiline = True
        Me.TxtAddress.Name = "TxtAddress"
        Me.TxtAddress.Size = New System.Drawing.Size(528, 106)
        Me.TxtAddress.TabIndex = 21
        '
        'TxtRPDesig
        '
        Me.TxtRPDesig.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRPDesig.Location = New System.Drawing.Point(298, 220)
        Me.TxtRPDesig.Name = "TxtRPDesig"
        Me.TxtRPDesig.Size = New System.Drawing.Size(428, 30)
        Me.TxtRPDesig.TabIndex = 22
        '
        'TxtMobile
        '
        Me.TxtMobile.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMobile.Location = New System.Drawing.Point(298, 419)
        Me.TxtMobile.Name = "TxtMobile"
        Me.TxtMobile.Size = New System.Drawing.Size(261, 30)
        Me.TxtMobile.TabIndex = 23
        '
        'TxtEmail
        '
        Me.TxtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEmail.Location = New System.Drawing.Point(298, 483)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(261, 30)
        Me.TxtEmail.TabIndex = 24
        '
        'ButnCancel
        '
        Me.ButnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButnCancel.Location = New System.Drawing.Point(678, 550)
        Me.ButnCancel.Name = "ButnCancel"
        Me.ButnCancel.Size = New System.Drawing.Size(131, 46)
        Me.ButnCancel.TabIndex = 26
        Me.ButnCancel.Text = "Cancel"
        Me.ButnCancel.UseVisualStyleBackColor = True
        '
        'butnOK
        '
        Me.butnOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butnOK.Location = New System.Drawing.Point(815, 550)
        Me.butnOK.Name = "butnOK"
        Me.butnOK.Size = New System.Drawing.Size(131, 46)
        Me.butnOK.TabIndex = 25
        Me.butnOK.Text = "OK"
        Me.butnOK.UseVisualStyleBackColor = True
        '
        'FrmRPMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(958, 620)
        Me.Controls.Add(Me.ButnCancel)
        Me.Controls.Add(Me.butnOK)
        Me.Controls.Add(Me.TxtEmail)
        Me.Controls.Add(Me.TxtMobile)
        Me.Controls.Add(Me.TxtRPDesig)
        Me.Controls.Add(Me.TxtAddress)
        Me.Controls.Add(Me.TxtRPSpecialization)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LblRPID)
        Me.Controls.Add(Me.TxtRPName)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmRPMaster"
        Me.Text = "Add New Resource Person"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblRPID As Label
    Friend WithEvents TxtRPName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtRPSpecialization As TextBox
    Friend WithEvents TxtAddress As TextBox
    Friend WithEvents TxtRPDesig As TextBox
    Friend WithEvents TxtMobile As TextBox
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents ButnCancel As Button
    Friend WithEvents butnOK As Button
End Class
