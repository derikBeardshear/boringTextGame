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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblNameInput = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lbxCharacters = New System.Windows.Forms.ListBox()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.lblEName = New System.Windows.Forms.Label()
        Me.lblUserHi = New System.Windows.Forms.Label()
        Me.lblUserHp = New System.Windows.Forms.Label()
        Me.lblEHP = New System.Windows.Forms.Label()
        Me.btnStrong = New System.Windows.Forms.Button()
        Me.btnFast = New System.Windows.Forms.Button()
        Me.btnHeal = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnDeleteUser = New System.Windows.Forms.Button()
        Me.lblKills = New System.Windows.Forms.Label()
        Me.lblGameName = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(62, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(209, 13)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "The Worlds Most Boring Text Based Game"
        '
        'lblNameInput
        '
        Me.lblNameInput.AutoSize = True
        Me.lblNameInput.Location = New System.Drawing.Point(13, 40)
        Me.lblNameInput.Name = "lblNameInput"
        Me.lblNameInput.Size = New System.Drawing.Size(35, 13)
        Me.lblNameInput.TabIndex = 1
        Me.lblNameInput.Text = "Name"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(55, 40)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(81, 20)
        Me.txtName.TabIndex = 2
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(12, 66)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(124, 22)
        Me.btnCreate.TabIndex = 3
        Me.btnCreate.Text = "Create Character"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(12, 94)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(124, 26)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "Save Character"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'lbxCharacters
        '
        Me.lbxCharacters.FormattingEnabled = True
        Me.lbxCharacters.Location = New System.Drawing.Point(12, 156)
        Me.lbxCharacters.Name = "lbxCharacters"
        Me.lbxCharacters.Size = New System.Drawing.Size(124, 95)
        Me.lbxCharacters.TabIndex = 5
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Location = New System.Drawing.Point(170, 66)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(0, 13)
        Me.lblUserName.TabIndex = 6
        '
        'lblEName
        '
        Me.lblEName.AutoSize = True
        Me.lblEName.Location = New System.Drawing.Point(273, 66)
        Me.lblEName.Name = "lblEName"
        Me.lblEName.Size = New System.Drawing.Size(0, 13)
        Me.lblEName.TabIndex = 7
        '
        'lblUserHi
        '
        Me.lblUserHi.AutoSize = True
        Me.lblUserHi.Location = New System.Drawing.Point(170, 125)
        Me.lblUserHi.Name = "lblUserHi"
        Me.lblUserHi.Size = New System.Drawing.Size(0, 13)
        Me.lblUserHi.TabIndex = 9
        '
        'lblUserHp
        '
        Me.lblUserHp.AutoSize = True
        Me.lblUserHp.Location = New System.Drawing.Point(170, 94)
        Me.lblUserHp.Name = "lblUserHp"
        Me.lblUserHp.Size = New System.Drawing.Size(0, 13)
        Me.lblUserHp.TabIndex = 10
        '
        'lblEHP
        '
        Me.lblEHP.AutoSize = True
        Me.lblEHP.Location = New System.Drawing.Point(273, 94)
        Me.lblEHP.Name = "lblEHP"
        Me.lblEHP.Size = New System.Drawing.Size(0, 13)
        Me.lblEHP.TabIndex = 12
        '
        'btnStrong
        '
        Me.btnStrong.Location = New System.Drawing.Point(173, 199)
        Me.btnStrong.Name = "btnStrong"
        Me.btnStrong.Size = New System.Drawing.Size(93, 23)
        Me.btnStrong.TabIndex = 13
        Me.btnStrong.Text = "Strong Attack"
        Me.btnStrong.UseVisualStyleBackColor = True
        '
        'btnFast
        '
        Me.btnFast.Location = New System.Drawing.Point(276, 199)
        Me.btnFast.Name = "btnFast"
        Me.btnFast.Size = New System.Drawing.Size(93, 23)
        Me.btnFast.TabIndex = 14
        Me.btnFast.Text = "Fast Attack"
        Me.btnFast.UseVisualStyleBackColor = True
        '
        'btnHeal
        '
        Me.btnHeal.Location = New System.Drawing.Point(223, 228)
        Me.btnHeal.Name = "btnHeal"
        Me.btnHeal.Size = New System.Drawing.Size(107, 23)
        Me.btnHeal.TabIndex = 15
        Me.btnHeal.Text = "Use Healing Item"
        Me.btnHeal.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(294, 125)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 23)
        Me.btnStart.TabIndex = 16
        Me.btnStart.Text = "Begin battle"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnDeleteUser
        '
        Me.btnDeleteUser.Location = New System.Drawing.Point(12, 126)
        Me.btnDeleteUser.Name = "btnDeleteUser"
        Me.btnDeleteUser.Size = New System.Drawing.Size(124, 23)
        Me.btnDeleteUser.TabIndex = 17
        Me.btnDeleteUser.Text = "Delete Character"
        Me.btnDeleteUser.UseVisualStyleBackColor = True
        '
        'lblKills
        '
        Me.lblKills.AutoSize = True
        Me.lblKills.Location = New System.Drawing.Point(173, 156)
        Me.lblKills.Name = "lblKills"
        Me.lblKills.Size = New System.Drawing.Size(0, 13)
        Me.lblKills.TabIndex = 18
        '
        'lblGameName
        '
        Me.lblGameName.AutoSize = True
        Me.lblGameName.Location = New System.Drawing.Point(160, 81)
        Me.lblGameName.Name = "lblGameName"
        Me.lblGameName.Size = New System.Drawing.Size(209, 13)
        Me.lblGameName.TabIndex = 19
        Me.lblGameName.Text = "The Worlds Most Boring Text Based Game"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(382, 261)
        Me.Controls.Add(Me.lblGameName)
        Me.Controls.Add(Me.lblKills)
        Me.Controls.Add(Me.btnDeleteUser)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.btnHeal)
        Me.Controls.Add(Me.btnFast)
        Me.Controls.Add(Me.btnStrong)
        Me.Controls.Add(Me.lblEHP)
        Me.Controls.Add(Me.lblUserHp)
        Me.Controls.Add(Me.lblUserHi)
        Me.Controls.Add(Me.lblEName)
        Me.Controls.Add(Me.lblUserName)
        Me.Controls.Add(Me.lbxCharacters)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblNameInput)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "Form1"
        Me.Text = "TWMBTBG"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblNameInput As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnCreate As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents lbxCharacters As ListBox
    Friend WithEvents lblUserName As Label
    Friend WithEvents lblEName As Label
    Friend WithEvents lblUserHi As Label
    Friend WithEvents lblUserHp As Label
    Friend WithEvents lblEHP As Label
    Friend WithEvents btnStrong As Button
    Friend WithEvents btnFast As Button
    Friend WithEvents btnHeal As Button
    Friend WithEvents btnStart As Button
    Friend WithEvents btnDeleteUser As Button
    Friend WithEvents lblKills As Label
    Friend WithEvents lblGameName As Label
End Class
