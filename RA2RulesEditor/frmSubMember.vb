Public Class frmSubMember

	Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

		Me.Dispose()

	End Sub

	Private Sub lvwMember_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lvwMember.MouseDoubleClick

		If lvwMember.SelectedItems.Count = 1 Then
			Dim lvi As ListViewItem = lvwMember.SelectedItems(0)
			curLVI = lvi
			Dim F As New Font("Microsoft Sans Serif", 9.75)
			With frmEditValue
				.lblMemberName.Text = lvi.Text.Trim
				.tbxValue.Text = lvi.SubItems(1).Text.Trim
				.tbxComment.Text = lvi.SubItems(3).Text.Trim
				OldValue = .tbxValue.Text
				.lblRefIndex.Text = lvi.Index
				.lblRefLineNo.Text = lvi.SubItems(2).Text

				.tbxValue.Left = .lblMemberName.Left + .lblMemberName.Width + 10
				.tbxValue.Width = .btnCancel.Left + .btnCancel.Width - .tbxValue.Left

				Dim textSize As Size = TextRenderer.MeasureText(lvi.SubItems(1).Text.Trim, F)
				.Width = .lblMemberName.Left + .lblMemberName.Width + textSize.Width + 30
				If .Width < 230 Then .Width = 230
				.ShowDialog()
			End With
		End If

	End Sub

	Private Sub lvwMember_MouseUp(sender As Object, e As MouseEventArgs) Handles lvwMember.MouseUp

		If e.Button = Button.MouseButtons.Middle Then
			If lvwMember.SelectedItems.Count = 1 Then
				Dim lvi As ListViewItem = lvwMember.SelectedItems(0)
				Dim Section As String = "[" & lvi.SubItems(1).Text.Trim & "]"
				Dim src As LineData() = GetMember(INIPath, Section)
				If Not src Is Nothing Then
					Dim sm As New frmSubMember
					With sm
						sm.lblTitle.Text = Section
						.lvwMember.Items.Clear()

						For Each LD As LineData In src
							lvi = .lvwMember.Items.Add(LD.Name)
							lvi.SubItems.Add(LD.Value)
							lvi.SubItems.Add(LD.LineNo)
							lvi.SubItems.Add(LD.Comment)
						Next
						.ShowDialog()
					End With

				End If
			End If
		End If

	End Sub
End Class