<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCloneSectionAs
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
		Me.pnlHeader = New System.Windows.Forms.Panel()
		Me.lblTitle = New System.Windows.Forms.Label()
		Me.tbxName = New System.Windows.Forms.TextBox()
		Me.lblMemberName = New System.Windows.Forms.Label()
		Me.btnClone = New System.Windows.Forms.Button()
		Me.btnCancel = New System.Windows.Forms.Button()
		Me.pnlHeader.SuspendLayout()
		Me.SuspendLayout()
		'
		'pnlHeader
		'
		Me.pnlHeader.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pnlHeader.BackColor = System.Drawing.Color.Silver
		Me.pnlHeader.Controls.Add(Me.lblTitle)
		Me.pnlHeader.ForeColor = System.Drawing.SystemColors.ControlText
		Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
		Me.pnlHeader.Name = "pnlHeader"
		Me.pnlHeader.Size = New System.Drawing.Size(500, 35)
		Me.pnlHeader.TabIndex = 28
		'
		'lblTitle
		'
		Me.lblTitle.AutoSize = True
		Me.lblTitle.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTitle.ForeColor = System.Drawing.Color.Black
		Me.lblTitle.Location = New System.Drawing.Point(2, 1)
		Me.lblTitle.Name = "lblTitle"
		Me.lblTitle.Size = New System.Drawing.Size(191, 33)
		Me.lblTitle.TabIndex = 7
		Me.lblTitle.Text = "Clone Section As"
		'
		'tbxName
		'
		Me.tbxName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tbxName.Font = New System.Drawing.Font("Bahnschrift SemiLight SemiConde", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.tbxName.Location = New System.Drawing.Point(153, 69)
		Me.tbxName.Name = "tbxName"
		Me.tbxName.Size = New System.Drawing.Size(288, 23)
		Me.tbxName.TabIndex = 22
		'
		'lblMemberName
		'
		Me.lblMemberName.AutoSize = True
		Me.lblMemberName.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblMemberName.Location = New System.Drawing.Point(57, 70)
		Me.lblMemberName.Name = "lblMemberName"
		Me.lblMemberName.Size = New System.Drawing.Size(96, 18)
		Me.lblMemberName.TabIndex = 27
		Me.lblMemberName.Text = "Section Name :"
		Me.lblMemberName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'btnClone
		'
		Me.btnClone.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnClone.DialogResult = System.Windows.Forms.DialogResult.OK
		Me.btnClone.Enabled = False
		Me.btnClone.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnClone.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnClone.Location = New System.Drawing.Point(285, 99)
		Me.btnClone.Name = "btnClone"
		Me.btnClone.Size = New System.Drawing.Size(75, 28)
		Me.btnClone.TabIndex = 25
		Me.btnClone.Text = "Clone"
		Me.btnClone.UseVisualStyleBackColor = True
		'
		'btnCancel
		'
		Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnCancel.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnCancel.Location = New System.Drawing.Point(366, 99)
		Me.btnCancel.Name = "btnCancel"
		Me.btnCancel.Size = New System.Drawing.Size(75, 28)
		Me.btnCancel.TabIndex = 26
		Me.btnCancel.Text = "Cancel"
		Me.btnCancel.UseVisualStyleBackColor = True
		'
		'frmCloneSectionAs
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(500, 155)
		Me.Controls.Add(Me.pnlHeader)
		Me.Controls.Add(Me.tbxName)
		Me.Controls.Add(Me.btnClone)
		Me.Controls.Add(Me.btnCancel)
		Me.Controls.Add(Me.lblMemberName)
		Me.Font = New System.Drawing.Font("Bahnschrift SemiLight SemiConde", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.Name = "frmCloneSectionAs"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Clone Section As"
		Me.pnlHeader.ResumeLayout(False)
		Me.pnlHeader.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents pnlHeader As Panel
	Friend WithEvents lblTitle As Label
	Friend WithEvents tbxName As TextBox
	Friend WithEvents lblMemberName As Label
	Friend WithEvents btnClone As Button
	Friend WithEvents btnCancel As Button
End Class
