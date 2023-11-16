<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmuserpassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmuserpassword))
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.linkback = New System.Windows.Forms.LinkLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblusername = New System.Windows.Forms.Label()
        Me.btnok = New System.Windows.Forms.Button()
        Me.lblrole = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.PicBox = New Guna.UI.WinForms.GunaCirclePictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel2.Location = New System.Drawing.Point(234, 135)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(101, 16)
        Me.LinkLabel2.TabIndex = 17
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Forgot Password?"
        '
        'linkback
        '
        Me.linkback.AutoSize = True
        Me.linkback.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkback.Location = New System.Drawing.Point(186, 195)
        Me.linkback.Name = "linkback"
        Me.linkback.Size = New System.Drawing.Size(75, 16)
        Me.linkback.TabIndex = 15
        Me.linkback.TabStop = True
        Me.linkback.Text = "Change User"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(111, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 16)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Password"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Label4.Location = New System.Drawing.Point(71, 203)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(297, 3)
        Me.Label4.TabIndex = 16
        '
        'lblusername
        '
        Me.lblusername.AutoSize = True
        Me.lblusername.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblusername.Location = New System.Drawing.Point(165, 42)
        Me.lblusername.Name = "lblusername"
        Me.lblusername.Size = New System.Drawing.Size(69, 16)
        Me.lblusername.TabIndex = 10
        Me.lblusername.Text = "Username"
        '
        'btnok
        '
        Me.btnok.Location = New System.Drawing.Point(108, 163)
        Me.btnok.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnok.Name = "btnok"
        Me.btnok.Size = New System.Drawing.Size(230, 28)
        Me.btnok.TabIndex = 9
        Me.btnok.TabStop = False
        Me.btnok.Text = "Continue"
        Me.btnok.UseVisualStyleBackColor = True
        '
        'lblrole
        '
        Me.lblrole.AutoSize = True
        Me.lblrole.Location = New System.Drawing.Point(165, 58)
        Me.lblrole.Name = "lblrole"
        Me.lblrole.Size = New System.Drawing.Size(51, 16)
        Me.lblrole.TabIndex = 18
        Me.lblrole.Text = "Position"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(313, 109)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(22, 20)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 19
        Me.PictureBox2.TabStop = False
        '
        'txtpass
        '
        Me.txtpass.Location = New System.Drawing.Point(108, 108)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.Size = New System.Drawing.Size(230, 23)
        Me.txtpass.TabIndex = 20
        '
        'PicBox
        '
        Me.PicBox.BaseColor = System.Drawing.Color.White
        Me.PicBox.Image = CType(resources.GetObject("PicBox.Image"), System.Drawing.Image)
        Me.PicBox.Location = New System.Drawing.Point(111, 31)
        Me.PicBox.Name = "PicBox"
        Me.PicBox.Size = New System.Drawing.Size(51, 50)
        Me.PicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBox.TabIndex = 21
        Me.PicBox.TabStop = False
        Me.PicBox.UseTransfarantBackground = False
        '
        'frmuserpassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(438, 235)
        Me.Controls.Add(Me.PicBox)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.txtpass)
        Me.Controls.Add(Me.lblrole)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.linkback)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblusername)
        Me.Controls.Add(Me.btnok)
        Me.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmuserpassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents linkback As LinkLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblusername As Label
    Friend WithEvents btnok As Button
    Friend WithEvents lblrole As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txtpass As TextBox
    Friend WithEvents PicBox As Guna.UI.WinForms.GunaCirclePictureBox
End Class
