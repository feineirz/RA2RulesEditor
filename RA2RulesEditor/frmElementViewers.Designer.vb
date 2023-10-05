<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmElementViewers
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmElementViewers))
		Me.pnlHeader = New System.Windows.Forms.Panel()
		Me.lblTitle = New System.Windows.Forms.Label()
		Me.pnlFooter = New System.Windows.Forms.Panel()
		Me.lblNearDropIndex = New System.Windows.Forms.Label()
		Me.lblCurrentSection = New System.Windows.Forms.Label()
		Me.btnClose = New System.Windows.Forms.Button()
		Me.lvwElements = New System.Windows.Forms.ListView()
		Me.col_Member_Name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.col_Member_Value = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.col_Member_Comment = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.col_Member_LineNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.cmsMember = New System.Windows.Forms.ContextMenuStrip(Me.components)
		Me.tsmi_AppendElement = New System.Windows.Forms.ToolStripMenuItem()
		Me.tsmi_RemoveElement = New System.Windows.Forms.ToolStripMenuItem()
		Me.pnlHeader.SuspendLayout()
		Me.pnlFooter.SuspendLayout()
		Me.cmsMember.SuspendLayout()
		Me.SuspendLayout()
		'
		'pnlHeader
		'
		Me.pnlHeader.BackColor = System.Drawing.Color.DarkGray
		Me.pnlHeader.Controls.Add(Me.lblTitle)
		Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
		Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
		Me.pnlHeader.Name = "pnlHeader"
		Me.pnlHeader.Size = New System.Drawing.Size(1194, 45)
		Me.pnlHeader.TabIndex = 0
		'
		'lblTitle
		'
		Me.lblTitle.AutoSize = True
		Me.lblTitle.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTitle.ForeColor = System.Drawing.Color.Black
		Me.lblTitle.Location = New System.Drawing.Point(3, 4)
		Me.lblTitle.Name = "lblTitle"
		Me.lblTitle.Size = New System.Drawing.Size(99, 35)
		Me.lblTitle.TabIndex = 1
		Me.lblTitle.Text = "Section"
		'
		'pnlFooter
		'
		Me.pnlFooter.BackColor = System.Drawing.Color.Gainsboro
		Me.pnlFooter.Controls.Add(Me.lblNearDropIndex)
		Me.pnlFooter.Controls.Add(Me.lblCurrentSection)
		Me.pnlFooter.Controls.Add(Me.btnClose)
		Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.pnlFooter.Location = New System.Drawing.Point(0, 720)
		Me.pnlFooter.Name = "pnlFooter"
		Me.pnlFooter.Size = New System.Drawing.Size(1194, 39)
		Me.pnlFooter.TabIndex = 1
		'
		'lblNearDropIndex
		'
		Me.lblNearDropIndex.AutoSize = True
		Me.lblNearDropIndex.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblNearDropIndex.Location = New System.Drawing.Point(708, 14)
		Me.lblNearDropIndex.Name = "lblNearDropIndex"
		Me.lblNearDropIndex.Size = New System.Drawing.Size(82, 16)
		Me.lblNearDropIndex.TabIndex = 8
		Me.lblNearDropIndex.Text = "NearDropIndex"
		Me.lblNearDropIndex.Visible = False
		'
		'lblCurrentSection
		'
		Me.lblCurrentSection.AutoSize = True
		Me.lblCurrentSection.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCurrentSection.Location = New System.Drawing.Point(894, 14)
		Me.lblCurrentSection.Name = "lblCurrentSection"
		Me.lblCurrentSection.Size = New System.Drawing.Size(84, 16)
		Me.lblCurrentSection.TabIndex = 7
		Me.lblCurrentSection.Text = "CurrentSection"
		Me.lblCurrentSection.Visible = False
		'
		'btnClose
		'
		Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnClose.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnClose.Location = New System.Drawing.Point(1113, 7)
		Me.btnClose.Name = "btnClose"
		Me.btnClose.Size = New System.Drawing.Size(69, 27)
		Me.btnClose.TabIndex = 3
		Me.btnClose.Text = "Close"
		Me.btnClose.UseVisualStyleBackColor = True
		'
		'lvwElements
		'
		Me.lvwElements.AllowDrop = True
		Me.lvwElements.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lvwElements.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.col_Member_Name, Me.col_Member_Value, Me.col_Member_Comment, Me.col_Member_LineNo})
		Me.lvwElements.ContextMenuStrip = Me.cmsMember
		Me.lvwElements.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lvwElements.FullRowSelect = True
		Me.lvwElements.GridLines = True
		Me.lvwElements.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
		Me.lvwElements.HideSelection = False
		Me.lvwElements.Location = New System.Drawing.Point(12, 58)
		Me.lvwElements.Name = "lvwElements"
		Me.lvwElements.Size = New System.Drawing.Size(1170, 648)
		Me.lvwElements.TabIndex = 6
		Me.lvwElements.UseCompatibleStateImageBehavior = False
		Me.lvwElements.View = System.Windows.Forms.View.Details
		'
		'col_Member_Name
		'
		Me.col_Member_Name.Text = "Name"
		Me.col_Member_Name.Width = 250
		'
		'col_Member_Value
		'
		Me.col_Member_Value.Text = "Value"
		Me.col_Member_Value.Width = 250
		'
		'col_Member_Comment
		'
		Me.col_Member_Comment.Text = "Comment"
		Me.col_Member_Comment.Width = 570
		'
		'col_Member_LineNo
		'
		Me.col_Member_LineNo.Text = "Line No."
		Me.col_Member_LineNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.col_Member_LineNo.Width = 70
		'
		'cmsMember
		'
		Me.cmsMember.Font = New System.Drawing.Font("Bahnschrift SemiLight SemiConde", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmsMember.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmi_AppendElement, Me.tsmi_RemoveElement})
		Me.cmsMember.Name = "cmsMember"
		Me.cmsMember.Size = New System.Drawing.Size(160, 48)
		'
		'tsmi_AppendElement
		'
		Me.tsmi_AppendElement.Enabled = False
		Me.tsmi_AppendElement.Image = CType(resources.GetObject("tsmi_AppendElement.Image"), System.Drawing.Image)
		Me.tsmi_AppendElement.Name = "tsmi_AppendElement"
		Me.tsmi_AppendElement.Size = New System.Drawing.Size(159, 22)
		Me.tsmi_AppendElement.Text = "Append element"
		'
		'tsmi_RemoveElement
		'
		Me.tsmi_RemoveElement.Enabled = False
		Me.tsmi_RemoveElement.Image = CType(resources.GetObject("tsmi_RemoveElement.Image"), System.Drawing.Image)
		Me.tsmi_RemoveElement.Name = "tsmi_RemoveElement"
		Me.tsmi_RemoveElement.Size = New System.Drawing.Size(159, 22)
		Me.tsmi_RemoveElement.Text = "Remove element"
		'
		'frmElementViewers
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.WhiteSmoke
		Me.ClientSize = New System.Drawing.Size(1194, 759)
		Me.ControlBox = False
		Me.Controls.Add(Me.lvwElements)
		Me.Controls.Add(Me.pnlFooter)
		Me.Controls.Add(Me.pnlHeader)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Name = "frmElementViewers"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Element Viewers"
		Me.pnlHeader.ResumeLayout(False)
		Me.pnlHeader.PerformLayout()
		Me.pnlFooter.ResumeLayout(False)
		Me.pnlFooter.PerformLayout()
		Me.cmsMember.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents pnlHeader As Panel
	Friend WithEvents pnlFooter As Panel
	Friend WithEvents lblTitle As Label
	Friend WithEvents lvwElements As ListView
	Friend WithEvents col_Member_Name As ColumnHeader
	Friend WithEvents col_Member_Value As ColumnHeader
	Friend WithEvents col_Member_LineNo As ColumnHeader
	Friend WithEvents col_Member_Comment As ColumnHeader
	Friend WithEvents btnClose As Button
	Friend WithEvents cmsMember As ContextMenuStrip
	Friend WithEvents tsmi_AppendElement As ToolStripMenuItem
	Friend WithEvents tsmi_RemoveElement As ToolStripMenuItem
	Friend WithEvents lblCurrentSection As Label
	Friend WithEvents lblNearDropIndex As Label
End Class
