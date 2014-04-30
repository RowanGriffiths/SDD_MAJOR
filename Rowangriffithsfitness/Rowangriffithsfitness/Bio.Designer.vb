<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bio
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OnlineTrainingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LearnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TeamRPFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PhotosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VideosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MembersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.BioToolStripMenuItem, Me.OnlineTrainingToolStripMenuItem, Me.LearnToolStripMenuItem, Me.TeamRPFToolStripMenuItem, Me.PhotosToolStripMenuItem, Me.VideosToolStripMenuItem, Me.ContactToolStripMenuItem, Me.MembersToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1664, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.HomeToolStripMenuItem.Text = "Home"
        '
        'BioToolStripMenuItem
        '
        Me.BioToolStripMenuItem.Name = "BioToolStripMenuItem"
        Me.BioToolStripMenuItem.Size = New System.Drawing.Size(38, 20)
        Me.BioToolStripMenuItem.Text = "Bio"
        '
        'OnlineTrainingToolStripMenuItem
        '
        Me.OnlineTrainingToolStripMenuItem.Name = "OnlineTrainingToolStripMenuItem"
        Me.OnlineTrainingToolStripMenuItem.Size = New System.Drawing.Size(107, 20)
        Me.OnlineTrainingToolStripMenuItem.Text = "Online Training"
        '
        'LearnToolStripMenuItem
        '
        Me.LearnToolStripMenuItem.Name = "LearnToolStripMenuItem"
        Me.LearnToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.LearnToolStripMenuItem.Text = "Learn"
        '
        'TeamRPFToolStripMenuItem
        '
        Me.TeamRPFToolStripMenuItem.Name = "TeamRPFToolStripMenuItem"
        Me.TeamRPFToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.TeamRPFToolStripMenuItem.Text = "Team RPF"
        '
        'PhotosToolStripMenuItem
        '
        Me.PhotosToolStripMenuItem.Name = "PhotosToolStripMenuItem"
        Me.PhotosToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.PhotosToolStripMenuItem.Text = "Photos"
        '
        'VideosToolStripMenuItem
        '
        Me.VideosToolStripMenuItem.Name = "VideosToolStripMenuItem"
        Me.VideosToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.VideosToolStripMenuItem.Text = "Videos"
        '
        'ContactToolStripMenuItem
        '
        Me.ContactToolStripMenuItem.Name = "ContactToolStripMenuItem"
        Me.ContactToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.ContactToolStripMenuItem.Text = "Contact"
        '
        'MembersToolStripMenuItem
        '
        Me.MembersToolStripMenuItem.Name = "MembersToolStripMenuItem"
        Me.MembersToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.MembersToolStripMenuItem.Text = "Members"
        '
        'Bio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1664, 862)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Bio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bio"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents HomeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OnlineTrainingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LearnToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TeamRPFToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PhotosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VideosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContactToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MembersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
