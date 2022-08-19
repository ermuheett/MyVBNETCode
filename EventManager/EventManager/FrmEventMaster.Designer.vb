<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEventMaster
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
        Me.butnOK = New System.Windows.Forms.Button()
        Me.ButnCancel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtEventName = New System.Windows.Forms.TextBox()
        Me.lblEventID = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtEventAddress = New System.Windows.Forms.TextBox()
        Me.TxtStartDate = New System.Windows.Forms.TextBox()
        Me.TxtEndDate = New System.Windows.Forms.TextBox()
        Me.TxtContactPerson = New System.Windows.Forms.TextBox()
        Me.TxtMobileNo = New System.Windows.Forms.TextBox()
        Me.TxtEmailID = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CboDays = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'butnOK
        '
        Me.butnOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butnOK.Location = New System.Drawing.Point(803, 620)
        Me.butnOK.Name = "butnOK"
        Me.butnOK.Size = New System.Drawing.Size(131, 46)
        Me.butnOK.TabIndex = 9
        Me.butnOK.Text = "OK"
        Me.butnOK.UseVisualStyleBackColor = True
        '
        'ButnCancel
        '
        Me.ButnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButnCancel.Location = New System.Drawing.Point(666, 620)
        Me.ButnCancel.Name = "ButnCancel"
        Me.ButnCancel.Size = New System.Drawing.Size(131, 46)
        Me.ButnCancel.TabIndex = 10
        Me.ButnCancel.Text = "Cancel"
        Me.ButnCancel.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(201, 37)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Event ID"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(40, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(201, 37)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Event Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(40, 310)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(201, 37)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Start Date"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(40, 367)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(201, 37)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "End Date"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(40, 428)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(201, 37)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Contact Person"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(40, 487)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(201, 37)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Mobile Number"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(40, 543)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(201, 37)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Email ID"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtEventName
        '
        Me.TxtEventName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEventName.Location = New System.Drawing.Point(307, 106)
        Me.TxtEventName.Name = "TxtEventName"
        Me.TxtEventName.Size = New System.Drawing.Size(571, 30)
        Me.TxtEventName.TabIndex = 1
        '
        'lblEventID
        '
        Me.lblEventID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEventID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEventID.Location = New System.Drawing.Point(307, 44)
        Me.lblEventID.Name = "lblEventID"
        Me.lblEventID.Size = New System.Drawing.Size(253, 37)
        Me.lblEventID.TabIndex = 10
        Me.lblEventID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(40, 160)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(201, 37)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Address of Event"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtEventAddress
        '
        Me.TxtEventAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEventAddress.Location = New System.Drawing.Point(307, 160)
        Me.TxtEventAddress.Multiline = True
        Me.TxtEventAddress.Name = "TxtEventAddress"
        Me.TxtEventAddress.Size = New System.Drawing.Size(571, 136)
        Me.TxtEventAddress.TabIndex = 2
        '
        'TxtStartDate
        '
        Me.TxtStartDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtStartDate.Location = New System.Drawing.Point(307, 317)
        Me.TxtStartDate.Name = "TxtStartDate"
        Me.TxtStartDate.Size = New System.Drawing.Size(293, 30)
        Me.TxtStartDate.TabIndex = 3
        '
        'TxtEndDate
        '
        Me.TxtEndDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEndDate.Location = New System.Drawing.Point(307, 367)
        Me.TxtEndDate.Name = "TxtEndDate"
        Me.TxtEndDate.Size = New System.Drawing.Size(293, 30)
        Me.TxtEndDate.TabIndex = 4
        '
        'TxtContactPerson
        '
        Me.TxtContactPerson.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtContactPerson.Location = New System.Drawing.Point(307, 429)
        Me.TxtContactPerson.Name = "TxtContactPerson"
        Me.TxtContactPerson.Size = New System.Drawing.Size(455, 30)
        Me.TxtContactPerson.TabIndex = 6
        '
        'TxtMobileNo
        '
        Me.TxtMobileNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMobileNo.Location = New System.Drawing.Point(307, 494)
        Me.TxtMobileNo.Name = "TxtMobileNo"
        Me.TxtMobileNo.Size = New System.Drawing.Size(331, 30)
        Me.TxtMobileNo.TabIndex = 7
        '
        'TxtEmailID
        '
        Me.TxtEmailID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEmailID.Location = New System.Drawing.Point(307, 543)
        Me.TxtEmailID.Name = "TxtEmailID"
        Me.TxtEmailID.Size = New System.Drawing.Size(455, 30)
        Me.TxtEmailID.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(616, 360)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(146, 37)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Total Days"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CboDays
        '
        Me.CboDays.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboDays.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboDays.FormattingEnabled = True
        Me.CboDays.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"})
        Me.CboDays.Location = New System.Drawing.Point(768, 364)
        Me.CboDays.Name = "CboDays"
        Me.CboDays.Size = New System.Drawing.Size(148, 33)
        Me.CboDays.TabIndex = 5
        '
        'FrmEventMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(946, 688)
        Me.Controls.Add(Me.CboDays)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtEmailID)
        Me.Controls.Add(Me.TxtMobileNo)
        Me.Controls.Add(Me.TxtContactPerson)
        Me.Controls.Add(Me.TxtEndDate)
        Me.Controls.Add(Me.TxtStartDate)
        Me.Controls.Add(Me.TxtEventAddress)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblEventID)
        Me.Controls.Add(Me.TxtEventName)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButnCancel)
        Me.Controls.Add(Me.butnOK)
        Me.Name = "FrmEventMaster"
        Me.Text = "Enter New Event"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents butnOK As Button
    Friend WithEvents ButnCancel As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtEventName As TextBox
    Friend WithEvents lblEventID As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtEventAddress As TextBox
    Friend WithEvents TxtStartDate As TextBox
    Friend WithEvents TxtEndDate As TextBox
    Friend WithEvents TxtContactPerson As TextBox
    Friend WithEvents TxtMobileNo As TextBox
    Friend WithEvents TxtEmailID As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents CboDays As ComboBox
End Class
