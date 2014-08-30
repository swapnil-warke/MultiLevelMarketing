<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class update_admin
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.lbl_info = New System.Windows.Forms.Label
        Me.txt_id = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.lbl_update = New System.Windows.Forms.LinkLabel
        Me.btn_update = New System.Windows.Forms.Button
        Me.btn_clear = New System.Windows.Forms.Button
        Me.btn_search = New System.Windows.Forms.Button
        Me.btn_cancel = New System.Windows.Forms.Button
        Me.gb = New System.Windows.Forms.GroupBox
        Me.lbl_post = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lbl_conpas = New System.Windows.Forms.Label
        Me.txtbx_conpas = New System.Windows.Forms.TextBox
        Me.lbl_password = New System.Windows.Forms.Label
        Me.txtbx_password = New System.Windows.Forms.TextBox
        Me.lbl_name = New System.Windows.Forms.Label
        Me.txtbx_adname = New System.Windows.Forms.TextBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.gb.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.lbl_info)
        Me.GroupBox3.Controls.Add(Me.txt_id)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Location = New System.Drawing.Point(62, 131)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(464, 111)
        Me.GroupBox3.TabIndex = 24
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Search"
        '
        'lbl_info
        '
        Me.lbl_info.AutoSize = True
        Me.lbl_info.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_info.Location = New System.Drawing.Point(117, 49)
        Me.lbl_info.Name = "lbl_info"
        Me.lbl_info.Size = New System.Drawing.Size(230, 13)
        Me.lbl_info.TabIndex = 24
        Me.lbl_info.Text = "(Enter ID and press OK to see Your information)"
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(175, 22)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(110, 20)
        Me.txt_id.TabIndex = 22
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(35, 22)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 16)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "LogIN ID:"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackgroundImage = Global.multilevel_marketing.My.Resources.Resources.images_043
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(-4, -1)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(606, 120)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Elephant", 54.74999!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(199, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(286, 94)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "MLM"
        '
        'lbl_update
        '
        Me.lbl_update.AutoSize = True
        Me.lbl_update.Location = New System.Drawing.Point(234, 475)
        Me.lbl_update.Name = "lbl_update"
        Me.lbl_update.Size = New System.Drawing.Size(121, 13)
        Me.lbl_update.TabIndex = 39
        Me.lbl_update.TabStop = True
        Me.lbl_update.Text = "Do you want to update?"
        '
        'btn_update
        '
        Me.btn_update.Location = New System.Drawing.Point(428, 514)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(75, 23)
        Me.btn_update.TabIndex = 38
        Me.btn_update.Text = "&Update"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'btn_clear
        '
        Me.btn_clear.Location = New System.Drawing.Point(316, 514)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(75, 23)
        Me.btn_clear.TabIndex = 37
        Me.btn_clear.Text = "&More"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'btn_search
        '
        Me.btn_search.Location = New System.Drawing.Point(85, 514)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(75, 23)
        Me.btn_search.TabIndex = 35
        Me.btn_search.Text = "&Search"
        Me.btn_search.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(199, 514)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancel.TabIndex = 36
        Me.btn_cancel.Text = "&Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'gb
        '
        Me.gb.BackColor = System.Drawing.Color.Transparent
        Me.gb.Controls.Add(Me.lbl_post)
        Me.gb.Controls.Add(Me.Label4)
        Me.gb.Controls.Add(Me.lbl_conpas)
        Me.gb.Controls.Add(Me.txtbx_conpas)
        Me.gb.Controls.Add(Me.lbl_password)
        Me.gb.Controls.Add(Me.txtbx_password)
        Me.gb.Controls.Add(Me.lbl_name)
        Me.gb.Controls.Add(Me.txtbx_adname)
        Me.gb.Location = New System.Drawing.Point(62, 269)
        Me.gb.Name = "gb"
        Me.gb.Size = New System.Drawing.Size(464, 188)
        Me.gb.TabIndex = 40
        Me.gb.TabStop = False
        Me.gb.Text = "Information"
        '
        'lbl_post
        '
        Me.lbl_post.AutoSize = True
        Me.lbl_post.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_post.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_post.Location = New System.Drawing.Point(268, 60)
        Me.lbl_post.Name = "lbl_post"
        Me.lbl_post.Size = New System.Drawing.Size(48, 18)
        Me.lbl_post.TabIndex = 34
        Me.lbl_post.Text = "Admin"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(38, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 16)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Post:"
        '
        'lbl_conpas
        '
        Me.lbl_conpas.AutoSize = True
        Me.lbl_conpas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_conpas.ForeColor = System.Drawing.Color.Black
        Me.lbl_conpas.Location = New System.Drawing.Point(38, 142)
        Me.lbl_conpas.Name = "lbl_conpas"
        Me.lbl_conpas.Size = New System.Drawing.Size(124, 16)
        Me.lbl_conpas.TabIndex = 32
        Me.lbl_conpas.Text = "Conform Password:"
        '
        'txtbx_conpas
        '
        Me.txtbx_conpas.Location = New System.Drawing.Point(268, 138)
        Me.txtbx_conpas.Name = "txtbx_conpas"
        Me.txtbx_conpas.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtbx_conpas.ReadOnly = True
        Me.txtbx_conpas.Size = New System.Drawing.Size(159, 20)
        Me.txtbx_conpas.TabIndex = 31
        '
        'lbl_password
        '
        Me.lbl_password.AutoSize = True
        Me.lbl_password.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_password.ForeColor = System.Drawing.Color.Black
        Me.lbl_password.Location = New System.Drawing.Point(38, 102)
        Me.lbl_password.Name = "lbl_password"
        Me.lbl_password.Size = New System.Drawing.Size(71, 16)
        Me.lbl_password.TabIndex = 30
        Me.lbl_password.Text = "Password:"
        '
        'txtbx_password
        '
        Me.txtbx_password.Location = New System.Drawing.Point(268, 98)
        Me.txtbx_password.Name = "txtbx_password"
        Me.txtbx_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtbx_password.ReadOnly = True
        Me.txtbx_password.Size = New System.Drawing.Size(159, 20)
        Me.txtbx_password.TabIndex = 29
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_name.ForeColor = System.Drawing.Color.Black
        Me.lbl_name.Location = New System.Drawing.Point(38, 18)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(89, 16)
        Me.lbl_name.TabIndex = 26
        Me.lbl_name.Text = "Admin Name:"
        '
        'txtbx_adname
        '
        Me.txtbx_adname.Location = New System.Drawing.Point(268, 17)
        Me.txtbx_adname.Name = "txtbx_adname"
        Me.txtbx_adname.ReadOnly = True
        Me.txtbx_adname.Size = New System.Drawing.Size(159, 20)
        Me.txtbx_adname.TabIndex = 25
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.multilevel_marketing.My.Resources.Resources.dgs
        Me.PictureBox1.Location = New System.Drawing.Point(25, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(175, 115)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'update_admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.multilevel_marketing.My.Resources.Resources.gray02
        Me.ClientSize = New System.Drawing.Size(600, 574)
        Me.Controls.Add(Me.gb)
        Me.Controls.Add(Me.lbl_update)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.btn_search)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "update_admin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update admin"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.gb.ResumeLayout(False)
        Me.gb.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_id As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbl_update As System.Windows.Forms.LinkLabel
    Friend WithEvents btn_update As System.Windows.Forms.Button
    Friend WithEvents btn_clear As System.Windows.Forms.Button
    Friend WithEvents btn_search As System.Windows.Forms.Button
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents gb As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_conpas As System.Windows.Forms.Label
    Friend WithEvents txtbx_conpas As System.Windows.Forms.TextBox
    Friend WithEvents lbl_password As System.Windows.Forms.Label
    Friend WithEvents txtbx_password As System.Windows.Forms.TextBox
    Friend WithEvents lbl_name As System.Windows.Forms.Label
    Friend WithEvents txtbx_adname As System.Windows.Forms.TextBox
    Friend WithEvents lbl_post As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbl_info As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
