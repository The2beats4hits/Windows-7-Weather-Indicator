<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Notify = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.OptionsMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ExitMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WeatherLabel = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.OptionsMenu.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Notify
        '
        Me.Notify.ContextMenuStrip = Me.OptionsMenu
        Me.Notify.Icon = CType(resources.GetObject("Notify.Icon"), System.Drawing.Icon)
        Me.Notify.Text = "Weather Indicator"
        Me.Notify.Visible = True
        '
        'OptionsMenu
        '
        Me.OptionsMenu.BackColor = System.Drawing.SystemColors.MenuBar
        Me.OptionsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitMenuItem})
        Me.OptionsMenu.Name = "ContextMenuStrip1"
        Me.OptionsMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.OptionsMenu.Size = New System.Drawing.Size(133, 26)
        '
        'ExitMenuItem
        '
        Me.ExitMenuItem.BackColor = System.Drawing.SystemColors.MenuBar
        Me.ExitMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ExitMenuItem.DoubleClickEnabled = True
        Me.ExitMenuItem.ImageTransparentColor = System.Drawing.SystemColors.MenuHighlight
        Me.ExitMenuItem.MergeIndex = 10
        Me.ExitMenuItem.Name = "ExitMenuItem"
        Me.ExitMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.ExitMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.ExitMenuItem.Text = "&Exit"
        Me.ExitMenuItem.ToolTipText = "Выход"
        '
        'WeatherLabel
        '
        Me.WeatherLabel.AutoSize = True
        Me.WeatherLabel.BackColor = System.Drawing.SystemColors.Window
        Me.WeatherLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.WeatherLabel.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WeatherLabel.ForeColor = System.Drawing.Color.RoyalBlue
        Me.WeatherLabel.Location = New System.Drawing.Point(12, 9)
        Me.WeatherLabel.Name = "WeatherLabel"
        Me.WeatherLabel.Size = New System.Drawing.Size(84, 25)
        Me.WeatherLabel.TabIndex = 1
        Me.WeatherLabel.Text = "Weather"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(144, 244)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Me.ClientSize = New System.Drawing.Size(144, 244)
        Me.ControlBox = False
        Me.Controls.Add(Me.WeatherLabel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Enabled = False
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(160, 260)
        Me.MinimumSize = New System.Drawing.Size(160, 260)
        Me.Name = "Form1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.OptionsMenu.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Notify As NotifyIcon
    Friend WithEvents OptionsMenu As ContextMenuStrip
    Friend WithEvents ExitMenuItem As ToolStripMenuItem
    Friend WithEvents WeatherLabel As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
