<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
		Me.pnlHeader = New System.Windows.Forms.Panel()
		Me.picIcon = New System.Windows.Forms.PictureBox()
		Me.lblTitle = New System.Windows.Forms.Label()
		Me.btnLoad = New System.Windows.Forms.Button()
		Me.btnExit = New System.Windows.Forms.Button()
		Me.pnlFooter = New System.Windows.Forms.Panel()
		Me.btnSort = New System.Windows.Forms.Button()
		Me.lblStatus = New System.Windows.Forms.Label()
		Me.lvwSection = New System.Windows.Forms.ListView()
		Me.col_Section_Name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.lvwMember = New System.Windows.Forms.ListView()
		Me.col_Member_Name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.col_Member_Value = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.col_Member_LineNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.col_Member_Comment = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.Label1 = New System.Windows.Forms.Label()
		Me.tbxFilter = New System.Windows.Forms.TextBox()
		Me.btnFilter = New System.Windows.Forms.Button()
		Me.lblCurSection = New System.Windows.Forms.Label()
		Me.pnlInit = New System.Windows.Forms.Panel()
		Me.lblMessage = New System.Windows.Forms.Label()
		Me.lblPath = New System.Windows.Forms.Label()
		Me.cmsMember = New System.Windows.Forms.ContextMenuStrip(Me.components)
		Me.InsertContentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.pnlHeader.SuspendLayout()
		CType(Me.picIcon, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.pnlFooter.SuspendLayout()
		Me.pnlInit.SuspendLayout()
		Me.cmsMember.SuspendLayout()
		Me.SuspendLayout()
		'
		'pnlHeader
		'
		Me.pnlHeader.BackColor = System.Drawing.Color.DimGray
		Me.pnlHeader.Controls.Add(Me.picIcon)
		Me.pnlHeader.Controls.Add(Me.lblTitle)
		Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
		Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
		Me.pnlHeader.Name = "pnlHeader"
		Me.pnlHeader.Size = New System.Drawing.Size(1453, 50)
		Me.pnlHeader.TabIndex = 0
		'
		'picIcon
		'
		Me.picIcon.Image = CType(resources.GetObject("picIcon.Image"), System.Drawing.Image)
		Me.picIcon.Location = New System.Drawing.Point(4, 4)
		Me.picIcon.Name = "picIcon"
		Me.picIcon.Size = New System.Drawing.Size(40, 40)
		Me.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.picIcon.TabIndex = 4
		Me.picIcon.TabStop = False
		'
		'lblTitle
		'
		Me.lblTitle.AutoSize = True
		Me.lblTitle.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTitle.ForeColor = System.Drawing.Color.WhiteSmoke
		Me.lblTitle.Location = New System.Drawing.Point(42, 5)
		Me.lblTitle.Name = "lblTitle"
		Me.lblTitle.Size = New System.Drawing.Size(226, 39)
		Me.lblTitle.TabIndex = 0
		Me.lblTitle.Text = "RA2 Rules Editor"
		'
		'btnLoad
		'
		Me.btnLoad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnLoad.Font = New System.Drawing.Font("Bahnschrift", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnLoad.Location = New System.Drawing.Point(1291, 6)
		Me.btnLoad.Name = "btnLoad"
		Me.btnLoad.Size = New System.Drawing.Size(75, 28)
		Me.btnLoad.TabIndex = 1
		Me.btnLoad.Text = "Load"
		Me.btnLoad.UseVisualStyleBackColor = True
		'
		'btnExit
		'
		Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnExit.Font = New System.Drawing.Font("Bahnschrift", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnExit.Location = New System.Drawing.Point(1372, 6)
		Me.btnExit.Name = "btnExit"
		Me.btnExit.Size = New System.Drawing.Size(69, 28)
		Me.btnExit.TabIndex = 2
		Me.btnExit.Text = "Exit"
		Me.btnExit.UseVisualStyleBackColor = True
		'
		'pnlFooter
		'
		Me.pnlFooter.BackColor = System.Drawing.Color.LightGray
		Me.pnlFooter.Controls.Add(Me.btnSort)
		Me.pnlFooter.Controls.Add(Me.lblStatus)
		Me.pnlFooter.Controls.Add(Me.btnLoad)
		Me.pnlFooter.Controls.Add(Me.btnExit)
		Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.pnlFooter.Location = New System.Drawing.Point(0, 760)
		Me.pnlFooter.Name = "pnlFooter"
		Me.pnlFooter.Size = New System.Drawing.Size(1453, 40)
		Me.pnlFooter.TabIndex = 3
		'
		'btnSort
		'
		Me.btnSort.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnSort.Font = New System.Drawing.Font("Bahnschrift", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnSort.Location = New System.Drawing.Point(1182, 6)
		Me.btnSort.Name = "btnSort"
		Me.btnSort.Size = New System.Drawing.Size(103, 28)
		Me.btnSort.TabIndex = 5
		Me.btnSort.Text = "Sort"
		Me.btnSort.UseVisualStyleBackColor = True
		'
		'lblStatus
		'
		Me.lblStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.lblStatus.AutoSize = True
		Me.lblStatus.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblStatus.Location = New System.Drawing.Point(9, 12)
		Me.lblStatus.Name = "lblStatus"
		Me.lblStatus.Size = New System.Drawing.Size(38, 16)
		Me.lblStatus.TabIndex = 4
		Me.lblStatus.Text = "Ready"
		'
		'lvwSection
		'
		Me.lvwSection.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lvwSection.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.col_Section_Name})
		Me.lvwSection.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lvwSection.FullRowSelect = True
		Me.lvwSection.GridLines = True
		Me.lvwSection.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
		Me.lvwSection.HideSelection = False
		Me.lvwSection.Location = New System.Drawing.Point(1182, 103)
		Me.lvwSection.MultiSelect = False
		Me.lvwSection.Name = "lvwSection"
		Me.lvwSection.Size = New System.Drawing.Size(259, 651)
		Me.lvwSection.TabIndex = 4
		Me.lvwSection.UseCompatibleStateImageBehavior = False
		Me.lvwSection.View = System.Windows.Forms.View.Details
		'
		'col_Section_Name
		'
		Me.col_Section_Name.Text = "Section"
		Me.col_Section_Name.Width = 230
		'
		'lvwMember
		'
		Me.lvwMember.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lvwMember.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.col_Member_Name, Me.col_Member_Value, Me.col_Member_LineNo, Me.col_Member_Comment})
		Me.lvwMember.ContextMenuStrip = Me.cmsMember
		Me.lvwMember.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lvwMember.FullRowSelect = True
		Me.lvwMember.GridLines = True
		Me.lvwMember.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
		Me.lvwMember.HideSelection = False
		Me.lvwMember.Location = New System.Drawing.Point(12, 103)
		Me.lvwMember.MultiSelect = False
		Me.lvwMember.Name = "lvwMember"
		Me.lvwMember.Size = New System.Drawing.Size(1164, 651)
		Me.lvwMember.TabIndex = 5
		Me.lvwMember.UseCompatibleStateImageBehavior = False
		Me.lvwMember.View = System.Windows.Forms.View.Details
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
		'col_Member_LineNo
		'
		Me.col_Member_LineNo.Text = "Line No."
		Me.col_Member_LineNo.Width = 70
		'
		'col_Member_Comment
		'
		Me.col_Member_Comment.Text = "Comment"
		Me.col_Member_Comment.Width = 570
		'
		'Label1
		'
		Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(1179, 55)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(34, 16)
		Me.Label1.TabIndex = 5
		Me.Label1.Text = "Filter"
		'
		'tbxFilter
		'
		Me.tbxFilter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tbxFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.tbxFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
		Me.tbxFilter.Location = New System.Drawing.Point(1182, 74)
		Me.tbxFilter.Name = "tbxFilter"
		Me.tbxFilter.Size = New System.Drawing.Size(184, 22)
		Me.tbxFilter.TabIndex = 6
		'
		'btnFilter
		'
		Me.btnFilter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnFilter.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnFilter.Location = New System.Drawing.Point(1372, 74)
		Me.btnFilter.Name = "btnFilter"
		Me.btnFilter.Size = New System.Drawing.Size(69, 22)
		Me.btnFilter.TabIndex = 7
		Me.btnFilter.Text = "OK"
		Me.btnFilter.UseVisualStyleBackColor = True
		'
		'lblCurSection
		'
		Me.lblCurSection.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lblCurSection.AutoSize = True
		Me.lblCurSection.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCurSection.Location = New System.Drawing.Point(7, 75)
		Me.lblCurSection.Name = "lblCurSection"
		Me.lblCurSection.Size = New System.Drawing.Size(64, 25)
		Me.lblCurSection.TabIndex = 9
		Me.lblCurSection.Text = "Section"
		'
		'pnlInit
		'
		Me.pnlInit.Controls.Add(Me.lblMessage)
		Me.pnlInit.Location = New System.Drawing.Point(560, 346)
		Me.pnlInit.Name = "pnlInit"
		Me.pnlInit.Size = New System.Drawing.Size(300, 100)
		Me.pnlInit.TabIndex = 10
		Me.pnlInit.Visible = False
		'
		'lblMessage
		'
		Me.lblMessage.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblMessage.ForeColor = System.Drawing.Color.Gray
		Me.lblMessage.Location = New System.Drawing.Point(3, 30)
		Me.lblMessage.Name = "lblMessage"
		Me.lblMessage.Size = New System.Drawing.Size(294, 38)
		Me.lblMessage.TabIndex = 1
		Me.lblMessage.Text = "Initializing..."
		Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'lblPath
		'
		Me.lblPath.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lblPath.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPath.Location = New System.Drawing.Point(264, 76)
		Me.lblPath.Name = "lblPath"
		Me.lblPath.Size = New System.Drawing.Size(912, 16)
		Me.lblPath.TabIndex = 11
		Me.lblPath.Text = "---"
		Me.lblPath.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'cmsMember
		'
		Me.cmsMember.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InsertContentToolStripMenuItem})
		Me.cmsMember.Name = "cmsMember"
		Me.cmsMember.Size = New System.Drawing.Size(150, 26)
		'
		'InsertContentToolStripMenuItem
		'
		Me.InsertContentToolStripMenuItem.Name = "InsertContentToolStripMenuItem"
		Me.InsertContentToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
		Me.InsertContentToolStripMenuItem.Text = "Insert Content"
		'
		'frmMain
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.ClientSize = New System.Drawing.Size(1453, 800)
		Me.ControlBox = False
		Me.Controls.Add(Me.lblPath)
		Me.Controls.Add(Me.pnlInit)
		Me.Controls.Add(Me.lblCurSection)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.tbxFilter)
		Me.Controls.Add(Me.btnFilter)
		Me.Controls.Add(Me.lvwMember)
		Me.Controls.Add(Me.lvwSection)
		Me.Controls.Add(Me.pnlFooter)
		Me.Controls.Add(Me.pnlHeader)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Name = "frmMain"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "RA2 Rules Editor"
		Me.pnlHeader.ResumeLayout(False)
		Me.pnlHeader.PerformLayout()
		CType(Me.picIcon, System.ComponentModel.ISupportInitialize).EndInit()
		Me.pnlFooter.ResumeLayout(False)
		Me.pnlFooter.PerformLayout()
		Me.pnlInit.ResumeLayout(False)
		Me.cmsMember.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents pnlHeader As Panel
	Friend WithEvents lblTitle As Label
	Friend WithEvents btnLoad As Button
	Friend WithEvents btnExit As Button
	Friend WithEvents pnlFooter As Panel
	Friend WithEvents picIcon As PictureBox
	Friend WithEvents lblStatus As Label
	Friend WithEvents lvwSection As ListView
	Friend WithEvents col_Section_Name As ColumnHeader
	Friend WithEvents lvwMember As ListView
	Friend WithEvents col_Member_Name As ColumnHeader
	Friend WithEvents col_Member_Value As ColumnHeader
	Friend WithEvents col_Member_LineNo As ColumnHeader
	Friend WithEvents col_Member_Comment As ColumnHeader
	Friend WithEvents btnFilter As Button
	Friend WithEvents tbxFilter As TextBox
	Friend WithEvents Label1 As Label
	Friend WithEvents lblCurSection As Label
	Friend WithEvents pnlInit As Panel
	Friend WithEvents lblMessage As Label
	Friend WithEvents btnSort As Button
	Friend WithEvents lblPath As Label
	Friend WithEvents cmsMember As ContextMenuStrip
	Friend WithEvents InsertContentToolStripMenuItem As ToolStripMenuItem
End Class
