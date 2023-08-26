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
		Me.btnCancel = New System.Windows.Forms.Button()
		Me.btnSave = New System.Windows.Forms.Button()
		Me.lblMemberName = New System.Windows.Forms.Label()
		Me.tbxValue = New System.Windows.Forms.TextBox()
		Me.pnlHeader = New System.Windows.Forms.Panel()
		Me.lblTitle = New System.Windows.Forms.Label()
		Me.lblRefIndex = New System.Windows.Forms.Label()
		Me.lblRefLineNo = New System.Windows.Forms.Label()
		Me.tbxComment = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.pnlHeader.SuspendLayout()
		Me.SuspendLayout()
		'
		'btnCancel
		'
		Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnCancel.Location = New System.Drawing.Point(393, 287)
		Me.btnCancel.Name = "btnCancel"
		Me.btnCancel.Size = New System.Drawing.Size(75, 23)
		Me.btnCancel.TabIndex = 2
		Me.btnCancel.Text = "Cancel"
		Me.btnCancel.UseVisualStyleBackColor = True
		'
		'btnSave
		'
		Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnSave.Location = New System.Drawing.Point(312, 287)
		Me.btnSave.Name = "btnSave"
		Me.btnSave.Size = New System.Drawing.Size(75, 23)
		Me.btnSave.TabIndex = 1
		Me.btnSave.Text = "Save"
		Me.btnSave.UseVisualStyleBackColor = True
		'
		'lblMemberName
		'
		Me.lblMemberName.AutoSize = True
		Me.lblMemberName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
		Me.lblMemberName.Location = New System.Drawing.Point(12, 44)
		Me.lblMemberName.Name = "lblMemberName"
		Me.lblMemberName.Size = New System.Drawing.Size(51, 16)
		Me.lblMemberName.TabIndex = 4
		Me.lblMemberName.Text = "Name :"
		Me.lblMemberName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'tbxValue
		'
		Me.tbxValue.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
						Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tbxValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
		Me.tbxValue.Location = New System.Drawing.Point(60, 41)
		Me.tbxValue.Name = "tbxValue"
		Me.tbxValue.Size = New System.Drawing.Size(408, 22)
		Me.tbxValue.TabIndex = 0
		'
		'pnlHeader
		'
		Me.pnlHeader.BackColor = System.Drawing.Color.DimGray
		Me.pnlHeader.Controls.Add(Me.lblTitle)
		Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
		Me.pnlHeader.ForeColor = System.Drawing.SystemColors.ControlText
		Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
		Me.pnlHeader.Name = "pnlHeader"
		Me.pnlHeader.Size = New System.Drawing.Size(480, 35)
		Me.pnlHeader.TabIndex = 6
		'
		'lblTitle
		'
		Me.lblTitle.AutoSize = True
		Me.lblTitle.Font = New System.Drawing.Font("Tw Cen MT Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTitle.ForeColor = System.Drawing.Color.White
		Me.lblTitle.Location = New System.Drawing.Point(2, 3)
		Me.lblTitle.Name = "lblTitle"
		Me.lblTitle.Size = New System.Drawing.Size(84, 28)
		Me.lblTitle.TabIndex = 7
		Me.lblTitle.Text = "Edit Value"
		'
		'lblRefIndex
		'
		Me.lblRefIndex.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.lblRefIndex.AutoSize = True
		Me.lblRefIndex.Location = New System.Drawing.Point(12, 300)
		Me.lblRefIndex.Name = "lblRefIndex"
		Me.lblRefIndex.Size = New System.Drawing.Size(56, 13)
		Me.lblRefIndex.TabIndex = 7
		Me.lblRefIndex.Text = "Ref. Index"
		Me.lblRefIndex.Visible = False
		'
		'lblRefLineNo
		'
		Me.lblRefLineNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.lblRefLineNo.AutoSize = True
		Me.lblRefLineNo.Location = New System.Drawing.Point(74, 300)
		Me.lblRefLineNo.Name = "lblRefLineNo"
		Me.lblRefLineNo.Size = New System.Drawing.Size(50, 13)
		Me.lblRefLineNo.TabIndex = 8
		Me.lblRefLineNo.Text = "Ref. Line"
		Me.lblRefLineNo.Visible = False
		'
		'tbxComment
		'
		Me.tbxComment.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
						Or System.Windows.Forms.AnchorStyles.Left) _
						Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tbxComment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
		Me.tbxComment.Location = New System.Drawing.Point(12, 95)
		Me.tbxComment.Multiline = True
		Me.tbxComment.Name = "tbxComment"
		Me.tbxComment.Size = New System.Drawing.Size(456, 186)
		Me.tbxComment.TabIndex = 9
		'
		'Label1
		'
		Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
		Me.Label1.Location = New System.Drawing.Point(9, 76)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(65, 16)
		Me.Label1.TabIndex = 10
		Me.Label1.Text = "Comment"
		'
		'frmEditValue
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(480, 322)
		Me.ControlBox = False
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.tbxComment)
		Me.Controls.Add(Me.lblRefLineNo)
		Me.Controls.Add(Me.pnlHeader)
		Me.Controls.Add(Me.tbxValue)
		Me.Controls.Add(Me.lblMemberName)
		Me.Controls.Add(Me.btnSave)
		Me.Controls.Add(Me.btnCancel)
		Me.Controls.Add(Me.lblRefIndex)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
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
	Friend WithEvents lblMemberName As Label
	Friend WithEvents tbxValue As TextBox
	Friend WithEvents pnlHeader As Panel
	Friend WithEvents lblTitle As Label
	Friend WithEvents lblRefIndex As Label
	Friend WithEvents lblRefLineNo As Label
	Friend WithEvents tbxComment As TextBox
	Friend WithEvents Label1 As Label
End Class
