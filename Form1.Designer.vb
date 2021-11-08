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
        Me.components = New System.ComponentModel.Container()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Image = Global.LockScreen.My.Resources.Resources.Graphicloads_100_Flat_2_Arrow_next_3
        Me.Button1.Location = New System.Drawing.Point(748, 434)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(38, 39)
        Me.Button1.TabIndex = 14
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.UseWaitCursor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(608, 444)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(134, 20)
        Me.TextBox1.TabIndex = 12
        Me.TextBox1.UseSystemPasswordChar = True
        Me.TextBox1.UseWaitCursor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Chocolate
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label2.Font = New System.Drawing.Font("Hobo Std", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(503, 442)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 27)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Password"
        Me.Label2.UseWaitCursor = True
        '
        'Label1
        '
        Me.Label1.Image = Global.LockScreen.My.Resources.Resources._049949_black_paint_splatter_icon_natural_wonders_star8_sc48
        Me.Label1.Location = New System.Drawing.Point(505, 157)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(284, 266)
        Me.Label1.TabIndex = 15
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.LockScreen.My.Resources.Resources.angel_wings_fire
        Me.ClientSize = New System.Drawing.Size(1364, 729)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1920, 1080)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1364, 726)
        Me.Name = "Form1"
        Me.Opacity = 0.8R
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
End Class
