<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmHome
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
        Me.MnuEM = New System.Windows.Forms.MenuStrip()
        Me.EventMangerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EventToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResourcePersonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.UpdateToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProgrameScheduleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateProgrammeSheduleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuEM.SuspendLayout()
        Me.SuspendLayout()
        '
        'MnuEM
        '
        Me.MnuEM.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MnuEM.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MnuEM.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EventMangerToolStripMenuItem, Me.EventToolStripMenuItem, Me.ResourcePersonToolStripMenuItem, Me.ProgrameScheduleToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MnuEM.Location = New System.Drawing.Point(0, 0)
        Me.MnuEM.Name = "MnuEM"
        Me.MnuEM.Size = New System.Drawing.Size(1133, 36)
        Me.MnuEM.TabIndex = 0
        Me.MnuEM.Text = "MenuStrip1"
        '
        'EventMangerToolStripMenuItem
        '
        Me.EventMangerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.EventMangerToolStripMenuItem.Name = "EventMangerToolStripMenuItem"
        Me.EventMangerToolStripMenuItem.Size = New System.Drawing.Size(156, 32)
        Me.EventMangerToolStripMenuItem.Text = "Event Manger"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(126, 32)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'EventToolStripMenuItem
        '
        Me.EventToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.ToolStripMenuItem1, Me.UpdateToolStripMenuItem})
        Me.EventToolStripMenuItem.Name = "EventToolStripMenuItem"
        Me.EventToolStripMenuItem.Size = New System.Drawing.Size(77, 32)
        Me.EventToolStripMenuItem.Text = "Event"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(181, 32)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(178, 6)
        '
        'UpdateToolStripMenuItem
        '
        Me.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
        Me.UpdateToolStripMenuItem.Size = New System.Drawing.Size(181, 32)
        Me.UpdateToolStripMenuItem.Text = "Modify"
        '
        'ResourcePersonToolStripMenuItem
        '
        Me.ResourcePersonToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem1, Me.ToolStripMenuItem2, Me.UpdateToolStripMenuItem1})
        Me.ResourcePersonToolStripMenuItem.Name = "ResourcePersonToolStripMenuItem"
        Me.ResourcePersonToolStripMenuItem.Size = New System.Drawing.Size(179, 32)
        Me.ResourcePersonToolStripMenuItem.Text = "Resource Person"
        '
        'NewToolStripMenuItem1
        '
        Me.NewToolStripMenuItem1.Name = "NewToolStripMenuItem1"
        Me.NewToolStripMenuItem1.Size = New System.Drawing.Size(181, 32)
        Me.NewToolStripMenuItem1.Text = "New"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(178, 6)
        '
        'UpdateToolStripMenuItem1
        '
        Me.UpdateToolStripMenuItem1.Name = "UpdateToolStripMenuItem1"
        Me.UpdateToolStripMenuItem1.Size = New System.Drawing.Size(181, 32)
        Me.UpdateToolStripMenuItem1.Text = "Modify"
        '
        'ProgrameScheduleToolStripMenuItem
        '
        Me.ProgrameScheduleToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem3, Me.UpdateProgrammeSheduleToolStripMenuItem})
        Me.ProgrameScheduleToolStripMenuItem.Name = "ProgrameScheduleToolStripMenuItem"
        Me.ProgrameScheduleToolStripMenuItem.Size = New System.Drawing.Size(207, 32)
        Me.ProgrameScheduleToolStripMenuItem.Text = "Programe Schedule"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(352, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem1})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(68, 32)
        Me.AboutToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem1
        '
        Me.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(148, 32)
        Me.AboutToolStripMenuItem1.Text = "About"
        '
        'UpdateProgrammeSheduleToolStripMenuItem
        '
        Me.UpdateProgrammeSheduleToolStripMenuItem.Name = "UpdateProgrammeSheduleToolStripMenuItem"
        Me.UpdateProgrammeSheduleToolStripMenuItem.Size = New System.Drawing.Size(355, 32)
        Me.UpdateProgrammeSheduleToolStripMenuItem.Text = "Update Programme Shedule"
        '
        'FrmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.EventManager.My.Resources.Resources.Event_Management_Solution
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1133, 594)
        Me.Controls.Add(Me.MnuEM)
        Me.MainMenuStrip = Me.MnuEM
        Me.Name = "FrmHome"
        Me.Text = "Event Manager"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MnuEM.ResumeLayout(False)
        Me.MnuEM.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MnuEM As MenuStrip
    Friend WithEvents EventMangerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EventToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents UpdateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResourcePersonToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents UpdateToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ProgrameScheduleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents UpdateProgrammeSheduleToolStripMenuItem As ToolStripMenuItem
End Class
