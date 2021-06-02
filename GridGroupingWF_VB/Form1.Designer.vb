Imports Microsoft.VisualBasic
Imports System
Namespace DataGrid
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.gridGroupingControl1 = New Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl()
			CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridGroupingControl1
			' 
			Me.gridGroupingControl1.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(64))))), (CInt(Fix((CByte(0))))), (CInt(Fix((CByte(120))))), (CInt(Fix((CByte(215))))))
			Me.gridGroupingControl1.BackColor = System.Drawing.SystemColors.Window
			Me.gridGroupingControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridGroupingControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridGroupingControl1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
			Me.gridGroupingControl1.Name = "gridGroupingControl1"
			Me.gridGroupingControl1.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus
			Me.gridGroupingControl1.Size = New System.Drawing.Size(1133, 588)
			Me.gridGroupingControl1.TabIndex = 0
			Me.gridGroupingControl1.Text = "gridGroupingControl1"
			Me.gridGroupingControl1.UseRightToLeftCompatibleTextBox = True
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(9F, 20F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(1133, 588)
			Me.Controls.Add(Me.gridGroupingControl1)
			Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
			Me.Name = "Form1"
			Me.Text = "AddNewRecord while clicking the PushButton"
			CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gridGroupingControl1 As Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl
	End Class
End Namespace

