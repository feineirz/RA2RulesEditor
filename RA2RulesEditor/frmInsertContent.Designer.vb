<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInsertContent
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInsertContent))
		Me.pnlHeader = New System.Windows.Forms.Panel()
		Me.lblTitle = New System.Windows.Forms.Label()
		Me.tbxName = New System.Windows.Forms.TextBox()
		Me.lblMemberName = New System.Windows.Forms.Label()
		Me.btnSave = New System.Windows.Forms.Button()
		Me.btnCancel = New System.Windows.Forms.Button()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.tbxComment = New System.Windows.Forms.TextBox()
		Me.lblRefLineNo = New System.Windows.Forms.Label()
		Me.lblRefIndex = New System.Windows.Forms.Label()
		Me.tbxValue = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.pnlHeader.SuspendLayout()
		Me.SuspendLayout()
		'
		'pnlHeader
		'
		Me.pnlHeader.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.pnlHeader.Controls.Add(Me.lblTitle)
		Me.pnlHeader.ForeColor = System.Drawing.SystemColors.ControlText
		Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
		Me.pnlHeader.Name = "pnlHeader"
		Me.pnlHeader.Size = New System.Drawing.Size(500, 35)
		Me.pnlHeader.TabIndex = 15
		'
		'lblTitle
		'
		Me.lblTitle.AutoSize = True
		Me.lblTitle.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTitle.ForeColor = System.Drawing.Color.White
		Me.lblTitle.Location = New System.Drawing.Point(2, 1)
		Me.lblTitle.Name = "lblTitle"
		Me.lblTitle.Size = New System.Drawing.Size(164, 33)
		Me.lblTitle.TabIndex = 7
		Me.lblTitle.Text = "Insert Content"
		'
		'tbxName
		'
		Me.tbxName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tbxName.Font = New System.Drawing.Font("Bahnschrift SemiLight SemiConde", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.tbxName.Location = New System.Drawing.Point(99, 69)
		Me.tbxName.Name = "tbxName"
		Me.tbxName.Size = New System.Drawing.Size(342, 23)
		Me.tbxName.TabIndex = 0
		'
		'lblMemberName
		'
		Me.lblMemberName.AutoSize = True
		Me.lblMemberName.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblMemberName.Location = New System.Drawing.Point(51, 70)
		Me.lblMemberName.Name = "lblMemberName"
		Me.lblMemberName.Size = New System.Drawing.Size(49, 18)
		Me.lblMemberName.TabIndex = 14
		Me.lblMemberName.Text = "Name :"
		Me.lblMemberName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'btnSave
		'
		Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK
		Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnSave.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnSave.Location = New System.Drawing.Point(285, 264)
		Me.btnSave.Name = "btnSave"
		Me.btnSave.Size = New System.Drawing.Size(75, 28)
		Me.btnSave.TabIndex = 3
		Me.btnSave.Text = "Save"
		Me.btnSave.UseVisualStyleBackColor = True
		'
		'btnCancel
		'
		Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnCancel.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnCancel.Location = New System.Drawing.Point(366, 264)
		Me.btnCancel.Name = "btnCancel"
		Me.btnCancel.Size = New System.Drawing.Size(75, 28)
		Me.btnCancel.TabIndex = 4
		Me.btnCancel.Text = "Cancel"
		Me.btnCancel.UseVisualStyleBackColor = True
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(30, 127)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(70, 18)
		Me.Label1.TabIndex = 19
		Me.Label1.Text = "Comment :"
		'
		'tbxComment
		'
		Me.tbxComment.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tbxComment.Font = New System.Drawing.Font("Bahnschrift SemiLight SemiConde", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.tbxComment.Location = New System.Drawing.Point(99, 127)
		Me.tbxComment.Multiline = True
		Me.tbxComment.Name = "tbxComment"
		Me.tbxComment.Size = New System.Drawing.Size(342, 131)
		Me.tbxComment.TabIndex = 2
		'
		'lblRefLineNo
		'
		Me.lblRefLineNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.lblRefLineNo.AutoSize = True
		Me.lblRefLineNo.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!)
		Me.lblRefLineNo.Location = New System.Drawing.Point(158, 264)
		Me.lblRefLineNo.Name = "lblRefLineNo"
		Me.lblRefLineNo.Size = New System.Drawing.Size(50, 16)
		Me.lblRefLineNo.TabIndex = 17
		Me.lblRefLineNo.Text = "Ref. Line"
		Me.lblRefLineNo.Visible = False
		'
		'lblRefIndex
		'
		Me.lblRefIndex.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.lblRefIndex.AutoSize = True
		Me.lblRefIndex.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!)
		Me.lblRefIndex.Location = New System.Drawing.Point(96, 264)
		Me.lblRefIndex.Name = "lblRefIndex"
		Me.lblRefIndex.Size = New System.Drawing.Size(56, 16)
		Me.lblRefIndex.TabIndex = 16
		Me.lblRefIndex.Text = "Ref. Index"
		Me.lblRefIndex.Visible = False
		'
		'tbxValue
		'
		Me.tbxValue.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tbxValue.Font = New System.Drawing.Font("Bahnschrift SemiLight SemiConde", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.tbxValue.Location = New System.Drawing.Point(99, 94)
		Me.tbxValue.Name = "tbxValue"
		Me.tbxValue.Size = New System.Drawing.Size(342, 23)
		Me.tbxValue.TabIndex = 1
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(53, 99)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(47, 18)
		Me.Label2.TabIndex = 21
		Me.Label2.Text = "Value :"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'frmInsertContent
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.Beige
		Me.ClientSize = New System.Drawing.Size(500, 320)
		Me.Controls.Add(Me.tbxComment)
		Me.Controls.Add(Me.tbxValue)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.pnlHeader)
		Me.Controls.Add(Me.tbxName)
		Me.Controls.Add(Me.lblMemberName)
		Me.Controls.Add(Me.btnSave)
		Me.Controls.Add(Me.btnCancel)
		Me.Controls.Add(Me.lblRefLineNo)
		Me.Controls.Add(Me.lblRefIndex)
		Me.Controls.Add(Me.Label1)
		Me.Font = New System.Drawing.Font("Bahnschrift SemiLight SemiConde", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.Name = "frmInsertContent"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "frmInsertContent"
		Me.pnlHeader.ResumeLayout(False)
		Me.pnlHeader.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents pnlHeader As Panel
	Friend WithEvents lblTitle As Label
	Friend WithEvents tbxName As TextBox
	Friend WithEvents lblMemberName As Label
	Friend WithEvents btnSave As Button
	Friend WithEvents btnCancel As Button
	Friend WithEvents Label1 As Label
	Friend WithEvents tbxComment As TextBox
	Friend WithEvents lblRefLineNo As Label
	Friend WithEvents lblRefIndex As Label
	Friend WithEvents tbxValue As TextBox
	Friend WithEvents Label2 As Label
End Class
