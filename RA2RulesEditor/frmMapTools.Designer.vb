<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMapTools
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMapTools))
		Me.pnlFooter = New System.Windows.Forms.Panel()
		Me.lblStatus = New System.Windows.Forms.Label()
		Me.btnClose = New System.Windows.Forms.Button()
		Me.pnlHeader = New System.Windows.Forms.Panel()
		Me.lblTitle = New System.Windows.Forms.Label()
		Me.pnlSource = New System.Windows.Forms.Panel()
		Me.pnlProgress = New System.Windows.Forms.Panel()
		Me.lblMessage = New System.Windows.Forms.Label()
		Me.lvwMapList = New System.Windows.Forms.ListView()
		Me.colMapName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.colMapType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.colFilename = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.colFullPath = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.Label1 = New System.Windows.Forms.Label()
		Me.lblSourcePath = New System.Windows.Forms.Label()
		Me.btnBrowseSourcePath = New System.Windows.Forms.Button()
		Me.pnlMapInfo = New System.Windows.Forms.Panel()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.lvwMapInfo = New System.Windows.Forms.ListView()
		Me.colElementName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.colElementValue = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.Label3 = New System.Windows.Forms.Label()
		Me.cmbConvertionProfile = New System.Windows.Forms.ComboBox()
		Me.MyApplicationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.btnConvertMap = New System.Windows.Forms.Button()
		Me.pnlConvert = New System.Windows.Forms.Panel()
		Me.lvwConversionLog = New System.Windows.Forms.ListView()
		Me.colMessageLog = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.btnClearLog = New System.Windows.Forms.Button()
		Me.pnlFooter.SuspendLayout()
		Me.pnlHeader.SuspendLayout()
		Me.pnlSource.SuspendLayout()
		Me.pnlProgress.SuspendLayout()
		Me.pnlMapInfo.SuspendLayout()
		CType(Me.MyApplicationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.pnlConvert.SuspendLayout()
		Me.SuspendLayout()
		'
		'pnlFooter
		'
		Me.pnlFooter.BackColor = System.Drawing.Color.Gainsboro
		Me.pnlFooter.BackgroundImage = CType(resources.GetObject("pnlFooter.BackgroundImage"), System.Drawing.Image)
		Me.pnlFooter.Controls.Add(Me.lblStatus)
		Me.pnlFooter.Controls.Add(Me.btnClose)
		Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.pnlFooter.Location = New System.Drawing.Point(0, 961)
		Me.pnlFooter.Name = "pnlFooter"
		Me.pnlFooter.Size = New System.Drawing.Size(1400, 39)
		Me.pnlFooter.TabIndex = 3
		'
		'lblStatus
		'
		Me.lblStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.lblStatus.AutoSize = True
		Me.lblStatus.BackColor = System.Drawing.Color.Transparent
		Me.lblStatus.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblStatus.ForeColor = System.Drawing.Color.White
		Me.lblStatus.Location = New System.Drawing.Point(12, 12)
		Me.lblStatus.Name = "lblStatus"
		Me.lblStatus.Size = New System.Drawing.Size(38, 16)
		Me.lblStatus.TabIndex = 5
		Me.lblStatus.Text = "Ready"
		'
		'btnClose
		'
		Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnClose.BackColor = System.Drawing.Color.White
		Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnClose.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnClose.Location = New System.Drawing.Point(1319, 7)
		Me.btnClose.Name = "btnClose"
		Me.btnClose.Size = New System.Drawing.Size(69, 27)
		Me.btnClose.TabIndex = 3
		Me.btnClose.Text = "Close"
		Me.btnClose.UseVisualStyleBackColor = False
		'
		'pnlHeader
		'
		Me.pnlHeader.BackColor = System.Drawing.Color.DarkGray
		Me.pnlHeader.BackgroundImage = CType(resources.GetObject("pnlHeader.BackgroundImage"), System.Drawing.Image)
		Me.pnlHeader.Controls.Add(Me.lblTitle)
		Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
		Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
		Me.pnlHeader.Name = "pnlHeader"
		Me.pnlHeader.Size = New System.Drawing.Size(1400, 60)
		Me.pnlHeader.TabIndex = 2
		'
		'lblTitle
		'
		Me.lblTitle.AutoSize = True
		Me.lblTitle.BackColor = System.Drawing.Color.Transparent
		Me.lblTitle.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTitle.ForeColor = System.Drawing.Color.White
		Me.lblTitle.Location = New System.Drawing.Point(3, 9)
		Me.lblTitle.Name = "lblTitle"
		Me.lblTitle.Size = New System.Drawing.Size(139, 39)
		Me.lblTitle.TabIndex = 1
		Me.lblTitle.Text = "Map Tools"
		'
		'pnlSource
		'
		Me.pnlSource.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.pnlSource.BackColor = System.Drawing.Color.White
		Me.pnlSource.Controls.Add(Me.pnlProgress)
		Me.pnlSource.Controls.Add(Me.lvwMapList)
		Me.pnlSource.Controls.Add(Me.Label1)
		Me.pnlSource.Controls.Add(Me.lblSourcePath)
		Me.pnlSource.Controls.Add(Me.btnBrowseSourcePath)
		Me.pnlSource.Location = New System.Drawing.Point(12, 66)
		Me.pnlSource.Name = "pnlSource"
		Me.pnlSource.Size = New System.Drawing.Size(850, 889)
		Me.pnlSource.TabIndex = 4
		'
		'pnlProgress
		'
		Me.pnlProgress.BackColor = System.Drawing.Color.Transparent
		Me.pnlProgress.BackgroundImage = CType(resources.GetObject("pnlProgress.BackgroundImage"), System.Drawing.Image)
		Me.pnlProgress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.pnlProgress.Controls.Add(Me.lblMessage)
		Me.pnlProgress.Location = New System.Drawing.Point(269, 341)
		Me.pnlProgress.Name = "pnlProgress"
		Me.pnlProgress.Size = New System.Drawing.Size(300, 168)
		Me.pnlProgress.TabIndex = 11
		Me.pnlProgress.Visible = False
		'
		'lblMessage
		'
		Me.lblMessage.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblMessage.ForeColor = System.Drawing.Color.WhiteSmoke
		Me.lblMessage.Location = New System.Drawing.Point(3, 109)
		Me.lblMessage.Name = "lblMessage"
		Me.lblMessage.Size = New System.Drawing.Size(294, 50)
		Me.lblMessage.TabIndex = 1
		Me.lblMessage.Text = "Processing..."
		Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'lvwMapList
		'
		Me.lvwMapList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lvwMapList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colMapName, Me.colMapType, Me.colFilename, Me.colFullPath})
		Me.lvwMapList.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lvwMapList.FullRowSelect = True
		Me.lvwMapList.GridLines = True
		Me.lvwMapList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
		Me.lvwMapList.HideSelection = False
		Me.lvwMapList.Location = New System.Drawing.Point(6, 29)
		Me.lvwMapList.MultiSelect = False
		Me.lvwMapList.Name = "lvwMapList"
		Me.lvwMapList.Size = New System.Drawing.Size(840, 857)
		Me.lvwMapList.TabIndex = 16
		Me.lvwMapList.UseCompatibleStateImageBehavior = False
		Me.lvwMapList.View = System.Windows.Forms.View.Details
		'
		'colMapName
		'
		Me.colMapName.Text = "Map Name"
		Me.colMapName.Width = 370
		'
		'colMapType
		'
		Me.colMapType.Text = "Type"
		Me.colMapType.Width = 70
		'
		'colFilename
		'
		Me.colFilename.Text = "Filename"
		Me.colFilename.Width = 370
		'
		'colFullPath
		'
		Me.colFullPath.Text = "Full Path"
		Me.colFullPath.Width = 0
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(3, 7)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(69, 16)
		Me.Label1.TabIndex = 15
		Me.Label1.Text = "Source Path"
		'
		'lblSourcePath
		'
		Me.lblSourcePath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lblSourcePath.Font = New System.Drawing.Font("Bahnschrift SemiLight SemiConde", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblSourcePath.ForeColor = System.Drawing.Color.Firebrick
		Me.lblSourcePath.Location = New System.Drawing.Point(78, 4)
		Me.lblSourcePath.Name = "lblSourcePath"
		Me.lblSourcePath.Size = New System.Drawing.Size(694, 22)
		Me.lblSourcePath.TabIndex = 13
		Me.lblSourcePath.Text = "---"
		Me.lblSourcePath.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'btnBrowseSourcePath
		'
		Me.btnBrowseSourcePath.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnBrowseSourcePath.BackColor = System.Drawing.Color.White
		Me.btnBrowseSourcePath.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnBrowseSourcePath.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnBrowseSourcePath.Location = New System.Drawing.Point(777, 3)
		Me.btnBrowseSourcePath.Name = "btnBrowseSourcePath"
		Me.btnBrowseSourcePath.Size = New System.Drawing.Size(69, 24)
		Me.btnBrowseSourcePath.TabIndex = 14
		Me.btnBrowseSourcePath.Text = "Browse"
		Me.btnBrowseSourcePath.UseVisualStyleBackColor = False
		'
		'pnlMapInfo
		'
		Me.pnlMapInfo.BackColor = System.Drawing.Color.White
		Me.pnlMapInfo.Controls.Add(Me.Label2)
		Me.pnlMapInfo.Controls.Add(Me.lvwMapInfo)
		Me.pnlMapInfo.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.pnlMapInfo.Location = New System.Drawing.Point(868, 66)
		Me.pnlMapInfo.Name = "pnlMapInfo"
		Me.pnlMapInfo.Size = New System.Drawing.Size(520, 471)
		Me.pnlMapInfo.TabIndex = 5
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(3, 7)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(50, 16)
		Me.Label2.TabIndex = 16
		Me.Label2.Text = "Map Info"
		'
		'lvwMapInfo
		'
		Me.lvwMapInfo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lvwMapInfo.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colElementName, Me.colElementValue})
		Me.lvwMapInfo.FullRowSelect = True
		Me.lvwMapInfo.GridLines = True
		Me.lvwMapInfo.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
		Me.lvwMapInfo.HideSelection = False
		Me.lvwMapInfo.Location = New System.Drawing.Point(3, 29)
		Me.lvwMapInfo.MultiSelect = False
		Me.lvwMapInfo.Name = "lvwMapInfo"
		Me.lvwMapInfo.Size = New System.Drawing.Size(514, 439)
		Me.lvwMapInfo.TabIndex = 0
		Me.lvwMapInfo.UseCompatibleStateImageBehavior = False
		Me.lvwMapInfo.View = System.Windows.Forms.View.Details
		'
		'colElementName
		'
		Me.colElementName.Text = "Element Name"
		Me.colElementName.Width = 200
		'
		'colElementValue
		'
		Me.colElementValue.Text = "Element Value"
		Me.colElementValue.Width = 290
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(3, 11)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(100, 16)
		Me.Label3.TabIndex = 25
		Me.Label3.Text = "Conversion profile"
		'
		'cmbConvertionProfile
		'
		Me.cmbConvertionProfile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbConvertionProfile.FormattingEnabled = True
		Me.cmbConvertionProfile.Location = New System.Drawing.Point(107, 8)
		Me.cmbConvertionProfile.Name = "cmbConvertionProfile"
		Me.cmbConvertionProfile.Size = New System.Drawing.Size(327, 21)
		Me.cmbConvertionProfile.TabIndex = 24
		'
		'MyApplicationBindingSource
		'
		Me.MyApplicationBindingSource.DataSource = GetType(RA2RulesEditor.My.MyApplication)
		'
		'btnConvertMap
		'
		Me.btnConvertMap.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnConvertMap.BackColor = System.Drawing.Color.White
		Me.btnConvertMap.Enabled = False
		Me.btnConvertMap.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnConvertMap.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnConvertMap.Location = New System.Drawing.Point(440, 8)
		Me.btnConvertMap.Name = "btnConvertMap"
		Me.btnConvertMap.Size = New System.Drawing.Size(77, 22)
		Me.btnConvertMap.TabIndex = 23
		Me.btnConvertMap.Text = "Convert"
		Me.btnConvertMap.UseVisualStyleBackColor = False
		'
		'pnlConvert
		'
		Me.pnlConvert.BackColor = System.Drawing.Color.White
		Me.pnlConvert.Controls.Add(Me.btnClearLog)
		Me.pnlConvert.Controls.Add(Me.lvwConversionLog)
		Me.pnlConvert.Controls.Add(Me.btnConvertMap)
		Me.pnlConvert.Controls.Add(Me.Label3)
		Me.pnlConvert.Controls.Add(Me.cmbConvertionProfile)
		Me.pnlConvert.Location = New System.Drawing.Point(868, 543)
		Me.pnlConvert.Name = "pnlConvert"
		Me.pnlConvert.Size = New System.Drawing.Size(520, 412)
		Me.pnlConvert.TabIndex = 26
		'
		'lvwConversionLog
		'
		Me.lvwConversionLog.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colMessageLog})
		Me.lvwConversionLog.FullRowSelect = True
		Me.lvwConversionLog.GridLines = True
		Me.lvwConversionLog.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
		Me.lvwConversionLog.HideSelection = False
		Me.lvwConversionLog.Location = New System.Drawing.Point(6, 35)
		Me.lvwConversionLog.Name = "lvwConversionLog"
		Me.lvwConversionLog.Size = New System.Drawing.Size(511, 374)
		Me.lvwConversionLog.TabIndex = 26
		Me.lvwConversionLog.UseCompatibleStateImageBehavior = False
		Me.lvwConversionLog.View = System.Windows.Forms.View.Details
		'
		'colMessageLog
		'
		Me.colMessageLog.Text = "Message Log"
		Me.colMessageLog.Width = 485
		'
		'btnClearLog
		'
		Me.btnClearLog.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnClearLog.BackColor = System.Drawing.Color.WhiteSmoke
		Me.btnClearLog.FlatAppearance.BorderColor = System.Drawing.Color.Gold
		Me.btnClearLog.FlatAppearance.BorderSize = 0
		Me.btnClearLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnClearLog.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnClearLog.Location = New System.Drawing.Point(439, 36)
		Me.btnClearLog.Name = "btnClearLog"
		Me.btnClearLog.Size = New System.Drawing.Size(77, 22)
		Me.btnClearLog.TabIndex = 27
		Me.btnClearLog.Text = "Clear"
		Me.btnClearLog.UseVisualStyleBackColor = False
		'
		'frmMapTools
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.WhiteSmoke
		Me.ClientSize = New System.Drawing.Size(1400, 1000)
		Me.ControlBox = False
		Me.Controls.Add(Me.pnlConvert)
		Me.Controls.Add(Me.pnlMapInfo)
		Me.Controls.Add(Me.pnlSource)
		Me.Controls.Add(Me.pnlFooter)
		Me.Controls.Add(Me.pnlHeader)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Name = "frmMapTools"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "frmMapTools"
		Me.pnlFooter.ResumeLayout(False)
		Me.pnlFooter.PerformLayout()
		Me.pnlHeader.ResumeLayout(False)
		Me.pnlHeader.PerformLayout()
		Me.pnlSource.ResumeLayout(False)
		Me.pnlSource.PerformLayout()
		Me.pnlProgress.ResumeLayout(False)
		Me.pnlMapInfo.ResumeLayout(False)
		Me.pnlMapInfo.PerformLayout()
		CType(Me.MyApplicationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		Me.pnlConvert.ResumeLayout(False)
		Me.pnlConvert.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents pnlFooter As Panel
	Friend WithEvents btnClose As Button
	Friend WithEvents pnlHeader As Panel
	Friend WithEvents lblTitle As Label
	Friend WithEvents pnlSource As Panel
	Friend WithEvents lblSourcePath As Label
	Friend WithEvents btnBrowseSourcePath As Button
	Friend WithEvents Label1 As Label
	Friend WithEvents lvwMapList As ListView
	Friend WithEvents colMapName As ColumnHeader
	Friend WithEvents colMapType As ColumnHeader
	Friend WithEvents colFilename As ColumnHeader
	Friend WithEvents colFullPath As ColumnHeader
	Friend WithEvents pnlProgress As Panel
	Friend WithEvents lblMessage As Label
	Friend WithEvents pnlMapInfo As Panel
	Friend WithEvents Label2 As Label
	Friend WithEvents lvwMapInfo As ListView
	Friend WithEvents colElementName As ColumnHeader
	Friend WithEvents colElementValue As ColumnHeader
	Friend WithEvents lblStatus As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents cmbConvertionProfile As ComboBox
	Friend WithEvents btnConvertMap As Button
	Friend WithEvents MyApplicationBindingSource As BindingSource
	Friend WithEvents pnlConvert As Panel
	Friend WithEvents lvwConversionLog As ListView
	Friend WithEvents colMessageLog As ColumnHeader
	Friend WithEvents btnClearLog As Button
End Class
