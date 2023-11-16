<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmusername
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmusername))
        Me.btnok = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtuser = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblsignup = New System.Windows.Forms.LinkLabel()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnok
        '
        Me.btnok.Location = New System.Drawing.Point(100, 161)
        Me.btnok.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnok.Name = "btnok"
        Me.btnok.Size = New System.Drawing.Size(230, 28)
        Me.btnok.TabIndex = 0
        Me.btnok.Text = "Continue"
        Me.btnok.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(97, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Login Manager"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(103, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Username"
        '
        'txtuser
        '
        Me.txtuser.BackColor = System.Drawing.SystemColors.Window
        Me.txtuser.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtuser.Location = New System.Drawing.Point(100, 106)
        Me.txtuser.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtuser.Name = "txtuser"
        Me.txtuser.Size = New System.Drawing.Size(230, 23)
        Me.txtuser.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(301, 107)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(25, 20)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(127, 202)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Don't have an account?"
        '
        'lblsignup
        '
        Me.lblsignup.AutoSize = True
        Me.lblsignup.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lblsignup.Location = New System.Drawing.Point(257, 202)
        Me.lblsignup.Name = "lblsignup"
        Me.lblsignup.Size = New System.Drawing.Size(45, 16)
        Me.lblsignup.TabIndex = 6
        Me.lblsignup.TabStop = True
        Me.lblsignup.Text = "Signup"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Label4.Location = New System.Drawing.Point(65, 209)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(297, 3)
        Me.Label4.TabIndex = 7
        '
        'frmusername
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Menu
        Me.ClientSize = New System.Drawing.Size(438, 235)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblsignup)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtuser)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnok)
        Me.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmusername"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnok As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtuser As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblsignup As LinkLabel
    Friend WithEvents Label4 As Label
End Class
