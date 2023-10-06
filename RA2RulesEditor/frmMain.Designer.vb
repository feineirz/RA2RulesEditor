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
		Me.lblAppVersion = New System.Windows.Forms.Label()
		Me.picIcon = New System.Windows.Forms.PictureBox()
		Me.lblAppTitle = New System.Windows.Forms.Label()
		Me.btnLoad = New System.Windows.Forms.Button()
		Me.btnExit = New System.Windows.Forms.Button()
		Me.pnlFooter = New System.Windows.Forms.Panel()
		Me.lblNearDropIndex = New System.Windows.Forms.Label()
		Me.lblCurrentSectionIndex = New System.Windows.Forms.Label()
		Me.btnSort = New System.Windows.Forms.Button()
		Me.lblStatus = New System.Windows.Forms.Label()
		Me.lvwSection = New System.Windows.Forms.ListView()
		Me.col_Section_Name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.col_Section_LineNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.cmsSection = New System.Windows.Forms.ContextMenuStrip(Me.components)
		Me.tsmi_CloneSectionAs = New System.Windows.Forms.ToolStripMenuItem()
		Me.lvwElements = New System.Windows.Forms.ListView()
		Me.col_Member_Name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.col_Member_Value = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.col_Member_Comment = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.col_Member_LineNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.cmsElements = New System.Windows.Forms.ContextMenuStrip(Me.components)
		Me.tsmi_AppendElement = New System.Windows.Forms.ToolStripMenuItem()
		Me.tsmi_CommentElement = New System.Windows.Forms.ToolStripMenuItem()
		Me.tsmi_RemoveElement = New System.Windows.Forms.ToolStripMenuItem()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.tbxFilter = New System.Windows.Forms.TextBox()
		Me.btnFilter = New System.Windows.Forms.Button()
		Me.lblCurrentSection = New System.Windows.Forms.Label()
		Me.pnlInit = New System.Windows.Forms.Panel()
		Me.lblMessage = New System.Windows.Forms.Label()
		Me.lblPath = New System.Windows.Forms.Label()
		Me.btnReload = New System.Windows.Forms.Button()
		Me.pnlSection = New System.Windows.Forms.Panel()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.btnOpenInEditor = New System.Windows.Forms.Button()
		Me.pnlHeader.SuspendLayout()
		CType(Me.picIcon, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.pnlFooter.SuspendLayout()
		Me.cmsSection.SuspendLayout()
		Me.cmsElements.SuspendLayout()
		Me.pnlInit.SuspendLayout()
		Me.pnlSection.SuspendLayout()
		Me.Panel1.SuspendLayout()
		Me.SuspendLayout()
		'
		'pnlHeader
		'
		Me.pnlHeader.BackColor = System.Drawing.Color.DimGray
		Me.pnlHeader.BackgroundImage = CType(resources.GetObject("pnlHeader.BackgroundImage"), System.Drawing.Image)
		Me.pnlHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.pnlHeader.Controls.Add(Me.lblAppVersion)
		Me.pnlHeader.Controls.Add(Me.picIcon)
		Me.pnlHeader.Controls.Add(Me.lblAppTitle)
		Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
		Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
		Me.pnlHeader.Name = "pnlHeader"
		Me.pnlHeader.Size = New System.Drawing.Size(1527, 93)
		Me.pnlHeader.TabIndex = 0
		'
		'lblAppVersion
		'
		Me.lblAppVersion.BackColor = System.Drawing.Color.Transparent
		Me.lblAppVersion.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblAppVersion.ForeColor = System.Drawing.Color.White
		Me.lblAppVersion.Location = New System.Drawing.Point(75, 55)
		Me.lblAppVersion.Name = "lblAppVersion"
		Me.lblAppVersion.Size = New System.Drawing.Size(230, 16)
		Me.lblAppVersion.TabIndex = 6
		Me.lblAppVersion.Text = "App Version"
		Me.lblAppVersion.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'picIcon
		'
		Me.picIcon.BackColor = System.Drawing.Color.Transparent
		Me.picIcon.Image = CType(resources.GetObject("picIcon.Image"), System.Drawing.Image)
		Me.picIcon.Location = New System.Drawing.Point(12, 16)
		Me.picIcon.Name = "picIcon"
		Me.picIcon.Size = New System.Drawing.Size(60, 60)
		Me.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.picIcon.TabIndex = 4
		Me.picIcon.TabStop = False
		'
		'lblAppTitle
		'
		Me.lblAppTitle.AutoSize = True
		Me.lblAppTitle.BackColor = System.Drawing.Color.Transparent
		Me.lblAppTitle.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblAppTitle.ForeColor = System.Drawing.Color.White
		Me.lblAppTitle.Location = New System.Drawing.Point(71, 16)
		Me.lblAppTitle.Name = "lblAppTitle"
		Me.lblAppTitle.Size = New System.Drawing.Size(242, 42)
		Me.lblAppTitle.TabIndex = 0
		Me.lblAppTitle.Text = "RA2 Rules Editor"
		'
		'btnLoad
		'
		Me.btnLoad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnLoad.BackColor = System.Drawing.Color.White
		Me.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnLoad.Font = New System.Drawing.Font("Bahnschrift", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnLoad.Location = New System.Drawing.Point(1365, 6)
		Me.btnLoad.Name = "btnLoad"
		Me.btnLoad.Size = New System.Drawing.Size(75, 28)
		Me.btnLoad.TabIndex = 1
		Me.btnLoad.Text = "Load"
		Me.btnLoad.UseVisualStyleBackColor = False
		'
		'btnExit
		'
		Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnExit.BackColor = System.Drawing.Color.White
		Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnExit.Font = New System.Drawing.Font("Bahnschrift", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnExit.Location = New System.Drawing.Point(1446, 6)
		Me.btnExit.Name = "btnExit"
		Me.btnExit.Size = New System.Drawing.Size(69, 28)
		Me.btnExit.TabIndex = 2
		Me.btnExit.Text = "Exit"
		Me.btnExit.UseVisualStyleBackColor = False
		'
		'pnlFooter
		'
		Me.pnlFooter.BackColor = System.Drawing.Color.LightGray
		Me.pnlFooter.BackgroundImage = CType(resources.GetObject("pnlFooter.BackgroundImage"), System.Drawing.Image)
		Me.pnlFooter.Controls.Add(Me.lblNearDropIndex)
		Me.pnlFooter.Controls.Add(Me.lblCurrentSectionIndex)
		Me.pnlFooter.Controls.Add(Me.btnSort)
		Me.pnlFooter.Controls.Add(Me.lblStatus)
		Me.pnlFooter.Controls.Add(Me.btnLoad)
		Me.pnlFooter.Controls.Add(Me.btnExit)
		Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.pnlFooter.Location = New System.Drawing.Point(0, 860)
		Me.pnlFooter.Name = "pnlFooter"
		Me.pnlFooter.Size = New System.Drawing.Size(1527, 40)
		Me.pnlFooter.TabIndex = 3
		'
		'lblNearDropIndex
		'
		Me.lblNearDropIndex.AutoSize = True
		Me.lblNearDropIndex.BackColor = System.Drawing.Color.White
		Me.lblNearDropIndex.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblNearDropIndex.Location = New System.Drawing.Point(885, 12)
		Me.lblNearDropIndex.Name = "lblNearDropIndex"
		Me.lblNearDropIndex.Size = New System.Drawing.Size(16, 16)
		Me.lblNearDropIndex.TabIndex = 9
		Me.lblNearDropIndex.Text = "-1"
		Me.lblNearDropIndex.Visible = False
		'
		'lblCurrentSectionIndex
		'
		Me.lblCurrentSectionIndex.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.lblCurrentSectionIndex.AutoSize = True
		Me.lblCurrentSectionIndex.BackColor = System.Drawing.Color.White
		Me.lblCurrentSectionIndex.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCurrentSectionIndex.Location = New System.Drawing.Point(801, 12)
		Me.lblCurrentSectionIndex.Name = "lblCurrentSectionIndex"
		Me.lblCurrentSectionIndex.Size = New System.Drawing.Size(16, 16)
		Me.lblCurrentSectionIndex.TabIndex = 6
		Me.lblCurrentSectionIndex.Text = "-1"
		Me.lblCurrentSectionIndex.Visible = False
		'
		'btnSort
		'
		Me.btnSort.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnSort.BackColor = System.Drawing.Color.White
		Me.btnSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnSort.Font = New System.Drawing.Font("Bahnschrift", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnSort.Location = New System.Drawing.Point(1256, 6)
		Me.btnSort.Name = "btnSort"
		Me.btnSort.Size = New System.Drawing.Size(103, 28)
		Me.btnSort.TabIndex = 5
		Me.btnSort.Text = "Sort"
		Me.btnSort.UseVisualStyleBackColor = False
		'
		'lblStatus
		'
		Me.lblStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.lblStatus.AutoSize = True
		Me.lblStatus.BackColor = System.Drawing.Color.Transparent
		Me.lblStatus.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblStatus.ForeColor = System.Drawing.Color.White
		Me.lblStatus.Location = New System.Drawing.Point(9, 12)
		Me.lblStatus.Name = "lblStatus"
		Me.lblStatus.Size = New System.Drawing.Size(38, 16)
		Me.lblStatus.TabIndex = 4
		Me.lblStatus.Text = "Ready"
		'
		'lvwSection
		'
		Me.lvwSection.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lvwSection.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.col_Section_Name, Me.col_Section_LineNo})
		Me.lvwSection.ContextMenuStrip = Me.cmsSection
		Me.lvwSection.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lvwSection.FullRowSelect = True
		Me.lvwSection.GridLines = True
		Me.lvwSection.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
		Me.lvwSection.HideSelection = False
		Me.lvwSection.Location = New System.Drawing.Point(8, 37)
		Me.lvwSection.MultiSelect = False
		Me.lvwSection.Name = "lvwSection"
		Me.lvwSection.Size = New System.Drawing.Size(255, 710)
		Me.lvwSection.TabIndex = 4
		Me.lvwSection.UseCompatibleStateImageBehavior = False
		Me.lvwSection.View = System.Windows.Forms.View.Details
		'
		'col_Section_Name
		'
		Me.col_Section_Name.Text = "Section List"
		Me.col_Section_Name.Width = 170
		'
		'col_Section_LineNo
		'
		Me.col_Section_LineNo.Text = "Line No."
		Me.col_Section_LineNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		'
		'cmsSection
		'
		Me.cmsSection.ImageScalingSize = New System.Drawing.Size(20, 20)
		Me.cmsSection.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmi_CloneSectionAs})
		Me.cmsSection.Name = "cmsSection"
		Me.cmsSection.Size = New System.Drawing.Size(168, 30)
		'
		'tsmi_CloneSectionAs
		'
		Me.tsmi_CloneSectionAs.Enabled = False
		Me.tsmi_CloneSectionAs.Image = CType(resources.GetObject("tsmi_CloneSectionAs.Image"), System.Drawing.Image)
		Me.tsmi_CloneSectionAs.Name = "tsmi_CloneSectionAs"
		Me.tsmi_CloneSectionAs.Size = New System.Drawing.Size(167, 26)
		Me.tsmi_CloneSectionAs.Text = "Clone Section As"
		'
		'lvwElements
		'
		Me.lvwElements.AllowDrop = True
		Me.lvwElements.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lvwElements.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.col_Member_Name, Me.col_Member_Value, Me.col_Member_Comment, Me.col_Member_LineNo})
		Me.lvwElements.ContextMenuStrip = Me.cmsElements
		Me.lvwElements.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lvwElements.FullRowSelect = True
		Me.lvwElements.GridLines = True
		Me.lvwElements.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
		Me.lvwElements.HideSelection = False
		Me.lvwElements.Location = New System.Drawing.Point(9, 37)
		Me.lvwElements.Name = "lvwElements"
		Me.lvwElements.Size = New System.Drawing.Size(1213, 710)
		Me.lvwElements.TabIndex = 5
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
		Me.col_Member_Value.Width = 300
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
		'cmsElements
		'
		Me.cmsElements.Font = New System.Drawing.Font("Bahnschrift SemiLight SemiConde", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmsElements.ImageScalingSize = New System.Drawing.Size(20, 20)
		Me.cmsElements.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmi_AppendElement, Me.tsmi_CommentElement, Me.tsmi_RemoveElement})
		Me.cmsElements.Name = "cmsMember"
		Me.cmsElements.Size = New System.Drawing.Size(172, 82)
		'
		'tsmi_AppendElement
		'
		Me.tsmi_AppendElement.Enabled = False
		Me.tsmi_AppendElement.Image = CType(resources.GetObject("tsmi_AppendElement.Image"), System.Drawing.Image)
		Me.tsmi_AppendElement.Name = "tsmi_AppendElement"
		Me.tsmi_AppendElement.Size = New System.Drawing.Size(171, 26)
		Me.tsmi_AppendElement.Text = "Append element"
		'
		'tsmi_CommentElement
		'
		Me.tsmi_CommentElement.Enabled = False
		Me.tsmi_CommentElement.Image = CType(resources.GetObject("tsmi_CommentElement.Image"), System.Drawing.Image)
		Me.tsmi_CommentElement.Name = "tsmi_CommentElement"
		Me.tsmi_CommentElement.Size = New System.Drawing.Size(171, 26)
		Me.tsmi_CommentElement.Text = "Comment element"
		'
		'tsmi_RemoveElement
		'
		Me.tsmi_RemoveElement.Enabled = False
		Me.tsmi_RemoveElement.Image = CType(resources.GetObject("tsmi_RemoveElement.Image"), System.Drawing.Image)
		Me.tsmi_RemoveElement.Name = "tsmi_RemoveElement"
		Me.tsmi_RemoveElement.Size = New System.Drawing.Size(171, 26)
		Me.tsmi_RemoveElement.Text = "Remove element"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(5, 11)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(34, 16)
		Me.Label1.TabIndex = 5
		Me.Label1.Text = "Filter"
		'
		'tbxFilter
		'
		Me.tbxFilter.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tbxFilter.BackColor = System.Drawing.Color.White
		Me.tbxFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.tbxFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
		Me.tbxFilter.Location = New System.Drawing.Point(39, 8)
		Me.tbxFilter.Name = "tbxFilter"
		Me.tbxFilter.Size = New System.Drawing.Size(149, 22)
		Me.tbxFilter.TabIndex = 6
		'
		'btnFilter
		'
		Me.btnFilter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnFilter.BackColor = System.Drawing.Color.White
		Me.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnFilter.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnFilter.Location = New System.Drawing.Point(194, 7)
		Me.btnFilter.Name = "btnFilter"
		Me.btnFilter.Size = New System.Drawing.Size(69, 24)
		Me.btnFilter.TabIndex = 7
		Me.btnFilter.Text = "OK"
		Me.btnFilter.UseVisualStyleBackColor = False
		'
		'lblCurrentSection
		'
		Me.lblCurrentSection.AutoSize = True
		Me.lblCurrentSection.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCurrentSection.Location = New System.Drawing.Point(4, 9)
		Me.lblCurrentSection.Name = "lblCurrentSection"
		Me.lblCurrentSection.Size = New System.Drawing.Size(64, 25)
		Me.lblCurrentSection.TabIndex = 9
		Me.lblCurrentSection.Text = "Section"
		'
		'pnlInit
		'
		Me.pnlInit.BackColor = System.Drawing.Color.Transparent
		Me.pnlInit.BackgroundImage = CType(resources.GetObject("pnlInit.BackgroundImage"), System.Drawing.Image)
		Me.pnlInit.Controls.Add(Me.lblMessage)
		Me.pnlInit.Location = New System.Drawing.Point(478, 272)
		Me.pnlInit.Name = "pnlInit"
		Me.pnlInit.Size = New System.Drawing.Size(300, 100)
		Me.pnlInit.TabIndex = 10
		Me.pnlInit.Visible = False
		'
		'lblMessage
		'
		Me.lblMessage.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblMessage.ForeColor = System.Drawing.Color.WhiteSmoke
		Me.lblMessage.Location = New System.Drawing.Point(3, 29)
		Me.lblMessage.Name = "lblMessage"
		Me.lblMessage.Size = New System.Drawing.Size(294, 38)
		Me.lblMessage.TabIndex = 1
		Me.lblMessage.Text = "Initializing..."
		Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'lblPath
		'
		Me.lblPath.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lblPath.Font = New System.Drawing.Font("Bahnschrift SemiLight SemiConde", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPath.ForeColor = System.Drawing.Color.Firebrick
		Me.lblPath.Location = New System.Drawing.Point(260, 8)
		Me.lblPath.Name = "lblPath"
		Me.lblPath.Size = New System.Drawing.Size(784, 22)
		Me.lblPath.TabIndex = 11
		Me.lblPath.Text = "---"
		Me.lblPath.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'btnReload
		'
		Me.btnReload.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnReload.BackColor = System.Drawing.Color.White
		Me.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnReload.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnReload.Location = New System.Drawing.Point(1153, 7)
		Me.btnReload.Name = "btnReload"
		Me.btnReload.Size = New System.Drawing.Size(69, 24)
		Me.btnReload.TabIndex = 12
		Me.btnReload.Text = "Reload"
		Me.btnReload.UseVisualStyleBackColor = False
		'
		'pnlSection
		'
		Me.pnlSection.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pnlSection.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
		Me.pnlSection.Controls.Add(Me.tbxFilter)
		Me.pnlSection.Controls.Add(Me.lvwSection)
		Me.pnlSection.Controls.Add(Me.btnFilter)
		Me.pnlSection.Controls.Add(Me.Label1)
		Me.pnlSection.Location = New System.Drawing.Point(1244, 99)
		Me.pnlSection.Name = "pnlSection"
		Me.pnlSection.Size = New System.Drawing.Size(271, 755)
		Me.pnlSection.TabIndex = 13
		'
		'Panel1
		'
		Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
		Me.Panel1.Controls.Add(Me.btnOpenInEditor)
		Me.Panel1.Controls.Add(Me.pnlInit)
		Me.Panel1.Controls.Add(Me.lblCurrentSection)
		Me.Panel1.Controls.Add(Me.lvwElements)
		Me.Panel1.Controls.Add(Me.lblPath)
		Me.Panel1.Controls.Add(Me.btnReload)
		Me.Panel1.Location = New System.Drawing.Point(12, 99)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(1230, 755)
		Me.Panel1.TabIndex = 14
		'
		'btnOpenInEditor
		'
		Me.btnOpenInEditor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnOpenInEditor.BackColor = System.Drawing.Color.White
		Me.btnOpenInEditor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnOpenInEditor.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnOpenInEditor.Location = New System.Drawing.Point(1050, 7)
		Me.btnOpenInEditor.Name = "btnOpenInEditor"
		Me.btnOpenInEditor.Size = New System.Drawing.Size(97, 24)
		Me.btnOpenInEditor.TabIndex = 13
		Me.btnOpenInEditor.Text = "Open in Editor"
		Me.btnOpenInEditor.UseVisualStyleBackColor = False
		'
		'frmMain
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.ClientSize = New System.Drawing.Size(1527, 900)
		Me.ControlBox = False
		Me.Controls.Add(Me.Panel1)
		Me.Controls.Add(Me.pnlSection)
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
		Me.cmsSection.ResumeLayout(False)
		Me.cmsElements.ResumeLayout(False)
		Me.pnlInit.ResumeLayout(False)
		Me.pnlSection.ResumeLayout(False)
		Me.pnlSection.PerformLayout()
		Me.Panel1.ResumeLayout(False)
		Me.Panel1.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents pnlHeader As Panel
	Friend WithEvents lblAppTitle As Label
	Friend WithEvents btnLoad As Button
	Friend WithEvents btnExit As Button
	Friend WithEvents pnlFooter As Panel
	Friend WithEvents picIcon As PictureBox
	Friend WithEvents lblStatus As Label
	Friend WithEvents lvwSection As ListView
	Friend WithEvents col_Section_Name As ColumnHeader
	Friend WithEvents lvwElements As ListView
	Friend WithEvents col_Member_Name As ColumnHeader
	Friend WithEvents col_Member_Value As ColumnHeader
	Friend WithEvents col_Member_LineNo As ColumnHeader
	Friend WithEvents col_Member_Comment As ColumnHeader
	Friend WithEvents btnFilter As Button
	Friend WithEvents tbxFilter As TextBox
	Friend WithEvents Label1 As Label
	Friend WithEvents lblCurrentSection As Label
	Friend WithEvents pnlInit As Panel
	Friend WithEvents lblMessage As Label
	Friend WithEvents btnSort As Button
	Friend WithEvents lblPath As Label
	Friend WithEvents cmsElements As ContextMenuStrip
	Friend WithEvents tsmi_AppendElement As ToolStripMenuItem
	Friend WithEvents tsmi_RemoveElement As ToolStripMenuItem
	Friend WithEvents btnReload As Button
	Friend WithEvents pnlSection As Panel
	Friend WithEvents Panel1 As Panel
	Friend WithEvents btnOpenInEditor As Button
	Friend WithEvents lblCurrentSectionIndex As Label
	Friend WithEvents col_Section_LineNo As ColumnHeader
	Friend WithEvents cmsSection As ContextMenuStrip
	Friend WithEvents tsmi_CloneSectionAs As ToolStripMenuItem
	Friend WithEvents lblAppVersion As Label
	Friend WithEvents tsmi_CommentElement As ToolStripMenuItem
	Friend WithEvents lblNearDropIndex As Label
End Class
