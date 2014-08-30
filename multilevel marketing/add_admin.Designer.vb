<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class add_admin
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(add_admin))
        Me.LinkL1 = New System.Windows.Forms.LinkLabel
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lbl_post = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtbx_conpas = New System.Windows.Forms.TextBox
        Me.btn_cancel = New System.Windows.Forms.Button
        Me.btn_ok = New System.Windows.Forms.Button
        Me.lbl_password = New System.Windows.Forms.Label
        Me.txtbx_password = New System.Windows.Forms.TextBox
        Me.lbl_login_id = New System.Windows.Forms.Label
        Me.txtbx_login_id = New System.Windows.Forms.TextBox
        Me.lbl_name = New System.Windows.Forms.Label
        Me.txtbx_adname = New System.Windows.Forms.TextBox
        Me.LinkL2 = New System.Windows.Forms.LinkLabel
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LinkL1
        '
        Me.LinkL1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LinkL1.AutoSize = True
        Me.LinkL1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkL1.Location = New System.Drawing.Point(195, 171)
        Me.LinkL1.Name = "LinkL1"
        Me.LinkL1.Size = New System.Drawing.Size(213, 16)
        Me.LinkL1.TabIndex = 3
        Me.LinkL1.TabStop = True
        Me.LinkL1.Text = "Yes, I want to create  a new ADMIN"
        Me.ToolTip1.SetToolTip(Me.LinkL1, "Create a new admin")
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.lbl_post)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtbx_conpas)
        Me.GroupBox1.Controls.Add(Me.btn_cancel)
        Me.GroupBox1.Controls.Add(Me.btn_ok)
        Me.GroupBox1.Controls.Add(Me.lbl_password)
        Me.GroupBox1.Controls.Add(Me.txtbx_password)
        Me.GroupBox1.Controls.Add(Me.lbl_login_id)
        Me.GroupBox1.Controls.Add(Me.txtbx_login_id)
        Me.GroupBox1.Controls.Add(Me.lbl_name)
        Me.GroupBox1.Controls.Add(Me.txtbx_adname)
        Me.GroupBox1.Location = New System.Drawing.Point(62, 279)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(464, 271)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Log In Info"
        '
        'lbl_post
        '
        Me.lbl_post.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_post.AutoSize = True
        Me.lbl_post.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_post.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_post.Location = New System.Drawing.Point(257, 196)
        Me.lbl_post.Name = "lbl_post"
        Me.lbl_post.Size = New System.Drawing.Size(48, 18)
        Me.lbl_post.TabIndex = 24
        Me.lbl_post.Text = "Admin"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(27, 196)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 16)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Post:"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(27, 149)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 16)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Conform Password:"
        '
        'txtbx_conpas
        '
        Me.txtbx_conpas.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtbx_conpas.Location = New System.Drawing.Point(257, 145)
        Me.txtbx_conpas.Name = "txtbx_conpas"
        Me.txtbx_conpas.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtbx_conpas.Size = New System.Drawing.Size(159, 20)
        Me.txtbx_conpas.TabIndex = 20
        '
        'btn_cancel
        '
        Me.btn_cancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_cancel.Location = New System.Drawing.Point(228, 240)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(71, 25)
        Me.btn_cancel.TabIndex = 19
        Me.btn_cancel.Text = "&Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'btn_ok
        '
        Me.btn_ok.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_ok.Location = New System.Drawing.Point(123, 240)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(71, 25)
        Me.btn_ok.TabIndex = 18
        Me.btn_ok.Text = "&Add"
        Me.btn_ok.UseVisualStyleBackColor = True
        '
        'lbl_password
        '
        Me.lbl_password.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_password.AutoSize = True
        Me.lbl_password.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_password.ForeColor = System.Drawing.Color.Black
        Me.lbl_password.Location = New System.Drawing.Point(27, 109)
        Me.lbl_password.Name = "lbl_password"
        Me.lbl_password.Size = New System.Drawing.Size(71, 16)
        Me.lbl_password.TabIndex = 17
        Me.lbl_password.Text = "Password:"
        '
        'txtbx_password
        '
        Me.txtbx_password.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtbx_password.Location = New System.Drawing.Point(257, 105)
        Me.txtbx_password.Name = "txtbx_password"
        Me.txtbx_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtbx_password.Size = New System.Drawing.Size(159, 20)
        Me.txtbx_password.TabIndex = 16
        '
        'lbl_login_id
        '
        Me.lbl_login_id.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_login_id.AutoSize = True
        Me.lbl_login_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_login_id.ForeColor = System.Drawing.Color.Black
        Me.lbl_login_id.Location = New System.Drawing.Point(27, 67)
        Me.lbl_login_id.Name = "lbl_login_id"
        Me.lbl_login_id.Size = New System.Drawing.Size(60, 16)
        Me.lbl_login_id.TabIndex = 15
        Me.lbl_login_id.Text = "Login ID:"
        '
        'txtbx_login_id
        '
        Me.txtbx_login_id.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtbx_login_id.Location = New System.Drawing.Point(257, 63)
        Me.txtbx_login_id.Name = "txtbx_login_id"
        Me.txtbx_login_id.Size = New System.Drawing.Size(159, 20)
        Me.txtbx_login_id.TabIndex = 14
        '
        'lbl_name
        '
        Me.lbl_name.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_name.AutoSize = True
        Me.lbl_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_name.ForeColor = System.Drawing.Color.Black
        Me.lbl_name.Location = New System.Drawing.Point(27, 25)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(89, 16)
        Me.lbl_name.TabIndex = 13
        Me.lbl_name.Text = "Admin Name:"
        '
        'txtbx_adname
        '
        Me.txtbx_adname.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtbx_adname.Location = New System.Drawing.Point(257, 24)
        Me.txtbx_adname.Name = "txtbx_adname"
        Me.txtbx_adname.Size = New System.Drawing.Size(159, 20)
        Me.txtbx_adname.TabIndex = 12
        '
        'LinkL2
        '
        Me.LinkL2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LinkL2.AutoSize = True
        Me.LinkL2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkL2.Location = New System.Drawing.Point(195, 220)
        Me.LinkL2.Name = "LinkL2"
        Me.LinkL2.Size = New System.Drawing.Size(239, 16)
        Me.LinkL2.TabIndex = 5
        Me.LinkL2.TabStop = True
        Me.LinkL2.Text = "No, I don't want to create  a new ADMIN"
        Me.ToolTip1.SetToolTip(Me.LinkL2, "Cancel to create a new admin")
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.BackgroundImage = Global.multilevel_marketing.My.Resources.Resources.images_043
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(-2, -1)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(634, 120)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Image = Global.multilevel_marketing.My.Resources.Resources.dgs
        Me.PictureBox1.Location = New System.Drawing.Point(23, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(170, 111)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Elephant", 54.74999!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(194, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(286, 94)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "MLM"
        '
        'add_admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(634, 576)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.LinkL2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LinkL1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "add_admin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "add_admin"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LinkL1 As System.Windows.Forms.LinkLabel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents btn_ok As System.Windows.Forms.Button
    Friend WithEvents lbl_password As System.Windows.Forms.Label
    Friend WithEvents txtbx_password As System.Windows.Forms.TextBox
    Friend WithEvents lbl_login_id As System.Windows.Forms.Label
    Friend WithEvents txtbx_login_id As System.Windows.Forms.TextBox
    Friend WithEvents lbl_name As System.Windows.Forms.Label
    Friend WithEvents txtbx_adname As System.Windows.Forms.TextBox
    Friend WithEvents LinkL2 As System.Windows.Forms.LinkLabel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtbx_conpas As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_post As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
