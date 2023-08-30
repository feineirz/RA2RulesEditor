<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditValue
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEditValue))
		Me.btnCancel = New System.Windows.Forms.Button()
		Me.btnSave = New System.Windows.Forms.Button()
		Me.tbxValue = New System.Windows.Forms.TextBox()
		Me.pnlHeader = New System.Windows.Forms.Panel()
		Me.lblTitle = New System.Windows.Forms.Label()
		Me.lblRefIndex = New System.Windows.Forms.Label()
		Me.lblRefLineNo = New System.Windows.Forms.Label()
		Me.tbxComment = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.tbxKeyName = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.pnlHeader.SuspendLayout()
		Me.SuspendLayout()
		'
		'btnCancel
		'
		Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnCancel.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnCancel.Location = New System.Drawing.Point(383, 277)
		Me.btnCancel.Name = "btnCancel"
		Me.btnCancel.Size = New System.Drawing.Size(75, 28)
		Me.btnCancel.TabIndex = 2
		Me.btnCancel.Text = "Cancel"
		Me.btnCancel.UseVisualStyleBackColor = True
		'
		'btnSave
		'
		Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnSave.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnSave.Location = New System.Drawing.Point(302, 277)
		Me.btnSave.Name = "btnSave"
		Me.btnSave.Size = New System.Drawing.Size(75, 28)
		Me.btnSave.TabIndex = 1
		Me.btnSave.Text = "Save"
		Me.btnSave.UseVisualStyleBackColor = True
		'
		'tbxValue
		'
		Me.tbxValue.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tbxValue.Font = New System.Drawing.Font("Bahnschrift SemiLight SemiConde", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.tbxValue.Location = New System.Drawing.Point(94, 96)
		Me.tbxValue.Name = "tbxValue"
		Me.tbxValue.Size = New System.Drawing.Size(364, 23)
		Me.tbxValue.TabIndex = 0
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
		Me.pnlHeader.TabIndex = 6
		'
		'lblTitle
		'
		Me.lblTitle.AutoSize = True
		Me.lblTitle.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTitle.ForeColor = System.Drawing.Color.Black
		Me.lblTitle.Location = New System.Drawing.Point(2, 1)
		Me.lblTitle.Name = "lblTitle"
		Me.lblTitle.Size = New System.Drawing.Size(119, 33)
		Me.lblTitle.TabIndex = 7
		Me.lblTitle.Text = "Edit Value"
		'
		'lblRefIndex
		'
		Me.lblRefIndex.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.lblRefIndex.AutoSize = True
		Me.lblRefIndex.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!)
		Me.lblRefIndex.Location = New System.Drawing.Point(91, 274)
		Me.lblRefIndex.Name = "lblRefIndex"
		Me.lblRefIndex.Size = New System.Drawing.Size(56, 16)
		Me.lblRefIndex.TabIndex = 7
		Me.lblRefIndex.Text = "Ref. Index"
		Me.lblRefIndex.Visible = False
		'
		'lblRefLineNo
		'
		Me.lblRefLineNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.lblRefLineNo.AutoSize = True
		Me.lblRefLineNo.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!)
		Me.lblRefLineNo.Location = New System.Drawing.Point(153, 274)
		Me.lblRefLineNo.Name = "lblRefLineNo"
		Me.lblRefLineNo.Size = New System.Drawing.Size(50, 16)
		Me.lblRefLineNo.TabIndex = 8
		Me.lblRefLineNo.Text = "Ref. Line"
		Me.lblRefLineNo.Visible = False
		'
		'tbxComment
		'
		Me.tbxComment.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tbxComment.Font = New System.Drawing.Font("Bahnschrift SemiLight SemiConde", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.tbxComment.Location = New System.Drawing.Point(94, 125)
		Me.tbxComment.Multiline = True
		Me.tbxComment.Name = "tbxComment"
		Me.tbxComment.Size = New System.Drawing.Size(364, 146)
		Me.tbxComment.TabIndex = 9
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(25, 125)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(70, 18)
		Me.Label1.TabIndex = 10
		Me.Label1.Text = "Comment :"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(48, 97)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(47, 18)
		Me.Label2.TabIndex = 11
		Me.Label2.Text = "Value :"
		'
		'tbxKeyName
		'
		Me.tbxKeyName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tbxKeyName.Font = New System.Drawing.Font("Bahnschrift SemiLight SemiConde", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.tbxKeyName.Location = New System.Drawing.Point(94, 70)
		Me.tbxKeyName.Name = "tbxKeyName"
		Me.tbxKeyName.ReadOnly = True
		Me.tbxKeyName.Size = New System.Drawing.Size(364, 23)
		Me.tbxKeyName.TabIndex = 12
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(59, 71)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(36, 18)
		Me.Label3.TabIndex = 13
		Me.Label3.Text = "Key :"
		'
		'frmEditValue
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(500, 337)
		Me.ControlBox = False
		Me.Controls.Add(Me.tbxKeyName)
		Me.Controls.Add(Me.tbxValue)
		Me.Controls.Add(Me.tbxComment)
		Me.Controls.Add(Me.lblRefLineNo)
		Me.Controls.Add(Me.pnlHeader)
		Me.Controls.Add(Me.btnSave)
		Me.Controls.Add(Me.btnCancel)
		Me.Controls.Add(Me.lblRefIndex)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Name = "frmEditValue"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "frmEditValue"
		Me.pnlHeader.ResumeLayout(False)
		Me.pnlHeader.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents btnCancel As Button
	Friend WithEvents btnSave As Button
	Friend WithEvents tbxValue As TextBox
	Friend WithEvents pnlHeader As Panel
	Friend WithEvents lblTitle As Label
	Friend WithEvents lblRefIndex As Label
	Friend WithEvents lblRefLineNo As Label
	Friend WithEvents tbxComment As TextBox
	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents tbxKeyName As TextBox
	Friend WithEvents Label3 As Label
End Class
